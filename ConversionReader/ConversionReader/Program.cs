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

        static Handler handler = new Handler("Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
        
        static void Main(string[] args)
        {
            handler.GetLineCode("DEFAULT", "klajsd", false);
            Console.ReadKey();
            //MainWindow form1 = new MainWindow();
            //Application.Run(form1);
            
        }

        
    }
}
