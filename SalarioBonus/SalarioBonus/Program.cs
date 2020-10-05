using System;

namespace SalarioBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double fixo, vendas, total;
            const double COMISSAO = 15.0;

            nome = Convert.ToString(Console.ReadLine());
            fixo = Convert.ToDouble(Console.ReadLine());
            vendas = Convert.ToDouble(Console.ReadLine());

            total = fixo + (vendas * (COMISSAO / 100));

            Console.WriteLine("TOTAL = {0}", total.ToString("R$ 0.00"));
        }
    }
}
