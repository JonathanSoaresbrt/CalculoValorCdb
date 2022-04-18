using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCdb.Domain.ValueObjects
{
    public struct ValoresCdb
    {
        public ValoresCdb(decimal valorInicial, decimal valorLiquido, decimal valorBruto, int meses)
        {
            ValorInicial = valorInicial;
            ValorLiquido = valorLiquido;
            ValorBruto = valorBruto;
            Meses = meses;
        }

        public decimal ValorInicial { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorBruto { get; set; }
        public int Meses { get; set; }

    }
}
