using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args
            )
        {

            Console.WriteLine("Informe seu salário bruto: ");
            double salariob = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do seu Vale Alimentação: ");
            double valealimentacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos filhos você tem: ");
            double nfilhos = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor por filho: ");
            double vfilho = double.Parse(Console.ReadLine());

            Console.WriteLine("Você fez quantas horas extras: ");
            double qtdhoras = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora trabalhada: ");
            double vhoras = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do INSS: ");
            double inss = Double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do IRPF: ");
            double irpf = Double.Parse(Console.ReadLine());

            double resultado = salariob + valealimentacao + (nfilhos * vfilho) + 
            (qtdhoras * vhoras) - (inss + irpf);

            Console.WriteLine("Salário Líquido:" + resultado);

            Console.ReadKey();

        }
    }
}
