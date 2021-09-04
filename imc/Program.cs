using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============");
            Console.WriteLine("Calcular IMC");
            Console.WriteLine("=============\n");

            Console.WriteLine("Informe seu peso: ");
            int peso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe sua altura: ");
            Double altura = Convert.ToDouble(Console.ReadLine());

            calcularImc(peso, altura);


        }
        static void calcularImc(int peso, Double altura)
        {
            int imc =Convert.ToInt32 ( peso / (altura * altura)) ;

            Console.WriteLine(@$"Seu IMC é = {imc} ");

            if (imc < 20)
                Console.WriteLine(" (abaixo do peso).");
            else if ((imc >= 20) && (imc < 25))
                Console.WriteLine(" (peso normal).");
            else if ((imc >= 25) && (imc < 30))
                Console.WriteLine(" (acima do peso).");
            else if ((imc >= 30) && (imc < 34))
                Console.WriteLine(" (obeso).");
            else
                Console.WriteLine(" (muito obeso).");
        }








    }
    }

