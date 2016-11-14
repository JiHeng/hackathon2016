using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Point
    {
        public int x, y;
        public bool isSpace;
        public bool visited;

        public Point(int x, int y, bool isSpace)
        {
            this.x = x;
            this.y = y;
            this.isSpace = isSpace;
            this.visited = false;
        }

        public override bool Equals(object obj)
        {
            Point other = (Point)obj;
            return this.x == other.x && this.y == other.y;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public List<Point> GetNeighbors(Point[][] board)
        {
            List<Point> neighbors = new List<Point>();
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (this.x + i >= 0 && this.x + i < board.Length &&
                        this.y + j >= 0 && this.y + j < board[x].Length)
                    {
                        if (!(i == 0 && j ==0))
                        {
                            var p = board[this.x + i][this.y + j];
                            if (p.isSpace && !p.visited)
                            {
                                neighbors.Add(p);
                            }
                        }
                    }
                }
            }
            return neighbors;
        }
    }

    class Program
    {
        static void MarkNeighbors(Point[][] board, Point p)
        {
            p.visited = true;
            var neighbors = p.GetNeighbors(board);
            foreach (Point n in neighbors)
            {
                MarkNeighbors(board, n);
            }
        }

        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("../../../results/Team1Problem5Output.txt", FileMode.OpenOrCreate))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                Point[][] board = Program.LoadBoard("../../../results/Problem5Input.txt", sw);
                int numSpaces = 0;
                for (int i = 0; i < board.Length; i++)
                {
                    for (int j = 0; j < board[i].Length; j++)
                    {
                        Point p = board[i][j];
                        if (p.isSpace && !p.visited)
                        {
                            MarkNeighbors(board, p);
                            numSpaces++;
                        }
                    }
                }
                sw.WriteLine(numSpaces);
            }
                
        }

        public static Point[][] LoadBoard(string inputFile, StreamWriter sw)
        {
            try
            {
                string[] lines = File.ReadAllLines(inputFile);
                int column = lines[0].Length;
                int row = lines.Length;

                Point[][] board = new Point[row][];
                for (int i = 0; i < row; i++)
                {
                    string line = lines[i];
                    board[i] = new Point[column];
                    for (int j = 0; j < line.Length; j++)
                    {
                        board[i][j] = new Point(i, j, line[j] == '.');
                    }
                }

                return board;
            }
            catch
            {
                sw.WriteLine("invalid input");
            }

            return null;
        }
    }
}
