namespace MachineInterfacing
{
    partial class frmInstruments
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
            this.lblInstrumentID = new System.Windows.Forms.Label();
            this.dgInstrument = new System.Windows.Forms.DataGridView();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.lblDataBit = new System.Windows.Forms.Label();
            this.lblAckCode = new System.Windows.Forms.Label();
            this.txtAckCode = new System.Windows.Forms.TextBox();
            this.lblFlowCtrl = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.lblComMethod = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtComStd = new System.Windows.Forms.TextBox();
            this.lblComStd = new System.Windows.Forms.Label();
            this.txtManual = new System.Windows.Forms.TextBox();
            this.lblManual = new System.Windows.Forms.Label();
            this.txtBarCodeStd = new System.Windows.Forms.TextBox();
            this.lblBarCodeStd = new System.Windows.Forms.Label();
            this.txtPFormat = new System.Windows.Forms.TextBox();
            this.lblPFormat = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtRelease = new System.Windows.Forms.TextBox();
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.chbBidirectional = new System.Windows.Forms.CheckBox();
            this.cmbFlowCtrl = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnManualBrowse = new System.Windows.Forms.Button();
            this.cmbCommMethod = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InstrumentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplierid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrument_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Release = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient_no_format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode_Standard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bidirectional = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Communication_Stnadard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Communication_method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaudRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stopbit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataBit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acknowledgement_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstrument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstrumentID
            // 
            this.lblInstrumentID.AutoSize = true;
            this.lblInstrumentID.Location = new System.Drawing.Point(175, 42);
            this.lblInstrumentID.Name = "lblInstrumentID";
            this.lblInstrumentID.Size = new System.Drawing.Size(0, 13);
            this.lblInstrumentID.TabIndex = 78;
            this.lblInstrumentID.Visible = false;
            // 
            // dgInstrument
            // 
            this.dgInstrument.AllowUserToAddRows = false;
            this.dgInstrument.AllowUserToDeleteRows = false;
            this.dgInstrument.AllowUserToOrderColumns = true;
            this.dgInstrument.AllowUserToResizeColumns = false;
            this.dgInstrument.AllowUserToResizeRows = false;
            this.dgInstrument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInstrument.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInstrument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgInstrument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstrumentID,
            this.Supplierid,
            this.Supplier_Name,
            this.Instrument_Name,
            this.Model,
            this.Release,
            this.Description,
            this.Manual,
            this.Patient_no_format,
            this.BarCode_Standard,
            this.Bidirectional,
            this.Communication_Stnadard,
            this.Communication_method,
            this.PORT,
            this.BaudRate,
            this.Parity,
            this.Stopbit,
            this.DataBit,
            this.FlowControl,
            this.Acknowledgement_code,
            this.Active});
            this.dgInstrument.Location = new System.Drawing.Point(12, 334);
            this.dgInstrument.MultiSelect = false;
            this.dgInstrument.Name = "dgInstrument";
            this.dgInstrument.ReadOnly = true;
            this.dgInstrument.RowHeadersWidth = 20;
            this.dgInstrument.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgInstrument.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInstrument.Size = new System.Drawing.Size(768, 220);
            this.dgInstrument.TabIndex = 76;
            this.dgInstrument.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInstrument_CellDoubleClick);
            // 
            // lblStopBit
            // 
            this.lblStopBit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStopBit.AutoSize = true;
            this.lblStopBit.Location = new System.Drawing.Point(582, 87);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(52, 13);
            this.lblStopBit.TabIndex = 20;
            this.lblStopBit.Text = "Stop bit : ";
            // 
            // lblDataBit
            // 
            this.lblDataBit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDataBit.AutoSize = true;
            this.lblDataBit.Location = new System.Drawing.Point(397, 87);
            this.lblDataBit.Name = "lblDataBit";
            this.lblDataBit.Size = new System.Drawing.Size(54, 13);
            this.lblDataBit.TabIndex = 22;
            this.lblDataBit.Text = "Data Bit : ";
            // 
            // lblAckCode
            // 
            this.lblAckCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAckCode.AutoSize = true;
            this.lblAckCode.Location = new System.Drawing.Point(228, 62);
            this.lblAckCode.Name = "lblAckCode";
            this.lblAckCode.Size = new System.Drawing.Size(63, 13);
            this.lblAckCode.TabIndex = 26;
            this.lblAckCode.Text = "Ack Code : ";
            // 
            // txtAckCode
            // 
            this.txtAckCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAckCode.Location = new System.Drawing.Point(288, 58);
            this.txtAckCode.Name = "txtAckCode";
            this.txtAckCode.Size = new System.Drawing.Size(87, 20);
            this.txtAckCode.TabIndex = 16;
            this.txtAckCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lblFlowCtrl
            // 
            this.lblFlowCtrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFlowCtrl.AutoSize = true;
            this.lblFlowCtrl.Location = new System.Drawing.Point(235, 112);
            this.lblFlowCtrl.Name = "lblFlowCtrl";
            this.lblFlowCtrl.Size = new System.Drawing.Size(56, 13);
            this.lblFlowCtrl.TabIndex = 24;
            this.lblFlowCtrl.Text = "Flow Ctrl : ";
            // 
            // lblPort
            // 
            this.lblPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(256, 87);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 13);
            this.lblPort.TabIndex = 73;
            this.lblPort.Text = "Port : ";
            // 
            // chbActive
            // 
            this.chbActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbActive.AutoSize = true;
            this.chbActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbActive.Checked = true;
            this.chbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbActive.Location = new System.Drawing.Point(662, 11);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(65, 17);
            this.chbActive.TabIndex = 2;
            this.chbActive.Text = "Active : ";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // lblComMethod
            // 
            this.lblComMethod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComMethod.AutoSize = true;
            this.lblComMethod.Location = new System.Drawing.Point(50, 87);
            this.lblComMethod.Name = "lblComMethod";
            this.lblComMethod.Size = new System.Drawing.Size(84, 13);
            this.lblComMethod.TabIndex = 72;
            this.lblComMethod.Text = "Comm Method : ";
            // 
            // txtModel
            // 
            this.txtModel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtModel.Location = new System.Drawing.Point(136, 33);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(87, 20);
            this.txtModel.TabIndex = 14;
            // 
            // lblModel
            // 
            this.lblModel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(89, 37);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 13);
            this.lblModel.TabIndex = 70;
            this.lblModel.Text = "Model : ";
            // 
            // txtComStd
            // 
            this.txtComStd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComStd.Location = new System.Drawing.Point(451, 33);
            this.txtComStd.Name = "txtComStd";
            this.txtComStd.Size = new System.Drawing.Size(167, 20);
            this.txtComStd.TabIndex = 10;
            // 
            // lblComStd
            // 
            this.lblComStd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComStd.AutoSize = true;
            this.lblComStd.Location = new System.Drawing.Point(387, 37);
            this.lblComStd.Name = "lblComStd";
            this.lblComStd.Size = new System.Drawing.Size(64, 13);
            this.lblComStd.TabIndex = 66;
            this.lblComStd.Text = "Comm Std : ";
            // 
            // txtManual
            // 
            this.txtManual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtManual.Location = new System.Drawing.Point(136, 133);
            this.txtManual.Name = "txtManual";
            this.txtManual.Size = new System.Drawing.Size(447, 20);
            this.txtManual.TabIndex = 17;
            // 
            // lblManual
            // 
            this.lblManual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManual.AutoSize = true;
            this.lblManual.Location = new System.Drawing.Point(83, 137);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(51, 13);
            this.lblManual.TabIndex = 63;
            this.lblManual.Text = "Manual : ";
            // 
            // txtBarCodeStd
            // 
            this.txtBarCodeStd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBarCodeStd.Location = new System.Drawing.Point(451, 58);
            this.txtBarCodeStd.Name = "txtBarCodeStd";
            this.txtBarCodeStd.Size = new System.Drawing.Size(167, 20);
            this.txtBarCodeStd.TabIndex = 7;
            // 
            // lblBarCodeStd
            // 
            this.lblBarCodeStd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBarCodeStd.AutoSize = true;
            this.lblBarCodeStd.Location = new System.Drawing.Point(376, 62);
            this.lblBarCodeStd.Name = "lblBarCodeStd";
            this.lblBarCodeStd.Size = new System.Drawing.Size(75, 13);
            this.lblBarCodeStd.TabIndex = 60;
            this.lblBarCodeStd.Text = "Barcode Std : ";
            // 
            // txtPFormat
            // 
            this.txtPFormat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPFormat.Location = new System.Drawing.Point(136, 58);
            this.txtPFormat.Name = "txtPFormat";
            this.txtPFormat.Size = new System.Drawing.Size(87, 20);
            this.txtPFormat.TabIndex = 3;
            // 
            // lblPFormat
            // 
            this.lblPFormat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPFormat.AutoSize = true;
            this.lblPFormat.Location = new System.Drawing.Point(40, 62);
            this.lblPFormat.Name = "lblPFormat";
            this.lblPFormat.Size = new System.Drawing.Size(94, 13);
            this.lblPFormat.TabIndex = 56;
            this.lblPFormat.Text = "Patient # Format : ";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(65, 162);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(69, 13);
            this.lblDescription.TabIndex = 53;
            this.lblDescription.Text = "Description : ";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(136, 159);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(591, 89);
            this.txtDescription.TabIndex = 18;
            // 
            // txtRelease
            // 
            this.txtRelease.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRelease.Location = new System.Drawing.Point(288, 33);
            this.txtRelease.Name = "txtRelease";
            this.txtRelease.Size = new System.Drawing.Size(87, 20);
            this.txtRelease.TabIndex = 15;
            // 
            // lblRelease
            // 
            this.lblRelease.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRelease.AutoSize = true;
            this.lblRelease.Location = new System.Drawing.Point(236, 37);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(55, 13);
            this.lblRelease.TabIndex = 50;
            this.lblRelease.Text = "Release : ";
            // 
            // lblParity
            // 
            this.lblParity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(92, 112);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(42, 13);
            this.lblParity.TabIndex = 48;
            this.lblParity.Text = "Parity : ";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(451, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(407, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Name : ";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(136, 8);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(239, 21);
            this.cmbSupplier.TabIndex = 0;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(80, 12);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(54, 13);
            this.lblSupplier.TabIndex = 80;
            this.lblSupplier.Text = "Supplier : ";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(384, 112);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(67, 13);
            this.lblBaudRate.TabIndex = 71;
            this.lblBaudRate.Text = "Baud Rate : ";
            // 
            // chbBidirectional
            // 
            this.chbBidirectional.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbBidirectional.AutoSize = true;
            this.chbBidirectional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbBidirectional.Checked = true;
            this.chbBidirectional.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBidirectional.Location = new System.Drawing.Point(635, 35);
            this.chbBidirectional.Name = "chbBidirectional";
            this.chbBidirectional.Size = new System.Drawing.Size(92, 17);
            this.chbBidirectional.TabIndex = 4;
            this.chbBidirectional.Text = "Bidirectional : ";
            this.chbBidirectional.UseVisualStyleBackColor = true;
            // 
            // cmbFlowCtrl
            // 
            this.cmbFlowCtrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbFlowCtrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFlowCtrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFlowCtrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlowCtrl.FormattingEnabled = true;
            this.cmbFlowCtrl.Location = new System.Drawing.Point(288, 108);
            this.cmbFlowCtrl.Name = "cmbFlowCtrl";
            this.cmbFlowCtrl.Size = new System.Drawing.Size(87, 21);
            this.cmbFlowCtrl.TabIndex = 12;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBaudRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBaudRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(451, 108);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(87, 21);
            this.cmbBaudRate.TabIndex = 6;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbStopBits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStopBits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Location = new System.Drawing.Point(640, 84);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(87, 21);
            this.cmbStopBits.TabIndex = 11;
            // 
            // cmbPortName
            // 
            this.cmbPortName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPortName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPortName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(288, 83);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(87, 21);
            this.cmbPortName.TabIndex = 5;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDataBits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDataBits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(451, 83);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(87, 21);
            this.cmbDataBits.TabIndex = 8;
            // 
            // cmbParity
            // 
            this.cmbParity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbParity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbParity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(137, 108);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(87, 21);
            this.cmbParity.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MachineInterfacing.Properties.Resources.Instrument;
            this.pictureBox1.Location = new System.Drawing.Point(-43, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 62);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Image = global::MachineInterfacing.Properties.Resources.Cancel35;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(664, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 54);
            this.btnClose.TabIndex = 21;
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
            this.btnRefresh.Location = new System.Drawing.Point(599, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 54);
            this.btnRefresh.TabIndex = 20;
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
            this.btnSave.Location = new System.Drawing.Point(534, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 54);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnManualBrowse
            // 
            this.btnManualBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManualBrowse.Location = new System.Drawing.Point(589, 133);
            this.btnManualBrowse.Name = "btnManualBrowse";
            this.btnManualBrowse.Size = new System.Drawing.Size(64, 20);
            this.btnManualBrowse.TabIndex = 82;
            this.btnManualBrowse.Text = "Add";
            this.btnManualBrowse.UseVisualStyleBackColor = true;
            this.btnManualBrowse.Click += new System.EventHandler(this.btnManualBrowse_Click);
            // 
            // cmbCommMethod
            // 
            this.cmbCommMethod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCommMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCommMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCommMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommMethod.FormattingEnabled = true;
            this.cmbCommMethod.Location = new System.Drawing.Point(137, 83);
            this.cmbCommMethod.Name = "cmbCommMethod";
            this.cmbCommMethod.Size = new System.Drawing.Size(87, 21);
            this.cmbCommMethod.TabIndex = 83;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpen.Location = new System.Drawing.Point(663, 133);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(64, 20);
            this.btnOpen.TabIndex = 84;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbSupplier);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.cmbCommMethod);
            this.panel1.Controls.Add(this.btnManualBrowse);
            this.panel1.Controls.Add(this.cmbParity);
            this.panel1.Controls.Add(this.cmbDataBits);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.cmbPortName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.cmbStopBits);
            this.panel1.Controls.Add(this.lblParity);
            this.panel1.Controls.Add(this.cmbBaudRate);
            this.panel1.Controls.Add(this.txtRelease);
            this.panel1.Controls.Add(this.cmbFlowCtrl);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.chbBidirectional);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblPFormat);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.txtPFormat);
            this.panel1.Controls.Add(this.lblBarCodeStd);
            this.panel1.Controls.Add(this.lblStopBit);
            this.panel1.Controls.Add(this.txtBarCodeStd);
            this.panel1.Controls.Add(this.lblManual);
            this.panel1.Controls.Add(this.lblDataBit);
            this.panel1.Controls.Add(this.txtManual);
            this.panel1.Controls.Add(this.lblComStd);
            this.panel1.Controls.Add(this.txtAckCode);
            this.panel1.Controls.Add(this.txtComStd);
            this.panel1.Controls.Add(this.lblModel);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.lblBaudRate);
            this.panel1.Controls.Add(this.chbActive);
            this.panel1.Controls.Add(this.lblComMethod);
            this.panel1.Controls.Add(this.lblRelease);
            this.panel1.Controls.Add(this.lblFlowCtrl);
            this.panel1.Controls.Add(this.lblPort);
            this.panel1.Controls.Add(this.lblAckCode);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 256);
            this.panel1.TabIndex = 85;
            // 
            // InstrumentID
            // 
            this.InstrumentID.DataPropertyName = "InstrumentID";
            this.InstrumentID.HeaderText = "InstrumentID";
            this.InstrumentID.Name = "InstrumentID";
            this.InstrumentID.ReadOnly = true;
            this.InstrumentID.Visible = false;
            // 
            // Supplierid
            // 
            this.Supplierid.DataPropertyName = "Supplierid";
            this.Supplierid.HeaderText = "Supplierid";
            this.Supplierid.Name = "Supplierid";
            this.Supplierid.ReadOnly = true;
            this.Supplierid.Visible = false;
            // 
            // Supplier_Name
            // 
            this.Supplier_Name.DataPropertyName = "Supplier_Name";
            this.Supplier_Name.FillWeight = 20F;
            this.Supplier_Name.HeaderText = "Supplier Name";
            this.Supplier_Name.Name = "Supplier_Name";
            this.Supplier_Name.ReadOnly = true;
            // 
            // Instrument_Name
            // 
            this.Instrument_Name.DataPropertyName = "Instrument_Name";
            this.Instrument_Name.FillWeight = 20F;
            this.Instrument_Name.HeaderText = "Instrument Name";
            this.Instrument_Name.Name = "Instrument_Name";
            this.Instrument_Name.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Visible = false;
            // 
            // Release
            // 
            this.Release.DataPropertyName = "I_Release";
            this.Release.HeaderText = "Release";
            this.Release.Name = "Release";
            this.Release.ReadOnly = true;
            this.Release.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Visible = false;
            // 
            // Manual
            // 
            this.Manual.DataPropertyName = "Manual";
            this.Manual.HeaderText = "Manual";
            this.Manual.Name = "Manual";
            this.Manual.ReadOnly = true;
            this.Manual.Visible = false;
            // 
            // Patient_no_format
            // 
            this.Patient_no_format.DataPropertyName = "Patient_no_format";
            this.Patient_no_format.HeaderText = "Patient_no_format";
            this.Patient_no_format.Name = "Patient_no_format";
            this.Patient_no_format.ReadOnly = true;
            this.Patient_no_format.Visible = false;
            // 
            // BarCode_Standard
            // 
            this.BarCode_Standard.DataPropertyName = "BarCode_Standard";
            this.BarCode_Standard.HeaderText = "BarCode_Standard";
            this.BarCode_Standard.Name = "BarCode_Standard";
            this.BarCode_Standard.ReadOnly = true;
            this.BarCode_Standard.Visible = false;
            // 
            // Bidirectional
            // 
            this.Bidirectional.DataPropertyName = "Bidirectional";
            this.Bidirectional.FalseValue = "N";
            this.Bidirectional.FillWeight = 10F;
            this.Bidirectional.HeaderText = "Bidirectional";
            this.Bidirectional.Name = "Bidirectional";
            this.Bidirectional.ReadOnly = true;
            this.Bidirectional.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Bidirectional.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Bidirectional.TrueValue = "Y";
            // 
            // Communication_Stnadard
            // 
            this.Communication_Stnadard.DataPropertyName = "Communication_Stnadard";
            this.Communication_Stnadard.HeaderText = "Communication_Stnadard";
            this.Communication_Stnadard.Name = "Communication_Stnadard";
            this.Communication_Stnadard.ReadOnly = true;
            this.Communication_Stnadard.Visible = false;
            // 
            // Communication_method
            // 
            this.Communication_method.DataPropertyName = "Communication_method";
            this.Communication_method.HeaderText = "Communication_method";
            this.Communication_method.Name = "Communication_method";
            this.Communication_method.ReadOnly = true;
            this.Communication_method.Visible = false;
            // 
            // PORT
            // 
            this.PORT.DataPropertyName = "PORT";
            this.PORT.FillWeight = 6F;
            this.PORT.HeaderText = "PORT";
            this.PORT.Name = "PORT";
            this.PORT.ReadOnly = true;
            // 
            // BaudRate
            // 
            this.BaudRate.DataPropertyName = "BaudRate";
            this.BaudRate.FillWeight = 8F;
            this.BaudRate.HeaderText = "Baud Rate";
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.ReadOnly = true;
            // 
            // Parity
            // 
            this.Parity.DataPropertyName = "Parity";
            this.Parity.FillWeight = 6F;
            this.Parity.HeaderText = "Parity";
            this.Parity.Name = "Parity";
            this.Parity.ReadOnly = true;
            // 
            // Stopbit
            // 
            this.Stopbit.DataPropertyName = "Stopbit";
            this.Stopbit.FillWeight = 8F;
            this.Stopbit.HeaderText = "Stop Bit";
            this.Stopbit.Name = "Stopbit";
            this.Stopbit.ReadOnly = true;
            // 
            // DataBit
            // 
            this.DataBit.DataPropertyName = "DataBit";
            this.DataBit.FillWeight = 7F;
            this.DataBit.HeaderText = "Data Bit";
            this.DataBit.Name = "DataBit";
            this.DataBit.ReadOnly = true;
            // 
            // FlowControl
            // 
            this.FlowControl.DataPropertyName = "FlowControl";
            this.FlowControl.FillWeight = 10F;
            this.FlowControl.HeaderText = "Flow Control";
            this.FlowControl.Name = "FlowControl";
            this.FlowControl.ReadOnly = true;
            // 
            // Acknowledgement_code
            // 
            this.Acknowledgement_code.DataPropertyName = "Acknowledgement_code";
            this.Acknowledgement_code.HeaderText = "Acknowledgement_code";
            this.Acknowledgement_code.Name = "Acknowledgement_code";
            this.Acknowledgement_code.ReadOnly = true;
            this.Acknowledgement_code.Visible = false;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.FalseValue = "N";
            this.Active.FillWeight = 6F;
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.TrueValue = "Y";
            // 
            // frmInstruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInstrumentID);
            this.Controls.Add(this.dgInstrument);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmInstruments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instruments";
            this.Load += new System.EventHandler(this.frmInstruments_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInstruments_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstrument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstrumentID;
        private System.Windows.Forms.DataGridView dgInstrument;
        private System.Windows.Forms.Label lblStopBit;
        private System.Windows.Forms.Label lblDataBit;
        private System.Windows.Forms.Label lblAckCode;
        private System.Windows.Forms.TextBox txtAckCode;
        private System.Windows.Forms.Label lblFlowCtrl;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.Label lblComMethod;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtComStd;
        private System.Windows.Forms.Label lblComStd;
        private System.Windows.Forms.TextBox txtManual;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.TextBox txtBarCodeStd;
        private System.Windows.Forms.Label lblBarCodeStd;
        private System.Windows.Forms.TextBox txtPFormat;
        private System.Windows.Forms.Label lblPFormat;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRelease;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.CheckBox chbBidirectional;
        private System.Windows.Forms.ComboBox cmbFlowCtrl;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Button btnManualBrowse;
        private System.Windows.Forms.ComboBox cmbCommMethod;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstrumentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplierid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrument_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Release;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient_no_format;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode_Standard;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bidirectional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Communication_Stnadard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Communication_method;
        private System.Windows.Forms.DataGridViewTextBoxColumn PORT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaudRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stopbit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataBit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acknowledgement_code;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
    }
}