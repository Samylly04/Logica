using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double media;
       
            Console.WriteLine("\t\t---Verificando aprovação---\n");

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe sua primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe sua segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Informe sua terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Informe sua quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4)/4;

            if (media >= 60)
            {
                Console.WriteLine($"\nO aluno {nome} teve a média {media} e foi aprovado");
            }

            else
            {
                Console.WriteLine($"\nO aluno {nome} teve a média {media} e foi reprovado");
            }

            Console.ReadKey();

        }
    }
}
