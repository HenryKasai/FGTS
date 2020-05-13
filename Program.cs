using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira seu salário e veja sua parcela do FGTS.");

            string salário = Console.ReadLine();
            decimal salario = Convert.ToDecimal(salário);
            string oito = "8";
            decimal oitoo = Convert.ToDecimal(oito);
            string cem = "100";
            decimal ceem = Convert.ToDecimal(cem);
            decimal resultado = salario * oitoo / ceem;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Seu FGTS é de R$ " + resultado + ",00");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
