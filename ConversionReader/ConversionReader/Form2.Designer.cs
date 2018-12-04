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
            this.OutputBox = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGoTable = new System.Windows.Forms.Button();
            this.boxSlctType = new System.Windows.Forms.ComboBox();
            this.txtListId = new System.Windows.Forms.TextBox();
            this.pnlWriteCnvrt = new System.Windows.Forms.Panel();
            this.pnlSubmit = new System.Windows.Forms.GroupBox();
            this.txtSbmOut = new System.Windows.Forms.Label();
            this.txtSbmIn2 = new System.Windows.Forms.Label();
            this.txtSbmIn1 = new System.Windows.Forms.Label();
            this.txtSbmLId = new System.Windows.Forms.Label();
            this.boxSbmOut = new System.Windows.Forms.TextBox();
            this.boxSbmIn2 = new System.Windows.Forms.TextBox();
            this.boxSbmIn1 = new System.Windows.Forms.TextBox();
            this.btnSbmSubmit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPortPier = new System.Windows.Forms.Panel();
            this.txtPier = new System.Windows.Forms.TextBox();
            this.Pier = new System.Windows.Forms.Label();
            this.lblPortPierHelp = new System.Windows.Forms.Label();
            this.lblListId_Ex = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtListId_Ex = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLinecode = new System.Windows.Forms.Panel();
            this.lblLinecodeHelp = new System.Windows.Forms.Label();
            this.lblListId = new System.Windows.Forms.Label();
            this.txtLinecode = new System.Windows.Forms.TextBox();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSelectionHelp = new System.Windows.Forms.Label();
            this.boxSbmLId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.pnlWriteCnvrt.SuspendLayout();
            this.pnlSubmit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPortPier.SuspendLayout();
            this.pnlLinecode.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(62, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // btnEditRow
            // 
            this.btnEditRow.Location = new System.Drawing.Point(7, 121);
            this.btnEditRow.Name = "btnEditRow";
            this.btnEditRow.Size = new System.Drawing.Size(144, 41);
            this.btnEditRow.TabIndex = 3;
            this.btnEditRow.Text = "Edit Row";
            this.btnEditRow.UseVisualStyleBackColor = true;
            // 
            // btnDelRow
            // 
            this.btnDelRow.Location = new System.Drawing.Point(7, 74);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(144, 41);
            this.btnDelRow.TabIndex = 2;
            this.btnDelRow.Text = "Delete Row";
            this.btnDelRow.UseVisualStyleBackColor = true;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(7, 27);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(144, 41);
            this.btnAddRow.TabIndex = 1;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.FormattingEnabled = true;
            this.OutputBox.ItemHeight = 16;
            this.OutputBox.Location = new System.Drawing.Point(381, 32);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(111, 52);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.SelectedIndexChanged += new System.EventHandler(this.OutputBox_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(226, 32);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 52);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Convert";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            // boxSlctType
            // 
            this.boxSlctType.FormattingEnabled = true;
            this.boxSlctType.Items.AddRange(new object[] {
            "Linecode -> Partner tag",
            "Port & Pier -> Terminal code"});
            this.boxSlctType.Location = new System.Drawing.Point(6, 33);
            this.boxSlctType.Name = "boxSlctType";
            this.boxSlctType.Size = new System.Drawing.Size(198, 24);
            this.boxSlctType.TabIndex = 5;
            this.boxSlctType.SelectedIndexChanged += new System.EventHandler(this.boxSlctType_SelectedIndexChanged);
            // 
            // txtListId
            // 
            this.txtListId.Location = new System.Drawing.Point(111, 60);
            this.txtListId.Name = "txtListId";
            this.txtListId.Size = new System.Drawing.Size(87, 22);
            this.txtListId.TabIndex = 6;
            this.txtListId.TextChanged += new System.EventHandler(this.txtListId_TextChanged);
            // 
            // pnlWriteCnvrt
            // 
            this.pnlWriteCnvrt.Controls.Add(this.pnlSubmit);
            this.pnlWriteCnvrt.Controls.Add(this.panel2);
            this.pnlWriteCnvrt.Location = new System.Drawing.Point(239, 12);
            this.pnlWriteCnvrt.Name = "pnlWriteCnvrt";
            this.pnlWriteCnvrt.Size = new System.Drawing.Size(510, 349);
            this.pnlWriteCnvrt.TabIndex = 7;
            this.pnlWriteCnvrt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWriteCnvrt_Paint);
            // 
            // pnlSubmit
            // 
            this.pnlSubmit.Controls.Add(this.boxSbmLId);
            this.pnlSubmit.Controls.Add(this.txtSbmOut);
            this.pnlSubmit.Controls.Add(this.txtSbmIn2);
            this.pnlSubmit.Controls.Add(this.txtSbmIn1);
            this.pnlSubmit.Controls.Add(this.txtSbmLId);
            this.pnlSubmit.Controls.Add(this.boxSbmOut);
            this.pnlSubmit.Controls.Add(this.boxSbmIn2);
            this.pnlSubmit.Controls.Add(this.boxSbmIn1);
            this.pnlSubmit.Controls.Add(this.btnSbmSubmit);
            this.pnlSubmit.Location = new System.Drawing.Point(3, 205);
            this.pnlSubmit.Name = "pnlSubmit";
            this.pnlSubmit.Size = new System.Drawing.Size(504, 141);
            this.pnlSubmit.TabIndex = 14;
            this.pnlSubmit.TabStop = false;
            this.pnlSubmit.Text = "Submit to table";
            this.pnlSubmit.Enter += new System.EventHandler(this.pnlSubmit_Enter);
            // 
            // txtSbmOut
            // 
            this.txtSbmOut.AutoSize = true;
            this.txtSbmOut.Location = new System.Drawing.Point(297, 23);
            this.txtSbmOut.Name = "txtSbmOut";
            this.txtSbmOut.Size = new System.Drawing.Size(51, 17);
            this.txtSbmOut.TabIndex = 9;
            this.txtSbmOut.Text = "Output";
            // 
            // txtSbmIn2
            // 
            this.txtSbmIn2.AutoSize = true;
            this.txtSbmIn2.Location = new System.Drawing.Point(200, 22);
            this.txtSbmIn2.Name = "txtSbmIn2";
            this.txtSbmIn2.Size = new System.Drawing.Size(47, 17);
            this.txtSbmIn2.TabIndex = 8;
            this.txtSbmIn2.Text = "Input2";
            // 
            // txtSbmIn1
            // 
            this.txtSbmIn1.AutoSize = true;
            this.txtSbmIn1.Location = new System.Drawing.Point(100, 23);
            this.txtSbmIn1.Name = "txtSbmIn1";
            this.txtSbmIn1.Size = new System.Drawing.Size(47, 17);
            this.txtSbmIn1.TabIndex = 7;
            this.txtSbmIn1.Text = "Input1";
            // 
            // txtSbmLId
            // 
            this.txtSbmLId.AutoSize = true;
            this.txtSbmLId.Location = new System.Drawing.Point(6, 23);
            this.txtSbmLId.Name = "txtSbmLId";
            this.txtSbmLId.Size = new System.Drawing.Size(45, 17);
            this.txtSbmLId.TabIndex = 6;
            this.txtSbmLId.Text = "ListId:";
            // 
            // boxSbmOut
            // 
            this.boxSbmOut.Location = new System.Drawing.Point(297, 43);
            this.boxSbmOut.Name = "boxSbmOut";
            this.boxSbmOut.Size = new System.Drawing.Size(91, 22);
            this.boxSbmOut.TabIndex = 4;
            // 
            // boxSbmIn2
            // 
            this.boxSbmIn2.Location = new System.Drawing.Point(200, 43);
            this.boxSbmIn2.Name = "boxSbmIn2";
            this.boxSbmIn2.Size = new System.Drawing.Size(91, 22);
            this.boxSbmIn2.TabIndex = 3;
            // 
            // boxSbmIn1
            // 
            this.boxSbmIn1.Location = new System.Drawing.Point(103, 43);
            this.boxSbmIn1.Name = "boxSbmIn1";
            this.boxSbmIn1.Size = new System.Drawing.Size(91, 22);
            this.boxSbmIn1.TabIndex = 2;
            // 
            // btnSbmSubmit
            // 
            this.btnSbmSubmit.Location = new System.Drawing.Point(381, 83);
            this.btnSbmSubmit.Name = "btnSbmSubmit";
            this.btnSbmSubmit.Size = new System.Drawing.Size(117, 52);
            this.btnSbmSubmit.TabIndex = 0;
            this.btnSbmSubmit.Text = "Submit";
            this.btnSbmSubmit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlPortPier);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pnlLinecode);
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Controls.Add(this.lblSelectionHelp);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.boxSlctType);
            this.panel2.Controls.Add(this.OutputBox);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 200);
            this.panel2.TabIndex = 12;
            // 
            // pnlPortPier
            // 
            this.pnlPortPier.Controls.Add(this.txtPier);
            this.pnlPortPier.Controls.Add(this.Pier);
            this.pnlPortPier.Controls.Add(this.lblPortPierHelp);
            this.pnlPortPier.Controls.Add(this.lblListId_Ex);
            this.pnlPortPier.Controls.Add(this.txtPort);
            this.pnlPortPier.Controls.Add(this.txtListId_Ex);
            this.pnlPortPier.Controls.Add(this.lblPort);
            this.pnlPortPier.Location = new System.Drawing.Point(3, 63);
            this.pnlPortPier.Name = "pnlPortPier";
            this.pnlPortPier.Size = new System.Drawing.Size(201, 133);
            this.pnlPortPier.TabIndex = 12;
            // 
            // txtPier
            // 
            this.txtPier.Location = new System.Drawing.Point(111, 88);
            this.txtPier.Name = "txtPier";
            this.txtPier.Size = new System.Drawing.Size(87, 22);
            this.txtPier.TabIndex = 11;
            this.txtPier.TextChanged += new System.EventHandler(this.txtPier_TextChanged);
            // 
            // Pier
            // 
            this.Pier.AutoSize = true;
            this.Pier.Location = new System.Drawing.Point(4, 88);
            this.Pier.Name = "Pier";
            this.Pier.Size = new System.Drawing.Size(37, 17);
            this.Pier.TabIndex = 10;
            this.Pier.Text = "Pier:";
            // 
            // lblPortPierHelp
            // 
            this.lblPortPierHelp.AutoSize = true;
            this.lblPortPierHelp.Location = new System.Drawing.Point(4, 2);
            this.lblPortPierHelp.Name = "lblPortPierHelp";
            this.lblPortPierHelp.Size = new System.Drawing.Size(75, 17);
            this.lblPortPierHelp.TabIndex = 8;
            this.lblPortPierHelp.Text = "Input data:";
            // 
            // lblListId_Ex
            // 
            this.lblListId_Ex.AutoSize = true;
            this.lblListId_Ex.Location = new System.Drawing.Point(4, 32);
            this.lblListId_Ex.Name = "lblListId_Ex";
            this.lblListId_Ex.Size = new System.Drawing.Size(34, 17);
            this.lblListId_Ex.TabIndex = 8;
            this.lblListId_Ex.Text = "List:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(111, 60);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(87, 22);
            this.txtPort.TabIndex = 6;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // txtListId_Ex
            // 
            this.txtListId_Ex.Location = new System.Drawing.Point(111, 32);
            this.txtListId_Ex.Name = "txtListId_Ex";
            this.txtListId_Ex.Size = new System.Drawing.Size(87, 22);
            this.txtListId_Ex.TabIndex = 7;
            this.txtListId_Ex.TextChanged += new System.EventHandler(this.txtListId_Ex_TextChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(4, 60);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 17);
            this.lblPort.TabIndex = 9;
            this.lblPort.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Confirm to convert";
            // 
            // pnlLinecode
            // 
            this.pnlLinecode.Controls.Add(this.lblLinecodeHelp);
            this.pnlLinecode.Controls.Add(this.lblListId);
            this.pnlLinecode.Controls.Add(this.txtListId);
            this.pnlLinecode.Controls.Add(this.txtLinecode);
            this.pnlLinecode.Controls.Add(this.lblInput1);
            this.pnlLinecode.Location = new System.Drawing.Point(3, 60);
            this.pnlLinecode.Name = "pnlLinecode";
            this.pnlLinecode.Size = new System.Drawing.Size(201, 95);
            this.pnlLinecode.TabIndex = 11;
            this.pnlLinecode.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLinecode_Paint);
            // 
            // lblLinecodeHelp
            // 
            this.lblLinecodeHelp.AutoSize = true;
            this.lblLinecodeHelp.Location = new System.Drawing.Point(3, 7);
            this.lblLinecodeHelp.Name = "lblLinecodeHelp";
            this.lblLinecodeHelp.Size = new System.Drawing.Size(75, 17);
            this.lblLinecodeHelp.TabIndex = 8;
            this.lblLinecodeHelp.Text = "Input data:";
            // 
            // lblListId
            // 
            this.lblListId.AutoSize = true;
            this.lblListId.Location = new System.Drawing.Point(3, 37);
            this.lblListId.Name = "lblListId";
            this.lblListId.Size = new System.Drawing.Size(34, 17);
            this.lblListId.TabIndex = 8;
            this.lblListId.Text = "List:";
            // 
            // txtLinecode
            // 
            this.txtLinecode.Location = new System.Drawing.Point(111, 32);
            this.txtLinecode.Name = "txtLinecode";
            this.txtLinecode.Size = new System.Drawing.Size(87, 22);
            this.txtLinecode.TabIndex = 7;
            this.txtLinecode.TextChanged += new System.EventHandler(this.txtLinecode_TextChanged);
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Location = new System.Drawing.Point(3, 63);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(70, 17);
            this.lblInput1.TabIndex = 9;
            this.lblInput1.Text = "Linecode:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(378, 10);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // 
            // lblSelectionHelp
            // 
            this.lblSelectionHelp.AutoSize = true;
            this.lblSelectionHelp.Location = new System.Drawing.Point(3, 10);
            this.lblSelectionHelp.Name = "lblSelectionHelp";
            this.lblSelectionHelp.Size = new System.Drawing.Size(124, 17);
            this.lblSelectionHelp.TabIndex = 10;
            this.lblSelectionHelp.Text = "Select conversion:";
            // 
            // boxSbmLId
            // 
            this.boxSbmLId.Location = new System.Drawing.Point(3, 43);
            this.boxSbmLId.Name = "boxSbmLId";
            this.boxSbmLId.Size = new System.Drawing.Size(91, 22);
            this.boxSbmLId.TabIndex = 10;
            this.boxSbmLId.TextChanged += new System.EventHandler(this.boxSbmLId_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlWriteCnvrt);
            this.Controls.Add(this.btnGoTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRtrnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.pnlWriteCnvrt.ResumeLayout(false);
            this.pnlSubmit.ResumeLayout(false);
            this.pnlSubmit.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPortPier.ResumeLayout(false);
            this.pnlPortPier.PerformLayout();
            this.pnlLinecode.ResumeLayout(false);
            this.pnlLinecode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRtrnMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditRow;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.ListBox OutputBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnGoTable;
        private System.Windows.Forms.ComboBox boxSlctType;
        private System.Windows.Forms.TextBox txtListId;
        private System.Windows.Forms.Panel pnlWriteCnvrt;
        private System.Windows.Forms.TextBox txtLinecode;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel pnlLinecode;
        private System.Windows.Forms.Label lblLinecodeHelp;
        private System.Windows.Forms.Label lblListId;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSelectionHelp;
        private System.Windows.Forms.Panel pnlPortPier;
        private System.Windows.Forms.Label lblPortPierHelp;
        private System.Windows.Forms.Label lblListId_Ex;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtListId_Ex;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPier;
        private System.Windows.Forms.Label Pier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox pnlSubmit;
        private System.Windows.Forms.Label txtSbmOut;
        private System.Windows.Forms.Label txtSbmIn2;
        private System.Windows.Forms.Label txtSbmIn1;
        private System.Windows.Forms.Label txtSbmLId;
        private System.Windows.Forms.TextBox boxSbmOut;
        private System.Windows.Forms.TextBox boxSbmIn2;
        private System.Windows.Forms.TextBox boxSbmIn1;
        private System.Windows.Forms.Button btnSbmSubmit;
        private System.Windows.Forms.TextBox boxSbmLId;
    }
}