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
using System.Threading;

namespace ConversionReader
{
    public partial class Form3 : Form
    {
        private Form2 frm2;
        private MainWindow mainWindow;
        private Mutex mutex = new Mutex();
        private bool buffer = true;

        private System.Windows.Forms.Label lblBuffer;

        public Form3(Form2 frm)
        {

            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.frm2 = frm;
            //LoadTable();
            SetupBufferText();

            backgroundWorker1.RunWorkerAsync();
        }

        public Form3(MainWindow mainWindow)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.mainWindow = mainWindow;
            SetupBufferText();

            backgroundWorker1.RunWorkerAsync();
        }


        private void ThreadProc()
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            /* Create a back button that can go back to MainWindow or back to Form2. When you are closing the table,
               depending on what button you have clicked to acces the table, you should be able to acces the table button again*/
            if (switchForm != true)
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
                frm2.EnableTableAgain();
                this.Close();
            }


        }

        public void SetupBufferText()
        {
            Point location = new Point(550, 337);
            lblBuffer = new Label();
            lblBuffer.AutoSize = false;
            lblBuffer.Parent = this;
            lblBuffer.Location = location;
            lblBuffer.SetBounds(location.X, location.Y, 100, 100);
            lblBuffer.Text = "Buffering...";
        }

        // Make a DataTable that can show our Database information and be able to see it in a Form window.
        //public void LoadTable()
        //{
        //    string constring = "Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12";
        //    SqlConnection conDataBase = new SqlConnection(constring);
        //    SqlCommand cmdDataBase = new SqlCommand(" SELECT * FROM convert_platform ; ", conDataBase);
        //    try
        //    {
        //        SqlDataAdapter sda = new SqlDataAdapter();
        //        sda.SelectCommand = cmdDataBase;
        //        DataTable dbdataset = new DataTable();
        //        sda.Fill(dbdataset);
        //        BindingSource bSource = new BindingSource();
        //        bSource.DataSource = dbdataset;
        //        sda.Update(dbdataset);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //background thread
        {
            string constring = "Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(" SELECT * FROM convert_platform ; ", conDataBase);

            do
            {
                Label lblBuffer = new Label();
                lblBuffer.AutoSize = true;
                lblBuffer.Visible = true;
                lblBuffer.Text = "Buffering...";

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    sda.Update(dbdataset);
                    e.Result = dbdataset;
                    mutex.WaitOne();
                    buffer = false;
                    mutex.ReleaseMutex();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    e.Cancel = true;
                }
            } while (buffer == true);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {



        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) //UI thread
        {
            if (e.Cancelled)
            {
                lblBuffer.Text = "Table-loading was canceled";
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                DataTable result = e.Result as DataTable;
                BindingSource bSource = new BindingSource();
                bSource.DataSource = result;
                dataGridView1.DataSource = bSource;

                lblBuffer.Text = "Loading table completed";
            }
        }

        private void pbTableView_Click(object sender, EventArgs e)
        {

        }
    }
}
