using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversionReader;
using System.Data;

namespace TestHandler
{
    [TestClass]
    public class HandlerTest
    {
        [TestMethod]
        public void GetFromLineCodeTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
            Row row = handler.GetFromLineCode("DEFAULT", "1370", false);
            string output = row.Output;
            Assert.AreEqual("APL", output);
        }

        [TestMethod]
        public void GetFromLineCodeEmptyTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
            Row row = handler.GetFromLineCode("DEFAULT", "3332", false);
            string output = row.Output;
            Assert.AreEqual("", output);
        }

        /// <summary>
        /// Commented out since we only test these when we intentionally make our methods fail inside the code and not through parameters.
        /// </summary>
        //[ExpectedException(typeof(System.Data.SqlClient.SqlException))]
        //[TestMethod]
        //public void GetFromPortAndPierTestFail()
        //{
        //    ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");

        //    Row row = handler.GetFromPortAndPier("DEFAULT", "lskfkadjf", "", true);

        //}

        //[ExpectedException(typeof(System.InvalidOperationException))]
        //[TestMethod]
        //public void GetFromPortAndPierTestFail2()
        //{
        //    ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");

        //    Row row = handler.GetFromPortAndPier("DEFAULT", "lskfkadjf", "", true);

        //}

        [TestMethod]
        public void GetFromLineCodeSecondSearchTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
            Row row = handler.GetFromLineCode("DEHAM", "4000", false);
            string output = row.Output;
            Assert.AreEqual("HMM", output);
        }

        [TestMethod]
        public void GetFromPortAndPierTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
            Row row = handler.GetFromPortAndPier("DEFAULT", "DKAAR", "FCT", false);
            string output = row.Output;
            Assert.AreEqual("DKFCT", output);
        }

        [TestMethod]
        public void GetFromPortAndPierSecondTryTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
            Row row = handler.GetFromPortAndPier("CMA", "DKAAR", "FCT", false);
            string output = row.Output;
            Assert.AreEqual("DKFCT", output);
        }

        [TestMethod]
        public void GetFromPortAndPierEmptyTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
            Row row = handler.GetFromPortAndPier("DEFAULT", "DKAAR", "FCR", false);
            string output = row.Output;
            Assert.AreEqual("", output);
        }

        [TestMethod]
        public void SetNewOutputTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
            handler.SetRow("DEFAULT", "0001", "NULL", "TEST", 1, false);
            Row row = handler.GetFromLineCode("DEFAULT", "0001", false);
            string output = row.Output;
            Assert.AreEqual("TEST", output);
        }

        [TestMethod]
        public void UpdateDataTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
            handler.UpdateRow("96", "DEFAULT", "0002", DBNull.Value.ToString(), "TESTER", 1, false);
            Row row = handler.GetFromLineCode("DEFAULT", "0002", false);
            string output = row.Output;
            Assert.AreEqual("TESTER", output);
        }

        [TestMethod]
        public void DeleteDataTest()
        {
            ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
            handler.DeleteRow("96", false);
            Row row = handler.GetFromLineCode("DEFAULT", "0002", false);
            string output = row.Output;
            Assert.AreEqual("", output);
        }

        //[TestMethod]
        //[ExpectedException(typeof(FormatException))]
        //public void DeleteDataTestFail2()
        //{
        //    ConversionReader.Handler handler = new Handler(@"Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
        //    handler.DeleteRow("a", true);
        //}
    }
}
