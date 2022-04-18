using CalculoCdb.Domain.Validacao;
using CalculoCdb.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCdb.Domain.Models
{
    public class Cdb : IContrato
    {
        public ValoresCdb CalcularCdb(decimal valorInicial, int meses) {

            var retimpostoRenda = new ImpostoRenda();

            var resultadoPorcentagem = 1 + PorcentagemParaCalculoCDB.Cdi / 100 * PorcentagemParaCalculoCDB.Tb / 100 * meses;

            var ValorBruto = valorInicial * Convert.ToDecimal(resultadoPorcentagem);

            var ValorLucro = ValorBruto - valorInicial;

            var retimpostoRendas = retimpostoRenda.PorcentagemImpostoRenda(meses);

            var ValorLiquido = ValorBruto - (ValorLucro * Convert.ToDecimal(retimpostoRendas));

            var valores = new ValoresCdb(valorInicial, ValorLiquido, ValorBruto,meses);

            return valores;
        }

        public ContratoValidacao<Cdb> Validacao(ValoresCdb valoresCdb)
        {
            var contratos = new ContratoValidacao<Cdb>()
            .MesesOK
            (valoresCdb.Meses, "A quantidade de meses deve ser maior que 1", "Meses")
            .ValorInicialOK(valoresCdb.ValorInicial, "O valor Inicial deve ser maior que 0", "ValorInicial");

            return contratos;
        }
    }
}
