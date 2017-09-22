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
    public partial class frmMachineTest : Form
    {
        private frmCommInterface objCommInterface = new frmCommInterface();

        public frmMachineTest()
        {
            InitializeComponent();
        }

        public frmMachineTest(frmCommInterface objCommInter)
        {
            InitializeComponent();
            objCommInterface = objCommInter;
        }

        private void frmMachineTest_Load(object sender, EventArgs e)
        {
            SComponents objComp = new SComponents();

            objComp.ApplyStyleToControls(this);
            FillGV();
            FillcmbInstrument();
            FillcmbLIMSDept();
            FillcmbLIMSTest("000000");
            this.Text += " (" + clsSharedVariable.UserName + " )";
            dgTest.ClearSelection();
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
            //cmbInstrument.SelectedIndex = 0;
            cmbLimsTest.SelectedIndex = 0;
            txtLonicCode.Text = ""; ;
            txtMachineTestName.Text = "";
            txtMachineTestCode.Text = "";
            chbActive.Checked = true;
            btnSave.Text = "Save";
            lblMachineTestID.Text = "";
            FillGV();
            dgTest.ClearSelection();
            cmbInstrument.Focus();
            //cmbDepartment.SelectedIndex = 0;
            FillcmbLIMSTest("000000");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbInstrument.SelectedIndex = 0;
            cmbDepartment.SelectedIndex = 0;

            Clear();
        }

        private void FillGV()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLTest objTest = new clsBLTest(objConnection);
            DataView dv = new DataView();
            try
            {
                objConnection.Connection_Open();
                dv = objTest.GetAll(1);
                dgTest.DataSource = dv;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Test FillGV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objTest = null;
            }
        }

        private void FillcmbLIMSTest(string filterTest)
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLTest objTest = new clsBLTest(objConnection);
            DataView dv = new DataView();
            SComponents objComp = new SComponents();

            try
            {
                objConnection.Connection_Open();
                objTest.Lims_testid = objTest.GetAll(2).Table.Rows[0][0].ToString().Replace(filterTest,"000000");

                if (cmbDepartment.SelectedIndex != 0)
                {
                    objTest.DeptID = cmbDepartment.SelectedValue.ToString();
                }

                objConnection.OraConnection_Open();
                dv = objTest.OraGetAll(1);
                objComp.FillComboBox(cmbLimsTest, dv, "TestName", "TestID", true);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "FillCombobox Lims Test ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection.OraConnection_Close();
                objConnection = null;
                objTest = null;
            }
        }

        private void FillcmbLIMSDept()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLTest objTest = new clsBLTest(objConnection);
            DataView dv = new DataView();
            SComponents objComp = new SComponents();

            try
            {
                objConnection.OraConnection_Open();
                dv = objTest.OraGetAll(2);
                objComp.FillComboBox(cmbDepartment, dv, "SectionName", "SectionID", true);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "FillCombobox Lims Test ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.OraConnection_Close();
                objConnection = null;
                objTest = null;
            }
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
            clsBLTest objTest = new clsBLTest(objConnection);

            try
            {
                objTest = SetBL(objTest);

                objConnection.Connection_Open();
                objConnection.Transaction_Begin();

                if (objTest.Insert())
                {
                    MessageBox.Show("Inserted Successfully...", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objConnection.Transaction_ComRoll();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Record is not Insert...( " + objTest.StrErr + " )", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objTest = null;
            }
        }

        private void UpdateData()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLTest objTest = new clsBLTest(objConnection);

            try
            {
                objTest.Machine_testid = lblMachineTestID.Text;
                objTest = SetBL(objTest);

                objConnection.Connection_Open();
                objConnection.Transaction_Begin();

                if (objTest.Update())
                {
                    MessageBox.Show("Updtae Successfully...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objConnection.Transaction_ComRoll();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Record is not Update...( " + objTest.StrErr + " )", "Updation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objTest = null;
            }
        }

        private clsBLTest SetBL(clsBLTest objTest)
        {
            if (cmbLimsTest.SelectedIndex != 0)
            {
                objTest.Lims_testid = cmbLimsTest.SelectedValue.ToString().Split(':')[1].Trim();
            }
            if (cmbLimsTest.SelectedIndex != 0)
            {
                objTest.Lims_test_name = cmbLimsTest.Text.Trim().Replace("'", "''").Trim();
            }
            objTest.Machine_Test_name = txtMachineTestName.Text.Trim().Replace("'", "''").Trim();
            objTest.LOINC_code = txtLonicCode.Text.Trim().Replace("'", "''").Trim();
            if (cmbInstrument.SelectedIndex != 0)
            {
                objTest.Instrumentid = cmbInstrument.SelectedValue.ToString();
            }
            objTest.EnteredBy = clsSharedVariable.PersonID;
            objTest.EnteredOn = DateTime.Now.ToString("dd/MM/yyyy");
            objTest.ClientID = clsSharedVariable.ClientID;
            objTest.Active = chbActive.Checked ? "Y" : "N";
            if (cmbLimsTest.SelectedIndex != 0)
            {
                objTest.DeptID = cmbLimsTest.SelectedValue.ToString().Split(':')[0].Trim();
            }
            objTest.MachineTestCode = txtMachineTestCode.Text.Trim().Replace("'", "''").Trim();

            return objTest;
        }

        private void frmMachineTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            objCommInterface.Show();
            this.Dispose();
        }

        private void dgTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FillForm(e.RowIndex);
            }
        }

        private void FillForm(int RowIndex)
        {
            this.btnSave.Text = "Update";
            FillcmbLIMSTest(dgTest.Rows[RowIndex].Cells["Lims_testid"].Value.ToString());

            lblMachineTestID.Text = dgTest.Rows[RowIndex].Cells["Machine_testid"].Value.ToString(); ;
            cmbInstrument.SelectedValue = dgTest.Rows[RowIndex].Cells["Instrumentid"].Value.ToString();
            txtMachineTestName.Text = dgTest.Rows[RowIndex].Cells["Machine_Test_name"].Value.ToString();
            txtMachineTestCode.Text = dgTest.Rows[RowIndex].Cells["MachineTestCode"].Value.ToString();
            chbActive.Checked = dgTest.Rows[RowIndex].Cells["Active"].Value.ToString().Equals("Y");
            cmbLimsTest.Text = dgTest.Rows[RowIndex].Cells["Lims_test_name"].Value.ToString();
            //cmbLimsTest.SelectedValue = dgTest.Rows[RowIndex].Cells["dept"].Value.ToString() + ":" + dgTest.Rows[RowIndex].Cells["Lims_testid"].Value.ToString();
            txtLonicCode.Text = dgTest.Rows[RowIndex].Cells["LOINC_code"].Value.ToString();
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

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnSave.Text.Equals("Save") || cmbLimsTest.SelectedIndex==0)
            {
                FillcmbLIMSTest("000000");
            }
            else
            {
                FillcmbLIMSTest(cmbLimsTest.SelectedValue.ToString().Split(':')[1].Trim());
            }
        }

        private void dgTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgTest.Columns[e.ColumnIndex].Name.Equals("Attribute"))
            {
                btnAttribClick(e.RowIndex);
            }
        }

        private void btnAttribClick(int rowIdx)
        {
            frmAttribute objAttrib = new frmAttribute(this);

            objAttrib.LIMSTestID=dgTest.Rows[rowIdx].Cells["Lims_testid"].Value.ToString();
            objAttrib.LIMSTestName= dgTest.Rows[rowIdx].Cells["Lims_test_name"].Value.ToString();
            objAttrib.MachineTestName= dgTest.Rows[rowIdx].Cells["Machine_Test_name"].Value.ToString();
            objAttrib.MashineTestID= dgTest.Rows[rowIdx].Cells["Machine_testid"].Value.ToString(); 

            this.Hide();
            objAttrib.Show();
        }
    }
}