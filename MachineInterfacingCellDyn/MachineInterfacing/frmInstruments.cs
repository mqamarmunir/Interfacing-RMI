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
    public partial class frmInstruments : Form
    {
        private frmCommInterface objCommInterface = new frmCommInterface();

        public frmInstruments()
        {
            InitializeComponent();
        }

        public frmInstruments(frmCommInterface objCommInter)
        {
            InitializeComponent();
            objCommInterface = objCommInter;
        }

        private void frmInstruments_Load(object sender, EventArgs e)
        {
            SComponents objComp = new SComponents();

            objComp.ApplyStyleToControls(this);
            FillGV();
            FillcmbSupp();

            fillParameter(cmbPortName, "Port");
            fillParameter(cmbBaudRate, "BaudRate");
            fillParameter(cmbParity, "Parity");
            fillParameter(cmbDataBits, "DataBit");
            fillParameter(cmbStopBits, "StopBit");
            fillParameter(cmbFlowCtrl, "FlowCtrl");
            fillParameter(cmbCommMethod, "CommMethod");


            if (cmbStopBits.Items.Count > 0)
            {
                cmbStopBits.Text = "One";
            }
            if (cmbDataBits.Items.Count > 0)
            {
                cmbDataBits.Text = "8";
            }
            if (cmbParity.Items.Count > 0)
            {
                cmbParity.Text = "None";
            }
            if (cmbBaudRate.Items.Count > 0)
            {
                cmbBaudRate.Text = "9600";
            }
            if (cmbCommMethod.Items.Count > 0)
            {
                cmbCommMethod.Text = "PORT";
            }

            this.Text += " (" + clsSharedVariable.UserName + " )";
            dgInstrument.ClearSelection();
            objComp = null;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Top = 0;
            this.Left = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear()
        {
            cmbSupplier.SelectedIndex = 0;
            txtName.Text = "";
            txtModel.Text = ""; ;
            txtRelease.Text = "";
            txtDescription.Text = "";
            txtManual.Text = "";
            txtPFormat.Text = ""; ;
            txtBarCodeStd.Text = "";
            chbBidirectional.Checked = true;
            cmbCommMethod.SelectedIndex= 0;
            txtComStd.Text = "";
            cmbPortName.SelectedIndex = 0;
            cmbBaudRate.SelectedIndex = 0;
            cmbParity.SelectedIndex = 0;
            cmbStopBits.SelectedIndex = 0;
            cmbDataBits.SelectedIndex = 0;
            cmbFlowCtrl.SelectedIndex = 0;
            txtAckCode.Text = "";
            chbActive.Checked = true;
            btnSave.Text = "Save";
            lblInstrumentID.Text = "";
            FillGV();
            dgInstrument.ClearSelection();
            cmbSupplier.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void FillGV()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLInstruments objInstrument = new clsBLInstruments(objConnection);
            DataView dv = new DataView();
            try
            {
                objConnection.Connection_Open();
                dv = objInstrument.GetAll(1);
                dgInstrument.DataSource = dv;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Instrument FillGV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objInstrument = null;
            }
        }

        private void FillcmbSupp()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLSuppliers objSupp = new clsBLSuppliers(objConnection);
            DataView dv = new DataView();
            SComponents objComp = new SComponents();

            try
            {
                objConnection.Connection_Open();
                dv = objSupp.GetAll(3);
                objComp.FillComboBox(cmbSupplier, dv, "Supplier_Name", "SupplierID", true, false);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Supplier Combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objSupp = null;
            }
        }

        private void fillParameter(ComboBox cmb, string Name)
        {
            string[] str = System.Configuration.ConfigurationSettings.AppSettings[Name].Split(',');
            cmb.DataSource = str;
            str = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text.Equals("Save"))
            {
                InsertData();
            }
            else if (btnSave.Text.Equals("Update"))
            {
                UpdateData();
            }
        }

        private void InsertData()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLInstruments objInstrument = new clsBLInstruments(objConnection);

            try
            {
                objInstrument = SetBL(objInstrument);

                objConnection.Connection_Open();
                objConnection.Transaction_Begin();

                if (objInstrument.Insert())
                {
                    MessageBox.Show("Inserted Successfully...", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objConnection.Transaction_ComRoll();

                    if (!txtManual.Text.Trim().Equals("") && !Microsoft.VisualBasic.FileIO.FileSystem.FileExists(Application.StartupPath + "\\Manual\\" + Microsoft.VisualBasic.FileIO.FileSystem.GetName(txtManual.Text.Trim())))
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(txtManual.Text.Trim(), Application.StartupPath + "\\Manual\\" + Microsoft.VisualBasic.FileIO.FileSystem.GetName(txtManual.Text.Trim()));
                    }

                    Clear();
                }
                else
                {
                    MessageBox.Show("Record is not Insert...( " + objInstrument.StrErr + " )", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objConnection.Transaction_ComRoll();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objInstrument = null;
            }
        }

        private void UpdateData()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLInstruments objInstrument = new clsBLInstruments(objConnection);

            try
            {
                objInstrument.InstrumentID = lblInstrumentID.Text;
                objInstrument = SetBL(objInstrument);

                objConnection.Connection_Open();
                objConnection.Transaction_Begin();

                if (objInstrument.Update())
                {
                    MessageBox.Show("Update Successfully...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objConnection.Transaction_ComRoll();

                    if (!txtManual.Text.Trim().Equals("") && !Microsoft.VisualBasic.FileIO.FileSystem.FileExists(Application.StartupPath + "\\Manual\\" + Microsoft.VisualBasic.FileIO.FileSystem.GetName(txtManual.Text.Trim())))
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(txtManual.Text.Trim(), Application.StartupPath + "\\Manual\\" + Microsoft.VisualBasic.FileIO.FileSystem.GetName(txtManual.Text.Trim()));
                    }
                    Clear();
                }
                else
                {
                    MessageBox.Show("Record is not Update...( " + objInstrument.StrErr + " )", "Updation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objConnection.Transaction_ComRoll();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objInstrument = null;
            }
        }

        private clsBLInstruments SetBL(clsBLInstruments objInstrument)
        {
            objInstrument.Supplierid = cmbSupplier.SelectedValue.ToString();
            objInstrument.Instrument_Name = txtName.Text.Replace("'", "''").Trim();
            objInstrument.Model = txtModel.Text.Replace("'", "''").Trim();
            objInstrument.Release = txtRelease.Text.Replace("'", "''").Trim();
            objInstrument.Description = txtDescription.Text.Replace("'", "''").Trim();
            objInstrument.Manual = txtManual.Text.Replace("\\", "\\\\").Replace("'", "''").Trim();
            objInstrument.Patient_no_format = txtPFormat.Text.Replace("'", "''").Trim();
            objInstrument.BarCode_Standard = txtBarCodeStd.Text.Replace("'", "''").Trim();
            objInstrument.Bidirectional = chbBidirectional.Checked ? "Y" : "N";
            objInstrument.Communication_method = cmbCommMethod.SelectedValue.ToString();
            objInstrument.Communicaton_Stnadard = txtComStd.Text.Replace("'", "''").Trim();
            objInstrument.PORT = cmbPortName.Text.Replace("'", "''").Trim();
            objInstrument.BaudRate = cmbBaudRate.Text.Replace("'", "''").Trim();
            objInstrument.Parity = cmbParity.Text.Replace("'", "''").Trim();
            objInstrument.Stopbit = cmbStopBits.Text.Replace("'", "''").Trim();
            objInstrument.DataBit = cmbDataBits.Text.Replace("'", "''").Trim();
            objInstrument.FlowControl = cmbFlowCtrl.Text.Replace("'", "''").Trim();
            if (!txtAckCode.Text.Equals(""))
            {
                objInstrument.Acknowledgement_code = txtAckCode.Text.Replace("'", "''").Trim();
            }
            objInstrument.EnteredBy = clsSharedVariable.PersonID;
            objInstrument.EnteredOn = DateTime.Now.ToString("dd/MM/yyyy");
            objInstrument.ClientID = clsSharedVariable.ClientID;
            objInstrument.Active = chbActive.Checked ? "Y" : "N";

            return objInstrument;
        }

        private void frmInstruments_FormClosing(object sender, FormClosingEventArgs e)
        {
            objCommInterface.Show();
            this.Dispose();
        }

        private void dgInstrument_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FillForm(e.RowIndex);
            }
        }

        private void FillForm(int RowIndex)
        {
            this.btnSave.Text = "Update";

            lblInstrumentID.Text = dgInstrument.Rows[RowIndex].Cells["InstrumentID"].Value.ToString(); ;

            cmbSupplier.SelectedValue = dgInstrument.Rows[RowIndex].Cells["Supplierid"].Value.ToString();
            txtName.Text = dgInstrument.Rows[RowIndex].Cells["Instrument_Name"].Value.ToString();
            txtModel.Text = dgInstrument.Rows[RowIndex].Cells["Model"].Value.ToString();
            chbActive.Checked = dgInstrument.Rows[RowIndex].Cells["Active"].Value.ToString().Equals("Y");
            txtRelease.Text = dgInstrument.Rows[RowIndex].Cells["Release"].Value.ToString();
            txtDescription.Text = dgInstrument.Rows[RowIndex].Cells["Description"].Value.ToString();
            txtManual.Text = dgInstrument.Rows[RowIndex].Cells["Manual"].Value.ToString();
            txtPFormat.Text = dgInstrument.Rows[RowIndex].Cells["Patient_no_format"].Value.ToString();
            txtBarCodeStd.Text = dgInstrument.Rows[RowIndex].Cells["BarCode_Standard"].Value.ToString();
            chbBidirectional.Checked = dgInstrument.Rows[RowIndex].Cells["Bidirectional"].Value.ToString().Equals("Y");
            cmbCommMethod.Text = dgInstrument.Rows[RowIndex].Cells["Communication_method"].Value.ToString();
            txtComStd.Text = dgInstrument.Rows[RowIndex].Cells["Communication_Stnadard"].Value.ToString();
            cmbPortName.Text = dgInstrument.Rows[RowIndex].Cells["PORT"].Value.ToString();
            cmbBaudRate.Text = dgInstrument.Rows[RowIndex].Cells["BaudRate"].Value.ToString();
            cmbParity.Text = dgInstrument.Rows[RowIndex].Cells["Parity"].Value.ToString();
            cmbStopBits.Text = dgInstrument.Rows[RowIndex].Cells["Stopbit"].Value.ToString();
            cmbDataBits.Text = dgInstrument.Rows[RowIndex].Cells["DataBit"].Value.ToString();
            cmbFlowCtrl.Text = dgInstrument.Rows[RowIndex].Cells["FlowControl"].Value.ToString();
            txtAckCode.Text = dgInstrument.Rows[RowIndex].Cells["Acknowledgement_code"].Value.ToString();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = "0123456789\b";
            e.Handled = !(str.Contains(e.KeyChar.ToString()));
        }

        private void txtAlph_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = "abcdefghijklmnopqrstuvwxyz\b";
            e.Handled = !(str.Contains(e.KeyChar.ToString().ToLower()));
        }

        private void btnManualBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdManual=new OpenFileDialog();

            ofdManual.Filter = "Document (*.Doc;*.DocX;*.Pdf;*.Xls;*.XlsX;*.txt;)|*.Doc;*.DocX;*.Pdf;*.Xls;*.XlsX;*.txt| All files (*.*)|*.*";

            // Allow the user to select multiple images.
            ofdManual.Multiselect = false;
            ofdManual.Title = "My Document Browser";
            DialogResult dr = ofdManual.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtManual.Text = ofdManual.FileName;
            }
            
            ofdManual.Dispose();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (!txtManual.Text.Trim().Equals(""))
            {
                System.Diagnostics.Process.Start(txtManual.Text.Trim());
            }
        }
    }
}