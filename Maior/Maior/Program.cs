using System;
using System.Numerics;

namespace Maior
{
    class Program
    {
        static void Main(string[] args)
        {   
            string linha;
            int a, b, c, maiorAB;

            linha = Console.ReadLine();
            String[] valores = linha.Split(' ');

            a = Convert.ToInt32(valores[0]);
            b = Convert.ToInt32(valores[1]);
            c = Convert.ToInt32(valores[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;

            if (maiorAB > c)
            {
                Console.WriteLine("{0} eh o maior", maiorAB);
            }
            else
            {
                Console.WriteLine("{0} eh o maior", c);
            }
        }
    }
}
