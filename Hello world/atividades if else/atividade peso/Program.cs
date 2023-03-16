using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_peso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tendo como entrada a altura e o sexo(codificado da seguinte forma: 1:feminino2: masculino) de uma pessoa,
             * construa um programa que calcule e imprima seu peso ideal, utilizando as seguintes fórmulas:
             *para homens: (72.7 * Altura) – 58
             * para mulheres: (62.1 * Altura) – 44.7
             */
            
            double homem, mulher;

            Console.WriteLine("\t\t---Calculando peso ideal---\n");

            Console.Write("Informe seu gênero (1: feminino; 2: masculino): ");
            int genero = int.Parse(Console.ReadLine());

            Console.Write("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            homem = ((72.7 * altura) - 58);
            mulher = ((62.1 * altura) - 44.7);

            if (genero == 1)
            {
                Console.WriteLine($"Seu peso ideial é: {mulher} ");
            }
            else if (genero == 2)
            {
                Console.WriteLine($"Seu peso ideal é: {homem}");
            }
            else
            {
                Console.WriteLine("Informação indisponível");
            }

            Console.ReadLine();

        }
    }
}
