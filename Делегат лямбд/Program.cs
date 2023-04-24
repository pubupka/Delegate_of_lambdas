using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Делегат_лямбд
{
    internal class Program
    {
        delegate double Calc(double[] vars);
        static void Main()
        {
            Calc min = (double[] arr) => arr.Min();
            Calc max = (double[] arr) => arr.Max();
            Calc sum = (double[] arr) => arr.Sum();
            Calc mult = (double[] arr) =>
            {
                double rez = 1;
                foreach (double x in arr) { rez *= x; }
                return rez;
            };
            Calc arithmetic_mean = (double[] arr) => arr.Sum() / arr.Length;

            Console.Write("Введите операнды через пробел: ");
            string input = Console.ReadLine();
            double[] vars = input.Split(' ').Select(x => Double.Parse(x)).ToArray();
            Console.WriteLine();

            Console.WriteLine("Минимум: {0}", min(vars));
            Console.WriteLine("Максимум: {0}", max(vars));
            Console.WriteLine("Сумма: {0}", sum(vars));
            Console.WriteLine("Произведение: {0}", mult(vars));
            Console.WriteLine("Среднее арифметическое: {0}", arithmetic_mean(vars));
        }
    }
}