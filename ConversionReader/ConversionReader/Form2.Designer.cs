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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGoTable = new System.Windows.Forms.Button();
            this.boxSlctType = new System.Windows.Forms.ComboBox();
            this.txtListId = new System.Windows.Forms.TextBox();
            this.pnlSubmit = new System.Windows.Forms.GroupBox();
            this.boxSbmLId = new System.Windows.Forms.TextBox();
            this.txtSbmOut = new System.Windows.Forms.Label();
            this.txtSbmIn2 = new System.Windows.Forms.Label();
            this.txtSbmIn1 = new System.Windows.Forms.Label();
            this.txtSbmLId = new System.Windows.Forms.Label();
            this.boxSbmOut = new System.Windows.Forms.TextBox();
            this.boxSbmIn2 = new System.Windows.Forms.TextBox();
            this.boxSbmIn1 = new System.Windows.Forms.TextBox();
            this.btnSbmSubmit = new System.Windows.Forms.Button();
            this.pnlEdit = new System.Windows.Forms.GroupBox();
            this.boxEditLId = new System.Windows.Forms.TextBox();
            this.lblEditOutput = new System.Windows.Forms.Label();
            this.lblEditInput2 = new System.Windows.Forms.Label();
            this.lblEditInput1 = new System.Windows.Forms.Label();
            this.lblEditLId = new System.Windows.Forms.Label();
            this.boxEditOutput = new System.Windows.Forms.TextBox();
            this.boxEditInput2 = new System.Windows.Forms.TextBox();
            this.boxEditInput1 = new System.Windows.Forms.TextBox();
            this.lblSelectId = new System.Windows.Forms.Label();
            this.boxGetFromId = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlDelete = new System.Windows.Forms.GroupBox();
            this.lblSelctId = new System.Windows.Forms.Label();
            this.boxSlctId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlException = new System.Windows.Forms.Panel();
            this.lblExcptn = new System.Windows.Forms.Label();
            this.chkExcptn = new System.Windows.Forms.CheckBox();
            this.pnlPortPier = new System.Windows.Forms.Panel();
            this.txtPier = new System.Windows.Forms.TextBox();
            this.lblPier = new System.Windows.Forms.Label();
            this.lblPortPierHelp = new System.Windows.Forms.Label();
            this.lblListId_Ex = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtListId_Ex = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.pnlLinecode = new System.Windows.Forms.Panel();
            this.lblLinecodeHelp = new System.Windows.Forms.Label();
            this.lblListId = new System.Windows.Forms.Label();
            this.txtLinecode = new System.Windows.Forms.TextBox();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectionHelp = new System.Windows.Forms.Label();
            this.gBoxMain = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.pnlSubmit.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlException.SuspendLayout();
            this.pnlPortPier.SuspendLayout();
            this.pnlLinecode.SuspendLayout();
            this.gBoxMain.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 369);
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
            this.btnEditRow.Click += new System.EventHandler(this.btnEditRow_Click);
            // 
            // btnDelRow
            // 
            this.btnDelRow.Location = new System.Drawing.Point(7, 74);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(144, 41);
            this.btnDelRow.TabIndex = 2;
            this.btnDelRow.Text = "Delete Row";
            this.btnDelRow.UseVisualStyleBackColor = true;
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(375, 47);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 48);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Get Data";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnGoTable
            // 
            this.btnGoTable.Location = new System.Drawing.Point(676, 401);
            this.btnGoTable.Name = "btnGoTable";
            this.btnGoTable.Size = new System.Drawing.Size(112, 37);
            this.btnGoTable.TabIndex = 4;
            this.btnGoTable.Text = "Show table";
            this.btnGoTable.UseVisualStyleBackColor = true;
            this.btnGoTable.Click += new System.EventHandler(this.btnGoTable_Click);
            // 
            // boxSlctType
            // 
            this.boxSlctType.FormattingEnabled = true;
            this.boxSlctType.Items.AddRange(new object[] {
            "Linecode -> Partner tag",
            "Port & Pier -> Terminal code"});
            this.boxSlctType.Location = new System.Drawing.Point(16, 47);
            this.boxSlctType.Name = "boxSlctType";
            this.boxSlctType.Size = new System.Drawing.Size(198, 24);
            this.boxSlctType.TabIndex = 5;
            this.boxSlctType.SelectedIndexChanged += new System.EventHandler(this.boxSlctType_SelectedIndexChanged);
            // 
            // txtListId
            // 
            this.txtListId.Location = new System.Drawing.Point(108, 32);
            this.txtListId.Name = "txtListId";
            this.txtListId.Size = new System.Drawing.Size(87, 22);
            this.txtListId.TabIndex = 6;
            this.txtListId.TextChanged += new System.EventHandler(this.txtListId_TextChanged);
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
            this.pnlSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlSubmit.Location = new System.Drawing.Point(190, 282);
            this.pnlSubmit.Name = "pnlSubmit";
            this.pnlSubmit.Size = new System.Drawing.Size(535, 110);
            this.pnlSubmit.TabIndex = 14;
            this.pnlSubmit.TabStop = false;
            this.pnlSubmit.Text = "Submit to table";
            this.pnlSubmit.Enter += new System.EventHandler(this.pnlSubmit_Enter);
            // 
            // boxSbmLId
            // 
            this.boxSbmLId.Location = new System.Drawing.Point(6, 43);
            this.boxSbmLId.Name = "boxSbmLId";
            this.boxSbmLId.Size = new System.Drawing.Size(91, 22);
            this.boxSbmLId.TabIndex = 10;
            this.boxSbmLId.TextChanged += new System.EventHandler(this.boxSbmLId_TextChanged);
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
            this.boxSbmOut.Location = new System.Drawing.Point(300, 43);
            this.boxSbmOut.Name = "boxSbmOut";
            this.boxSbmOut.Size = new System.Drawing.Size(77, 22);
            this.boxSbmOut.TabIndex = 4;
            this.boxSbmOut.TextChanged += new System.EventHandler(this.boxSbmOut_TextChanged);
            // 
            // boxSbmIn2
            // 
            this.boxSbmIn2.Location = new System.Drawing.Point(200, 43);
            this.boxSbmIn2.Name = "boxSbmIn2";
            this.boxSbmIn2.Size = new System.Drawing.Size(91, 22);
            this.boxSbmIn2.TabIndex = 3;
            this.boxSbmIn2.TextChanged += new System.EventHandler(this.boxSbmIn2_TextChanged);
            // 
            // boxSbmIn1
            // 
            this.boxSbmIn1.Location = new System.Drawing.Point(103, 43);
            this.boxSbmIn1.Name = "boxSbmIn1";
            this.boxSbmIn1.Size = new System.Drawing.Size(91, 22);
            this.boxSbmIn1.TabIndex = 2;
            this.boxSbmIn1.TextChanged += new System.EventHandler(this.boxSbmIn1_TextChanged);
            // 
            // btnSbmSubmit
            // 
            this.btnSbmSubmit.Location = new System.Drawing.Point(403, 42);
            this.btnSbmSubmit.Name = "btnSbmSubmit";
            this.btnSbmSubmit.Size = new System.Drawing.Size(117, 52);
            this.btnSbmSubmit.TabIndex = 0;
            this.btnSbmSubmit.Text = "Submit";
            this.btnSbmSubmit.UseVisualStyleBackColor = true;
            this.btnSbmSubmit.Click += new System.EventHandler(this.btnSbmSubmit_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.boxEditLId);
            this.pnlEdit.Controls.Add(this.lblEditOutput);
            this.pnlEdit.Controls.Add(this.lblEditInput2);
            this.pnlEdit.Controls.Add(this.lblEditInput1);
            this.pnlEdit.Controls.Add(this.lblEditLId);
            this.pnlEdit.Controls.Add(this.boxEditOutput);
            this.pnlEdit.Controls.Add(this.boxEditInput2);
            this.pnlEdit.Controls.Add(this.boxEditInput1);
            this.pnlEdit.Controls.Add(this.lblSelectId);
            this.pnlEdit.Controls.Add(this.boxGetFromId);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Location = new System.Drawing.Point(308, 11);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(535, 110);
            this.pnlEdit.TabIndex = 16;
            this.pnlEdit.TabStop = false;
            this.pnlEdit.Text = "Edit row in table";
            this.pnlEdit.Visible = false;
            // 
            // boxEditLId
            // 
            this.boxEditLId.Location = new System.Drawing.Point(6, 78);
            this.boxEditLId.Name = "boxEditLId";
            this.boxEditLId.Size = new System.Drawing.Size(91, 22);
            this.boxEditLId.TabIndex = 18;
            this.boxEditLId.TextChanged += new System.EventHandler(this.boxEditLId_TextChanged);
            // 
            // lblEditOutput
            // 
            this.lblEditOutput.AutoSize = true;
            this.lblEditOutput.Location = new System.Drawing.Point(294, 58);
            this.lblEditOutput.Name = "lblEditOutput";
            this.lblEditOutput.Size = new System.Drawing.Size(51, 17);
            this.lblEditOutput.TabIndex = 17;
            this.lblEditOutput.Text = "Output";
            // 
            // lblEditInput2
            // 
            this.lblEditInput2.AutoSize = true;
            this.lblEditInput2.Location = new System.Drawing.Point(197, 58);
            this.lblEditInput2.Name = "lblEditInput2";
            this.lblEditInput2.Size = new System.Drawing.Size(47, 17);
            this.lblEditInput2.TabIndex = 16;
            this.lblEditInput2.Text = "Input2";
            // 
            // lblEditInput1
            // 
            this.lblEditInput1.AutoSize = true;
            this.lblEditInput1.Location = new System.Drawing.Point(100, 58);
            this.lblEditInput1.Name = "lblEditInput1";
            this.lblEditInput1.Size = new System.Drawing.Size(47, 17);
            this.lblEditInput1.TabIndex = 15;
            this.lblEditInput1.Text = "Input1";
            // 
            // lblEditLId
            // 
            this.lblEditLId.AutoSize = true;
            this.lblEditLId.Location = new System.Drawing.Point(6, 58);
            this.lblEditLId.Name = "lblEditLId";
            this.lblEditLId.Size = new System.Drawing.Size(45, 17);
            this.lblEditLId.TabIndex = 14;
            this.lblEditLId.Text = "ListId:";
            // 
            // boxEditOutput
            // 
            this.boxEditOutput.Location = new System.Drawing.Point(297, 78);
            this.boxEditOutput.Name = "boxEditOutput";
            this.boxEditOutput.Size = new System.Drawing.Size(77, 22);
            this.boxEditOutput.TabIndex = 13;
            this.boxEditOutput.TextChanged += new System.EventHandler(this.boxEditOutput_TextChanged);
            // 
            // boxEditInput2
            // 
            this.boxEditInput2.Location = new System.Drawing.Point(200, 78);
            this.boxEditInput2.Name = "boxEditInput2";
            this.boxEditInput2.Size = new System.Drawing.Size(91, 22);
            this.boxEditInput2.TabIndex = 12;
            this.boxEditInput2.TextChanged += new System.EventHandler(this.boxEditInput2_TextChanged);
            // 
            // boxEditInput1
            // 
            this.boxEditInput1.Location = new System.Drawing.Point(103, 78);
            this.boxEditInput1.Name = "boxEditInput1";
            this.boxEditInput1.Size = new System.Drawing.Size(91, 22);
            this.boxEditInput1.TabIndex = 11;
            this.boxEditInput1.TextChanged += new System.EventHandler(this.boxEditInput1_TextChanged);
            // 
            // lblSelectId
            // 
            this.lblSelectId.AutoSize = true;
            this.lblSelectId.Location = new System.Drawing.Point(83, 23);
            this.lblSelectId.Name = "lblSelectId";
            this.lblSelectId.Size = new System.Drawing.Size(68, 17);
            this.lblSelectId.TabIndex = 9;
            this.lblSelectId.Text = "Select ID:";
            // 
            // boxGetFromId
            // 
            this.boxGetFromId.Location = new System.Drawing.Point(157, 21);
            this.boxGetFromId.Name = "boxGetFromId";
            this.boxGetFromId.Size = new System.Drawing.Size(48, 22);
            this.boxGetFromId.TabIndex = 4;
            this.boxGetFromId.TextChanged += new System.EventHandler(this.boxGetFromId_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(403, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 52);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit and save";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.lblSelctId);
            this.pnlDelete.Controls.Add(this.boxSlctId);
            this.pnlDelete.Controls.Add(this.btnDelete);
            this.pnlDelete.Location = new System.Drawing.Point(754, 28);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(535, 110);
            this.pnlDelete.TabIndex = 15;
            this.pnlDelete.TabStop = false;
            this.pnlDelete.Text = "Delete row from table";
            this.pnlDelete.Visible = false;
            // 
            // lblSelctId
            // 
            this.lblSelctId.AutoSize = true;
            this.lblSelctId.Location = new System.Drawing.Point(25, 25);
            this.lblSelctId.Name = "lblSelctId";
            this.lblSelctId.Size = new System.Drawing.Size(64, 17);
            this.lblSelctId.TabIndex = 9;
            this.lblSelctId.Text = "Select ID";
            // 
            // boxSlctId
            // 
            this.boxSlctId.Location = new System.Drawing.Point(16, 45);
            this.boxSlctId.Name = "boxSlctId";
            this.boxSlctId.Size = new System.Drawing.Size(81, 22);
            this.boxSlctId.TabIndex = 4;
            this.boxSlctId.TextChanged += new System.EventHandler(this.boxSlctId_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(403, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 52);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlException);
            this.panel2.Controls.Add(this.pnlPortPier);
            this.panel2.Controls.Add(this.pnlLinecode);
            this.panel2.Location = new System.Drawing.Point(16, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 170);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlException
            // 
            this.pnlException.Controls.Add(this.lblExcptn);
            this.pnlException.Controls.Add(this.chkExcptn);
            this.pnlException.Location = new System.Drawing.Point(3, 138);
            this.pnlException.Name = "pnlException";
            this.pnlException.Size = new System.Drawing.Size(201, 29);
            this.pnlException.TabIndex = 16;
            this.pnlException.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlException_Paint);
            // 
            // lblExcptn
            // 
            this.lblExcptn.AutoSize = true;
            this.lblExcptn.Location = new System.Drawing.Point(6, 6);
            this.lblExcptn.Name = "lblExcptn";
            this.lblExcptn.Size = new System.Drawing.Size(116, 17);
            this.lblExcptn.TabIndex = 15;
            this.lblExcptn.Text = "Throw Exception:";
            // 
            // chkExcptn
            // 
            this.chkExcptn.AutoSize = true;
            this.chkExcptn.Location = new System.Drawing.Point(153, 6);
            this.chkExcptn.Name = "chkExcptn";
            this.chkExcptn.Size = new System.Drawing.Size(18, 17);
            this.chkExcptn.TabIndex = 14;
            this.chkExcptn.UseVisualStyleBackColor = true;
            this.chkExcptn.CheckedChanged += new System.EventHandler(this.chkExcptn_CheckedChanged);
            // 
            // pnlPortPier
            // 
            this.pnlPortPier.Controls.Add(this.txtPier);
            this.pnlPortPier.Controls.Add(this.lblPier);
            this.pnlPortPier.Controls.Add(this.lblPortPierHelp);
            this.pnlPortPier.Controls.Add(this.lblListId_Ex);
            this.pnlPortPier.Controls.Add(this.txtPort);
            this.pnlPortPier.Controls.Add(this.txtListId_Ex);
            this.pnlPortPier.Controls.Add(this.lblPort);
            this.pnlPortPier.Location = new System.Drawing.Point(210, 6);
            this.pnlPortPier.Name = "pnlPortPier";
            this.pnlPortPier.Size = new System.Drawing.Size(201, 126);
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
            // lblPier
            // 
            this.lblPier.AutoSize = true;
            this.lblPier.Location = new System.Drawing.Point(4, 88);
            this.lblPier.Name = "lblPier";
            this.lblPier.Size = new System.Drawing.Size(37, 17);
            this.lblPier.TabIndex = 10;
            this.lblPier.Text = "Pier:";
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
            // pnlLinecode
            // 
            this.pnlLinecode.Controls.Add(this.lblLinecodeHelp);
            this.pnlLinecode.Controls.Add(this.lblListId);
            this.pnlLinecode.Controls.Add(this.txtListId);
            this.pnlLinecode.Controls.Add(this.txtLinecode);
            this.pnlLinecode.Controls.Add(this.lblInput1);
            this.pnlLinecode.Location = new System.Drawing.Point(3, 3);
            this.pnlLinecode.Name = "pnlLinecode";
            this.pnlLinecode.Size = new System.Drawing.Size(201, 129);
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
            this.txtLinecode.Location = new System.Drawing.Point(108, 58);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Check Conversion";
            // 
            // lblSelectionHelp
            // 
            this.lblSelectionHelp.AutoSize = true;
            this.lblSelectionHelp.Location = new System.Drawing.Point(16, 27);
            this.lblSelectionHelp.Name = "lblSelectionHelp";
            this.lblSelectionHelp.Size = new System.Drawing.Size(155, 17);
            this.lblSelectionHelp.TabIndex = 10;
            this.lblSelectionHelp.Text = "Select conversion type:";
            // 
            // gBoxMain
            // 
            this.gBoxMain.Controls.Add(this.boxSlctType);
            this.gBoxMain.Controls.Add(this.panel2);
            this.gBoxMain.Controls.Add(this.btnSubmit);
            this.gBoxMain.Controls.Add(this.lblSelectionHelp);
            this.gBoxMain.Controls.Add(this.lblResult);
            this.gBoxMain.Controls.Add(this.label1);
            this.gBoxMain.Controls.Add(this.OutputBox);
            this.gBoxMain.Location = new System.Drawing.Point(190, 23);
            this.gBoxMain.Name = "gBoxMain";
            this.gBoxMain.Size = new System.Drawing.Size(535, 253);
            this.gBoxMain.TabIndex = 15;
            this.gBoxMain.TabStop = false;
            this.gBoxMain.Text = "Conversion selection";
            this.gBoxMain.Enter += new System.EventHandler(this.gBoxMain_Enter);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(372, 107);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result:";
            this.lblResult.Visible = false;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.FormattingEnabled = true;
            this.OutputBox.ItemHeight = 16;
            this.OutputBox.Location = new System.Drawing.Point(375, 127);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(145, 116);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.Visible = false;
            this.OutputBox.SelectedIndexChanged += new System.EventHandler(this.OutputBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.gBoxMain);
            this.Controls.Add(this.pnlSubmit);
            this.Controls.Add(this.btnGoTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRtrnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Conversion view";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.pnlSubmit.ResumeLayout(false);
            this.pnlSubmit.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlException.ResumeLayout(false);
            this.pnlException.PerformLayout();
            this.pnlPortPier.ResumeLayout(false);
            this.pnlPortPier.PerformLayout();
            this.pnlLinecode.ResumeLayout(false);
            this.pnlLinecode.PerformLayout();
            this.gBoxMain.ResumeLayout(false);
            this.gBoxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRtrnMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditRow;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox boxSlctType;
        private System.Windows.Forms.TextBox txtListId;
        private System.Windows.Forms.TextBox txtLinecode;
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
        private System.Windows.Forms.Label lblPier;
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
        private System.Windows.Forms.Label lblExcptn;
        private System.Windows.Forms.CheckBox chkExcptn;
        private System.Windows.Forms.Panel pnlException;
        private System.Windows.Forms.GroupBox gBoxMain;
        private System.Windows.Forms.GroupBox pnlDelete;
        private System.Windows.Forms.Label lblSelctId;
        private System.Windows.Forms.TextBox boxSlctId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox pnlEdit;
        private System.Windows.Forms.TextBox boxEditLId;
        private System.Windows.Forms.Label lblEditOutput;
        private System.Windows.Forms.Label lblEditInput2;
        private System.Windows.Forms.Label lblEditInput1;
        private System.Windows.Forms.Label lblEditLId;
        private System.Windows.Forms.TextBox boxEditOutput;
        private System.Windows.Forms.TextBox boxEditInput2;
        private System.Windows.Forms.TextBox boxEditInput1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGoTable;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox OutputBox;
        private System.Windows.Forms.Label lblSelectId;
        private System.Windows.Forms.TextBox boxGetFromId;
    }
}