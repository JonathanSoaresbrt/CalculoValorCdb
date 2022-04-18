using CalculoCdb.Domain.Notificacoes;
using CalculoCdb.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCdb.Domain.Validacao
{
    public partial class ContratoValidacao<T>
    {
        public ContratoValidacao<T> ValorInicialOK(decimal ValorInicial, string menssagem, string nomePropriedade)
        {
            if (ValorInicial <= 0)
            {
                AddNotificacao(new Notificar(menssagem, nomePropriedade));
            }
            return this;
        }
    }
}
