namespace ConversionReader
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Converts = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbTableProgress = new System.Windows.Forms.ProgressBar();
            this.lblTableProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Converts
            // 
            this.Converts.Location = new System.Drawing.Point(224, 110);
            this.Converts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Converts.Name = "Converts";
            this.Converts.Size = new System.Drawing.Size(134, 46);
            this.Converts.TabIndex = 0;
            this.Converts.Text = "Show conversions";
            this.Converts.UseVisualStyleBackColor = true;
            this.Converts.Click += new System.EventHandler(this.Converts_Click);
            // 
            // Table
            // 
            this.Table.Location = new System.Drawing.Point(224, 195);
            this.Table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(134, 46);
            this.Table.TabIndex = 1;
            this.Table.Text = "Show table";
            this.Table.UseVisualStyleBackColor = true;
            this.Table.Click += new System.EventHandler(this.Table_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(9, 337);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(72, 19);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textbox1
            // 
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1.Location = new System.Drawing.Point(224, 46);
            this.textbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbox1.Name = "textbox1";
            this.textbox1.ReadOnly = true;
            this.textbox1.Size = new System.Drawing.Size(134, 26);
            this.textbox1.TabIndex = 3;
            this.textbox1.Text = "Menu";
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pbTableProgress
            // 
            this.pbTableProgress.Location = new System.Drawing.Point(488, 316);
            this.pbTableProgress.Name = "pbTableProgress";
            this.pbTableProgress.Size = new System.Drawing.Size(100, 23);
            this.pbTableProgress.TabIndex = 4;
            this.pbTableProgress.Click += new System.EventHandler(this.pbTableProgress_Click);
            // 
            // lblTableProgress
            // 
            this.lblTableProgress.AutoSize = true;
            this.lblTableProgress.Location = new System.Drawing.Point(488, 346);
            this.lblTableProgress.Name = "lblTableProgress";
            this.lblTableProgress.Size = new System.Drawing.Size(35, 13);
            this.lblTableProgress.TabIndex = 5;
            this.lblTableProgress.Text = "label1";
            this.lblTableProgress.Click += new System.EventHandler(this.lblTableProgress_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblTableProgress);
            this.Controls.Add(this.pbTableProgress);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Converts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "Integration Platform";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Converts;
        private System.Windows.Forms.Button Table;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textbox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar pbTableProgress;
        private System.Windows.Forms.Label lblTableProgress;
    }
}