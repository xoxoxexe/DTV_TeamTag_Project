using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.Contracts;
using Backend.Impl;
using System.Linq;

namespace BackendImpl.Test
{
    /// <summary>
    /// Summary description for AngebotFacadeTest
    /// </summary>
    [TestClass]
    public class FinazenFacadeTest
    {
        public FinazenFacadeTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void TestFinazenFacadeTest() {
            var facade = new FinanzenFacade();
            var rechnungen = facade.GetFinanzUebersicht();
            Assert.IsTrue(rechnungen.Any());
        }

      
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

    }
}
