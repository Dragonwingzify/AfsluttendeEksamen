﻿using System;
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
    public partial class Form2 : Form
    {
        //Fields & Properties
        private int x;
        private int y;
        public string ListId { get; set; }
        public string Input1 { get; set; }
        public string Input2 { get; set; }
        public bool ToThrow { get; set; }
        public string Output { get; set; }
        Handler handler = new Handler(@"Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
        
        /*  panel2 is the interface for linecode/port&pier input boxes */

        public Form2()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            panel2.Visible = false;
            btnGoTable.Enabled = true;
            //Set location values
            x = pnlLinecode.Location.X;
            y = pnlLinecode.Location.Y;
        }

        private void btnRtrnMain_Click(object sender, EventArgs e)
        {
            // If we press backbutton, all other forms than MainWindow will close
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach(Form thisForm in forms)
            {
                if (thisForm.Name != "MainWindow") thisForm.Close();
            }
                this.Hide();
                var form = new MainWindow();
                form.ShowDialog();
        }


        private void btnGoTable_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var form3 = new Form3(this);
            form3.Show();
            btnGoTable.Enabled = false;
            switchForm = true;

        }

        private void pnlWriteCnvrt_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            

            //Switch case: Which type is selected in the dropdown?
            switch (boxSlctType.SelectedIndex)
            {
                case 0:
                    OutputBox.Text = handler.GetFromLineCode(ListId, Input1, ToThrow);
                    if (OutputBox.Text != null)
                        boxSbmOut.Text = OutputBox.Text;
                    break;
                case 1:
                    OutputBox.Text = handler.GetFromPortAndPier(ListId, Input1, Input2, ToThrow);
                    if (OutputBox.Text != null)
                        boxSbmOut.Text = OutputBox.Text;
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void boxSlctType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            if (boxSlctType.SelectedIndex == 0)
            {
                pnlPortPier.Visible = false; //disable the other panel

                //Activate Linecode Panel
                pnlLinecode.Location = new Point(x, y); //placement
                pnlLinecode.Visible = true;
            }
            else if (boxSlctType.SelectedIndex == 1)
            {
                pnlLinecode.Visible = false;

                pnlPortPier.Location = new Point(x, y);
                pnlPortPier.Visible = true;
            }
            else
                panel2.Visible = false;
        }

        private void pnlLinecode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLinecode_TextChanged(object sender, EventArgs e)
        {
            Input1 = txtLinecode.Text;
        }

        private void txtListId_TextChanged(object sender, EventArgs e)
        {
            ListId = txtListId.Text;
        }

        private void txtListId_Ex_TextChanged(object sender, EventArgs e)
        {
            ListId = txtListId_Ex.Text;
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            Input1 = txtPort.Text;
        }

        private void txtPier_TextChanged(object sender, EventArgs e)
        {
            Input2 = txtPort.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlSubmit_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            pnlSubmit.Visible = true;
        }

        private void boxSbmLId_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkExcptn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcptn.Checked)
                ToThrow = true;
            else
                ToThrow = false;
        }

        private void pnlException_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void gBoxMain_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boxSbmOut_TextChanged(object sender, EventArgs e)
        {

        }

        public void EnableTableAgain()
        {
            btnGoTable.Enabled = true;
        }
        
    }
}
