using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

namespace NotasMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, centavos;
            int reais;

            valor = Convert.ToDouble(Console.ReadLine());
            reais = Convert.ToInt32(Math.Floor(valor));
            centavos = valor - reais;

            Console.WriteLine("NOTAS:");
            reais = Notas(reais, 100);
            reais = Notas(reais, 50);
            reais = Notas(reais, 20);
            reais = Notas(reais, 10);
            reais = Notas(reais, 5);
            reais = Notas(reais, 2);
            centavos = reais + centavos;

            Console.WriteLine("CENTAVOS:");
            centavos = Moedas(centavos, 1.00);
            centavos = Moedas(centavos, 0.50);
            centavos = Moedas(centavos, 0.25);
            centavos = Moedas(centavos, 0.10);
            centavos = Moedas(centavos, 0.05);
            Moedas(centavos, 0.01);
        }

        /**
         * Converte os reais em notas
         * 
         * @param reais -> valor em reais
         * @param nota -> valor da nota
         **/
        static int Notas(int reais, int nota) {
            int resto = 0;
            
            if (reais >= nota)
            {
                Console.WriteLine("{0} nota(s) de R$ {1},00", (reais / nota), nota);
                resto = reais % nota;
            }
            else
            {
                Console.WriteLine("0 nota(s) de R$ {0},00", nota);
                resto = reais;
            }

            return resto;
        }

        /**
         * Converte os centavos em moedas
         * 
         * @param centavos -> parte em centavos
         * @param moeda -> valor da moeda
         **/
        static double Moedas(double centavos, double moeda) {
            double resto = centavos;
            int qtd = 0;

            while (resto >= moeda)
            {
                resto -= moeda;
                qtd++;
            }

            Console.WriteLine("{0} moeda(s) de R$ {1}", qtd, moeda.ToString("0.00"));
            
            return resto;
        }
    }
}
