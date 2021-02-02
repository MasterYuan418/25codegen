using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace _25codegen
{
    class Program
    {
        Random r = new Random();
        string[] charset = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

        string[] gen5Code()
        {
            string key1 = charset[r.Next(0, charset.Length - 1)];
            Thread.Sleep(50);
            string key2 = charset[r.Next(0, charset.Length - 1)];
            Thread.Sleep(50);
            string key3 = charset[r.Next(0, charset.Length - 1)];
            Thread.Sleep(50);
            string key4 = charset[r.Next(0, charset.Length - 1)];
            Thread.Sleep(50);
            string key5 = charset[r.Next(0, charset.Length - 1)];
            return new string[] { key1 + key2 + key3 + key4 + key5 };
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Output file path:");
            string path = Console.ReadLine();
            Console.Write("Max:");
            int max = Convert.ToInt32(Console.ReadLine());
            StreamWriter sw = new StreamWriter(@path);
            for (int i = 0;i <= max;i++)
            {
                string[] a = p.gen5Code();
                string[] b = p.gen5Code();
                string[] c = p.gen5Code();
                string[] d = p.gen5Code();
                sw.WriteLine(a + "-" + b + "-" + c + "-" + d);
                Console.WriteLine(a + "-" + b + "-" + c + "-" + d);
            }
            sw.Close();
        }
    }
}
