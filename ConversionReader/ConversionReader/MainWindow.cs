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
        public MainWindow()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }


        private void Converts_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.ShowDialog();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
