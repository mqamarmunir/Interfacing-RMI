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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbInstrument.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Instrument", "Select Instrument", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ;
            }

            clsBLDBConnection objConn = new clsBLDBConnection();
            clsBLLogin objLogin=new clsBLLogin(objConn);
            frmMain objMain1 = new frmMain(this);
            frmCommInterface objCommInterface = new frmCommInterface(this);

            try
            {
                objConn.Connection_Open();
                if (txtLoginID.Text.Trim().Equals("") && txtPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Password or User Name is not allowed to be empty.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtLoginID.Text="";
                    txtPassword.Text = "";
                    cmbInstrument.SelectedIndex = 0;
                    
                    return;
                }

                DataView dv = new DataView();

                objLogin.LoginID = txtLoginID.Text.Trim();
                objLogin.Password= txtPassword.Text.Trim();
                
                dv = objLogin.GetAll(1);

                if (dv.Table.Rows.Count != 0)
                {
                    clsSharedVariable.PersonID =dv.Table.Rows[0]["personid"].ToString();
                    clsSharedVariable.LoginID=txtLoginID.Text;
                    clsSharedVariable.UserName= dv.Table.Rows[0]["Name"].ToString();
                    clsSharedVariable.InstrumentID= cmbInstrument.SelectedValue.ToString();
                    clsSharedVariable.InstrumentName = cmbInstrument.Text;

                    FillInstrumentInfo();

                    objCommInterface.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Password or User Name.","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtLoginID.Text = "";
                    txtPassword.Text = "";
                    cmbInstrument.SelectedIndex = 0;
                }
                dv.Dispose();
                dv = null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message );
            }
            finally 
            {
                objConn.Connection_Close();
                objConn = null;
                objLogin = null;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            FillcmbInstrument();
            //cmbInstrument.SelectedValue = "9";
            cmbInstrument.Text = System.Configuration.ConfigurationSettings.AppSettings["MachineName"].ToString();
        }

        private void FillcmbInstrument()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLInstruments objInstrument = new clsBLInstruments(objConnection);
            DataView dv = new DataView();
            SComponents objComp = new SComponents();

            try
            {
                objConnection.Connection_Open();
                dv = objInstrument.GetAll(2);
                objComp.FillComboBox(cmbInstrument, dv, "Instrument_Name", "InstrumentID", true, false);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Instrument Combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objInstrument = null;
            }
        }

        private void FillInstrumentInfo()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLInstruments objInstrument = new clsBLInstruments(objConnection);
            DataView dv = new DataView();
            try
            {
                objInstrument.InstrumentID=cmbInstrument.SelectedValue.ToString();
                objConnection.Connection_Open();
                dv = objInstrument.GetAll(1);
               
                clsSharedVariable.Supplierid = dv.Table.Rows[0]["Supplierid"].ToString() ;
                clsSharedVariable.Model = dv.Table.Rows[0]["Model"].ToString(); ;
                clsSharedVariable.I_Release = dv.Table.Rows[0]["I_Release"].ToString(); ;
                clsSharedVariable.Patient_no_format = dv.Table.Rows[0]["Patient_no_format"].ToString(); ;
                clsSharedVariable.BarCode_Standard = dv.Table.Rows[0]["BarCode_Standard"].ToString(); ;
                clsSharedVariable.Communication_Stnadard = dv.Table.Rows[0]["Communication_Stnadard"].ToString(); ;
                clsSharedVariable.Communication_method = dv.Table.Rows[0]["Communication_method"].ToString(); ;
                clsSharedVariable.PORT = dv.Table.Rows[0]["PORT"].ToString(); ;
                clsSharedVariable.BaudRate = dv.Table.Rows[0]["BaudRate"].ToString(); ;
                clsSharedVariable.Parity = dv.Table.Rows[0]["Parity"].ToString(); ;
                clsSharedVariable.Stopbit = dv.Table.Rows[0]["Stopbit"].ToString(); ;
                clsSharedVariable.DataBit = dv.Table.Rows[0]["DataBit"].ToString(); ;
                clsSharedVariable.FlowControl = dv.Table.Rows[0]["FlowControl"].ToString(); ;
                clsSharedVariable.Acknowledgement_code = dv.Table.Rows[0]["Acknowledgement_code"].ToString(); ;
                clsSharedVariable.Supplier_Name = dv.Table.Rows[0]["Supplier_Name"].ToString(); ;

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Fill Instrument Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objInstrument = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}