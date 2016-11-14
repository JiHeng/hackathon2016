using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            using (FileStream fs = new FileStream("../../../results/Team1Problem2Output.txt", FileMode.OpenOrCreate))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                var s = app.Load("../../../results/Problem2Input.txt", sw);
               // app.Print(s);

                var points = app.EmptyPoints(s);
                //Console.WriteLine(app.Solve(s, points, 0));

                app.Solve(s, points, 0);
                //app.Print(s);
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < s[i].Length; j++)
                    {
                        sw.Write(s[i][j]);
                    }

                    sw.WriteLine();
                }
            }
        }


        public int[][] Load(string fn, StreamWriter sw)
        {
            try
            {
                int[][] s = new int[9][];
                for (int k = 0; k < s.Length; k++) s[k] = new int[9];
                var lines = File.ReadAllLines(fn);
                if (lines.Length != 9) throw new Exception();

                for(int i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];
                    if (line.Length != 9) throw new Exception(); 

                    for(int j  = 0;j < line.Length; j++)
                    {
                        int n = 0;
                        int.TryParse(line[j].ToString(), out n);
                        s[i][j] = n;
                    }
                }

                return s;
            }
            catch
            {
                sw.WriteLine("invalid input");
            }

            return null;
        }

        public bool Solve(int[][] s, List<int[]> points, int pos)
        {
            if (isSolved(s)) return true;
            int x = points[pos][0];
            int y = points[pos][1];
             
            for(int i = 1; i <= 9; i++)
            {
                s[x][y] = i;

                //Console.WriteLine(x + ", " + y + " : " + i);
                //Print(s);

                if (isValid(s, x, y))
                {
                    if (Solve(s, points, pos + 1))
                    {
                        return true;
                    }
                }
            }

            s[x][y] = 0;
            return false;
        }
        public bool isSolved(int[][] s)
        {
            if (s == null) return false;
            foreach(var r in s)
            {
                foreach(var c in r)
                {
                    if (c == 0) return false;
                }
            }

            return true;
        }
        public List<int[]> EmptyPoints(int[][] s)
        {
            if (s == null) return null;
            List<int[]> list  = new List<int[]>();
            for (int i = 0; i < s.Length; i++)
            for (int j = 0; j < s[i].Length; j++)
            {
                    if (s[i][j] == 0) list.Add(new int[] { i, j });
            }

            return list;
        }

        public bool isValid(int[][] s, int x, int y)
        {
            if (s == null || x < 0 || x >= 9 || y < 0 || y >= 9) return false;

            // check row
            var n = s[x][y];
            int i = 0;
            for (i = 0; i < 9; i++)
            {
                if (i != y && s[x][i] == n) return false;
            }

            // check column
            for (i = 0; i < 9; i++)
            {
                if (i != x && s[i][y] == n) return false;
            }

            // check 3 x 3
            int j = 0;
            for (i = x/3 * 3; i < x/3*3 + 2; i++)
            for (j = y/3 * 3; j < y/3*3 + 2; j++)
            {
                    if ((i != x || j != y) && s[i][j] == n) return false;
            }

            return true;
        }


        public void Print(int[][] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s[i].Length; j++)
                {
                    Console.Write(s[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
