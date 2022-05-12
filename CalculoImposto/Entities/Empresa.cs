using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Entities
{
    class Empresa : Contribuinte
    {
        public int NumeroDeFuncionarios { get; set; }

        public Empresa()
        {
        }

        public Empresa(string nome, double rendimentoAnual, int numeroDeFuncionarios) : base(nome, rendimentoAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public override double Tax()
        {
            double total;

            if (NumeroDeFuncionarios > 10)
            {
                total = RendimentoAnual * 0.14;
            }
            else
            {
                total = RendimentoAnual * .016;
            }

            return total;
        }
    }
}
