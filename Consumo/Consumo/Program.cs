using System;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int km;
            double litro, consumo;

            km = Convert.ToInt32(Console.ReadLine());
            litro = Convert.ToDouble(Console.ReadLine());

            consumo = km / litro;

            Console.WriteLine(consumo.ToString("0.000 km/l"));
        }
    }
}
