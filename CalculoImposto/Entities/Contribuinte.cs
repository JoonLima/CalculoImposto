using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoImposto.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendimentoAnual { get; set; }

        public Contribuinte()
        {
        }

        protected Contribuinte(string nome, double rendimentoAnual)
        {
            Nome = nome;
            RendimentoAnual = rendimentoAnual;
        }

        public abstract double Tax();
    }
}
