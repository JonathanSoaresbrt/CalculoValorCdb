using CalculoCdb.Domain.Models;
using CalculoCdb.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCdb.Tests.Teste
{
    [TestClass]
    public class CdbTeste
    {
        [TestMethod]
        public void Dado_Um_Mes_Valido_Deve_Passar() {

            var cdb = new Cdb(meses : 2,valoresCdb : new ValoresCdb(2.00M,0,0));

            Assert.AreEqual(true ,cdb.Validacao());
        }


        [TestMethod]
        public void Dado_Um_ValorLiquido_Valido_Deve_Passar()
        {

            var cdb = new Cdb(meses: 2, valoresCdb: new ValoresCdb(2.00M, 0, 0));

            Assert.AreEqual(true, cdb.Validacao());
        }

    }
}
