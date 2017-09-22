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
    public partial class frmAttribute : Form
    {
        private frmMachineTest objMachineTest = new frmMachineTest();

        #region Class Variable and Properties

        private string _MachineTestID = "";
        private string _MachineTestName = "";
        private string _LIMSTestID = "";
        private string _LIMSTestName = "";
        private DataTable dt;

        public string MashineTestID
        {
            get { return _MachineTestID; }
            set { _MachineTestID = value; }
        }

        public string MachineTestName
        {
            get { return _MachineTestName; }
            set { _MachineTestName = value; }
        }

        public string LIMSTestID
        {
            get { return _LIMSTestID; }
            set { _LIMSTestID = value; }
        }

        public string LIMSTestName
        {
            get { return _LIMSTestName; }
            set { _LIMSTestName = value; }
        }

        #endregion

        public frmAttribute()
        {
            InitializeComponent();
        }

        public frmAttribute(frmMachineTest ObjMT)
        {
            InitializeComponent();
            objMachineTest = ObjMT;
        }

        private void frmAttribute_Load(object sender, EventArgs e)
        {
            SComponents objComp = new SComponents();

            objComp.ApplyStyleToControls(this);
            this.Text += " (" + clsSharedVariable.UserName + " )";

            txtLIMSTestName.Text = _LIMSTestName;
            txtLIMSTestName.Tag = _LIMSTestID;

            txtMachineTestName.Text = _MachineTestName;
            txtMachineTestName.Tag = _MachineTestID;

            FillcmbLIMSAttrib();

            FillGV();
            dt = ((DataView)dgTestAttrib.DataSource).Table;

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
            cmbLimsAttribte.SelectedIndex = 0;
            txtMachineTestAttrib.Text = "";
            txtMachineAttribCode.Text = "";
            chbActive.Checked = true;
            btnSave.Text = "Save";
            lblMchineAttrib.Text = "";
            FillGV();
            dt = ((DataView)dgTestAttrib.DataSource).Table;
            dgTestAttrib.ClearSelection();
            cmbLimsAttribte.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void FillGV()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLTestAttribute objTestAttrib = new clsBLTestAttribute(objConnection);
            DataView dv = new DataView();
            try
            {
                objConnection.Connection_Open();
                objTestAttrib.Machine_testid = _MachineTestID;
                dv = objTestAttrib.GetAll(1);
                dgTestAttrib.DataSource = dv;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Test Attrib FillGV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objTestAttrib = null;
            }
        }

        private void FillcmbLIMSAttrib()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLTest objTest = new clsBLTest(objConnection);
            DataView dv = new DataView();
            SComponents objComp = new SComponents();

            try
            {
                objTest.Lims_testid = txtLIMSTestName.Tag.ToString();

                objConnection.OraConnection_Open();
                dv = objTest.OraGetAll(3);
                objComp.FillComboBox(cmbLimsAttribte, dv, "attribute_Name", "attributeid", true);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "FillCombobox Lims Attribute", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.OraConnection_Close();
                objConnection = null;
                objTest = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgTestAttrib.Rows.Count; i++)
            {
                if (dgTestAttrib.Rows[i].Cells["AttributeID"].Value.ToString().Equals("0"))
                {
                    InsertData(i);
                }
                else if (!dgTestAttrib.Rows[i].Cells["AttributeID"].Value.ToString().Equals("0"))
                {
                    UpdateData(i);
                }
            }
        }

        private void InsertData(int ri)
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLTestAttribute objTestAttrib = new clsBLTestAttribute(objConnection);

            try
            {
                objTestAttrib = SetBL(objTestAttrib,ri);

                objConnection.Connection_Open();
                objConnection.Transaction_Begin();

                if (objTestAttrib.Insert())
                {
                   // MessageBox.Show("Inserted Successfully...", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                   //MessageBox.Show("Record is not Insert...( " + objTestAttrib.StrErr + " )", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objTestAttrib = null;
            }
        }

        private void UpdateData(int ri)
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLTestAttribute objTestAttrib = new clsBLTestAttribute(objConnection);

            try
            {
                objTestAttrib.AttributeID = dgTestAttrib.Rows[ri].Cells["AttributeID"].Value.ToString();
                objTestAttrib = SetBL(objTestAttrib,ri);

                objConnection.Connection_Open();
                objConnection.Transaction_Begin();

                if (objTestAttrib.Update())
                {
                   // MessageBox.Show("Updtae Successfully...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objConnection.Transaction_ComRoll();
                }
                else
                {
                    //MessageBox.Show("Record is not Update...( " + objTestAttrib.StrErr + " )", "Updation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objTestAttrib = null;
            }
        }

        private clsBLTestAttribute SetBL(clsBLTestAttribute objTestAttrib,int ri)
        {
            objTestAttrib.Machine_testid = _MachineTestID;
            objTestAttrib.LIMSAttributeID = dgTestAttrib.Rows[ri].Cells["LIMSAttributeID"].Value.ToString();
            objTestAttrib.LIMSAttributeName = dgTestAttrib.Rows[ri].Cells["LIMSAttributeName"].Value.ToString();
            objTestAttrib.MachineAttributeName = dgTestAttrib.Rows[ri].Cells["MachineAttributeName"].Value.ToString().Replace("'","''");
            objTestAttrib.MachineAttributeCode = dgTestAttrib.Rows[ri].Cells["MachineAttributeCode"].Value.ToString().Replace("'", "''");
            objTestAttrib.EnteredBy = clsSharedVariable.PersonID;
            objTestAttrib.EnteredOn = DateTime.Now.ToString("dd/MM/yyyy");
            objTestAttrib.ClientID = clsSharedVariable.ClientID;
            objTestAttrib.Active = dgTestAttrib.Rows[ri].Cells["Active"].Value.ToString();
            if (!dgTestAttrib.Rows[ri].Cells["Channel"].Value.ToString().Equals("0"))
            {
                objTestAttrib.Channel = dgTestAttrib.Rows[ri].Cells["Channel"].Value.ToString();
            }
            
            return objTestAttrib;
        }

        private void frmAttribute_FormClosing(object sender, FormClosingEventArgs e)
        {
            objMachineTest.Show();
            this.Dispose();
        }

        private void dgTestAttrib_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FillForm(e.RowIndex);
            }
        }

        private void FillForm(int RowIndex)
        {
            btnAdd.Tag = RowIndex.ToString();

            cmbLimsAttribte.Text = dgTestAttrib.Rows[RowIndex].Cells["LIMSAttributeName"].Value.ToString();
            txtMachineTestAttrib.Text = dgTestAttrib.Rows[RowIndex].Cells["MachineAttributeName"].Value.ToString();
            chbActive.Checked = dgTestAttrib.Rows[RowIndex].Cells["Active"].Value.ToString().Equals("Y");
            txtMachineAttribCode.Text = dgTestAttrib.Rows[RowIndex].Cells["MachineAttributeCode"].Value.ToString();
            txtChannel.Text = dgTestAttrib.Rows[RowIndex].Cells["Channel"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbLimsAttribte.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Lims Attribute...", "Select Attribute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMachineTestAttrib.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please insert Machine Attribute Name ...", "Machine Attribute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMachineAttribCode.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please insert Machine Attribute Code ...", "Machine Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!btnAdd.Tag.ToString().Equals(i.ToString()))
                {
                    if (dt.Rows[i]["LIMSAttributeName"].ToString().Equals(cmbLimsAttribte.Text))
                    {
                        MessageBox.Show("LIMS Attribute name Already add", "Duplicate Attribute name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (dt.Rows[i]["MachineAttributeName"].ToString().Equals(txtMachineTestAttrib.Text.Trim()))
                    {
                        MessageBox.Show("Machine Attribute name Already add", "Duplicate Attribute name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (!btnAdd.Tag.ToString().Equals("-1") && btnAdd.Tag.ToString().Equals(i.ToString()))
                {
                    dt.Rows[Convert.ToInt16(btnAdd.Tag)]["LIMSAttributeName"] = cmbLimsAttribte.Text;
                    dt.Rows[Convert.ToInt16(btnAdd.Tag)]["MachineAttributeName"] = txtMachineTestAttrib.Text.Trim();
                    dt.Rows[Convert.ToInt16(btnAdd.Tag)]["MachineAttributeCode"] = txtMachineAttribCode.Text.Trim().Trim();
                    dt.Rows[Convert.ToInt16(btnAdd.Tag)]["Active"] = chbActive.Checked ? "Y" : "N";
                    dt.Rows[Convert.ToInt16(btnAdd.Tag)]["channel"] = txtChannel.Text.Trim().Trim();
                    dgTestAttrib.DataSource = dt.DefaultView;
                    ClearField();
                    return;
                }
            }

            DataRow dr= dt.NewRow();

            dr["AttributeID"] = "0";
            dr["LIMSAttributeID"] = cmbLimsAttribte.SelectedValue.ToString();
            dr["LIMSAttributeName"] = cmbLimsAttribte.Text; 
            dr["MachineAttributeName"] = txtMachineTestAttrib.Text.Trim();
            dr["Active"] = chbActive.Checked ? "Y" :"N";
            dr["MachineAttributeCode"] = txtMachineAttribCode.Text.Trim();
            dr["channel"] = txtChannel.Text.Trim().Equals("") ? "0" : txtChannel.Text.Trim();
            
            dt.Rows.Add(dr);

            dgTestAttrib.DataSource = dt.DefaultView;
            ClearField();
        }

        private void ClearField()
        {
            cmbLimsAttribte.SelectedIndex = 0;
            txtMachineTestAttrib.Text = "";
            chbActive.Checked = true;
            cmbLimsAttribte.Focus();
            txtMachineAttribCode.Text = "";
            txtChannel.Text = "";
            btnAdd.Tag = "-1";
        }
    }
}