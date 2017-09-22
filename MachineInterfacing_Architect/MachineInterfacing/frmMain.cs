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
    public partial class frmMain : Form
    {
        frmLogin objLogin = new frmLogin();

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain( frmLogin objLog)
        {
            InitializeComponent();
            objLogin = objLog;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            objLogin.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            //frmSupplier objSupplier = new frmSupplier(this);

            //this.Hide();
            //objSupplier.Show();
        }

        private void btnInstrument_Click(object sender, EventArgs e)
        {
            //frmInstruments objInstrument= new frmInstruments(this);

            //this.Hide();
            //objInstrument.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //frmMachineTest objMachineTest= new frmMachineTest(this);

            //this.Hide();
            //objMachineTest.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            //frmSetting objSetting = new frmSetting(this);

            //this.Hide();
            //objSetting.Show();
        }
    }
}