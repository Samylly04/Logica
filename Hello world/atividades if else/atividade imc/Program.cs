using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Crie um programa que calcule o IMC

            Console.WriteLine("\t\t---Calculando IMC---\n");

            Console.Write("Indique sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Indique seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);


            if (imc < 18.5)
            {
                Console.WriteLine($"O seu IMC é: {imc} e você está abaixo do peso normal");
            }

            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine($"O seu IMC é: {imc} e você está no peso normal");
            }

            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine($"O seu IMC é: {imc} e você está com execesso de peso");
            }

            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine($"O seu IMC é: {imc} e você está com obesidade classe I");
            }

            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine($"O seu IMC é: {imc} e você está com obesidade classe II");
            }

            else
            {
                Console.WriteLine($"O seu IMC é: {imc} e você está com obesidade classe III");
            }


            Console.ReadKey();

        }
    }
}
