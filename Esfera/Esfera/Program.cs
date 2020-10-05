using System;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;
            const double PI = 3.14159;
            
            raio = Convert.ToDouble(Console.ReadLine());

            volume = (4.0/3.0) * PI * Math.Pow(raio,3.0);

            Console.WriteLine("VOLUME = {0}", volume.ToString("F3"));
        }
    }
}
