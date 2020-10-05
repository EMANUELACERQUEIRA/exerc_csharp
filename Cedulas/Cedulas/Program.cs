using System;

namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int reais;

            reais = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(reais);
            reais = Notas(reais, 100);
            reais = Notas(reais, 50);
            reais = Notas(reais, 20);
            reais = Notas(reais, 10);
            reais = Notas(reais, 5);
            reais = Notas(reais, 2);
            reais = Notas(reais, 1);
        }

        /**
         * Converte os reais em notas
         * 
         * @param reais -> valor em reais
         * @param nota -> valor da nota
         **/
        static int Notas(int reais, int nota)
        {
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
    }
}
