using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Sorting
    {
        public static void Ascending(int[] element)
        {
            if (element == null) Console.WriteLine("Wrong Array");

            for (int i = 0; i < element!.Length - 1; i++)
            {
                for (int j = 0; j < element.Length - 1 - i; j++)
                {
                    if (element[j] > element[j + 1])
                    {
                        int n = element[j];
                        element[j] = element[j + 1];
                        element[j + 1] = n;
                    }
                }
            }

            foreach (int item in element)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void Descending(int[] element)
        {
            if (element == null) Console.WriteLine("Wrong Array");

            for (int i = element!.Length - 1; i > 0; i--)
            {
                for (int j = element.Length - 1 - i; j >= 0; j--)
                {
                    if (element[j] < element[j + 1])
                    {
                        int n = element[j];
                        element[j] = element[j + 1];
                        element[j + 1] = n;
                    }
                }
            }

            foreach (int item in element)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
