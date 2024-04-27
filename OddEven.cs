using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class OddEven
    {
        public static int SumOdd(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) if (arr[i] % 2 == 1) sum += arr[i];
            return sum;
        }

        public static int ProductEven(int[] arr)
        {
            int sum = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) sum *= 1;
                else if (arr[i] % 2 == 0) sum *= arr[i];
            }
            return sum;
        }
    }
}
