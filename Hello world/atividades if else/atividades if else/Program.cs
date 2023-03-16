using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividades_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Verifica se o número é par ou ímpar---\n");
            Console.Write("Informe um número");
            int numero = int.Parse(Console.ReadLine());

            if (numero%2==0)
            {
                Console.WriteLine("\nEste número é ímpar");
            }
            else
            {
                Console.WriteLine("\nEste número é par");
            }

            Console.ReadKey();
        }
    }
}
