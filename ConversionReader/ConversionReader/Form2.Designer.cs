namespace ConversionReader
{
    partial class Form2
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
            this.btnRtrnMain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditRow = new System.Windows.Forms.Button();
            this.btnDelRow = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGoTable = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRtrnMain
            // 
            this.btnRtrnMain.Location = new System.Drawing.Point(13, 415);
            this.btnRtrnMain.Name = "btnRtrnMain";
            this.btnRtrnMain.Size = new System.Drawing.Size(75, 23);
            this.btnRtrnMain.TabIndex = 0;
            this.btnRtrnMain.Text = "Return";
            this.btnRtrnMain.UseVisualStyleBackColor = true;
            this.btnRtrnMain.Click += new System.EventHandler(this.btnRtrnMain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditRow);
            this.groupBox1.Controls.Add(this.btnDelRow);
            this.groupBox1.Controls.Add(this.btnAddRow);
            this.groupBox1.Controls.Add(this.btnWrite);
            this.groupBox1.Location = new System.Drawing.Point(112, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // btnEditRow
            // 
            this.btnEditRow.Location = new System.Drawing.Point(6, 163);
            this.btnEditRow.Name = "btnEditRow";
            this.btnEditRow.Size = new System.Drawing.Size(144, 41);
            this.btnEditRow.TabIndex = 3;
            this.btnEditRow.Text = "Edit Row";
            this.btnEditRow.UseVisualStyleBackColor = true;
            // 
            // btnDelRow
            // 
            this.btnDelRow.Location = new System.Drawing.Point(6, 116);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(144, 41);
            this.btnDelRow.TabIndex = 2;
            this.btnDelRow.Text = "Delete Row";
            this.btnDelRow.UseVisualStyleBackColor = true;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(6, 69);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(144, 41);
            this.btnAddRow.TabIndex = 1;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(7, 22);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(144, 41);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "Write Conversion";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // InputBox
            // 
            this.InputBox.FormattingEnabled = true;
            this.InputBox.ItemHeight = 16;
            this.InputBox.Location = new System.Drawing.Point(554, 93);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(120, 84);
            this.InputBox.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(599, 183);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnGoTable
            // 
            this.btnGoTable.Location = new System.Drawing.Point(676, 401);
            this.btnGoTable.Name = "btnGoTable";
            this.btnGoTable.Size = new System.Drawing.Size(112, 37);
            this.btnGoTable.TabIndex = 4;
            this.btnGoTable.Text = "Go To Table";
            this.btnGoTable.UseVisualStyleBackColor = true;
            this.btnGoTable.Click += new System.EventHandler(this.btnGoTable_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoTable);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRtrnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRtrnMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditRow;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.ListBox InputBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnGoTable;
    }
}