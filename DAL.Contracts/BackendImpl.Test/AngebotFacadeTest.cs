using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.Contracts;
using Backend.Impl;


namespace BackendImpl.Test
{
    /// <summary>
    /// Summary description for AngebotFacadeTest
    /// </summary>
    [TestClass]
    public class AngebotFacadeTest
    {
        public AngebotFacadeTest()
        {
            //
            // TODO: Add constructor logic here
            //
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

        [TestMethod]
        public void TestMethod1()
        {
            IAngebotFacade angebotFacade = new AngebotFacade();
            angebotFacade.Save(new Angebot() { Betreff = "Test Angebot", Datum = DateTime.Now, Gesamt = 100, KundeId = new Guid(), Positionen = new List<Position>() { new Position() { Freitext = "TestPosition", Preis = 100 } } });

            //
            // TODO: Add test logic here
            //
        }
    }
}
