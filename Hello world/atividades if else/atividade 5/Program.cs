using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Calculando salário---\n");

            Console.Write("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine());

            double salario23 = (((salario * 23) / 100)+ salario);
            double salario18 = (((salario * 18) / 100) + salario);

            if (salario <= 1500)
            {
                Console.WriteLine($"O seu salário é: {salario}, e passará a ser: {salario23}");
            }

            else
            {
                Console.WriteLine($"O seu salário é: {salario}, e passará a ser: {salario18}");
            }

            Console.ReadKey();

        }
    }
}
