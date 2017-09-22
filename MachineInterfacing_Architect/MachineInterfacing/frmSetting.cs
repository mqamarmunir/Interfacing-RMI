using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MI_BL;

namespace MachineInterfacing
{
    public partial class frmSetting : Form
    {
        private frmCommInterface objCommInterface = new frmCommInterface();

        public frmSetting()
        {
            InitializeComponent();
        }

        public frmSetting(frmCommInterface objCommInter)
        {
            InitializeComponent();
            objCommInterface = objCommInter;
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            SComponents objComp = new SComponents();

            objComp.ApplyStyleToControls(this);
            this.Text += " (" + clsSharedVariable.UserName + " )";

            filData();

            objComp = null;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.Top = 0;
            //this.Left = 0;
        }

        private void filData() 
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLSetting objSetting = new clsBLSetting(objConnection);
            DataView dv = new DataView();
            try
            {
                objConnection.Connection_Open();
                dv = objSetting.GetAll(1);
                for (int i = 0; i < dv.Table.Rows.Count; i++)
                {
                    switch (dv.Table.Rows[i]["ID"].ToString())
                    {
                        case "EmailInfo":
                            txtUserName.Text = dv.Table.Rows[i]["Parameter1"].ToString();
                            txtPassword.Text = dv.Table.Rows[i]["Parameter2"].ToString();
                            txtHost.Text = dv.Table.Rows[i]["Parameter3"].ToString();
                            txtPort.Text = dv.Table.Rows[i]["Parameter4"].ToString();
                            gbEmail.Tag = "U";
                            break;
                        case "Refresh":
                            txtRefres.Text = dv.Table.Rows[i]["Parameter1"].ToString();
                            txtRefres.Tag= "U";
                            break;
                        case "Read":
                            txtRead.Text = dv.Table.Rows[i]["Parameter1"].ToString();
                            txtRead.Tag = "U";
                            break;
                        case "Send":
                            txtSend.Text = dv.Table.Rows[i]["Parameter1"].ToString();
                            txtSend.Tag = "U";
                            break;
                        case "Upload":
                            txtUpload.Text = dv.Table.Rows[i]["Parameter1"].ToString();
                            txtUpload.Tag = "U";
                            break;
                        case "LogFilePath":
                            txtpath.Text = dv.Table.Rows[i]["Parameter1"].ToString();
                            txtpath.Tag = "U";
                            break;
                        case "Retention":
                            txtRetention.Text = dv.Table.Rows[i]["Parameter1"].ToString();
                            txtRetention.Tag = "U";
                            break;
                        case "CreateFile":
                            chbCreatFile.Checked= dv.Table.Rows[i]["Parameter1"].ToString().Equals("Y");
                            chbCreatFile.Tag = "U";
                            break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Get setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objSetting= null;
            }
        }

        private void frmSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            objCommInterface.Show();
            this.Dispose();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr= fbd.ShowDialog();

            if (dr.Equals(DialogResult.OK))
            {
                txtpath.Text = fbd.SelectedPath;
            }
            else
            {
                txtpath.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLSetting objSetting = new clsBLSetting(objConnection);
            try
            {
                objConnection.Connection_Open();

                EmailInfo(objConnection, objSetting);
                
                objSetting.Parameter1 = "~!@";
                objSetting.Parameter2 = "~!@";
                objSetting.Parameter3 = "~!@";

                RefreshRate(objConnection, objSetting);
                ReadRate(objConnection, objSetting);
                SendRate(objConnection, objSetting);
                UploadRate(objConnection, objSetting);
                LogFilePath(objConnection, objSetting);
                Retention(objConnection, objSetting);
                CreateFile(objConnection, objSetting);

                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Insert or update Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objSetting= null;
            }
        }

        private void EmailInfo(clsBLDBConnection objConnection, clsBLSetting objSetting)
        {
            objSetting.ID = "EmailInfo";
            objSetting.Parameter1 = txtUserName.Text.Trim();
            objSetting.Parameter2 = txtPassword.Text.Trim();
            objSetting.Parameter3 = txtHost.Text.Trim();
            objSetting.Parameter4 = txtPort.Text.Trim();

            objConnection.Transaction_Begin();

            if (gbEmail.Tag==null)
            {
                if (objSetting.Insert())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
            else if (gbEmail.Tag.ToString().Equals("U"))
            {
                if (objSetting.Update())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }

        }

        private void RefreshRate(clsBLDBConnection objConnection, clsBLSetting objSetting)
        {
            objSetting.ID = "Refresh";
            objSetting.Parameter1 = txtRefres.Text.Trim();

            objConnection.Transaction_Begin();

            if (txtRefres.Tag==null)
            {
                if (objSetting.Insert())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
            else if (txtRefres.Tag.ToString().Equals("U"))
            {
                if (objSetting.Update())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
        }

        private void ReadRate(clsBLDBConnection objConnection, clsBLSetting objSetting)
        {
            objSetting.ID = "Read";
            objSetting.Parameter1 = txtRead.Text.Trim();

            objConnection.Transaction_Begin();

            if (txtRead.Tag==null)
            {
                if (objSetting.Insert())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
            else if (txtRead.Tag.ToString().Equals("U"))
            {
                if (objSetting.Update())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
        }

        private void SendRate(clsBLDBConnection objConnection, clsBLSetting objSetting)
        {
            objSetting.ID = "Send";
            objSetting.Parameter1 = txtSend.Text.Trim();

            objConnection.Transaction_Begin();

            if (txtSend.Tag==null)
            {
                if (objSetting.Insert())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
            else if (txtSend.Tag.ToString().Equals("U"))
            {
                if (objSetting.Update())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
        }

        private void UploadRate(clsBLDBConnection objConnection, clsBLSetting objSetting)
        {
            objSetting.ID = "Upload";
            objSetting.Parameter1 = txtUpload.Text.Trim();

            objConnection.Transaction_Begin();

            if (txtUpload.Tag==null)
            {
                if (objSetting.Insert())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
            else if (txtSend.Tag.ToString().Equals("U"))
            {
                if (objSetting.Update())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
        }

        private void LogFilePath(clsBLDBConnection objConnection, clsBLSetting objSetting)
        {
            objSetting.ID = "LogFilePath";
            objSetting.Parameter1 = txtpath.Text.Replace("\\", "\\\\").Replace("'", "''").Trim(); 

            objConnection.Transaction_Begin();

            if (txtpath.Tag==null)
            {
                if (objSetting.Insert())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
            else if (txtSend.Tag.ToString().Equals("U"))
            {
                if (objSetting.Update())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
        }

        private void Retention(clsBLDBConnection objConnection, clsBLSetting objSetting)
        {
            objSetting.ID = "Retention";
            objSetting.Parameter1 = txtRetention.Text.Trim();

            objConnection.Transaction_Begin();

            if (txtRetention.Tag==null)
            {
                if (objSetting.Insert())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
            else if (txtSend.Tag.ToString().Equals("U"))
            {
                if (objSetting.Update())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
        }

        private void CreateFile(clsBLDBConnection objConnection, clsBLSetting objSetting)
        {
            objSetting.ID = "CreateFile";
            objSetting.Parameter1 = chbCreatFile.Checked?"Y":"N";

            objConnection.Transaction_Begin();

            if (chbCreatFile.Tag==null)
            {
                if (objSetting.Insert())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
            else if (txtSend.Tag.ToString().Equals("U"))
            {
                if (objSetting.Update())
                {
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    objConnection.Transaction_ComRoll();
                }
            }
        }
    }
}