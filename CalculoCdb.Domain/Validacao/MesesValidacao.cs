using CalculoCdb.Domain.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCdb.Domain.Validacao
{
    public partial class ContratoValidacao<T>
    {
        public ContratoValidacao<T> MesesOK(int meses, string menssagem , string nomePropriedade)
        {
            if (meses < 2){
                AddNotificacao(new Notificar(menssagem, nomePropriedade));
            }
            return this;
        }
    }
}
