﻿using System;

namespace CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, code1, code2;
            double valor1, valor2, total;
            string linha1, linha2;

            linha1 = Console.ReadLine();
            linha2 = Console.ReadLine();

            string[] values1 = linha1.Split(' ');
            code1 = Convert.ToInt32(values1[0]);
            num1 = Convert.ToInt32(values1[1]);
            valor1 = Convert.ToDouble(values1[2]);

            string[] values2 = linha2.Split(' ');
            code2 = Convert.ToInt32(values2[0]);
            num2 = Convert.ToInt32(values2[1]);
            valor2 = Convert.ToDouble(values2[2]);

            total = (num1 * valor1) + (num2 * valor2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));            
        }
    }
}
