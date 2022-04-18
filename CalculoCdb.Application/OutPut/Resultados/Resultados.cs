using CalculoCdb.Application.Resultados.Interface;
using CalculoCdb.Domain.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCdb.Application.Resultados
{
    public class Resultado : IResultado
    {

        public Resultado(int resultCode, string message, bool isOk )
        {
            ResultCode = resultCode;
            Message = message;
            IsOk = isOk;
        }

        public int ResultCode { get; private set; }
        public string Message { get; private set; }
        public bool IsOk { get; private set; }
    }
}
