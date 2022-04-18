using CalculoCdb.Domain.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCdb.Domain.Validacao
{
    public partial class ContratoValidacao<T> where T : IContrato
    {
        private List<Notificar> _notificacoes;
        public ContratoValidacao() {
            _notificacoes = new List<Notificar>();
        }

        public IReadOnlyCollection<Notificar> Notificaoes => _notificacoes;

        public void AddNotificacao(Notificar notificar) {
            _notificacoes.Add(notificar);
        }
        public bool IsValid() {
            return _notificacoes.Count == 0 ? true : false;
        }
    }

}
