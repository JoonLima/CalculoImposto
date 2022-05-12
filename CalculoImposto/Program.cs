using CalculoImposto.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();

            Console.Write("Entre com a quantidade de contribuíntes: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Contribuínte #{i}:");
                Console.Write("Individual ou Empresa (i/e)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendimentoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'i')
                {
                    Console.Write("Gastos com saúde: ");
                    double despesasSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(nome, rendimentoAnual, despesasSaude));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Número de funcionários: ");
                    int numeroDeFuncionarios = int.Parse(Console.ReadLine());
                    list.Add(new Empresa(nome, rendimentoAnual, numeroDeFuncionarios));
                    Console.WriteLine();
                }
            }

            Console.WriteLine("IMPOSTOS PAGOS:");

            double totalImpostos = 0.0;

            foreach (Contribuinte contribuinte in list)
            {
                totalImpostos += contribuinte.Tax();
                Console.WriteLine($"{contribuinte.Nome} R$ {contribuinte.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL DE IMPOSTOS: R$ {totalImpostos.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
