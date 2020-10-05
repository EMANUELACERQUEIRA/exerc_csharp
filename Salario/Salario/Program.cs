using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, time;
            double value, salary;

            number = Convert.ToInt32(Console.ReadLine());
            time = Convert.ToInt32(Console.ReadLine());
            value = Convert.ToDouble(Console.ReadLine());

            salary = time * value;

            Console.WriteLine("NUMBER = {0}", number);
            Console.WriteLine("SALARY = {0}", salary.ToString("U$ 0.00" ) );
        }
    }
}
