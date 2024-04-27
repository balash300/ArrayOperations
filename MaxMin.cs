using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class MaxMin
    {
        public static int MaximumElement(int[] element)
        {
            if (element == null) Console.WriteLine("Wrong Array");

            int maxElement = element![0];
            for (int i = 1; i < element.Length; i++) if (element[i] > maxElement) maxElement = element[i];

            return maxElement;
        }

        public static int MinimumElement(int[] element)
        {
            if (element == null) Console.WriteLine("Wrong Array");

            int minElement = element![0];
            for (int i = 1; i < element.Length; i++) if (element[i] < minElement) minElement = element[i];

            return minElement;
        }
    }
}
