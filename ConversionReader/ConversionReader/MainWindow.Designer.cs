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
            this.lblSelectionHelp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Converts
            // 
            this.Converts.BackColor = System.Drawing.SystemColors.Menu;
            this.Converts.Location = new System.Drawing.Point(156, 322);
            this.Converts.Name = "Converts";
            this.Converts.Size = new System.Drawing.Size(178, 36);
            this.Converts.TabIndex = 0;
            this.Converts.Text = "Show conversions";
            this.Converts.UseVisualStyleBackColor = false;
            this.Converts.Click += new System.EventHandler(this.Converts_Click);
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Table.Location = new System.Drawing.Point(490, 322);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(178, 36);
            this.Table.TabIndex = 1;
            this.Table.Text = "Show table";
            this.Table.UseVisualStyleBackColor = false;
            this.Table.Click += new System.EventHandler(this.Table_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.Location = new System.Drawing.Point(12, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lblSelectionHelp
            // 
            this.lblSelectionHelp.AutoSize = true;
            this.lblSelectionHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionHelp.Location = new System.Drawing.Point(322, 215);
            this.lblSelectionHelp.Name = "lblSelectionHelp";
            this.lblSelectionHelp.Size = new System.Drawing.Size(179, 69);
            this.lblSelectionHelp.TabIndex = 11;
            this.lblSelectionHelp.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConversionReader.Properties.Resources.case_5560e361_d33a_4916_b06f_3ee89098ebd1;
            this.pictureBox1.Location = new System.Drawing.Point(156, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSelectionHelp);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Converts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.Text = "Integration Platform";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Converts;
        private System.Windows.Forms.Button Table;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label lblSelectionHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}