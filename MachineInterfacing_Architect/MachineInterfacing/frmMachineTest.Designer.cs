namespace MachineInterfacing
{
    partial class frmMachineTest
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
            this.lblInstrument = new System.Windows.Forms.Label();
            this.cmbInstrument = new System.Windows.Forms.ComboBox();
            this.lblMachineTestID = new System.Windows.Forms.Label();
            this.dgTest = new System.Windows.Forms.DataGridView();
            this.Instrumentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lims_testid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine_testid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrument_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine_Test_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineTestCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lims_test_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOINC_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Attribute = new System.Windows.Forms.DataGridViewLinkColumn();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.lblMachineTestName = new System.Windows.Forms.Label();
            this.txtLonicCode = new System.Windows.Forms.TextBox();
            this.lblLonicCode = new System.Windows.Forms.Label();
            this.lblLimsTest = new System.Windows.Forms.Label();
            this.txtMachineTestCode = new System.Windows.Forms.TextBox();
            this.lblMchineTestCode = new System.Windows.Forms.Label();
            this.txtMachineTestName = new System.Windows.Forms.TextBox();
            this.cmbLimsTest = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstrument
            // 
            this.lblInstrument.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInstrument.AutoSize = true;
            this.lblInstrument.Location = new System.Drawing.Point(81, 18);
            this.lblInstrument.Name = "lblInstrument";
            this.lblInstrument.Size = new System.Drawing.Size(65, 13);
            this.lblInstrument.TabIndex = 122;
            this.lblInstrument.Text = "Instrument : ";
            // 
            // cmbInstrument
            // 
            this.cmbInstrument.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbInstrument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbInstrument.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInstrument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstrument.FormattingEnabled = true;
            this.cmbInstrument.Location = new System.Drawing.Point(149, 14);
            this.cmbInstrument.Name = "cmbInstrument";
            this.cmbInstrument.Size = new System.Drawing.Size(202, 21);
            this.cmbInstrument.TabIndex = 82;
            // 
            // lblMachineTestID
            // 
            this.lblMachineTestID.AutoSize = true;
            this.lblMachineTestID.Location = new System.Drawing.Point(172, 43);
            this.lblMachineTestID.Name = "lblMachineTestID";
            this.lblMachineTestID.Size = new System.Drawing.Size(0, 13);
            this.lblMachineTestID.TabIndex = 121;
            this.lblMachineTestID.Visible = false;
            // 
            // dgTest
            // 
            this.dgTest.AllowUserToAddRows = false;
            this.dgTest.AllowUserToDeleteRows = false;
            this.dgTest.AllowUserToOrderColumns = true;
            this.dgTest.AllowUserToResizeColumns = false;
            this.dgTest.AllowUserToResizeRows = false;
            this.dgTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Instrumentid,
            this.Lims_testid,
            this.Machine_testid,
            this.Instrument_Name,
            this.Machine_Test_name,
            this.MachineTestCode,
            this.Lims_test_name,
            this.Dept,
            this.LOINC_code,
            this.Active,
            this.Attribute});
            this.dgTest.Location = new System.Drawing.Point(12, 184);
            this.dgTest.MultiSelect = false;
            this.dgTest.Name = "dgTest";
            this.dgTest.ReadOnly = true;
            this.dgTest.RowHeadersWidth = 20;
            this.dgTest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTest.Size = new System.Drawing.Size(768, 370);
            this.dgTest.TabIndex = 120;
            this.dgTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTest_CellClick);
            this.dgTest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTest_CellDoubleClick);
            // 
            // Instrumentid
            // 
            this.Instrumentid.DataPropertyName = "Instrumentid";
            this.Instrumentid.HeaderText = "Instrumentid";
            this.Instrumentid.Name = "Instrumentid";
            this.Instrumentid.ReadOnly = true;
            this.Instrumentid.Visible = false;
            // 
            // Lims_testid
            // 
            this.Lims_testid.DataPropertyName = "Lims_testid";
            this.Lims_testid.HeaderText = "Lims_testid";
            this.Lims_testid.Name = "Lims_testid";
            this.Lims_testid.ReadOnly = true;
            this.Lims_testid.Visible = false;
            // 
            // Machine_testid
            // 
            this.Machine_testid.DataPropertyName = "Machine_testid";
            this.Machine_testid.FillWeight = 10F;
            this.Machine_testid.HeaderText = "Machine_testid";
            this.Machine_testid.Name = "Machine_testid";
            this.Machine_testid.ReadOnly = true;
            this.Machine_testid.Visible = false;
            // 
            // Instrument_Name
            // 
            this.Instrument_Name.DataPropertyName = "Instrument_Name";
            this.Instrument_Name.FillWeight = 22F;
            this.Instrument_Name.HeaderText = "Instrument Name";
            this.Instrument_Name.Name = "Instrument_Name";
            this.Instrument_Name.ReadOnly = true;
            // 
            // Machine_Test_name
            // 
            this.Machine_Test_name.DataPropertyName = "Machine_Test_name";
            this.Machine_Test_name.FillWeight = 22F;
            this.Machine_Test_name.HeaderText = "Machine Test name";
            this.Machine_Test_name.Name = "Machine_Test_name";
            this.Machine_Test_name.ReadOnly = true;
            // 
            // MachineTestCode
            // 
            this.MachineTestCode.DataPropertyName = "MachineTestCode";
            this.MachineTestCode.FillWeight = 10F;
            this.MachineTestCode.HeaderText = "Test Code";
            this.MachineTestCode.Name = "MachineTestCode";
            this.MachineTestCode.ReadOnly = true;
            // 
            // Lims_test_name
            // 
            this.Lims_test_name.DataPropertyName = "Lims_test_name";
            this.Lims_test_name.FillWeight = 22F;
            this.Lims_test_name.HeaderText = "Lims Test name";
            this.Lims_test_name.Name = "Lims_test_name";
            this.Lims_test_name.ReadOnly = true;
            // 
            // Dept
            // 
            this.Dept.DataPropertyName = "DeptID";
            this.Dept.HeaderText = "Dept";
            this.Dept.Name = "Dept";
            this.Dept.ReadOnly = true;
            this.Dept.Visible = false;
            // 
            // LOINC_code
            // 
            this.LOINC_code.DataPropertyName = "LOINC_code";
            this.LOINC_code.FillWeight = 9F;
            this.LOINC_code.HeaderText = "LOINC code";
            this.LOINC_code.Name = "LOINC_code";
            this.LOINC_code.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.FalseValue = "N";
            this.Active.FillWeight = 5F;
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.TrueValue = "Y";
            // 
            // Attribute
            // 
            this.Attribute.DataPropertyName = "Attribute";
            this.Attribute.FillWeight = 9F;
            this.Attribute.HeaderText = "Attribute";
            this.Attribute.Name = "Attribute";
            this.Attribute.ReadOnly = true;
            this.Attribute.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Attribute.Text = "Add Attribute";
            // 
            // chbActive
            // 
            this.chbActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbActive.AutoSize = true;
            this.chbActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbActive.Checked = true;
            this.chbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbActive.Location = new System.Drawing.Point(286, 42);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(65, 17);
            this.chbActive.TabIndex = 84;
            this.chbActive.Text = "Active : ";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // lblMachineTestName
            // 
            this.lblMachineTestName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMachineTestName.AutoSize = true;
            this.lblMachineTestName.Location = new System.Drawing.Point(381, 18);
            this.lblMachineTestName.Name = "lblMachineTestName";
            this.lblMachineTestName.Size = new System.Drawing.Size(112, 13);
            this.lblMachineTestName.TabIndex = 115;
            this.lblMachineTestName.Text = "Machine Test Name : ";
            // 
            // txtLonicCode
            // 
            this.txtLonicCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLonicCode.Location = new System.Drawing.Point(496, 40);
            this.txtLonicCode.Name = "txtLonicCode";
            this.txtLonicCode.Size = new System.Drawing.Size(234, 20);
            this.txtLonicCode.TabIndex = 89;
            // 
            // lblLonicCode
            // 
            this.lblLonicCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLonicCode.AutoSize = true;
            this.lblLonicCode.Location = new System.Drawing.Point(423, 44);
            this.lblLonicCode.Name = "lblLonicCode";
            this.lblLonicCode.Size = new System.Drawing.Size(70, 13);
            this.lblLonicCode.TabIndex = 113;
            this.lblLonicCode.Text = "Lonic Code : ";
            // 
            // lblLimsTest
            // 
            this.lblLimsTest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLimsTest.AutoSize = true;
            this.lblLimsTest.Location = new System.Drawing.Point(428, 70);
            this.lblLimsTest.Name = "lblLimsTest";
            this.lblLimsTest.Size = new System.Drawing.Size(65, 13);
            this.lblLimsTest.TabIndex = 112;
            this.lblLimsTest.Text = "LIMS Test : ";
            // 
            // txtMachineTestCode
            // 
            this.txtMachineTestCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMachineTestCode.Location = new System.Drawing.Point(150, 40);
            this.txtMachineTestCode.Name = "txtMachineTestCode";
            this.txtMachineTestCode.Size = new System.Drawing.Size(131, 20);
            this.txtMachineTestCode.TabIndex = 83;
            // 
            // lblMchineTestCode
            // 
            this.lblMchineTestCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMchineTestCode.AutoSize = true;
            this.lblMchineTestCode.Location = new System.Drawing.Point(37, 44);
            this.lblMchineTestCode.Name = "lblMchineTestCode";
            this.lblMchineTestCode.Size = new System.Drawing.Size(109, 13);
            this.lblMchineTestCode.TabIndex = 108;
            this.lblMchineTestCode.Text = "Machine Test Code : ";
            // 
            // txtMachineTestName
            // 
            this.txtMachineTestName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMachineTestName.Location = new System.Drawing.Point(496, 14);
            this.txtMachineTestName.Name = "txtMachineTestName";
            this.txtMachineTestName.Size = new System.Drawing.Size(234, 20);
            this.txtMachineTestName.TabIndex = 92;
            // 
            // cmbLimsTest
            // 
            this.cmbLimsTest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLimsTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLimsTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLimsTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLimsTest.FormattingEnabled = true;
            this.cmbLimsTest.Location = new System.Drawing.Point(496, 66);
            this.cmbLimsTest.Name = "cmbLimsTest";
            this.cmbLimsTest.Size = new System.Drawing.Size(234, 21);
            this.cmbLimsTest.TabIndex = 124;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(149, 66);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(202, 21);
            this.cmbDepartment.TabIndex = 126;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lblDept
            // 
            this.lblDept.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(75, 70);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(71, 13);
            this.lblDept.TabIndex = 125;
            this.lblDept.Text = "Department : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MachineInterfacing.Properties.Resources.Test;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 76);
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Image = global::MachineInterfacing.Properties.Resources.Cancel35;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(665, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 54);
            this.btnClose.TabIndex = 104;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.Image = global::MachineInterfacing.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(600, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 54);
            this.btnRefresh.TabIndex = 102;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Image = global::MachineInterfacing.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(535, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 54);
            this.btnSave.TabIndex = 101;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.cmbDepartment);
            this.panel1.Controls.Add(this.lblMchineTestCode);
            this.panel1.Controls.Add(this.txtMachineTestCode);
            this.panel1.Controls.Add(this.cmbLimsTest);
            this.panel1.Controls.Add(this.lblLimsTest);
            this.panel1.Controls.Add(this.lblLonicCode);
            this.panel1.Controls.Add(this.lblInstrument);
            this.panel1.Controls.Add(this.txtLonicCode);
            this.panel1.Controls.Add(this.cmbInstrument);
            this.panel1.Controls.Add(this.lblMachineTestName);
            this.panel1.Controls.Add(this.txtMachineTestName);
            this.panel1.Controls.Add(this.chbActive);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 100);
            this.panel1.TabIndex = 127;
            // 
            // frmMachineTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMachineTestID);
            this.Controls.Add(this.dgTest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMachineTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMachineTest_FormClosing);
            this.Load += new System.EventHandler(this.frmMachineTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstrument;
        private System.Windows.Forms.ComboBox cmbInstrument;
        private System.Windows.Forms.Label lblMachineTestID;
        private System.Windows.Forms.DataGridView dgTest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.Label lblMachineTestName;
        private System.Windows.Forms.TextBox txtLonicCode;
        private System.Windows.Forms.Label lblLonicCode;
        private System.Windows.Forms.Label lblLimsTest;
        private System.Windows.Forms.TextBox txtMachineTestCode;
        private System.Windows.Forms.Label lblMchineTestCode;
        private System.Windows.Forms.TextBox txtMachineTestName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbLimsTest;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrumentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lims_testid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine_testid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrument_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine_Test_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineTestCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lims_test_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOINC_code;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewLinkColumn Attribute;
    }
}