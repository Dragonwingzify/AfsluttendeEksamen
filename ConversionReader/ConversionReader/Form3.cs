using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ConversionReader.MainWindow;

namespace ConversionReader
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
       
       
        private void BackButton_Click(object sender, EventArgs e)
        {

            if ( switchForm != true)
            {
                switchForm = true;
                this.Hide();
                MainWindow mainForm = new MainWindow();
                mainForm.ShowDialog();
            }
            else
            {
                switchForm = false;
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }


        }
    }
}
