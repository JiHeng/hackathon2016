using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            using (FileStream fs = new FileStream("../../../results/Team1Problem1Output.txt", FileMode.OpenOrCreate))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                app.Sum("../../../results/Problem1Input.txt", sw);
            }
        }


        public void Sum(string inFile, StreamWriter sw)
        {
            string[] lines = File.ReadAllLines(inFile);
            foreach(var line in lines)
            {
                if (line == null) continue;
                string[] numStrs = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                double sum = 0.0;
                foreach (string numStr in numStrs)
                {
                    double num = 0.0;
                    if (!double.TryParse(numStr, out num))
                    {
                        sw.WriteLine("invalid input");
                    }

                    sum += num;
                }

                sw.WriteLine(sum);
            }
        }
    }
}
