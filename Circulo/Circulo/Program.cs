using System;

namespace Circulo
{
    class Program
    {
        public const double n = 3.14159;

        static void Main(string[] args)
        {
            double area, raio;

            raio = Convert.ToDouble(Console.ReadLine());

            area = n * Math.Pow( raio, 2 );

            Console.WriteLine("A={0}", area.ToString("0.0000"));
        }
    }
}
