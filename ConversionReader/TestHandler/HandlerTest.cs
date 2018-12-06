using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversionReader;

namespace TestHandler
{
    [TestClass]
    public class HandlerTest
    {
        [TestMethod]
        public void GetFromLineCodeTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");

            string output = handler.GetFromLineCode("DEFAULT", "1370", true);
            Assert.AreEqual("APL", output);
        }

        [TestMethod]
        public void GetFromLineCodeEmptyTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");

            string output = handler.GetFromLineCode("DEFAULT", "3332", true);
            Assert.AreEqual("", output);
        }

        [TestMethod]
        public void GetFromLineCodeSecondSearchTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");

            string output = handler.GetFromLineCode("DEHAM", "4000", true);
            Assert.AreEqual("HMM", output);
        }

        [TestMethod]
        public void GetFromPortAndPierTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");

            string output = handler.GetFromPortAndPier("DEFAULT", "DKAAR", "FCT", false);
            Assert.AreEqual("DKFCT", output);
        }

        [TestMethod]
        public void GetFromPortAndPierSecondTryTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");

            string output = handler.GetFromPortAndPier("CMA", "DKAAR", "FCT", false);
            Assert.AreEqual("DKFCT", output);
        }

        [TestMethod]
        public void GetFromPortAndPierEmptyTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");

            string output = handler.GetFromPortAndPier("DEFAULT", "DKAAR", "FCR", false);
            Assert.AreEqual("", output);
        }

        [TestMethod]
        public void SetNewOutputTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
            handler.SetRow("DEFAULT", "0001", "NULL", "TEST", "1");
            string output = handler.GetFromLineCode("DEFAULT", "0001", false);
            Assert.AreEqual("TEST", output);
        }
    }
}
