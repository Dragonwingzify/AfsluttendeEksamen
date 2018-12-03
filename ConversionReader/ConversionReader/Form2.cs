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
        private int x;
        private int y;

        public Form2()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            pnlWriteCnvrt.Visible = false;

            //Set location values
            x = pnlLinecode.Location.X;
            y = pnlLinecode.Location.Y;
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

        private void pnlWriteCnvrt_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            pnlWriteCnvrt.Visible = true;
            pnlPortPier.Visible = false;
            pnlLinecode.Visible = false;
            btnSubmit.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void boxSlctType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxSlctType.SelectedIndex == 0)
            {
                pnlPortPier.Visible = false; //disable the other panel

                //Activate Linecode Panel
                pnlLinecode.Location = new Point(x,y); //placement
                pnlLinecode.Visible = true;
                pnlWriteCnvrt.Enabled = true;

            }
            else if (boxSlctType.SelectedIndex == 1)
            {
                pnlLinecode.Visible = false;

                pnlPortPier.Location = new Point(x,y);
                pnlPortPier.Visible = true;
                pnlWriteCnvrt.Enabled = true;
            }
            else
                pnlWriteCnvrt.Enabled = false;
        }

        private void pnlLinecode_Paint(object sender, PaintEventArgs e)
        {


        }

        private void txtLinecode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtListId_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
