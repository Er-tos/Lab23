using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, для которого необходимо рассчитать факториал.");
            int numForFactorial = Convert.ToInt32(Console.ReadLine());
            int fact = CalcFactorialAsync(numForFactorial).Result;
            Console.WriteLine();
            Console.Write("Факториал данного числа равен {0}", fact);
            Console.ReadKey();
        }
        static async Task<int> CalcFactorialAsync(int num)
        {
            int result = await Task.Run(() => CalcFactorial(num));
            return result;
        }
        static int CalcFactorial(int num)
        {
            int factorial = 1;

            for (int i = 2; i < num + 1; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
