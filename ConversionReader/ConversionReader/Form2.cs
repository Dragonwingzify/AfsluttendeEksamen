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
using System.Data.SqlClient;

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

        private List<string> outputList = new List<string>();
        

        Handler handler = MainWindow.Handler; //shorthand variable

        /*  panel2 is the interface for linecode/port&pier input boxes */

        public Form2()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            panel2.Visible = false;
            pnlSubmit.Visible = true;
            btnGoTable.Enabled = true;
            ToThrow = false;

            //Set location values
            x = pnlLinecode.Location.X;
            y = pnlLinecode.Location.Y;

            Point Location = new Point(190, 288);
        }

        private void btnRtrnMain_Click(object sender, EventArgs e)
        {
            // If we press backbutton, all other forms than MainWindow will close
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in forms)
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
                    {
                        #region values to txt boxes
                        try
                        {
                            using (var conn = new SqlConnection(handler.ConnectionString))
                            {
                                handler.SqlCommand = new SqlCommand("dbo.GetFromLineCode", conn);
                                handler.SqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                                handler.SqlCommand.Parameters.Add("@ListId", SqlDbType.NVarChar);
                                handler.SqlCommand.Parameters["@ListId"].Value = ListId;
                                handler.SqlCommand.Parameters.Add("@Linecode", SqlDbType.NVarChar);
                                handler.SqlCommand.Parameters["@Linecode"].Value = Input1;
                                conn.Open();
                                using (SqlDataReader reader = handler.SqlCommand.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Output = reader.GetString(reader.GetOrdinal("output"));
                                        ListId = reader.GetString(reader.GetOrdinal("list_id"));
                                        Id = reader.GetString(reader.GetOrdinal("id"));
                                        Input1 = reader.GetString(reader.GetOrdinal("input1"));
                                    }
                                }
                                conn.Dispose();
                            }
                        }
                        catch (Exception ex)
                        {
                            if (ToThrow == true)
                            {
                                MessageBox.Show(ex.ToString());
                                //throw ex;
                            }

                        }
                        #endregion
                        boxSbmOut.Text = OutputBox.Text;
                        boxSbmLId.Text = txtListId.Text;
                        boxSbmIn1.Text = txtLinecode.Text;
                    }

                    break;
                case 1:
                    OutputBox.Text = handler.GetFromPortAndPier(ListId, Input1, Input2, ToThrow);
                    if (OutputBox.Text != null)
                    {
                        #region values to txt boxes
                        try
                        {
                            using (var conn = new SqlConnection(handler.ConnectionString))
                            {
                                handler.SqlCommand = new SqlCommand("dbo.GetFromPortAndPier", conn);
                                handler.SqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                                handler.SqlCommand.Parameters.Add("@ListId", SqlDbType.NVarChar);
                                handler.SqlCommand.Parameters["@ListId"].Value = ListId;
                                handler.SqlCommand.Parameters.Add(new SqlParameter("@Port", SqlDbType.NVarChar));
                                handler.SqlCommand.Parameters["@Port"].Value = Input1;
                                handler.SqlCommand.Parameters.Add(new SqlParameter("@Pier", SqlDbType.NVarChar));
                                handler.SqlCommand.Parameters["@Pier"].Value = Input2;
                                conn.Open();
                                using (SqlDataReader reader = handler.SqlCommand.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Output = reader.GetString(reader.GetOrdinal("output"));
                                        ListId = reader.GetString(reader.GetOrdinal("list_id"));
                                        Id = reader.GetString(reader.GetOrdinal("id"));
                                        Input1 = reader.GetString(reader.GetOrdinal("input1"));
                                        Input2 = reader.GetString(reader.GetOrdinal("input2"));
                                    }
                                }
                                conn.Dispose();
                            }
                        }
                        catch (Exception ex)
                        {
                            if (ToThrow == true)
                            {
                                MessageBox.Show(ex.ToString());
                                //throw ex;
                            }

                        }
                        #endregion
                        boxSbmOut.Text = OutputBox.Text;
                        boxSbmLId.Text = txtListId_Ex.Text;
                        boxSbmIn1.Text = txtPort.Text;
                        boxSbmIn2.Text = txtPier.Text;
                    }
                    break;
            }


            //Add to text fields in Submit
            boxSbmLId.Text = ListId;
            boxSbmIn1.Text = Input1;
            boxSbmIn2.Text = Input2;
            boxSbmOut.Text = Output;

            //Add to text fields in Edit
            boxEditLId.Text = ListId;
            boxEditInput1.Text = Input1;
            boxEditInput2.Text = Input2;
            boxEditOutput.Text = Output;

            //Doesn't currently update box.
            outputList.Add("Output: " + Output);
            outputList.Add("List-Id: " + ListId);
            outputList.Add("Input1: " + Input1);
            outputList.Add("Input2: " + Input2);

            foreach (string item in outputList)
                OutputBox.Text = item;
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

            handler.SetRow(ListId, Input1, Input2, Output, type, ToThrow);
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
            Id = boxSlctId.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            handler.DeleteRow(Id, ToThrow);
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
            if (boxGetFromId.Text == "")
                btnEdit.Enabled = false;
            else
            {
                Id = boxGetFromId.Text;
                btnEdit.Enabled = true;
            }
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

            if (boxGetFromId.Text == "")
                MessageBox.Show("Please Insert an ID into the input field.");
            else
                handler.UpdateRow(boxGetFromId.Text, boxEditLId.Text, boxEditInput1.Text, boxEditInput2.Text, boxEditOutput.Text, type, ToThrow);
        }

        private void boxEditLId_TextChanged(object sender, EventArgs e)
        {
                ListId = boxEditLId.Text;
        }

        private void boxEditInput1_TextChanged(object sender, EventArgs e)
        {
                Input1 = boxEditInput1.Text;
        }

        private void boxEditInput2_TextChanged(object sender, EventArgs e)
        {
                Input2 = boxEditInput2.Text;
        }

        private void boxEditOutput_TextChanged(object sender, EventArgs e)
        {
            Output = boxEditOutput.Text;
        }

        private void btnEditRow_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = false;
            pnlSubmit.Visible = false;

            pnlEdit.Location = pnlSubmit.Location;
            pnlEdit.Visible = true;
        }
        public void EnableTableAgain()
        {
            btnGoTable.Enabled = true;
        }
    }
}
