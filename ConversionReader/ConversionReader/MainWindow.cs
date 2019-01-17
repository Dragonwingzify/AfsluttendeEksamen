﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ConversionReader.Form2;
namespace ConversionReader
{
    public partial class MainWindow : Form
    {
        public static bool switchForm;
        //Singleton Handler. Can be used across all forms.
        private static Handler handler;
        public static Handler Handler
        {
            get
            {
                if (handler == null)
                {
                    handler = new Handler("Data Source=lc-server.database.windows.net;Initial Catalog=LC-Engine;Persist Security Info=True;User ID=jdaProject;Password=Gruppe12");
                }
                return handler;
            }
        }
        public enum SwitchForms
        {
            showConvert,
            showTable

        };

        public MainWindow()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        /* When we press the convert button, the foreach loop is closing everything except MainWindow, but at the same time
        it closes everything we hide the MainWindow by using the "this.Hide()", which in the end opens form2 */
        /// <summary>
        /// Look here, you two
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Converts_Click(object sender, EventArgs e)
        {
            // when pressing the Convert button, all other forms is closed except MainWindow
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in forms)
            {
                if (thisForm.Name != "MainWindow") thisForm.Close();
            }
            // Hides MainWindow and opens form2
            MainWindow.SwitchForms NextForm = SwitchForms.showConvert;
            if (NextForm == SwitchForms.showConvert)
            {
                switchForm = true;
                this.Hide();
                var form2 = new Form2();
                form2.ShowDialog();

            }


        }

        private void Table_Click(object sender, EventArgs e)
        {
            MainWindow.SwitchForms tableForm = SwitchForms.showTable;
            if (tableForm == SwitchForms.showTable)
            {
                switchForm = false;
                Table.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // When you exit the "Show tables", this method should enable the button again.
        public void EnableTableClick()
        {
            Table.Enabled = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var form3 = new Form3(this);
            e.Result = form3;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            pbTableProgress.Value = e.ProgressPercentage;
            lblTableProgress.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Form3 resultForm3 = e.Result as Form3;

            ///Conditions: If completed object returns with:
            ///Cancellation,
            ///Error
            ///or Completion.
            if (e.Cancelled) //If Background Worker thread was canceled...
            {
                //Display text that tells the user that the process has been canceled.
                lblTableProgress.Text = "Loading table has been canceled.";
            }
        
            else if(e.Error != null) //If there is an error...
            {
                lblTableProgress.Text = e.Error.Message; //Display error message.
            }

            else //if Progress has completed...
            {
                resultForm3.Show(); //Show form 3.
            }
        }

        private void pbTableProgress_Click(object sender, EventArgs e)
{

}

private void lblTableProgress_Click(object sender, EventArgs e)
{

}
    }
}
