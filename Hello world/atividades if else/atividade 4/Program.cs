using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Verificando qual nome é maior---\n");

            Console.Write("Digite o primeiro nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o segundo nome: ");
            string nome2 = Console.ReadLine();

            if (nome.Length > nome2.Length)
            {
                Console.WriteLine($"O nome maior é: {nome}, e possui {nome.Length} letras");
            }
           
            else
            {
                Console.WriteLine($"O nome maior é: {nome2}, e possui {nome2.Length} letras");
            }

            Console.ReadKey();

        }
    }
}
