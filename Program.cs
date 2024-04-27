using static ConsoleApp.Average;
using static ConsoleApp.MaxMin;
using static ConsoleApp.OddEven;
using static ConsoleApp.SecondMax;
using static ConsoleApp.Sorting;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool t = true;
            Random random = new Random();

            while (t)
            {
                Console.Write("Enter your array size: ");
                bool success = int.TryParse(Console.ReadLine(), out int count);
                Console.WriteLine("\n-------------------------------------------------------------\n");

                if (!success)
                {
                    Console.WriteLine("Enter the number!");
                    Console.WriteLine("\n-------------------------------------------------------------\n");
                }
                else
                {
                    int[] arr = new int[count];

                    for (int i = 0; i < count; i++) arr[i] = random.Next(10);

                    Console.Write("Elements of Array: ");
                    for (int i = 0; i < count; i++) Console.Write(arr[i] + " ");

                    Console.WriteLine("\n\n-------------------------------------------------------------\n");
                    Console.WriteLine("Maximum Element of array: " + MaximumElement(arr));
                    Console.WriteLine("Minimum Element of array: " + MinimumElement(arr));
                    Console.WriteLine("Second Maximum Element of array: " + SecondMaximumElement(arr));
                    Console.WriteLine("Numerical Average of array: " + NumericalAverage(arr));
                    Console.WriteLine("Sum of odd: " + SumOdd(arr));
                    Console.WriteLine("Product of even: " + ProductEven(arr));
                    Console.Write("Ascending: "); Ascending(arr);
                    Console.Write("Descending: "); Descending(arr);
                    Console.WriteLine("\n-------------------------------------------------------------\n");
                }

                Console.Write("Exit the program (y/n): ");
                string last = Console.ReadLine();
                if (last.Equals("y")) t = false;
                else t = true;
                Console.WriteLine("\n-------------------------------------------------------------\n");
            }
        }
    }
}
