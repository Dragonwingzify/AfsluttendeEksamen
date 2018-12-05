using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConversionReader
{
    class Program
    {

        //static Handler handler = new Handler("Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
        
        static void Main(string[] args)
        {
            //handler.GetFromLineCode("DEFAULT", "1370", true);
            handler.GetFromPortAndPier("MISK", "DKAAR", "FCT", false);

            handler.SetRow("DEFAULT", "0001", "NULL", "TEST", "1");

            handler.SetPartner("Test_CREATE", "TEST_Input1", "TEST_Input2", "TEST_Output", 2, true);
            handler.UpdatePartner(103, "DEFAULT", "0001", "EDITED", "TEST", 2, true);
            handler.DeletePartner(103, true);

            MainWindow form1 = new MainWindow();
            Application.Run(form1);
            
        }

        
    }
}
