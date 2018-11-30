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
            this.SuspendLayout();
            // 
            // Converts
            // 
            this.Converts.Location = new System.Drawing.Point(298, 133);
            this.Converts.Name = "Converts";
            this.Converts.Size = new System.Drawing.Size(178, 23);
            this.Converts.TabIndex = 0;
            this.Converts.Text = "Show converts";
            this.Converts.UseVisualStyleBackColor = true;
            this.Converts.Click += new System.EventHandler(this.Converts_Click);
            // 
            // Table
            // 
            this.Table.Location = new System.Drawing.Point(298, 210);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(178, 23);
            this.Table.TabIndex = 1;
            this.Table.Text = "Show tables";
            this.Table.UseVisualStyleBackColor = true;
            this.Table.Click += new System.EventHandler(this.Table_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textbox1
            // 
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1.Location = new System.Drawing.Point(298, 57);
            this.textbox1.Name = "textbox1";
            this.textbox1.ReadOnly = true;
            this.textbox1.Size = new System.Drawing.Size(178, 30);
            this.textbox1.TabIndex = 3;
            this.textbox1.Text = "Menu";
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Converts);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Converts;
        private System.Windows.Forms.Button Table;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textbox1;
    }
}