namespace MachineInterfacing
{
    partial class frmAttribute
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
            this.cmbLimsAttribte = new System.Windows.Forms.ComboBox();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.txtMachineTestName = new System.Windows.Forms.TextBox();
            this.lblMachineTestName = new System.Windows.Forms.Label();
            this.txtLIMSTestName = new System.Windows.Forms.TextBox();
            this.lblLimsTest = new System.Windows.Forms.Label();
            this.txtMachineTestAttrib = new System.Windows.Forms.TextBox();
            this.lblMchineAttrib = new System.Windows.Forms.Label();
            this.lblMachineAttributeID = new System.Windows.Forms.Label();
            this.dgTestAttrib = new System.Windows.Forms.DataGridView();
            this.lblLimsAttribute = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMachineAttribCode = new System.Windows.Forms.Label();
            this.txtMachineAttribCode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblChannel = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.AttributeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIMSAttributeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIMSAttributeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineAttributeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineAttributeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestAttrib)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLimsAttribte
            // 
            this.cmbLimsAttribte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLimsAttribte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLimsAttribte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLimsAttribte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLimsAttribte.FormattingEnabled = true;
            this.cmbLimsAttribte.Location = new System.Drawing.Point(147, 39);
            this.cmbLimsAttribte.Name = "cmbLimsAttribte";
            this.cmbLimsAttribte.Size = new System.Drawing.Size(202, 21);
            this.cmbLimsAttribte.TabIndex = 145;
            // 
            // chbActive
            // 
            this.chbActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbActive.AutoSize = true;
            this.chbActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbActive.Checked = true;
            this.chbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbActive.Location = new System.Drawing.Point(663, 41);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(65, 17);
            this.chbActive.TabIndex = 129;
            this.chbActive.Text = "Active : ";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // txtMachineTestName
            // 
            this.txtMachineTestName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMachineTestName.Location = new System.Drawing.Point(494, 10);
            this.txtMachineTestName.Name = "txtMachineTestName";
            this.txtMachineTestName.ReadOnly = true;
            this.txtMachineTestName.Size = new System.Drawing.Size(234, 20);
            this.txtMachineTestName.TabIndex = 131;
            // 
            // lblMachineTestName
            // 
            this.lblMachineTestName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMachineTestName.AutoSize = true;
            this.lblMachineTestName.Location = new System.Drawing.Point(380, 14);
            this.lblMachineTestName.Name = "lblMachineTestName";
            this.lblMachineTestName.Size = new System.Drawing.Size(112, 13);
            this.lblMachineTestName.TabIndex = 138;
            this.lblMachineTestName.Text = "Machine Test Name : ";
            // 
            // txtLIMSTestName
            // 
            this.txtLIMSTestName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLIMSTestName.Location = new System.Drawing.Point(147, 10);
            this.txtLIMSTestName.Name = "txtLIMSTestName";
            this.txtLIMSTestName.ReadOnly = true;
            this.txtLIMSTestName.Size = new System.Drawing.Size(202, 20);
            this.txtLIMSTestName.TabIndex = 130;
            // 
            // lblLimsTest
            // 
            this.lblLimsTest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLimsTest.AutoSize = true;
            this.lblLimsTest.Location = new System.Drawing.Point(79, 14);
            this.lblLimsTest.Name = "lblLimsTest";
            this.lblLimsTest.Size = new System.Drawing.Size(65, 13);
            this.lblLimsTest.TabIndex = 136;
            this.lblLimsTest.Text = "LIMS Test : ";
            // 
            // txtMachineTestAttrib
            // 
            this.txtMachineTestAttrib.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMachineTestAttrib.Location = new System.Drawing.Point(494, 39);
            this.txtMachineTestAttrib.Name = "txtMachineTestAttrib";
            this.txtMachineTestAttrib.Size = new System.Drawing.Size(163, 20);
            this.txtMachineTestAttrib.TabIndex = 128;
            // 
            // lblMchineAttrib
            // 
            this.lblMchineAttrib.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMchineAttrib.AutoSize = true;
            this.lblMchineAttrib.Location = new System.Drawing.Point(369, 43);
            this.lblMchineAttrib.Name = "lblMchineAttrib";
            this.lblMchineAttrib.Size = new System.Drawing.Size(123, 13);
            this.lblMchineAttrib.TabIndex = 135;
            this.lblMchineAttrib.Text = "Machine Test Attribute : ";
            // 
            // lblMachineAttributeID
            // 
            this.lblMachineAttributeID.AutoSize = true;
            this.lblMachineAttributeID.Location = new System.Drawing.Point(310, 9);
            this.lblMachineAttributeID.Name = "lblMachineAttributeID";
            this.lblMachineAttributeID.Size = new System.Drawing.Size(0, 13);
            this.lblMachineAttributeID.TabIndex = 140;
            this.lblMachineAttributeID.Visible = false;
            // 
            // dgTestAttrib
            // 
            this.dgTestAttrib.AllowUserToAddRows = false;
            this.dgTestAttrib.AllowUserToDeleteRows = false;
            this.dgTestAttrib.AllowUserToOrderColumns = true;
            this.dgTestAttrib.AllowUserToResizeColumns = false;
            this.dgTestAttrib.AllowUserToResizeRows = false;
            this.dgTestAttrib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTestAttrib.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTestAttrib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgTestAttrib.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttributeID,
            this.LIMSAttributeID,
            this.LIMSAttributeName,
            this.MachineAttributeCode,
            this.MachineAttributeName,
            this.Active,
            this.channel});
            this.dgTestAttrib.Location = new System.Drawing.Point(14, 181);
            this.dgTestAttrib.MultiSelect = false;
            this.dgTestAttrib.Name = "dgTestAttrib";
            this.dgTestAttrib.ReadOnly = true;
            this.dgTestAttrib.RowHeadersWidth = 20;
            this.dgTestAttrib.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgTestAttrib.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTestAttrib.Size = new System.Drawing.Size(768, 375);
            this.dgTestAttrib.TabIndex = 139;
            this.dgTestAttrib.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTestAttrib_CellDoubleClick);
            // 
            // lblLimsAttribute
            // 
            this.lblLimsAttribute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLimsAttribute.AutoSize = true;
            this.lblLimsAttribute.Location = new System.Drawing.Point(41, 43);
            this.lblLimsAttribute.Name = "lblLimsAttribute";
            this.lblLimsAttribute.Size = new System.Drawing.Size(103, 13);
            this.lblLimsAttribute.TabIndex = 144;
            this.lblLimsAttribute.Text = "Lims Test Attribute : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(653, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 146;
            this.btnAdd.Tag = "-1";
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblChannel);
            this.panel1.Controls.Add(this.txtChannel);
            this.panel1.Controls.Add(this.lblMachineAttribCode);
            this.panel1.Controls.Add(this.txtMachineAttribCode);
            this.panel1.Controls.Add(this.txtMachineTestName);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblLimsAttribute);
            this.panel1.Controls.Add(this.cmbLimsAttribte);
            this.panel1.Controls.Add(this.lblMchineAttrib);
            this.panel1.Controls.Add(this.txtMachineTestAttrib);
            this.panel1.Controls.Add(this.lblLimsTest);
            this.panel1.Controls.Add(this.chbActive);
            this.panel1.Controls.Add(this.txtLIMSTestName);
            this.panel1.Controls.Add(this.lblMachineTestName);
            this.panel1.Location = new System.Drawing.Point(14, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 100);
            this.panel1.TabIndex = 147;
            // 
            // lblMachineAttribCode
            // 
            this.lblMachineAttribCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMachineAttribCode.AutoSize = true;
            this.lblMachineAttribCode.Location = new System.Drawing.Point(17, 72);
            this.lblMachineAttribCode.Name = "lblMachineAttribCode";
            this.lblMachineAttribCode.Size = new System.Drawing.Size(127, 13);
            this.lblMachineAttribCode.TabIndex = 148;
            this.lblMachineAttribCode.Text = "Machine Attribute Code : ";
            // 
            // txtMachineAttribCode
            // 
            this.txtMachineAttribCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMachineAttribCode.Location = new System.Drawing.Point(147, 69);
            this.txtMachineAttribCode.Name = "txtMachineAttribCode";
            this.txtMachineAttribCode.Size = new System.Drawing.Size(202, 20);
            this.txtMachineAttribCode.TabIndex = 147;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MachineInterfacing.Properties.Resources.Attrib;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 65);
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.Image = global::MachineInterfacing.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(617, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 54);
            this.btnRefresh.TabIndex = 148;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Image = global::MachineInterfacing.Properties.Resources.Cancel35;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(683, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 54);
            this.btnClose.TabIndex = 134;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Image = global::MachineInterfacing.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(551, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 54);
            this.btnSave.TabIndex = 132;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblChannel
            // 
            this.lblChannel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(437, 72);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(55, 13);
            this.lblChannel.TabIndex = 150;
            this.lblChannel.Text = "Channel : ";
            // 
            // txtChannel
            // 
            this.txtChannel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChannel.Location = new System.Drawing.Point(498, 69);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(102, 20);
            this.txtChannel.TabIndex = 149;
            // 
            // AttributeID
            // 
            this.AttributeID.DataPropertyName = "AttributeID";
            this.AttributeID.HeaderText = "AttributeID";
            this.AttributeID.Name = "AttributeID";
            this.AttributeID.ReadOnly = true;
            this.AttributeID.Visible = false;
            // 
            // LIMSAttributeID
            // 
            this.LIMSAttributeID.DataPropertyName = "LIMSAttributeID";
            this.LIMSAttributeID.HeaderText = "LIMS AttributeID";
            this.LIMSAttributeID.Name = "LIMSAttributeID";
            this.LIMSAttributeID.ReadOnly = true;
            this.LIMSAttributeID.Visible = false;
            // 
            // LIMSAttributeName
            // 
            this.LIMSAttributeName.DataPropertyName = "LIMSAttributeName";
            this.LIMSAttributeName.FillWeight = 40F;
            this.LIMSAttributeName.HeaderText = "LIMS Attribute Name";
            this.LIMSAttributeName.Name = "LIMSAttributeName";
            this.LIMSAttributeName.ReadOnly = true;
            // 
            // MachineAttributeCode
            // 
            this.MachineAttributeCode.DataPropertyName = "MachineAttributeCode";
            this.MachineAttributeCode.FillWeight = 12F;
            this.MachineAttributeCode.HeaderText = "Attribute Code";
            this.MachineAttributeCode.Name = "MachineAttributeCode";
            this.MachineAttributeCode.ReadOnly = true;
            // 
            // MachineAttributeName
            // 
            this.MachineAttributeName.DataPropertyName = "MachineAttributeName";
            this.MachineAttributeName.FillWeight = 40F;
            this.MachineAttributeName.HeaderText = "Machine Attribute Name";
            this.MachineAttributeName.Name = "MachineAttributeName";
            this.MachineAttributeName.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.FalseValue = "N";
            this.Active.FillWeight = 8F;
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.TrueValue = "Y";
            // 
            // channel
            // 
            this.channel.DataPropertyName = "channel";
            this.channel.HeaderText = "channel";
            this.channel.Name = "channel";
            this.channel.ReadOnly = true;
            this.channel.Visible = false;
            // 
            // frmAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMachineAttributeID);
            this.Controls.Add(this.dgTestAttrib);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAttribute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attribute";
            this.Load += new System.EventHandler(this.frmAttribute_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAttribute_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgTestAttrib)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLimsAttribte;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.TextBox txtMachineTestName;
        private System.Windows.Forms.Label lblMachineTestName;
        private System.Windows.Forms.TextBox txtLIMSTestName;
        private System.Windows.Forms.Label lblLimsTest;
        private System.Windows.Forms.TextBox txtMachineTestAttrib;
        private System.Windows.Forms.Label lblMchineAttrib;
        private System.Windows.Forms.Label lblMachineAttributeID;
        private System.Windows.Forms.DataGridView dgTestAttrib;
        private System.Windows.Forms.Label lblLimsAttribute;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMachineAttribCode;
        private System.Windows.Forms.TextBox txtMachineAttribCode;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttributeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIMSAttributeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIMSAttributeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineAttributeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineAttributeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel;
    }
}