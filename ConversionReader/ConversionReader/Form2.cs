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
    public partial class Form2 : Form
    {
        public Form2()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnRtrnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainWindow();
            form.ShowDialog();
            
        }

        private void btnGoTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
