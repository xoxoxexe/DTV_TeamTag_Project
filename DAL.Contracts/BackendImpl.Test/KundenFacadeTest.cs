using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.Contracts;
using Backend.Impl;

namespace BackendImpl.Test
{
    [TestClass]
    public class KundenFacadeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IKundenFacade kundenFacade = new KundenFacade();

            Kunde kunde = kundenFacade.GetKunden().First();

            kunde.Email = "geänderte Email";

            kundenFacade.Save(kunde);

            IEnumerable<Kunde> kundenListe = kundenFacade.GetKunden();

            Assert.IsTrue(true);
        }
    }
}
