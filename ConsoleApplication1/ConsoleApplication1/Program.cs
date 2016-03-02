using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myMassive = new int[2, 2];
            string rawStr = Console.ReadLine();
            while (rawStr == null) // проверка массива на пустоту
            {
                Console.WriteLine("Введите не пустой массив");
                rawStr = Console.ReadLine();
            }

            var rawArray = rawStr.Split(' ');

            // проверка на соответствие массива требуемой размерности
            while (rawArray.Length != 4)
            {
                Console.WriteLine("Массив должен содержать 2*2 элемента. Введите массив заново");
                rawStr = Console.ReadLine();
                rawArray = rawStr.Split(' ');
            }
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int next;
                        if (int.TryParse(rawArray[i * 2 + j], out next))
                            myMassive[i, j] = next;
                        else
                            throw new Exception("Массив содержит не числовой элемент");//если очередной элемент не число
                    }
                }
                Console.WriteLine("Array is");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(myMassive[i, j]);
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
