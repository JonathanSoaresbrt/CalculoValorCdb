using CalculoCdb.Domain.Notificacoes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCdb.Domain.Notificacoes
{
    public class Notificar : INotificar
    {
        public Notificar(string menssagem, string nomePropriedade)
        {
            Menssagem = menssagem;
            NomePropriedade = nomePropriedade;
        }

        public string Menssagem { get; set; }
        public string NomePropriedade { get; set; }

        public void AddNotificacao()
        {
            throw new NotImplementedException();
        }
    }
}
