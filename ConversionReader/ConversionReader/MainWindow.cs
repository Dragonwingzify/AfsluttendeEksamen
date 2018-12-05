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
            InitializeComponent();
        }

        /// <summary>
        /// Look here, you two
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Converts_Click(object sender, EventArgs e)
        {
            Handler handler = new Handler("");
            this.Hide();
            var form2 = new Form2();
            form2.Handler = handler;
            form2.Show();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
