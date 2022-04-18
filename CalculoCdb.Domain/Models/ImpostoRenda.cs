using CalculoCdb.Domain.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCdb.Domain.Models
{
    public class ImpostoRenda : IValidacao
    {
      
        public float PorcentagemImpostoDeRenda { get; set; }

        public float PorcentagemImpostoRenda(int meses) {

            if (meses <6) {
                this.PorcentagemImpostoDeRenda = PorcentagemParaCalculoCDB.ImpostoDeRendaAtéSeisMeses;
            }
            if (meses >6 && meses <12)
            {
                this.PorcentagemImpostoDeRenda = PorcentagemParaCalculoCDB.ImpostoDeRendaAtéDozeMeses;
            }
            if (meses > 12 && meses < 24)
            {
                this.PorcentagemImpostoDeRenda = PorcentagemParaCalculoCDB.ImpostoDeRendaAtéVinteQuatroMeses;
            }

            else {
                this.PorcentagemImpostoDeRenda = PorcentagemParaCalculoCDB.ImpostoDeRendaAcimaDeVinteQuatroMeses;
            }

            return this.PorcentagemImpostoDeRenda;
        }

        public bool Validacao()
        {
            throw new NotImplementedException();
        }
    }
}
