using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] buf = { 't', 'a', 'n', 'y', 'a' };
            StringBuilder sb = new StringBuilder();
            foreach (var sim in buf)
            {
                sb.Append(sim);
            }
            Console.Write(sb);
            Console.WriteLine();
            sb.Replace('t', 'T');
            Console.Write(sb);
            Console.WriteLine();
            sb.Remove(0, 1);
            Console.Write(sb);
            Console.WriteLine();
            sb.Insert(0, "tatyana and ");
            Console.Write(sb);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
