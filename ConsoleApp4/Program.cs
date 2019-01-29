using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("../../adv.txt"))

            {
                string line;
                int sum = 0;
                while ((line = sr.ReadLine()) !=null)
                {
                    int x = Convert.ToInt32(line);
                    sum = sum + x;
                    Console.WriteLine(sum);
                }
            }

                Console.ReadLine();
        }
    }
}
