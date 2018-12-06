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
using static ConversionReader.Form2;

namespace ConversionReader
{
    public partial class Form3 : Form
    {
        private Form2 frm;
        private MainWindow mainWindow;

        public Form3(Form2 frm)
        {

            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.frm = frm;
            LoadTable();
        }

        public Form3(MainWindow mainWindow)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.mainWindow = mainWindow;
            LoadTable();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            /* Create a back button that can go back to MainWindow or back to Form2. When you are closing the table,
               depending on what button you have clicked to acces the table, you should be able to acces the table button again*/
            if ( switchForm != true)
            {
                switchForm = true;
                this.Hide();
                this.Close();
                mainWindow.EnableTableClick();

            }
            else
            {
                switchForm = false;
                this.Hide();
                frm.EnableTableAgain();
                this.Close();
            }
            

        }
        // Make a DataTable that can show our Database information and be able to see it in a Form window.
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
