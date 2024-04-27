using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class SecondMax
    {
        public static int SecondMaximumElement(int[] element)
        {
            if (element == null) Console.WriteLine("Wrong Array");

            int maxElement = element![0];
            for (int i = 1; i < element.Length; i++) if (element[i] > maxElement) maxElement = element[i];

            int j = element.Length - 1;
            int[] arr = new int[element!.Length];
            while (j >= 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (element[i].Equals(maxElement)) arr[i] = 0;
                    else arr[i] = element[i];
                }
                j--;
            }

            maxElement = arr![0];
            for (int i = 1; i < arr.Length; i++) if (arr[i] > maxElement) maxElement = arr[i];

            return maxElement;
        }
    }
}
