using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            using (FileStream fs = new FileStream("../../../results/Team1Problem3Output.txt", FileMode.OpenOrCreate))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                var nums = app.Load("../../../results/Problem3Input.txt");
                if (nums.Length % 2 == 1)
                {
                    sw.Write("invalid input");
                    return;
                }

                for(int i =0; i <= nums.Length -2;i = i+ 2)
                {
                    sw.WriteLine(app.avg(nums[i + 1], nums[i][0]));
                }
            }
        }

        public int avg(int[] arr, int num)
        {
            if (arr.Length <= num * 2) return 0;
            List<int> tmp = new List<int>();
            SortedList<int, int> q = new SortedList<int, int>(num);

            int i = 0;
            for (i = 0; i < num; i++) q.Add(arr[i], arr[i]);

            for(; i < arr.Length; i++)
            {
                if (q.ElementAt(0).Value < arr[i])
                {
                    tmp.Add(q.ElementAt(0).Value);
                    q.RemoveAt(0);
                    q.Add(arr[i], arr[i]);
                }
                else
                {
                    tmp.Add(arr[i]);
                }

            }

            q.Clear();
            for (i = 0; i < num; i++) q.Add(tmp[i], tmp[i]);

            List<int> tt = new List<int>();
            int n = tmp.Count;
            for(; i < n; i++)
            {
                if (q.ElementAt(num - 1).Value > tmp[i])
                {
                    tt.Add(q.ElementAt(num - 1).Value);
                    q.RemoveAt(num - 1);
                    q.Add(tmp[i], tmp[i]);
                }
                else
                {
                    tt.Add(tmp[i]);
                }
            }


            int sum = 0;
            n = tt.Count;
            for( i = 0; i < n; i++)
            {
                sum += tt[i];
            }

            return sum / n;
        }

        public int[][] Load(string fn)
        {
            var lines = File.ReadLines(fn).ToArray();

            int[][] num = new int[lines.Length][];

            for(int i = 0; i < lines.Length; i++)
            {
                string[] str = lines[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                num[i] = new int[str.Length];
                for (int j = 0; j < str.Length; j++)
                {
                    num[i][j] = int.Parse(str[j]);
                }
            }

            return num;

        }
    }
}
