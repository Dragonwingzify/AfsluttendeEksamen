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
        //Fields & Properties
        private int x;
        private int y;
        public string ListId { get; set; }
        public string Input1 { get; set; }
        public string Input2 { get; set; }
        public bool ToThrow { get; set; }
        public string Output { get; set; }
        public string Id { get; set; }

        Handler handler = MainWindow.Handler; //shorthand variable

        /*  panel2 is the interface for linecode/port&pier input boxes */

        public Form2()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            panel2.Visible = false;
            pnlSubmit.Visible = false;
            ToThrow = false;

            //Set location values
            x = pnlLinecode.Location.X;
            y = pnlLinecode.Location.Y;

            Point Location = new Point(190,288);
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
            var form3 = new Form3();
            form3.Show();
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
                    {
                        boxSbmOut.Text = OutputBox.Text;
                        boxSbmLId.Text = txtListId.Text;
                        boxSbmIn1.Text = txtLinecode.Text;
                    }
                       
                    break;
                case 1:
                    OutputBox.Text = handler.GetFromPortAndPier(ListId, Input1, Input2, ToThrow);
                    if (OutputBox.Text != null)
                    {
                        boxSbmOut.Text = OutputBox.Text;
                        boxSbmLId.Text = txtListId_Ex.Text;
                        boxSbmIn1.Text = txtPort.Text;
                        boxSbmIn2.Text = txtPier.Text;
                    }
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

        #region Textbox input values to variable values
        private void txtLinecode_TextChanged(object sender, EventArgs e)
        {
            Input1 = txtLinecode.Text; //txtLinecode text is set as Input1 variable's value
        }

        private void txtListId_TextChanged(object sender, EventArgs e)
        {
            ListId = txtListId.Text; //txtListId text is set as ListId variable's value
        }

        private void txtListId_Ex_TextChanged(object sender, EventArgs e)
        {
            ListId = txtListId_Ex.Text; //ListId variable value is the same as the user-typed input in txtListId_Ex
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            Input1 = txtPort.Text; //Input1 is the same as the value in txtPort's input field.
        }

        private void txtPier_TextChanged(object sender, EventArgs e)
        {
            Input2 = txtPier.Text; //Sets Input2 value to be what the user wrote in the txtPier textbox.
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlSubmit_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            pnlDelete.Visible = false;

            pnlSubmit.Visible = true;
        }

        private void boxSbmLId_TextChanged(object sender, EventArgs e)
        {
            ListId = boxSbmLId.Text;
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
            Output = boxSbmOut.Text;
        }

        private void btnSbmSubmit_Click(object sender, EventArgs e)
        {
            int type = 1;
            if (boxSlctType.SelectedIndex == 1)
                type = 1;
            if (Input2 != null)
                type = 2;

                handler.SetRow(ListId, Input1, Input2, Output, type);
        }

        private void boxSbmIn1_TextChanged(object sender, EventArgs e)
        {
            Input1 = boxSbmIn1.Text;
        }

        private void boxSbmIn2_TextChanged(object sender, EventArgs e)
        {
            Input2 = boxSbmIn2.Text;
        }

        private void boxSlctId_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            handler.DeleteRow(boxSlctId.Text);
        }

        private void btnDelRow_Click(object sender, EventArgs e)
        {
            pnlDelete.Location = pnlSubmit.Location; //align location
            pnlSubmit.Visible = false; //close Add Row GroupBox
            pnlEdit.Visible = false; //close Edit Row GroupBox

            pnlDelete.Visible = true;
        }

        private void boxGetFromId_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGetFromId_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int type = 1;
            if (boxEditInput2.Text == null)
                type = 1;
            else
                type = 2;

            handler.UpdateRow(boxGetFromId.Text, boxEditLId.Text, boxEditInput1.Text, boxEditInput2.Text, boxEditOutput.Text, type);
        }

        private void boxEditLId_TextChanged(object sender, EventArgs e)
        {
        }

        private void boxEditInput1_TextChanged(object sender, EventArgs e)
        {
        }

        private void boxEditInput2_TextChanged(object sender, EventArgs e)
        {
        }

        private void boxEditOutput_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnEditRow_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = false;
            pnlSubmit.Visible = false;

            pnlEdit.Location = pnlSubmit.Location;
            pnlEdit.Visible = true;
        }
    }
}
