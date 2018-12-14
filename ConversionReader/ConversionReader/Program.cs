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
        
        //static Handler handler = new Handler("Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
        
        static void Main(string[] args)
        {
            //handler.GetFromLineCode("DEFAULT", "1370", true);
            //handler.GetFromPortAndPier("MISK", "DKAAR", "FCT", true);

            MainWindow form1 = new MainWindow();
            Application.Run(form1);
            
        }

        
    }
}
