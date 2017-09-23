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
    public partial class frmSupplier : Form
    {
        private frmCommInterface objCommInterface = new frmCommInterface();

        public frmSupplier()
        {
            InitializeComponent();
        }

        public frmSupplier(frmCommInterface objCommInter)
        {
            InitializeComponent();
            objCommInterface = objCommInter;
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            SComponents objComp = new SComponents();

            objComp.ApplyStyleToControls(this);
            FillGV();
            this.Text += " (" + clsSharedVariable.UserName + " )";
            dgSupplier.ClearSelection();
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
            txtName.Text = "";
            txtAddress.Text = ""; ;
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtFax1.Text = "";
            txtFax2.Text = ""; ;
            txtEmail.Text = "";
            txtCellNo.Text = "";
            txtWebAddress.Text = "";
            txtLinkedInID.Text = "";
            txtCPName.Text = "";
            txtCPDesignation.Text = "";
            txtCPPhone.Text = "";
            txtCPCellNo.Text = "";
            txtCPEmail.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            chbActive.Checked = true;
            txtSupplierRefID.Text = "";
            btnSave.Text = "Save";
            lblSupplierID.Text = "";
            FillGV();
            dgSupplier.ClearSelection();
            txtName.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void FillGV()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLSuppliers objSupp = new clsBLSuppliers(objConnection);
            DataView dv = new DataView();
            try
            {
                objConnection.Connection_Open();
                dv = objSupp.GetAll(1);
                dgSupplier.DataSource = dv;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Supplier FillGV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objSupp = null;
            }

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
            clsBLSuppliers objSupp = new clsBLSuppliers(objConnection);

            try
            {
                objSupp = SetBL(objSupp);

                objConnection.Connection_Open();
                objConnection.Transaction_Begin();

                if (objSupp.Insert())
                {
                    MessageBox.Show("Inserted Successfully...", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objConnection.Transaction_ComRoll();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Record is not Insert...( " + objSupp.StrErr + " )", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objSupp = null;
            }
        }

        private void UpdateData()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLSuppliers objSupp = new clsBLSuppliers(objConnection);

            try
            {
                objSupp.SupplierID = lblSupplierID.Text;
                objSupp = SetBL(objSupp);

                objConnection.Connection_Open();
                objConnection.Transaction_Begin();

                if (objSupp.Update())
                {
                    MessageBox.Show("Updtae Successfully...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objConnection.Transaction_ComRoll();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Record is not Update...( " + objSupp.StrErr + " )", "Updation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objSupp = null;
            }
        }

        private clsBLSuppliers SetBL(clsBLSuppliers objSupp)
        {
            objSupp.Supplier_Name = txtName.Text.Replace("'", "''").Trim();
            objSupp.Address = txtAddress.Text.Replace("'", "''").Trim();
            objSupp.Phone_1 = txtPhone1.Text.Replace("'", "''").Trim();
            objSupp.Phone_2 = txtPhone2.Text.Replace("'", "''").Trim();
            objSupp.Fax_1 = txtFax1.Text.Replace("'", "''").Trim();
            objSupp.Fax_2 = txtFax2.Text.Replace("'", "''").Trim();
            objSupp.Email = txtEmail.Text.Replace("'", "''").Trim();
            objSupp.CellNo = txtCellNo.Text.Replace("'", "''").Trim();
            objSupp.WebAddress = txtWebAddress.Text.Replace("'", "''").Trim();
            objSupp.Linkedin_ID = txtLinkedInID.Text.Replace("'", "''").Trim();
            objSupp.CP_Name = txtCPName.Text.Replace("'", "''").Trim();
            objSupp.CP_Designation = txtCPDesignation.Text.Replace("'", "''").Trim();
            objSupp.CP_Office_Phone = txtCPPhone.Text.Replace("'", "''").Trim();
            objSupp.CP_Cell_no = txtCPCellNo.Text.Replace("'", "''").Trim();
            objSupp.CP_Email = txtCPEmail.Text.Replace("'", "''").Trim();
            objSupp.City = txtCity.Text.Replace("'", "''").Trim();
            objSupp.Country = txtCountry.Text.Replace("'", "''").Trim();
            objSupp.CP_Cell_no = txtCPCellNo.Text.Replace("'", "''").Trim();
            objSupp.EnteredBy = clsSharedVariable.PersonID;
            objSupp.EnteredOn = DateTime.Now.ToString("dd/MM/yyyy");
            objSupp.Clientid = clsSharedVariable.ClientID;
            objSupp.Active = chbActive.Checked ? "Y" : "N";
            if (!txtSupplierRefID.Text.Trim().Equals(""))
            {
                objSupp.Ref_SupplierID = txtSupplierRefID.Text.Replace("'", "''").Trim();
            }

            return objSupp;
        }

        private void frmSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            objCommInterface.Show();
            this.Dispose();
        }

        private void dgSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FillForm(e.RowIndex);
            }
        }

        private void FillForm(int RowIndex)
        {
            this.btnSave.Text = "Update";

            lblSupplierID.Text = dgSupplier.Rows[RowIndex].Cells["SupplierID"].Value.ToString(); ;

            txtName.Text = dgSupplier.Rows[RowIndex].Cells["SuppName"].Value.ToString();
            txtLinkedInID.Text = dgSupplier.Rows[RowIndex].Cells["LinkedinID"].Value.ToString();
            chbActive.Checked = dgSupplier.Rows[RowIndex].Cells["Active"].Value.ToString().Equals("Y");
            txtPhone1.Text = dgSupplier.Rows[RowIndex].Cells["Phone1"].Value.ToString();
            txtPhone2.Text = dgSupplier.Rows[RowIndex].Cells["Phone2"].Value.ToString();
            txtEmail.Text = dgSupplier.Rows[RowIndex].Cells["SupEmail"].Value.ToString();
            txtFax1.Text = dgSupplier.Rows[RowIndex].Cells["Fax1"].Value.ToString();
            txtFax2.Text = dgSupplier.Rows[RowIndex].Cells["Fax2"].Value.ToString();
            txtWebAddress.Text = dgSupplier.Rows[RowIndex].Cells["WebAddress"].Value.ToString();
            txtCellNo.Text = dgSupplier.Rows[RowIndex].Cells["SupCellNo"].Value.ToString();
            txtCountry.Text = dgSupplier.Rows[RowIndex].Cells["Country"].Value.ToString();
            txtSupplierRefID.Text = dgSupplier.Rows[RowIndex].Cells["RefSuppID"].Value.ToString();
            txtCity.Text = dgSupplier.Rows[RowIndex].Cells["City"].Value.ToString();
            txtAddress.Text = dgSupplier.Rows[RowIndex].Cells["Address"].Value.ToString();
            txtCPName.Text = dgSupplier.Rows[RowIndex].Cells["CPName"].Value.ToString();
            txtCPDesignation.Text = dgSupplier.Rows[RowIndex].Cells["CPDesignation"].Value.ToString();
            txtCPPhone.Text = dgSupplier.Rows[RowIndex].Cells["CPPhone"].Value.ToString();
            txtCPCellNo.Text = dgSupplier.Rows[RowIndex].Cells["CPCell"].Value.ToString();
            txtCPEmail.Text = dgSupplier.Rows[RowIndex].Cells["CPEmail"].Value.ToString();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = "0123456789-#*\b";
            e.Handled= !(str.Contains(e.KeyChar.ToString()));
        }

        private void txtAlph_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = "abcdefghijklmnopqrstuvwxyz\b";
            e.Handled = !(str.Contains(e.KeyChar.ToString().ToLower()));
        }
    }
}