using System;

namespace Juros_Compostos
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = "S";  
            while(i == "S")
            {
                Console.Clear();
                JurosCalcMethod();
                Console.WriteLine("Deseja continuar? [S/N]: ");
                i = Console.ReadLine();
                i = i.ToUpper();

            }

        }

        static void JurosCalcMethod()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|------Calculadora Juros compostos-----|");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Valor inicial:");
            double initialValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total de Juros a.a:");
            double interestAA = Convert.ToDouble(Console.ReadLine());
            interestAA = (interestAA / 100)/12 ;

            Console.WriteLine("Tempo para pagar em meses: ");
            int payTime = Convert.ToInt32(Console.ReadLine());
            
            InterestTotal(initialValue, interestAA, payTime);
            
            static void InterestTotal(double init, double aaTotal, int timeToPay)
            {
                aaTotal = aaTotal + 1;
                double totalToPay = init * (Math.Pow(aaTotal, timeToPay));
                double totJuros = totalToPay - init;

                //Console.WriteLine("Total a pagar: " +  totalToPay + " Juros total: " + (totalToPay-aaTotal));

                Console.WriteLine("Valor total: " + totalToPay.ToString("C"));
                Console.WriteLine("Valor Juros: " + totJuros.ToString("C"));


            }

        }

    }
}
