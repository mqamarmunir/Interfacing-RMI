namespace MachineInterfacing
{
    partial class frmCommInterface
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
            this.components = new System.ComponentModel.Container();
            this.pnlToday = new System.Windows.Forms.Panel();
            this.dgTodaySummary = new System.Windows.Forms.DataGridView();
            this.Patient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTodayTestCount = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            //this.crvMonth = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            //this.crvWeek = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.llblRefresh = new System.Windows.Forms.LinkLabel();
            this.rtfTerminal = new System.Windows.Forms.RichTextBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.pbComm = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiCtrlPnl = new System.Windows.Forms.ToolStripMenuItem();
            this.miSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.miInstrument = new System.Windows.Forms.ToolStripMenuItem();
            this.miTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbtnRefresh = new System.Windows.Forms.LinkLabel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timerImmulite = new System.Windows.Forms.Timer(this.components);
            this.timer_getsetorders = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pnlToday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTodaySummary)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.msMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToday
            // 
            this.pnlToday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToday.Controls.Add(this.dgTodaySummary);
            this.pnlToday.Controls.Add(this.lblTodayTestCount);
            this.pnlToday.Controls.Add(this.lblMachineName);
            this.pnlToday.Controls.Add(this.lblToday);
            this.pnlToday.Location = new System.Drawing.Point(1, 128);
            this.pnlToday.Name = "pnlToday";
            this.pnlToday.Size = new System.Drawing.Size(395, 245);
            this.pnlToday.TabIndex = 1;
            // 
            // dgTodaySummary
            // 
            this.dgTodaySummary.AllowUserToAddRows = false;
            this.dgTodaySummary.AllowUserToDeleteRows = false;
            this.dgTodaySummary.AllowUserToOrderColumns = true;
            this.dgTodaySummary.AllowUserToResizeColumns = false;
            this.dgTodaySummary.AllowUserToResizeRows = false;
            this.dgTodaySummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTodaySummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTodaySummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTodaySummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patient_name,
            this.LabID,
            this.Test_Code,
            this.Test_Name,
            this.Result,
            this.ReceivedDate});
            this.dgTodaySummary.Location = new System.Drawing.Point(1, 44);
            this.dgTodaySummary.MultiSelect = false;
            this.dgTodaySummary.Name = "dgTodaySummary";
            this.dgTodaySummary.ReadOnly = true;
            this.dgTodaySummary.RowHeadersWidth = 20;
            this.dgTodaySummary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgTodaySummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTodaySummary.Size = new System.Drawing.Size(391, 198);
            this.dgTodaySummary.TabIndex = 3;
            // 
            // Patient_name
            // 
            this.Patient_name.DataPropertyName = "Patient_name";
            this.Patient_name.FillWeight = 30F;
            this.Patient_name.HeaderText = "Patient Name";
            this.Patient_name.Name = "Patient_name";
            this.Patient_name.ReadOnly = true;
            this.Patient_name.Visible = false;
            // 
            // LabID
            // 
            this.LabID.DataPropertyName = "LabID";
            this.LabID.FillWeight = 20F;
            this.LabID.HeaderText = "LabID";
            this.LabID.Name = "LabID";
            this.LabID.ReadOnly = true;
            // 
            // Test_Code
            // 
            this.Test_Code.DataPropertyName = "Test_Code";
            this.Test_Code.FillWeight = 15F;
            this.Test_Code.HeaderText = "Test Code";
            this.Test_Code.Name = "Test_Code";
            this.Test_Code.ReadOnly = true;
            // 
            // Test_Name
            // 
            this.Test_Name.DataPropertyName = "Test_Name";
            this.Test_Name.FillWeight = 30F;
            this.Test_Name.HeaderText = "Test Name";
            this.Test_Name.Name = "Test_Name";
            this.Test_Name.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.DataPropertyName = "result";
            this.Result.FillWeight = 10F;
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // ReceivedDate
            // 
            this.ReceivedDate.DataPropertyName = "ReceivedOn";
            this.ReceivedDate.FillWeight = 25F;
            this.ReceivedDate.HeaderText = "Received Date";
            this.ReceivedDate.Name = "ReceivedDate";
            this.ReceivedDate.ReadOnly = true;
            // 
            // lblTodayTestCount
            // 
            this.lblTodayTestCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTodayTestCount.AutoSize = true;
            this.lblTodayTestCount.Location = new System.Drawing.Point(290, 25);
            this.lblTodayTestCount.Name = "lblTodayTestCount";
            this.lblTodayTestCount.Size = new System.Drawing.Size(64, 13);
            this.lblTodayTestCount.TabIndex = 2;
            this.lblTodayTestCount.Text = "Total Test : ";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.Location = new System.Drawing.Point(3, 23);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(134, 17);
            this.lblMachineName.TabIndex = 1;
            this.lblMachineName.Tag = "no";
            this.lblMachineName.Text = "Machine Name  : ";
            // 
            // lblToday
            // 
            this.lblToday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.Location = new System.Drawing.Point(3, 3);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(68, 17);
            this.lblToday.TabIndex = 0;
            this.lblToday.Text = "Today : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button2);
            //this.panel1.Controls.Add(this.crvMonth);
            this.panel1.Location = new System.Drawing.Point(1, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 192);
            this.panel1.TabIndex = 1;
            // 
            // crvMonth
            // 
            //this.crvMonth.ActiveViewIndex = -1;
            //this.crvMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.crvMonth.Cursor = System.Windows.Forms.Cursors.Default;
            //this.crvMonth.DisplayBackgroundEdge = false;
            //this.crvMonth.DisplayStatusBar = false;
            //this.crvMonth.DisplayToolbar = false;
            //this.crvMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.crvMonth.EnableDrillDown = false;
            //this.crvMonth.Location = new System.Drawing.Point(0, 0);
            //this.crvMonth.Name = "crvMonth";
            //this.crvMonth.SelectionFormula = "";
            //this.crvMonth.Size = new System.Drawing.Size(395, 192);
            //this.crvMonth.TabIndex = 6;
            //this.crvMonth.ViewTimeSelectionFormula = "";
            //// 
            //// crvWeek
            //// 
            //this.crvWeek.ActiveViewIndex = -1;
            //this.crvWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.crvWeek.Cursor = System.Windows.Forms.Cursors.Default;
            //this.crvWeek.DisplayBackgroundEdge = false;
            //this.crvWeek.DisplayStatusBar = false;
            //this.crvWeek.DisplayToolbar = false;
            //this.crvWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.crvWeek.EnableDrillDown = false;
            //this.crvWeek.Location = new System.Drawing.Point(0, 0);
            //this.crvWeek.Name = "crvWeek";
            //this.crvWeek.SelectionFormula = "";
            //this.crvWeek.ShowCloseButton = false;
            //this.crvWeek.ShowExportButton = false;
            //this.crvWeek.ShowGotoPageButton = false;
            //this.crvWeek.ShowGroupTreeButton = false;
            //this.crvWeek.ShowPageNavigateButtons = false;
            //this.crvWeek.ShowPrintButton = false;
            //this.crvWeek.ShowRefreshButton = false;
            //this.crvWeek.ShowTextSearchButton = false;
            //this.crvWeek.ShowZoomButton = false;
            //this.crvWeek.Size = new System.Drawing.Size(395, 192);
            //this.crvWeek.TabIndex = 5;
            //this.crvWeek.ViewTimeSelectionFormula = "";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            //this.panel2.Controls.Add(this.crvWeek);
            this.panel2.Location = new System.Drawing.Point(397, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 192);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.llblRefresh);
            this.panel3.Controls.Add(this.rtfTerminal);
            this.panel3.Controls.Add(this.btnStatus);
            this.panel3.Controls.Add(this.pbComm);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Location = new System.Drawing.Point(397, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 245);
            this.panel3.TabIndex = 2;
            // 
            // llblRefresh
            // 
            this.llblRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblRefresh.AutoSize = true;
            this.llblRefresh.Location = new System.Drawing.Point(304, 5);
            this.llblRefresh.Name = "llblRefresh";
            this.llblRefresh.Size = new System.Drawing.Size(44, 13);
            this.llblRefresh.TabIndex = 6;
            this.llblRefresh.TabStop = true;
            this.llblRefresh.Text = "Refresh";
            this.llblRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtnRefresh_LinkClicked);
            // 
            // rtfTerminal
            // 
            this.rtfTerminal.Location = new System.Drawing.Point(1, 44);
            this.rtfTerminal.Name = "rtfTerminal";
            this.rtfTerminal.Size = new System.Drawing.Size(391, 198);
            this.rtfTerminal.TabIndex = 5;
            this.rtfTerminal.Text = "";
            this.rtfTerminal.TextChanged += new System.EventHandler(this.rtfTerminal_TextChanged);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.Red;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(128, 0);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(137, 23);
            this.btnStatus.TabIndex = 4;
            this.btnStatus.Tag = "no";
            this.btnStatus.Text = "Disconnect";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // pbComm
            // 
            this.pbComm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbComm.Enabled = false;
            this.pbComm.Location = new System.Drawing.Point(1, 23);
            this.pbComm.MarqueeAnimationSpeed = 50;
            this.pbComm.Name = "pbComm";
            this.pbComm.Size = new System.Drawing.Size(391, 21);
            this.pbComm.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbComm.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status : ";
            // 
            // Port
            // 
            this.Port.DtrEnable = true;
            this.Port.RtsEnable = true;
            this.Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Port_DataReceived);
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.Transparent;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCtrlPnl});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(792, 24);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiCtrlPnl
            // 
            this.tsmiCtrlPnl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSupplier,
            this.miInstrument,
            this.miTest,
            this.miSetting});
            this.tsmiCtrlPnl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tsmiCtrlPnl.Name = "tsmiCtrlPnl";
            this.tsmiCtrlPnl.Size = new System.Drawing.Size(102, 20);
            this.tsmiCtrlPnl.Text = "Control Panel";
            // 
            // miSupplier
            // 
            this.miSupplier.Name = "miSupplier";
            this.miSupplier.Size = new System.Drawing.Size(144, 22);
            this.miSupplier.Text = "Supplier";
            this.miSupplier.Click += new System.EventHandler(this.miSupplier_Click);
            // 
            // miInstrument
            // 
            this.miInstrument.Name = "miInstrument";
            this.miInstrument.Size = new System.Drawing.Size(144, 22);
            this.miInstrument.Text = "Instrument";
            this.miInstrument.Click += new System.EventHandler(this.miInstrument_Click);
            // 
            // miTest
            // 
            this.miTest.Name = "miTest";
            this.miTest.Size = new System.Drawing.Size(144, 22);
            this.miTest.Text = "Test";
            this.miTest.Click += new System.EventHandler(this.miTest_Click);
            // 
            // miSetting
            // 
            this.miSetting.Name = "miSetting";
            this.miSetting.Size = new System.Drawing.Size(144, 22);
            this.miSetting.Text = "Setting";
            this.miSetting.Click += new System.EventHandler(this.miSetting_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbtnRefresh
            // 
            this.lbtnRefresh.AutoSize = true;
            this.lbtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtnRefresh.LinkColor = System.Drawing.Color.White;
            this.lbtnRefresh.Location = new System.Drawing.Point(731, 110);
            this.lbtnRefresh.Name = "lbtnRefresh";
            this.lbtnRefresh.Size = new System.Drawing.Size(51, 13);
            this.lbtnRefresh.TabIndex = 0;
            this.lbtnRefresh.TabStop = true;
            this.lbtnRefresh.Text = "Refresh";
            this.lbtnRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtnRefresh_LinkClicked);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnlHeader.BackgroundImage = global::MachineInterfacing.Properties.Resources.Header8;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.lbtnRefresh);
            this.pnlHeader.Location = new System.Drawing.Point(1, 23);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(791, 104);
            this.pnlHeader.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerImmulite
            // 
            this.timerImmulite.Interval = 100000000;
            this.timerImmulite.Tick += new System.EventHandler(this.timerImmulite_Tick);
            // 
            // timer_getsetorders
            // 
            this.timer_getsetorders.Enabled = true;
            this.timer_getsetorders.Interval = 300000;
            this.timer_getsetorders.Tick += new System.EventHandler(this.timer_getsetorders_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Send pending Orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCommInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlToday);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "frmCommInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communication Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCommInterface_FormClosing);
            this.Load += new System.EventHandler(this.frmCommInterface_Load);
            this.pnlToday.ResumeLayout(false);
            this.pnlToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTodaySummary)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlToday;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.DataGridView dgTodaySummary;
        private System.Windows.Forms.Label lblTodayTestCount;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStatus;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crvWeek;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMonth;
        private System.Windows.Forms.ProgressBar pbComm;
        private System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.RichTextBox rtfTerminal;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiCtrlPnl;
        private System.Windows.Forms.ToolStripMenuItem miSupplier;
        private System.Windows.Forms.ToolStripMenuItem miInstrument;
        private System.Windows.Forms.ToolStripMenuItem miTest;
        private System.Windows.Forms.ToolStripMenuItem miSetting;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel lbtnRefresh;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedDate;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Timer timerImmulite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel llblRefresh;
        private System.Windows.Forms.Timer timer_getsetorders;
        private System.Windows.Forms.Button button2;
    }
}