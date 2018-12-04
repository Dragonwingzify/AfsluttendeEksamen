using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            LoadTable();
        }
       
       
        private void BackButton_Click(object sender, EventArgs e)
        {

            if ( switchForm != true)
            {
                switchForm = true;
                this.Hide();
                //MainWindow mainForm = new MainWindow();
                //mainForm.ShowDialog();
            }
            else
            {
                switchForm = false;
                this.Hide();
                //Form2 form2 = new Form2();
                //form2.ShowDialog();
            }
            

        }

        public void LoadTable()
        {
            string constring = "Data Source=lc-engine.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(" SELECT * FROM convert_platform ; ", conDataBase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
