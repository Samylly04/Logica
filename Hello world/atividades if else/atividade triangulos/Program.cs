using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_triangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Calculando triângulos---\n");

            Console.Write("Informe a medida de um lado do triângulo: ");
            double lado = double.Parse(Console.ReadLine());

            Console.Write("Informe a medida do segundo lado do triângulo: ");
            double lado2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a medida do terceiro lado do triângulo: ");
            double lado3 = double.Parse(Console.ReadLine());

            if (lado + lado2 > lado3 && lado2 + lado3 > lado && lado + lado3 > lado2)
            {
                Console.WriteLine("Suas medidas formam um triângulo");

                if (lado == lado2 && lado == lado3)
                    Console.WriteLine("E ele é equilátero");
                else if (lado == lado2 || lado == lado3 || lado2 == lado3)
                    Console.WriteLine("E ele é isocéles");
                else
                    Console.WriteLine("E ele é escaleno");
            }

            else 
            {
                Console.WriteLine("Suas medidas não formam um triângulo");
            }

            Console.ReadKey();

        }
    }
}
