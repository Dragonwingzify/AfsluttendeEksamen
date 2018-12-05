using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionReader
{
    public partial class MainWindow : Form
    {
        public static bool switchForm;
        //Singleton Handler. Can be used across all forms.
        private static Handler handler;
        public static Handler Handler
        {
            get
            {
                if (handler == null)
                {
                    handler = new Handler("Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
                }
                return handler;
            }
        }
        public enum SwitchForms
        {
            showConvert,
            showTable

        };

        public MainWindow()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        public SwitchForms MainForm { get; set; }

        /// <summary>
        /// Look here, you two
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Converts_Click(object sender, EventArgs e)
        {

            MainWindow.SwitchForms NextForm = SwitchForms.showConvert;
            if (NextForm == SwitchForms.showConvert)
            {
                switchForm = true;
                this.Hide();
                var form2 = new Form2();
                form2.ShowDialog();
            }

            this.Hide();
            var form2 = new Form2();
            form2.Handler = handler;
            form2.Show();

        }

        private void Table_Click(object sender, EventArgs e)
        {
            MainWindow.SwitchForms tableForm = SwitchForms.showTable;
            if (tableForm == SwitchForms.showTable)
            {
                switchForm = false;
                //this.Hide();
                var form3 = new Form3();
                form3.Show();
            }


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
