namespace MachineInterfacing
{
    partial class frmSetting
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
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gbTimeInterval = new System.Windows.Forms.GroupBox();
            this.txtUpload = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtRefres = new System.Windows.Forms.TextBox();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.bgLogfile = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.lblLogfilePath = new System.Windows.Forms.Label();
            this.txtRetention = new System.Windows.Forms.TextBox();
            this.lblRetention = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbCreatFile = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbEmail.SuspendLayout();
            this.gbTimeInterval.SuspendLayout();
            this.bgLogfile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmail
            // 
            this.gbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEmail.Controls.Add(this.txtPassword);
            this.gbEmail.Controls.Add(this.txtUserName);
            this.gbEmail.Controls.Add(this.txtHost);
            this.gbEmail.Controls.Add(this.txtPort);
            this.gbEmail.Controls.Add(this.lblUserName);
            this.gbEmail.Controls.Add(this.lblPort);
            this.gbEmail.Controls.Add(this.lblHost);
            this.gbEmail.Controls.Add(this.lblPassword);
            this.gbEmail.Location = new System.Drawing.Point(12, 12);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(768, 52);
            this.gbEmail.TabIndex = 0;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "Email setting";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Location = new System.Drawing.Point(385, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(77, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserName.Location = new System.Drawing.Point(119, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(195, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtHost
            // 
            this.txtHost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHost.Location = new System.Drawing.Point(513, 19);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(113, 20);
            this.txtHost.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPort.Location = new System.Drawing.Point(681, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(39, 20);
            this.txtPort.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(48, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(69, 13);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name  :";
            // 
            // lblPort
            // 
            this.lblPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(632, 22);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(46, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "PORT : ";
            // 
            // lblHost
            // 
            this.lblHost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(471, 22);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(38, 13);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Host : ";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(320, 22);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password : ";
            // 
            // gbTimeInterval
            // 
            this.gbTimeInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTimeInterval.Controls.Add(this.txtUpload);
            this.gbTimeInterval.Controls.Add(this.txtSend);
            this.gbTimeInterval.Controls.Add(this.txtRefres);
            this.gbTimeInterval.Controls.Add(this.txtRead);
            this.gbTimeInterval.Controls.Add(this.lblSend);
            this.gbTimeInterval.Controls.Add(this.lblUpload);
            this.gbTimeInterval.Controls.Add(this.lblRead);
            this.gbTimeInterval.Controls.Add(this.lblRefresh);
            this.gbTimeInterval.Location = new System.Drawing.Point(12, 70);
            this.gbTimeInterval.Name = "gbTimeInterval";
            this.gbTimeInterval.Size = new System.Drawing.Size(768, 52);
            this.gbTimeInterval.TabIndex = 1;
            this.gbTimeInterval.TabStop = false;
            this.gbTimeInterval.Text = "Time Interval : ";
            // 
            // txtUpload
            // 
            this.txtUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUpload.Location = new System.Drawing.Point(452, 20);
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.Size = new System.Drawing.Size(75, 20);
            this.txtUpload.TabIndex = 2;
            // 
            // txtSend
            // 
            this.txtSend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSend.Location = new System.Drawing.Point(645, 21);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(75, 20);
            this.txtSend.TabIndex = 3;
            // 
            // txtRefres
            // 
            this.txtRefres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRefres.Location = new System.Drawing.Point(119, 20);
            this.txtRefres.Name = "txtRefres";
            this.txtRefres.Size = new System.Drawing.Size(75, 20);
            this.txtRefres.TabIndex = 0;
            // 
            // txtRead
            // 
            this.txtRead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRead.Location = new System.Drawing.Point(277, 20);
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(75, 20);
            this.txtRead.TabIndex = 1;
            // 
            // lblSend
            // 
            this.lblSend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(601, 25);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(41, 13);
            this.lblSend.TabIndex = 4;
            this.lblSend.Text = "Send : ";
            // 
            // lblUpload
            // 
            this.lblUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(400, 24);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(50, 13);
            this.lblUpload.TabIndex = 3;
            this.lblUpload.Text = "Upload : ";
            // 
            // lblRead
            // 
            this.lblRead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRead.AutoSize = true;
            this.lblRead.Location = new System.Drawing.Point(230, 24);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(45, 13);
            this.lblRead.TabIndex = 2;
            this.lblRead.Text = "Read  : ";
            // 
            // lblRefresh
            // 
            this.lblRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRefresh.AutoSize = true;
            this.lblRefresh.Location = new System.Drawing.Point(64, 24);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(53, 13);
            this.lblRefresh.TabIndex = 0;
            this.lblRefresh.Text = "Refresh : ";
            // 
            // bgLogfile
            // 
            this.bgLogfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bgLogfile.Controls.Add(this.btnBrowse);
            this.bgLogfile.Controls.Add(this.txtpath);
            this.bgLogfile.Controls.Add(this.lblLogfilePath);
            this.bgLogfile.Controls.Add(this.txtRetention);
            this.bgLogfile.Controls.Add(this.lblRetention);
            this.bgLogfile.Location = new System.Drawing.Point(12, 128);
            this.bgLogfile.Name = "bgLogfile";
            this.bgLogfile.Size = new System.Drawing.Size(768, 54);
            this.bgLogfile.TabIndex = 2;
            this.bgLogfile.TabStop = false;
            this.bgLogfile.Text = "Log File";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse.Location = new System.Drawing.Point(533, 18);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtpath
            // 
            this.txtpath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpath.Location = new System.Drawing.Point(119, 20);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(408, 20);
            this.txtpath.TabIndex = 0;
            // 
            // lblLogfilePath
            // 
            this.lblLogfilePath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogfilePath.AutoSize = true;
            this.lblLogfilePath.Location = new System.Drawing.Point(79, 23);
            this.lblLogfilePath.Name = "lblLogfilePath";
            this.lblLogfilePath.Size = new System.Drawing.Size(38, 13);
            this.lblLogfilePath.TabIndex = 10;
            this.lblLogfilePath.Text = "Path : ";
            // 
            // txtRetention
            // 
            this.txtRetention.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRetention.Location = new System.Drawing.Point(681, 20);
            this.txtRetention.Name = "txtRetention";
            this.txtRetention.Size = new System.Drawing.Size(39, 20);
            this.txtRetention.TabIndex = 2;
            // 
            // lblRetention
            // 
            this.lblRetention.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRetention.AutoSize = true;
            this.lblRetention.Location = new System.Drawing.Point(617, 23);
            this.lblRetention.Name = "lblRetention";
            this.lblRetention.Size = new System.Drawing.Size(62, 13);
            this.lblRetention.TabIndex = 1;
            this.lblRetention.Text = "Retention : ";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(579, 197);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(657, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chbCreatFile
            // 
            this.chbCreatFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbCreatFile.AutoSize = true;
            this.chbCreatFile.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbCreatFile.Checked = true;
            this.chbCreatFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCreatFile.Location = new System.Drawing.Point(48, 12);
            this.chbCreatFile.Name = "chbCreatFile";
            this.chbCreatFile.Size = new System.Drawing.Size(85, 17);
            this.chbCreatFile.TabIndex = 0;
            this.chbCreatFile.Text = "Create File : ";
            this.chbCreatFile.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chbCreatFile);
            this.panel1.Location = new System.Drawing.Point(11, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 0);
            this.panel1.TabIndex = 7;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 229);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.bgLogfile);
            this.Controls.Add(this.gbTimeInterval);
            this.Controls.Add(this.gbEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetting_FormClosing);
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.gbTimeInterval.ResumeLayout(false);
            this.gbTimeInterval.PerformLayout();
            this.bgLogfile.ResumeLayout(false);
            this.bgLogfile.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.GroupBox gbTimeInterval;
        private System.Windows.Forms.GroupBox bgLogfile;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRetention;
        private System.Windows.Forms.TextBox txtUpload;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtRefres;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.Label lblRetention;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Label lblLogfilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox chbCreatFile;
        private System.Windows.Forms.Panel panel1;
    }
}