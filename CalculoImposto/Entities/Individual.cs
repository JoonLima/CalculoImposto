using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Entities
{
    class Individual : Contribuinte
    {
        public double DespesasSaude { get; set; }

        public Individual()
        {
        }

        public Individual(string nome, double rendimentoAnual, double despesasSaude) : base(nome, rendimentoAnual)
        {
            DespesasSaude = despesasSaude;
        }

        public override double Tax()
        {
            double total;

            if (RendimentoAnual < 20000.00)
            {
                total = (RendimentoAnual * 0.15) - (DespesasSaude * 0.50);
            } 
            else
            {
                total = (RendimentoAnual * 0.25) - (DespesasSaude * 0.50);
            }

            return total;
        }
    }
}
