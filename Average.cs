using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Average
    {
        public static double NumericalAverage(int[] element)
        {
            if (element == null) Console.WriteLine("Wrong Array");

            double average = 0;
            for (int i = 0; i < element!.Length; i++) average += +element[i];
            average /= element.Length;

            return average;
        }
    }
}
