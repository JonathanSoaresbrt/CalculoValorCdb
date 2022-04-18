using CalculoCdb.Application.Resultados;
using CalculoCdb.Domain.Models;
using CalculoCdb.Domain.Notificacoes;
using CalculoCdb.Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoCdb.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoCdbController : ControllerBase
    {

        [HttpPost]
        public dynamic CalcularCbd(ValoresCdb valoresCdb, [FromServices] Cdb _repository)
        {

            var validacao = _repository.Validacao(valoresCdb);

            if (validacao.Notificaoes.Count > 0)
            {

                foreach (var notificacao in validacao.Notificaoes)
                {
                    return BadRequest(new Resultado(400, $"Falha ao calcular CDB { notificacao.Menssagem }", false));

                }
            }

            return _repository.CalcularCdb(valoresCdb.ValorInicial, valoresCdb.Meses);
        }
    }
}
