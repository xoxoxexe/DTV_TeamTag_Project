using System;
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
            IKundenFacade facade = new KundenFacade();
            var kunden = facade.GetKunden();
            var bla = 0;

        }
    }
}
