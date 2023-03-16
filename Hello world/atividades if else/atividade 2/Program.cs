using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Verifica qual número é maior---\n");

            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro número: ");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero > numero2 && numero > numero3)
            {
                Console.WriteLine($"\nO número {numero} é o maior");
            }
            
              else if (numero2 > numero && numero2 > numero3)
              {
                Console.WriteLine($"\nO número {numero2} é o maior");
              }

              else if (numero3 > numero && numero3 > numero2 )
              {
                Console.WriteLine("\nO número {numero3} é o maior");
              }

            else
            {
                Console.WriteLine("Todos os números são iguais");
            }

            Console.ReadKey();
        }
    }
    }

