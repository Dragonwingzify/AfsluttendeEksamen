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

        static Handler handler = new Handler("lc-engine.database.windows.net");
        
        static void Main(string[] args)
        { 
            MainWindow form1 = new MainWindow();
            Application.Run(form1);
            
        }

        
    }
}
