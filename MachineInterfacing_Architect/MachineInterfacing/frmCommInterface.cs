using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Xml;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;
//using CrystalDecisions.Web;
using MI_BL;
using System.IO.Ports;
using System.Threading;
using MySql.Data.MySqlClient;

namespace MachineInterfacing
{
    public partial class frmCommInterface : Form
    {
        frmLogin objLogin = new frmLogin();
        bool inUse = false;
        private string AxsynData = "";
        private int VitrossLine=0;
        private string Roche902Data = "";
        private string CellDynRubyData = "";
        private string cobas_urine_analyzerdata = "";
        private static string DSerialNos = "";

        private static int framenumber = 0;
        public frmCommInterface()
        {
            InitializeComponent();
        }

        public frmCommInterface(frmLogin objLog)
        {
            InitializeComponent();
            objLogin = objLog;
        }

        private void frmCommInterface_Load(object sender, EventArgs e)
        {
            
           
            SComponents objComp = new SComponents();
            
            objComp.ApplyStyleToControls(this);
            this.Text += " (" + clsSharedVariable.UserName + " )";
            lblToday.Text = "Today ( " + DateTime.Now.ToString("D") + " " + DateTime.Now.ToLongTimeString() + " )";
            lblMachineName.Text = "Machine Name : " + clsSharedVariable.InstrumentName;
            //FillcmbInstrument();
            GetTodayTotalTest();
            GetTodayDetailTest();
            //WeeklyGraph();
            //MonthlyGraph();
            ////StartInterfaceData();
            if (clsSharedVariable.InstrumentID.Equals("9"))//Imulite2000
            {
                timerImmulite.Enabled = true;
                timerImmulite.Interval = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["ImmuliteRefereshTime"].ToString());
            }
            else
            {
                timerImmulite.Enabled = false;
                ConnectPort();
            }
            if (clsSharedVariable.InstrumentID.Equals("17"))
            {
                Port.DiscardNull = true;
            }

            timer1.Interval = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["ReconnectTime"].ToString());
            
            objComp = null;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Top = 0;
            this.Left = 0;
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
                //objComp.FillComboBox(cmbInstrument, dv, "Instrument_Name", "InstrumentID", false, false);
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

        private void GetTodayTotalTest()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLBooking objBooking = new clsBLBooking(objConnection);
            try
            {
                objConnection.Connection_Open();
                objBooking.InstrumentID = clsSharedVariable.InstrumentID;
                lblTodayTestCount.Text = "Total Test : ( " + objBooking.GetAll(2).Table.Rows[0]["TestCount"].ToString() + " ) ";

            }
            catch (Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Count Today Test : " + exc.Message);
                //MessageBox.Show(exc.Message, "Count Today Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objBooking = null;
            }
        }

        private void GetTodayDetailTest()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLBooking objBooking = new clsBLBooking(objConnection);
            DataView dv = new DataView();
            try
            {
                objConnection.Connection_Open();
                objBooking.InstrumentID = clsSharedVariable.InstrumentID;
                dv = objBooking.GetAll(3);
                dgTodaySummary.DataSource = dv;
            }
            catch (Exception exc)
            {
                //MessageBox.Show(exc.Message, "Count Today Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Today Detail Test : " + exc.Message);
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objBooking = null;
            }
        }

        private void cmbInstrument_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTodayTotalTest();
            GetTodayDetailTest();
        }

        private void WeeklyGraph()
        {
            //clsBLDBConnection objConnection = new clsBLDBConnection();
            //clsBLBooking objBooking = new clsBLBooking(objConnection);
            //DataView dv = new DataView();
            //ReportDocument report = (ReportDocument)crvWeek.ReportSource;
            //if (report == null)
            //{
            //    report = new ReportDocument();
            //}

            //objBooking.InstrumentID = clsSharedVariable.InstrumentID + " and date_format( m.enteredon,'%m/%Y' )='" + DateTime.Now.ToString("MM/yyyy") + "' group by CEILING (day(m.enteredon)/7) ";

            //objBooking.Test_Name = " cast(concat('week', CEILING (day(m.enteredon)/7)) as char) as day ";

            //try
            //{
            //    objConnection.Connection_Open();
            //    dv = objBooking.GetAll(4);

            //    report.Load("Reports/WeekGraph.rpt");
            //    //AppSettingsReader con = new AppSettingsReader();
            //    //string userName = con.GetValue("susername", "".GetType()).ToString();
            //    //string pwd = con.GetValue("spassword", "".GetType()).ToString();
            //    //string serverName = con.GetValue("sserver", "".GetType()).ToString();
            //    //string sdb = con.GetValue("sdb", "".GetType()).ToString();

            //    report.SetDatabaseLogon(clsSharedVariable.dbUserName, clsSharedVariable.dbPWD, "localhost", "mi");
            //    //report.SetDatabaseLogon("root", "123", "localhost", "mi");
            //    report.SetDataSource(dv.Table);
            //    crvWeek.ReportSource = report;
            //}
            //catch (Exception exc)
            //{
            //    writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Weekly Summary : " + exc.Message);
            //    //MessageBox.Show(exc.Message, "Weekly Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    objConnection.Connection_Close();
            //    objConnection = null;
            //    objBooking = null;
            //    dv = null;
            //    report = null;
            //}
        }

        private void MonthlyGraph()
        {
            //clsBLDBConnection objConnection = new clsBLDBConnection();
            //clsBLBooking objBooking = new clsBLBooking(objConnection);
            //DataView dv = new DataView();
            //ReportDocument report = (ReportDocument)crvMonth.ReportSource;
            //if (report == null)
            //{
            //    report = new ReportDocument();
            //}
            
            //objBooking.InstrumentID = clsSharedVariable.InstrumentID + " and date_format( m.enteredon,'%m/%Y' )='" + DateTime.Now.ToString("MM/yyyy") + "' group by day(m.enteredon) ";

            //objBooking.Test_Name = " day(m.enteredon) as day ";

            //try
            //{
            //    objConnection.Connection_Open();
            //    dv = objBooking.GetAll(4);

            //    report.Load("Reports/MonthGraph.rpt");
            //    //report.SetDatabaseLogon("root", "123", "localhost", "mi");
            //    report.SetDatabaseLogon(clsSharedVariable.dbUserName, clsSharedVariable.dbPWD, "localhost", "mi");
            //    report.SetDataSource(dv.Table);
            //    crvMonth.ReportSource = report;
            //}
            //catch (Exception exc)
            //{
            //    writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Monthly Summary : " + exc.Message);
            //    //MessageBox.Show(exc.Message, "Monthly Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    objConnection.Connection_Close();
            //    objConnection = null;
            //    objBooking = null;
            //    dv = null;
            //    report = null;
            //}
        }

        private void lbtnRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            
            GetTodayTotalTest();
            GetTodayDetailTest();
            //WeeklyGraph();
            //MonthlyGraph();
            lblToday.Text = "Today ( " + DateTime.Now.ToString("D") + " " + DateTime.Now.ToLongTimeString() + " )";
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            //if (pbComm.Value == pbComm.Maximum)
            //{
            //    pbComm.Value = pbComm.Minimum;
            //}
            //pbComm.PerformStep();
            ConnectPort();
        }

        private void ConnectPort()
        {
            try
            {
                if (Port.IsOpen)
                {
                    Port.Close();
                    btnStatus.Text = "Disconnected";
                    btnStatus.BackColor = Color.Red;
                }
                else
                {
                    Port.BaudRate = int.Parse(clsSharedVariable.BaudRate);
                    Port.DataBits = int.Parse(clsSharedVariable.DataBit);
                    Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), clsSharedVariable.Stopbit);
                    Port.Parity = (Parity)Enum.Parse(typeof(Parity), clsSharedVariable.Parity);
                    Port.PortName = clsSharedVariable.PORT;
                    Port.Handshake = Handshake.None; ;
                    //Port.ReadTimeout = 1100;
                    //Port.WriteTimeout = 1100;



                    //Port.RtsEnable = true;

                    //Port.DtrEnable = true;
                 

                    Port.Open();
                    btnStatus.Text = "Connected";
                    btnStatus.BackColor = Color.Green;
                }
            }
            catch (Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Connection : " + exc.Message);
                //MessageBox.Show(exc.Message, "Open Port333", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // Read all the data waiting in the buffer
            this.Invoke(new EventHandler(DoDataReceived));
           
        }

        private void DoDataReceived(object s, EventArgs e)
        {
            //byte[] send = new byte[1];
            //send[0] = 0x06;
            //Port.Write(send, 0, 1);

            string data = "";
            inUse = true;
            //System.Threading.Thread.Sleep(2000);
            #region Dimension
            if (clsSharedVariable.InstrumentName.Equals("Dimension RxL"))
            {
                data = Port.ReadTo("\r\n");
                InsertBooking(data);
            }
            #endregion

            #region AXsym
            else if (clsSharedVariable.InstrumentName.Equals("AxSYM Plus"))
            {

                data = Port.ReadExisting();
                AxsynData += data;
                Port.Write(new byte[] { 0x06 }, 0, 1);

                if (data.Contains("L|1"))
                {
                    data = AxsynData;
                    AxsynData = "";

                    string[] del = { "O|", "1H|" };
                    string[] p = data.Split(del, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i <= p.GetUpperBound(0); i++)
                    {
                        if (p[i].Contains("^^F"))
                        {
                            FillAxsymData(p[i]);
                        }
                    }
                }
            }
            #endregion

            #region Architecture
            else if (clsSharedVariable.InstrumentName.Equals("Architect i 1000 SR System"))
            {
                data = Port.ReadExisting();
                AxsynData += data;
                Port.Write(new byte[] { 0x06 }, 0, 1);

                if (data.Contains("L|1"))
                {
                    data = AxsynData;
                    AxsynData = "";

                    data = data.Replace("S/CO", "S/CP");

                    string[] del = { "O|", "1H|" };
                    string[] p = data.Split(del, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i <= p.GetUpperBound(0); i++)
                    {
                        if (p[i].Contains("^^F"))
                        {
                            data = data.Replace("S/CP", "S/CO");
                            FillArchData(p[i]);
                        }
                    }
                }
            }
            #endregion

            #region Elecsys

            else if (clsSharedVariable.InstrumentName.Equals("Elecsys2010"))
            {
                data = Port.ReadExisting();
                AxsynData += data;
                Port.Write(new byte[] { 0x06 }, 0, 1);

                if (data.Contains("L|1"))
                {
                    data = AxsynData;
                    AxsynData = "";

                    string labid = "";
                    string Sendon = "";

                    string[] Del1 ={ "|", "^", "\r" };
                    string[] MSplitData;

                    string[] del = { "\r\n" };
                    string[] p = data.Split(del, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i <= p.GetUpperBound(0); i++)
                    {
                        if (p[i].Contains("O|"))
                        {
                            MSplitData = p[i].Split(Del1, StringSplitOptions.RemoveEmptyEntries);
                            labid = MSplitData[2].Trim();//labid
                            if (MSplitData[10].Trim().Length > 10)
                            {
                                Sendon = MSplitData[10].Trim().Substring(6, 2) + "/" + MSplitData[10].Trim().Substring(4, 2) + "/" + MSplitData[10].Trim().Substring(0, 4) + " " + MSplitData[10].Trim().Substring(8, 2) + ":" + MSplitData[10].Trim().Substring(10, 2);//SendOnsub
                            }
                            Sendon = DateTime.ParseExact(Sendon, "dd/MM/yyyy HH:mm", null).ToString("dd/MM/yyyy hh:mm tt");//SendOn

                        }
                        if (p[i].Contains("|F|"))
                        {
                            //if (i + 2 < p.GetUpperBound(0) && p[i + 2].Contains("C|"))
                            //{
                            //    FillElecsys(p[i], labid, Sendon, p[i + 2]);
                            //    i =' i + 2;
                            //}
                            //else
                            {
                                FillElecsys(p[i], labid, Sendon, "");
                            }
                        }
                    }
                }
            }
            #endregion

            #region Vitros ECi
            if (clsSharedVariable.InstrumentName.Equals("Vitros ECi"))
            {
                string[] del = { " ", "\n" };

                data = Port.ReadTo("\r\n");
                AxsynData += data;

                if (data.Contains(VitrossLine.ToString() + "h"))
                {
                    data = AxsynData;
                    AxsynData = "";
                    VitrossLine = 0;

                    if (!data.Equals(""))
                    {
                        //FillVitrosData(main[j]);
                        FillVitrosData(data);
                    }
                }
                else
                {
                    VitrossLine++;
                }
                //string[] main = data.Split(del, StringSplitOptions.RemoveEmptyEntries);

                //for (int j = 0; j <= main.GetUpperBound(0); j++)
                {

                }
            }
            #endregion

            #region"Hitachi 902"
            if (clsSharedVariable.InstrumentName.Equals("Hitachi902"))
            {
                data = Port.ReadExisting();
                Roche902Data += data;

                if (data.Split(' ').Length > 5)
                {
                    data = Roche902Data;
                    Roche902Data = "";

                    FillHitachi_902(data);
                }
            }
            #endregion

            #region"Hitachi 912"
            if (clsSharedVariable.InstrumentName.Equals("Hitachi912"))
            {
                data = Port.ReadExisting();
                Roche902Data += data;

                if (data.Split(' ').Length > 5)
                {
                    data = Roche902Data;
                    Roche902Data = "";

                    FillHitachi_912(data);
                }
            }
            #endregion

            #region"CellDyn Ruby"
            if (clsSharedVariable.InstrumentName.Equals("Cell-Dyn Ruby"))
            {
                data = Port.ReadExisting();
                //if (data.Contains("L|1|N"))
                //{
                //    CellDynRubyData = "";
                //}
                if (data.Contains(Convert.ToChar(6).ToString()))
                {
                    Port.Write(new byte[] { 0x04 }, 0, 1);
                    updatedatabase();
                }
                CellDynRubyData += data;
                Port.Write(new byte[] { 0x06 }, 0, 1);
                string[] s1 ={ "L|1|N" };
                string[] cont1 =CellDynRubyData.Split(s1, StringSplitOptions.RemoveEmptyEntries);

                for (int arr = 0; arr <= cont1.GetUpperBound(0); arr++)
                {
                    if (cont1[arr].Contains("R|22|"))
                    {

                        data = CellDynRubyData;
                        CellDynRubyData = "";
                        FillCellDyn_Ruby(cont1[arr]);

                    }
                    else if (cont1[arr].Contains("1H"))
                        CellDynRubyData += cont1[arr];
                }
            }
            #endregion


            #region"SYSmex CA-500"
            if (clsSharedVariable.InstrumentName.Equals("Sysmex CA-500"))
            {
                data = Port.ReadExisting();
                Roche902Data += data;
                if (Roche902Data.Split('').Length > 1 && Roche902Data.Contains("M"))
                {
                    data = Roche902Data;
                    
                    FillSysmax_CA500(data);
                    Roche902Data = "";
                    //FillHitachi_902(data);
                }
            }
            #endregion

            #region "cobas_E411"
            if (clsSharedVariable.InstrumentName.Equals("cobas e 411"))
            {
                data = Port.ReadExisting();
                Port.Write(new byte[] { 0x06 }, 0, 1);
                if (data.Length > 0)
                {
                    cobas_urine_analyzerdata += data;
                    if (cobas_urine_analyzerdata.Contains("L|1"))
                    {
                        data = cobas_urine_analyzerdata;
                        Fillcobas(data);
                        cobas_urine_analyzerdata = "";
                    }
                }
            }
            #endregion
            Log(0, data);
           
                RefreshForm();
         
            inUse = false;
        }

        private void Log(int i, string msg)
        {
            rtfTerminal.Invoke(new EventHandler(delegate
            {
                rtfTerminal.SelectedText = string.Empty;
                rtfTerminal.SelectionFont = new Font(rtfTerminal.SelectionFont, FontStyle.Bold);
                if (i == 0)
                {
                    rtfTerminal.SelectionColor = Color.Green;
                    msg = msg;
                }
                else if (i == 1)
                {
                    rtfTerminal.SelectionColor = Color.Blue;
                    msg = "Send : " + msg;
                }
                else if (i == 2)
                {
                    rtfTerminal.SelectionColor = Color.Red;
                }
                rtfTerminal.AppendText(msg);
                rtfTerminal.ScrollToCaret();

            }));
        }

        private void frmCommInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ReportDocument rpt = (ReportDocument)crvMonth.ReportSource;

            //if (rpt != null)
            //{
            //    rpt.Close();
            //    rpt.Dispose();
            //    rpt = null;
            //}

            //rpt = (ReportDocument)crvWeek.ReportSource;

            //if (rpt != null)
            //{
            //    rpt.Close();
            //    rpt.Dispose();
            //    rpt = null;
            //}

            if (Port.IsOpen)
            {
                Port.Close();
            }
            Port.Dispose();

            GC.Collect();

            objLogin.Show();
            this.Dispose();
        }

        private void miSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier objSupplier = new frmSupplier(this);

            this.Hide();
            objSupplier.Show();
        }

        private void miInstrument_Click(object sender, EventArgs e)
        {
            frmInstruments objInstrument = new frmInstruments(this);

            this.Hide();
            objInstrument.Show();
        }

        private void miTest_Click(object sender, EventArgs e)
        {
            frmMachineTest objMachineTest = new frmMachineTest(this);

            this.Hide();
            objMachineTest.Show();
        }

        private void miSetting_Click(object sender, EventArgs e)
        {
            frmSetting objSetting = new frmSetting(this);

            this.Hide();
            objSetting.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (!Port.IsOpen)
            //{
            //    ConnectPort();
            //}

            //if (pbComm.Value == pbComm.Maximum)
            //{
            //    pbComm.Value = pbComm.Minimum;
            //}
            //pbComm.PerformStep();
            this.Invoke(new EventHandler(UpdateInterfceData));
           // StartInterfaceData();
        }

        private string[] ParseData(string msg)
        {
            //0 PatinetID
            //1 Seq No
            //2 Batch #
            //3 Labid
            //4 sample Type
            //5 AttributeCode
            //6 SendOn
            //7 Result
            //8 ReceivedOn
            //9 BookingID
            //10    AttributeID
          

            string[] str=new string[11] ;
            if (clsSharedVariable.InstrumentID.Equals("10"))//Dimnsion RXL
            {
                char[] Delimeter ={ ' ' };
                str = msg.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);
                str[0] = "";
                str[2] = "";
                str[4] = "";
                str[6] = "";
                str[8] = "";
                str[9] = "";
            }
            if (clsSharedVariable.InstrumentID.Equals("17"))//Vitros
            {
                char[] Delimeter ={ ' ' };
                str = msg.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);
            }
            if (clsSharedVariable.InstrumentID.Equals("9"))//Imulite2000
            {
                string[] Delimeter ={ " , " };
                str = msg.Split(Delimeter, StringSplitOptions.None);
                str[0] = "";
                str[1] = "";
                str[2] = "";
                str[4] = "";
                str[8] = "";
               
            }

            return str;
        }

        private void InsertBooking(string Msg)
        {
            MySqlConnection objConn = new MySqlConnection("Server = localhost; Port = 3306; Database = mi; Uid = " + clsSharedVariable.dbUserName + "; Pwd = " + clsSharedVariable.dbPWD + "");
            //MySqlConnection objConn = new MySqlConnection("Server = localhost; Port = 3306; Database = MI; Uid = root; Pwd = 123");
            MySqlCommand objCmd= new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(objCmd);
            DataSet DS = new DataSet();
            string myquerystring="";
            string EnteredOn = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            
            string[] str = { "","","","","","",""};//BookingID,LABID,SendOn,ReceivedOn,Result,AttributeCode,AttributeID

            str[3]=DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            ///
            /// Create Quries for Selected Machine
            /// 
            try
            {
                objConn.Open();
                objCmd.Connection = objConn;

                #region Dimnsion RXL
                if (clsSharedVariable.InstrumentID.Equals("10"))//Dimnsion RXL
                {
                    char[] Delimeter ={ ' ' };
                    string[] Tmp = Msg.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);
                   
                    str[1] = Tmp[3].Trim();//Labid
                    if (Tmp[6].Equals("A"))
                    {
                        str[4] = Tmp[7].Trim();//Result
                    }
                    else if (Tmp[6].Equals("Q")) 
                    {
                        if (Tmp[7].Trim().Equals("16"))
                        {
                            str[4] = "Below asy rng";
                        }
                        else if ( Tmp[7].Trim().Equals("11"))
                        {
                            str[4] = "Process Over";
                        }
                        else if (Tmp[7].Trim().Equals("10"))
                        {
                            str[4] = "Aborted Test";
                        }
                        else if (Tmp[7].Trim().Equals("09"))
                        {
                            str[4] = "No Reagent";
                        }
                    }
                        
                    str[5] = Tmp[5].Trim();//AttributeCode
                }
                #endregion

                #region Vitros
                else if (clsSharedVariable.InstrumentID.Equals("17"))//Vitros 17
                {
                    string[] Delimeter ={ " , " };
                    string[] Tmp = Msg.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);

                    str[1] = Tmp[0].Trim();//Labid
                    str[4] = Tmp[3].Trim();//Result
                    str[5] = Tmp[2].Trim();//AttributeCode
                    str[2] = Tmp[1];//sendon
                }
                #endregion

                #region Imulite2000

                else if (clsSharedVariable.InstrumentID.Equals("9"))//Imulite2000
                {
                    char[] Delimeter ={ ',' };
                    string []Tmp = Msg.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);

                    str[1]=Tmp[0].Trim();//LABID
                    str[5] = Tmp[1].Trim();//AttributeCode
                    str[2] = DateTime.Parse(Tmp[2].Trim()).ToString("dd/MM/yyyy hh:mm tt");//SendOn
                    str[4] = Tmp[3].Trim();//Result
                }
                #endregion

                #region Axsym and Architecture

                else if (clsSharedVariable.InstrumentID.Equals("3") || clsSharedVariable.InstrumentID.Equals("4"))//Axsym
                {
                    string[] Delimeter = { " , " };
                    //writeLog("Message to be parsed:"+Msg);
                    string[] Tmp = Msg.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);
                    
                    try
                    {
                        str[1] = Tmp[0].Trim();//Labid
                        
                        str[4] = Tmp[3].Trim();//Result
                        str[5] = Tmp[1].Trim();//AttributeCode
                        str[2] = Tmp[2];//sendon
                    }
                    catch(Exception exc)
                    {
                        writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : str parsing : "+exc.ToString().Trim());
                    }
                }
                #endregion

                #region Elecsys

                else if (clsSharedVariable.InstrumentID.Equals("5"))//Elecsys
                {
                    string[] Delimeter = { " , " };
                    string[] Tmp = Msg.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);

                    str[1] = Tmp[0].Trim();//Labid
                    str[4] = Tmp[3].Trim();//Result
                    str[5] = Tmp[2].Trim();//AttributeCode
                    str[2] = Tmp[1];
                }
                #endregion

                #region Hitachi 902

                if (clsSharedVariable.InstrumentID.Equals("7"))//hitachi 902
                {
                    string[] Delimeter ={ " , " };
                    string[] Tmp = Msg.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);

                    str[1] = Tmp[0].Trim();//Labid
                    str[4] = Tmp[3].Trim();//Result
                    str[5] = Tmp[1].Trim();//AttributeCode
                    str[2] = Tmp[2];//sendon
                }
                #endregion

                #region CellDyn Ruby

                if (clsSharedVariable.InstrumentID.Equals("18"))//CellDyn Ruby
                {
                    string[] Delimeter ={ " , " };
                    string[] Tmp = Msg.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);
                    
                    //if (Tmp[0].Trim().Length > 6)
                    //{
                    //    str[1] = Tmp[0].Substring(Tmp[0].Length - 5,5).Trim();//Lab ID//if labid is read from bar code then barcode will read e.g 120010209605 if case is used to get the last 6 characters of the lab id as already being used in the system
                    //}
                    //else
                    //{
                    //    str[1] = Tmp[0].Trim();//Labid
                    //}
                    str[1] = Tmp[0].Trim();
                    str[4] = Tmp[2].Trim();//Result
                    str[5] = Tmp[1].Trim();//AttributeCode
                    if (str[5] == "9")
                    {
                        double intvalueHCT = Convert.ToDouble(str[4]) / 100;
                        str[4] = intvalueHCT.ToString();
                    }
                    if (str[4].Substring(0, 1).Equals("."))
                    {
                        str[4] = "0" + str[4];

                    }
                    if (str[4].Substring(str[4].Length - 1, 1).Equals("."))
                    {
                        str[4] = str[4].Substring(0,str[4].Length-1);
                    }
                    System.Globalization.CultureInfo ct = new System.Globalization.CultureInfo("ur-PK");
                    //DateTime dt = DateTime.ParseExact(Tmp[3].Trim(),"dd/MM/yyyy HH:mm",ct);
                    str[2] = Tmp[3].Trim();//sendon
                }
                #endregion


                #region Sysmex CA-500

                if (clsSharedVariable.InstrumentID.Equals("19"))//hitachi 902
                {
                    string[] Delimeter ={ " , " };
                    string[] Tmp = Msg.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);

                    str[1] = Tmp[0].Trim();//Labid
                    str[4] = Tmp[3].Trim();//Result
                    str[5] = Tmp[1].Trim();//AttributeCode
                    str[2] = Tmp[2];//sendon
                }
                #endregion

                #region "Cobas E411"
                if (clsSharedVariable.InstrumentID.Equals("21"))//cobas e 411
                {
                    string[] Delimeter = { "," };
                    string[] Tmp = Msg.Split(Delimeter, StringSplitOptions.RemoveEmptyEntries);

                    str[1] = Tmp[0].Trim();//Labid
                    str[4] = Tmp[3].Trim();//Result
                    str[5] = Tmp[1].Trim();//AttributeCode
                    str[2] = Tmp[2];//sendon
                }
                #endregion

                if (!IsNaturalNumber(str[1].Trim()))
                {
                    return;
                }

                myquerystring = "SELECT a.attributeid,a.MachineAttributeCode,t.Machine_Test_name, t.Machine_testid,t.MachineTestCode, t.Instrumentid,b.bookingid FROM mi_ttestattribute a,mi_ttests t left outer join mi_tbooking b on b.Machine_TestID=t.Machine_TestID and b.labid='" + str[1].Trim() + "' and b.Test_code='" + str[5].Trim() + "' where a.Machine_TestID=t.Machine_TestID and a.MachineAttributeCode='" + str[5].Trim() + "'  and t.Instrumentid="+clsSharedVariable.InstrumentID+"";

                objCmd.CommandText = myquerystring;
                da.Fill(DS, "TestInfo");

                if (DS.Tables[0].Rows.Count > 0)
                {
                    str[0] = DS.Tables["TestInfo"].Rows[0]["BookingID"].ToString();
                    if (str[0].Equals(""))
                    {
                        myquerystring = "INSERT INTO mi_tbooking(LABID,Test_Code,Machine_TestID,Test_name,InstrumentID,EnteredBy,EnteredOn,ClientID";
                        if (!str[2].Equals(""))
                        {
                            myquerystring += ",SendON";
                        }
                        if (!str[3].Equals(""))
                        {
                            myquerystring += ",ReceivedON";
                        }
                        myquerystring += ",Active) VALUES('" + str[1].Trim() + "','" + DS.Tables["TestInfo"].Rows[0]["MachineTestCode"].ToString() + "','" + DS.Tables["TestInfo"].Rows[0]["Machine_testid"].ToString() + "','" + DS.Tables["TestInfo"].Rows[0]["Machine_Test_name"].ToString() + "','" + DS.Tables["TestInfo"].Rows[0]["Instrumentid"].ToString() + "'," + clsSharedVariable.PersonID + ",str_to_date('" + EnteredOn + "','%d/%m/%Y %h:%i %p')  ,'" + clsSharedVariable.ClientID + "'";
                        if (!str[2].Equals(""))
                        {
                            myquerystring += ",str_to_date('" + str[2].Trim() + "','%d/%m/%Y %h:%i %p')";
                        }
                        if (!str[3].Equals(""))
                        {
                            myquerystring += ",str_to_date('" + str[3].Trim() + "','%d/%m/%Y %h:%i %p')";
                        }
                        myquerystring += ",'Y')";
                    }
                    str[6] = DS.Tables["TestInfo"].Rows[0]["attributeid"].ToString();
                }

                if (!str[6].Equals(""))
                {
                    if (str[0].Equals(""))
                    {
                        objCmd.CommandText = myquerystring;
                        objCmd.ExecuteNonQuery();

                        myquerystring = "SELECT ifnull(max(bookingid),1) as bookingid FROM mi_tbooking m";
                        objCmd.CommandText = myquerystring;

                        da.Fill(DS, "BookingID");
                        str[0] = DS.Tables["BookingID"].Rows[0]["bookingid"].ToString();
                    }
                    myquerystring = "SELECT Resultid FROM mi_tresult m where bookingID=" + str[0] + " and AttributeID=" + str[6];
                    objCmd.CommandText = myquerystring;
                    
                    da.Fill(DS, "ResultDup");

                    if (DS.Tables["ResultDup"].Rows.Count == 0)
                    {
                        myquerystring = "INSERT INTO mi_tresult(BookingID, AttributeID, Result, EnteredBy, EnteredOn, ClientID, Status ) values(" + str[0] + "," + str[6] + ",'" + str[4] + "'," + clsSharedVariable.PersonID + ",str_to_date('" + EnteredOn + "','%d/%m/%Y %h:%i %p')  ,'" + clsSharedVariable.ClientID + "','0' )";

                        objCmd.CommandText = myquerystring;
                        objCmd.ExecuteNonQuery();

                        //System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

                        //GetTodayTotalTest();
                        //GetTodayDetailTest();
                       // WeeklyGraph();
                       // MonthlyGraph();

                        //System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = true ;
                    }
                }
            }
            catch (Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Insert Booking : " + exc.Message);
               // MessageBox.Show(exc.Message);
            }
            finally 
            {
                objConn.Close();
                lblToday.Tag = "";
            }
        }

        private bool IsNaturalNumber(string strNumber)
        {
            System.Text.RegularExpressions.Regex objNotNaturalPattern = new System.Text.RegularExpressions.Regex("[^0-9]");
            System.Text.RegularExpressions.Regex objNaturalPattern = new System.Text.RegularExpressions.Regex("0*[1-9][0-9]*");
            return !objNotNaturalPattern.IsMatch(strNumber) &&
                objNaturalPattern.IsMatch(strNumber);
        }

        private bool InsertResult(string Result, string BookingID, string AttributeID, clsBLDBConnection objConnection)
        {
            clsBLResult objRes = new clsBLResult(objConnection);
            try
            {
                objRes.BookingID = BookingID;
                objRes.AttributeID = AttributeID;
                objRes.Result = Result;
                objRes.EnteredBy = clsSharedVariable.PersonID;
                objRes.EnteredOn = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                objRes.ClientID = clsSharedVariable.ClientID;
                objRes.Status = "0";

                if (objRes.Insert())
                {
                    return true;
                }
                else
                {
                    //writeLog("Result Record is not Insert...( " + objRes.StrErr + " )");
                    writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Insert Result : " + objRes.StrErr);
                    return false;
                }
            }
            catch (Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Insert Result : " + exc.Message); 
                return false;
            }
            finally
            {
                objRes = null;
            }
        }

        private clsBLBooking SetBL(clsBLBooking objBooking, string[] str)
        {
            objBooking.PatientID = str[0].Trim();
            objBooking.Patient_name = "";
            objBooking.LabID = str[3].Trim();

            objBooking.MachineAttributeCode = str[5].Trim();

            DataView dv = GetTestInfo(objBooking);

            if (dv.Table.Rows.Count > 0)
            {
                objBooking.Test_Code = dv.Table.Rows[0]["MachineTestCode"].ToString();
                objBooking.Machine_TestID = dv.Table.Rows[0]["Machine_testid"].ToString();
                objBooking.Test_Name = dv.Table.Rows[0]["Machine_Test_name"].ToString();
                objBooking.InstrumentID = dv.Table.Rows[0]["Instrumentid"].ToString();
                lblToday.Tag = dv.Table.Rows[0]["attributeid"].ToString();
            }

            objBooking.Machine_Time = "";
            objBooking.SeqID = str[1].Trim();
            objBooking.BatchNo = str[2];

            objBooking.Sample_Type = str[4];

            objBooking.EnteredBy = clsSharedVariable.PersonID;
            objBooking.EnteredOn = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            objBooking.ClientID = clsSharedVariable.ClientID;
            objBooking.Active = "Y";


            if (str[6].Trim().Equals(""))
            {
                objBooking.SendOn ="";
            }
            else
            {
                objBooking.SendOn = DateTime.Parse(str[6]).ToString("dd/MM/yyyy hh:mm tt");
            }
            

            if (str[8].Trim().Equals(""))
            {
                objBooking.RecievedOn = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            }
            else
            {
                objBooking.RecievedOn = DateTime.Parse(str[8]).ToString("dd/MM/yyyy hh:mm tt");
            }

            return objBooking;
        }

        //Get Test Info according to Selected attributeCode
        private DataView GetTestInfo(clsBLBooking objBooking)
        {
            DataView dv = new DataView();

            dv = objBooking.GetAll(5);

            return dv;
        }

        private string GetBookingID(clsBLBooking objBooking)
        {
            DataView dv = new DataView();

            dv = objBooking.GetAll(6);

            return dv.Table.Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] del = { "!000a02" };

            string data = System.IO.File.ReadAllText("2.txt");
            string[] main = data.Split(del, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j <= main.GetUpperBound(0); j++)
            {
                FillVitrosData(main[j]);
            }

            //string[] p = data.Split(del, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < p.GetUpperBound(0); i++)
            //{
            //    FillAxsymData(p[i],str);
                
            //}



           //string[] del = { "6001\n\n" };


           
            

            //string data = System.IO.File.ReadAllText("Vitros.txt");
            //string[] str = { "", "", "", "", "", "", "" };//BookingID,LABID,SendOn,ReceivedOn,Result,AttributeCode,

            //string[] p = data.Split(del, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < p.GetUpperBound(0); i++)
            //{
            //    FillVitrosData(p[i], str);
            //}



            //InsertBooking(data);
            //Log(0, data);

            //StartInterfaceData();
            //GetImmuliteDataFromAccess();

            //string data = System.IO.File.ReadAllText("Vitros.txt");

            //string[] p = data.Split(del, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i <= p.GetUpperBound(0); i++)
            //{
            //    FillVitrosData(p[i].Trim());
            //}
        }

        private void rtfTerminal_TextChanged(object sender, EventArgs e)
        {
            ////GetTodayTotalTest();
            ////GetTodayDetailTest();
            ////WeeklyGraph();
            ////MonthlyGraph();
        }

        private void writeLog(string msg)
        {
            System.IO.TextWriter trLog = new System.IO.StreamWriter("Error.txt",true);
            trLog.Write(msg+"\n");
            trLog.Close();
        }

        private void writemycheckdata(string msg)
        {
            System.IO.TextWriter trLog = new System.IO.StreamWriter("myfile.txt", true);
            trLog.Write(msg + "\n");
            trLog.Close();
        }

        private void StartInterfaceData()
        {
            //Thread th = new Thread(UpdateInterfceData);
            //th.Start();
        }

        private void UpdateInterfceData(object s, EventArgs e)
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLInterfaced objInterfaced = new clsBLInterfaced(objConnection);
            clsBLResult objRes = new clsBLResult(objConnection);

            DataView dv = new DataView();

            try
            {
                objConnection.Connection_Open();
                dv = objInterfaced.GetAll(1);

                objConnection.OraConnection_Open();

                //dgTodaySummary.Columns[0].DefaultCellStyle.fo
                DataView dvLIMSAttribID = new DataView();

                for (int i = 0; i < dv.Table.Rows.Count; i++)
                {
                    objInterfaced.LimsAttributeID = dv.Table.Rows[i]["limsattributeid"].ToString();
                    dvLIMSAttribID = objInterfaced.GetAllOra(1);
                    if (dvLIMSAttribID.Table.Rows.Count != 0)
                    {
                        objInterfaced.Interfaceid = dvLIMSAttribID.Table.Rows[0][0].ToString();
                    }
                    else
                    {
                        objInterfaced.Interfaceid = "-1";
                    }
                    
                    objInterfaced.MSerialNo = dv.Table.Rows[i]["LabID"].ToString();
                    objInterfaced.Value = dv.Table.Rows[i]["Result"].ToString();

                    
                    objConnection.OraTransaction_Begin();
                    if (objInterfaced.Insert())
                    {
                        objConnection.OraTransaction_ComRoll();
                    }
                    else
                    {
                        objConnection.OraTransaction_ComRoll();
                        writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Update Status flag: " + objInterfaced.StrErr); 
                    }
                    
                    objRes.Status = "1";
                    objRes.ResultID = dv.Table.Rows[i]["ResultiD"].ToString();
                    objConnection.Transaction_Begin();

                    if (objRes.Update())
                    {
                        objConnection.Transaction_ComRoll();
                    }
                    else
                    {
                        objConnection.Transaction_ComRoll();
                        writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Update Status flag: " + objRes.StrErr); 
                    }
                }
                objConnection.OraConnection_Close();
                objConnection.Connection_Close();
            }
            catch(Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Update Interface Data : " + exc.Message); 
            }
            finally
            {
                try
                {
                    objConnection.OraConnection_Close();
                }
                catch
                { }
                objConnection = null;

                objRes = null;
                objInterfaced = null;
            
            }
        }

        public  void WriteSetting(string key, string value)
        {
            // load config document for current assembly
            XmlDocument doc = loadConfigDocument();

            // retrieve appSettings node
            XmlNode node = doc.SelectSingleNode("//appSettings");

            if (node == null)
                throw new InvalidOperationException("appSettings section not found in config file.");

            try
            {
                // select the 'add' element that contains the key
                XmlElement elem = (XmlElement)node.SelectSingleNode(string.Format("//add[@key='{0}']", key));

                if (elem != null)
                {
                    // add value for key
                    elem.SetAttribute("value", value);
                }
                else
                {
                    // key was not found so create the 'add' element 
                    // and set it's key/value attributes 
                    elem = doc.CreateElement("add");
                    elem.SetAttribute("key", key);
                    elem.SetAttribute("value", value);
                    node.AppendChild(elem);
                }
                doc.Save("MachineInterfacing.exe.config");
            }
            catch(Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Write Setting : " + exc.Message); 
                //throw;
            }
        }

        private  XmlDocument loadConfigDocument()
        {
            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                doc.Load("MachineInterfacing.exe.config");
                return doc;
            }
            catch (System.IO.FileNotFoundException e)
            {
                throw new Exception("No configuration file found.", e);
            }
        }

        private void GetImmuliteDataFromAccess()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLMSAccessData objAccess = new clsBLMSAccessData(objConnection);
            DataView dv = new DataView();
            try
            {
                objConnection.AccessConnection_Open();
                if (clsSharedVariable.ImmuliteLastRec.Equals(""))
                {
                    objAccess.ID = System.Configuration.ConfigurationSettings.AppSettings["ImmuliteLastRecord"].
    ToString();
                }
                else
                {
                    objAccess.ID = clsSharedVariable.ImmuliteLastRec;
                }

                dv = objAccess.GetAll(1);
                for (int i = 0; i < dv.Table.Rows.Count; i++)
                {
                    string str = dv.Table.Rows[i]["Patid"].ToString() + " , " + dv.Table.Rows[i]["TName"].ToString() + " , " + dv.Table.Rows[i]["RecDTime"].ToString() + " , " + dv.Table.Rows[i]["TResult"].ToString() ;
                    InsertBooking(str);
                    Log(0, str);
                }
                if (dv.Table.Rows.Count > 0)
                {
                    WriteSetting("ImmuliteLastRecord", dv.Table.Rows[dv.Table.Rows.Count - 1]["ID"].ToString());
                    clsSharedVariable.ImmuliteLastRec = dv.Table.Rows[dv.Table.Rows.Count - 1]["ID"].ToString();
                }
            }
            catch (Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Immulite Data from Access : " + exc.Message); 
                //MessageBox.Show(exc.Message, "Get Immulite Data from Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objConnection.AccessConnection_Close();
                objConnection = null;
                objAccess= null;
            }
        }

        private void timerImmulite_Tick(object sender, EventArgs e) 
        {
            if (clsSharedVariable.InstrumentID.Equals("9"))//Imulite2000
            {
                GetImmuliteDataFromAccess();
            }
            if (!inUse)
            {
                if (clsSharedVariable.InstrumentID.Equals("3") || clsSharedVariable.InstrumentID.Equals("4") || clsSharedVariable.InstrumentID.Equals("5"))
                {

                    Port.Write(new byte[] { 0x06 }, 0, 1);
                }
            }
        }

        private void FillAxsymData(string data)
        {
            try
            {
                string[] Del ={ "\r\n" };
                string[] Del1 ={ "|", "^" ,"\r"};
                string[] SplitData;
                string[] MSplitData;
                string pars = "";

                if (data.Contains("^^F"))
                {
                    SplitData = data.Split(Del, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < SplitData.GetUpperBound(0); i++)
                    {
                        if (SplitData[i].Contains("UNDILUTED|R|"))
                        {
                            MSplitData = SplitData[i].Split(Del1, StringSplitOptions.RemoveEmptyEntries);

                            pars = MSplitData[1].Trim();//labid
                            pars += " , " + MSplitData[4].Trim();// AttributeCode 
                        }
                        else if (SplitData[i].Contains("^^F"))
                        {
                            string tempDate="";
                            MSplitData = SplitData[i].Split(Del1, StringSplitOptions.RemoveEmptyEntries);

                            if (MSplitData[10].Trim().Length > 10)
                            {
                                //pars += " , " + DateTime.Parse(MSplitData[10].Trim()).ToString("dd/MM/yyyy hh:mm tt");//SendOn
                                tempDate= MSplitData[10].Trim().Substring(6, 2) + "/" + MSplitData[10].Trim().Substring(4, 2) + "/" + MSplitData[10].Trim().Substring(0, 4) + " " + MSplitData[10].Trim().Substring(8, 2) + ":" + MSplitData[10].Trim().Substring(10, 2);//SendOnsub
                            }
                            else if (MSplitData[11].Trim().Length > 10)
                            {
                                tempDate= MSplitData[11].Trim().Substring(6, 2) + "/" + MSplitData[11].Trim().Substring(4, 2) + "/" + MSplitData[11].Trim().Substring(0, 4) + " " + MSplitData[11].Trim().Substring(8, 2) + ":" + MSplitData[11].Trim().Substring(10, 2);//SendOnsub
                            }

                            pars += " , " + DateTime.ParseExact(tempDate, "dd/MM/yyyy HH:mm", null).ToString("dd/MM/yyyy hh:mm tt");//SendOn
                            pars += " , " + MSplitData[6].Trim();//Result

                        }
                        else if (SplitData[i].Contains("^^I"))
                        {
                            MSplitData = SplitData[i].Split(Del1, StringSplitOptions.RemoveEmptyEntries);

                            pars += "(" + MSplitData[6].Trim() + ")";//Result
                        }
                    }
                    InsertBooking(pars);
                }
                
            }
            catch (Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Axsym Data : " + exc.Message); 
                //MessageBox.Show(exc.Message, "Axsys data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillArchData(string data)
        {
            try
            {
                writemycheckdata(data);
                string[] Del ={ "\r\n" };
                string[] Del1 ={ "|", "^", "\r" };
                string[] SplitData;
                string[] MSplitData;
                string pars = "";

                if (data.Contains("^^F"))
                {
                    SplitData = data.Split(Del, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < SplitData.GetUpperBound(0); i++)
                    {
                        if (SplitData[i].Contains("||||||||F")) //old conditions SplitData[i].Contains("1|") && (SplitData[i].Contains("^Z") || SplitData[i].Contains("^E"))
                        {
                            MSplitData = SplitData[i].Split(Del1, StringSplitOptions.RemoveEmptyEntries);

                            pars = MSplitData[2].Trim();//labid
                            pars += " , " + MSplitData[5].Trim();// AttributeCode 
                        }
                        else  if (SplitData[i].Contains("^^F"))
                        {
                            string tempDate = "";
                            MSplitData = SplitData[i].Split(Del1, StringSplitOptions.RemoveEmptyEntries);

                            try
                            {
                                if (MSplitData[14].Trim().Length > 10)
                                {
                                    tempDate = MSplitData[14].Trim().Substring(6, 2) + "/" + MSplitData[14].Trim().Substring(4, 2) + "/" + MSplitData[14].Trim().Substring(0, 4) + " " + MSplitData[14].Trim().Substring(8, 2) + ":" + MSplitData[14].Trim().Substring(10, 2);//SendOnsub
                                }
                                else if (MSplitData[15].Trim().Length > 10)//15
                                {
                                    tempDate = MSplitData[15].Trim().Substring(6, 2) + "/" + MSplitData[15].Trim().Substring(4, 2) + "/" + MSplitData[15].Trim().Substring(0, 4) + " " + MSplitData[15].Trim().Substring(8, 2) + ":" + MSplitData[15].Trim().Substring(10, 2);//SendOnsub
                                }
                                if (tempDate.Equals(""))
                                    tempDate = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm tt");
                                if (!tempDate.Equals(""))
                                {
                                    pars += " , " + DateTime.ParseExact(tempDate, "dd/MM/yyyy HH:mm", null).ToString("dd/MM/yyyy hh:mm tt");//SendOn
                                }
                            }
                            catch
                            {
                                pars += " , " + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                                tempDate = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                            }
                            
                            pars += " , " + MSplitData[9].Trim();//Result
                        }
                        else if (SplitData[i].Contains("^^I"))
                        {
                            MSplitData = SplitData[i].Split(Del1, StringSplitOptions.RemoveEmptyEntries);

                            pars += "(" + MSplitData[9].Trim() + ")";//Result
                        }
                    }
                    writemycheckdata("parsdata:" + pars);
                    InsertBooking(pars);
                }
            }
            catch (Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : ArchitectureData : " + exc.Message); 
                //MessageBox.Show(exc.Message, "Architecture data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillElecsys(string data,string LabID,string SendOn,string Err)
        {
            try
            {
                string[] Del1 ={ "|", "^", "\r" };
                string[] MSplitData;

                string[] ErrSplitData;

                string pars = "";

                        MSplitData = data.Split(Del1, StringSplitOptions.RemoveEmptyEntries);

                        pars = LabID;//labid
                        pars += " , " + SendOn;//SendOn
                        pars += " , " + MSplitData[2].Trim();// AttributeCode 

                        //if (!Err.Equals(""))
                        //{
                        //    ErrSplitData = Err.Split(Del1, StringSplitOptions.RemoveEmptyEntries);
                        //    pars += " , " + MSplitData[4].Trim() + " ( " +ErrSplitData[4].Trim() + " ) ";//Result
                        //}
                        //else
                        //{
                        if (MSplitData[4].Trim().Equals("-1"))
                        {
                            pars += " , " + MSplitData[5].Trim();//Result
                        }
                        else
                        {
                            pars += " , " + MSplitData[4].Trim();//Result
                        }
                        //}
                InsertBooking(pars);
            }
            catch (Exception exc)
            {
                //MessageBox.Show(exc.Message, "Axsys data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : ElecSys Data : " + exc.Message); 
            }
        }

        private void FillVitrosData(string data)
        {
            try
            {
                string[] Del ={ " ", "\n","!" };//Separator
                string[] SplitData;

                string pars = "";

                SplitData = data.Split(Del, StringSplitOptions.RemoveEmptyEntries);

                //if (SplitData[0].IndexOf("Vitros") != -1)
                {
                    //string DteTme = SplitData[0].Substring(SplitData[0].IndexOf("Vitros") + 6, 12);
                    //string DteTme = SplitData[0].Substring(SplitData[0].Length-12);
                    //str[1] = SplitData[0].Substring(SplitData[0].IndexOf("Vitros") + 18);

                    //str[2] = DateTime.ParseExact(DteTme.Substring(10, 2) + "/" + DteTme.Substring(8, 2) + "/20" + DteTme.Substring(6, 2) + " " + DteTme.Substring(0, 2) + ":" + DteTme.Substring(2, 2), "dd/MM/yyyy HH:mm", null).ToString("dd/MM/yyyy hh:mm tt");//SendOn
                    if (SplitData.GetUpperBound(0) > 11)
                    {
                        int i = 10;
                        do
                        {
                            pars = "";
                            string DteTme = SplitData[1].Substring(SplitData[1].IndexOf("Vitros") + 6, 12);

                            pars = SplitData[1].Substring(SplitData[1].IndexOf("Vitros") + 18);//labid
                            pars += " , " + DateTime.ParseExact(DteTme.Substring(10, 2) + "/" + DteTme.Substring(8, 2) + "/20" + DteTme.Substring(6, 2) + " " + DteTme.Substring(0, 2) + ":" + DteTme.Substring(2, 2), "dd/MM/yyyy HH:mm", null).ToString("dd/MM/yyyy hh:mm tt");//SendOn;//SendOn
                            

                            pars += " , " + SplitData[i].Substring(SplitData[i].IndexOf("f") + 1).Trim(); // AttributeCode 
                            i++;
                            pars += " , " + SplitData[i].Trim();//Result\
                            InsertBooking(pars);
                            i = i + 2;
                        }
                        while (SplitData[i].Contains("f"));
                       
                    }
                }
                //Result 
                //AttributeCode
            }
            catch (Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Vitros Data : " + exc.Message); 
                //MessageBox.Show(exc.Message, "Vitros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void FillHitachi_902(string data)
        {
            try
            {
                DataView dv = new DataView();

                string[] Sep ={ ":n" };
                string[] Sep1 ={ " " };
                string pars;
                string[] Rec = data.Split(Sep, StringSplitOptions.RemoveEmptyEntries);

                dv = GetAttribCodeFromChannel();
                if (dv == null)
                {
                    return;
                }

                for (int i = 0; i < Rec.Length; i++)
                {
                    string[] RecField = Rec[i].Split(Sep1, StringSplitOptions.RemoveEmptyEntries);

                    if (RecField.Length > 1)
                    {
                        try
                        {
                            for (int j = 3; j < RecField.Length - 1; j += 2)
                            {
                                pars = RecField[1].Substring(1);//labid
                                dv.RowFilter = "channel=" + RecField[j];
                                if (dv.Count == 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    pars += " , " + dv[0]["MachineAttributeCode"].ToString().Trim();// AttributeCode 
                                    pars += " , " + DateTime.Now.ToString("dd/MM/yyyy");//SendOn
                                    pars += " , " + RecField[j + 1];//ResultS
                                    InsertBooking(pars);
                                }

                            }
                        }
                        catch { }
                    }
                }
            }
            catch (Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Roche 902 Data : " + exc.Message);
                //MessageBox.Show(exc.Message, "Axsys data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillHitachi_912(string data)
        {

           try
            {
                DataView dv = new DataView();

                string[] Sep ={ ":q" };
                string[] Sep1 ={ " " };
                string pars = "";
                string[] Rec = data.Split(Sep, StringSplitOptions.RemoveEmptyEntries);

                //dv = GetAttribCodeFromChannel();
                //if (dv == null)
                //{
                //    return;
                //}

                for (int i = 0; i < Rec.Length; i++)
                {
                    string[] RecField = Rec[i].Split(Sep1, StringSplitOptions.RemoveEmptyEntries);

                    if (RecField.Length > 1)
                    {
                        try
                        {
                            pars = RecField[2].Substring(0);
                            if (RecField.Length > 9)
                            {
                                for (int j = 5; j < RecField.Length - 1; j += 2)
                                {
                                    pars = RecField[1].Substring(1);//labid
                                    //dv.RowFilter = "channel=" + RecField[j];
                                    //if (dv.Count == 0)
                                    //{
                                    //    continue;
                                    //}
                                    //else
                                    //{
                                   // pars += " , " + dv[0]["MachineAttributeCode"].ToString().Trim();// AttributeCode 
                                    pars += " , " + DateTime.Now.ToString("dd/MM/yyyy");//SendOn
                                    pars += " , " + RecField[j + 1].Substring(0);//ResultS
                                    //InsertBooking(pars);
                                    //}

                                }
                            }
                            else
                            {
                                for (int j = 2; j < RecField.Length - 1; j += 2)
                                {
                                    //pars = RecField[1].Substring(1);//labid
                                    //dv.RowFilter = "channel=" + RecField[j];
                                    //if (dv.Count == 0)
                                    //{
                                    //    continue;
                                    //}
                                    //else
                                    //{
                                    //pars += " , " + dv[0]["MachineAttributeCode"].ToString().Trim();// AttributeCode 
                                    //pars += " , " + DateTime.Now.ToString("dd/MM/yyyy");//SendOn
                                    pars += " , " + RecField[j + 1].Substring(0);//ResultS
                                    //InsertBooking(pars);
                                    //}

                                }
                            }
                            

                        }
                        catch { }
                    }
                }
            }
            catch (Exception exc)
            {
                //writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Roche 902 Data : " + exc.Message);
                MessageBox.Show(exc.Message, "Hitachi912 data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void FillCellDyn_Ruby(string data)
        {
          try
            {
                string[] Sep ={ "R|" };
                string[] Sep1 ={ "|" };
                string[] sep2 ={"O|1|"};
                string[] sep3={"^R"};
                string[] sep4 = {"\r"};
                data = data.Replace("R||", "X||");
                string[] Rec = data.Split(Sep, StringSplitOptions.RemoveEmptyEntries);


                for (int i = 1; i <= Rec.GetUpperBound(0); i++)
                {
                    if (Rec[i].Contains("36094BG^CDRuby^2.0ML^1.0|||||||P|LIS2-A"))
                    {
                        continue;
                    }
                    else
                    {
                        string pars = "";
                        string[] RecField1 = Rec[0].Split(sep2, StringSplitOptions.RemoveEmptyEntries);
                       // RecField1 = RecField1[0].Split(sep4, StringSplitOptions.RemoveEmptyEntries);
                        
                            string[] RecField2 = RecField1[1].Split(Sep1, StringSplitOptions.RemoveEmptyEntries);


                            string[] RecField3 = RecField2[0].Split(sep3, StringSplitOptions.RemoveEmptyEntries);
                            pars = RecField3[0].Substring(0);//Pid
                            if (pars.Length > 7)
                            {
                                pars = pars.Substring(pars.Length - 7, 7);
                            }

                            string[] RecField = Rec[i].Split(Sep1, StringSplitOptions.RemoveEmptyEntries);

                        
                        //pars = RecField[0].Substring(0);
                        if (RecField.Length > 5)
                        {
                            for (int j = 0; j <= 3; j += 2)
                            {


                                pars += " , " + RecField[j].Substring(0);//ID & ResultS


                            }
                            try
                            {
                                pars += " , " + RecField[5].Substring(6, 2) + "/" + RecField[5].Substring(4, 2) + "/" + RecField[5].Substring(0, 4) + "  " + (((Convert.ToInt32(RecField[5].Substring(8, 2)) + 11) % 12) + 1) + ":" + RecField[5].Substring(10, 2);//DateTime
                            }
                            catch
                            {
                                pars += " , " + System.DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                            }


                        }
                        else if (RecField.Length >= 4)
                        {
                            for (int j = 0; j <= 3; j += 2)
                            {
                                pars += "," + RecField[j].Substring(0);//ID & Results
                            }
                            pars += "," + RecField[3].Substring(6, 2) + "/" + RecField[3].Substring(4, 2) + "/" + RecField[3].Substring(0, 4) + "  " + (((Convert.ToInt32(RecField[3].Substring(8, 2)) + 11) % 12) + 1) + ":" + RecField[3].Substring(10, 2);//DateTime
                        }
                        InsertBooking(pars);

                    }
                }
            }
            catch (Exception exc)
            {
                writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : CellDyn Ruby Data : " + exc.Message);
               // MessageBox.Show(exc.Message, "Vitros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillSysmax_CA500(string data)
        {

            try
            {
                DataView dv = new DataView();

                string[] Sep ={ "" };
                string[] Sep1 ={ " " };
                string pars = "";
                string[] Rec = data.Split(Sep, StringSplitOptions.RemoveEmptyEntries);

                //dv = GetAttribCodeFromChannel();
                //if (dv == null)
                //{
                //    return;
                //}
                double res_value = 0;
                try
                {
                    for (int i = 0; i <= Rec.Length; i++)
                    {
                       
                        string[] RecField = Rec[i].Split(Sep1, StringSplitOptions.RemoveEmptyEntries);
                        if (RecField.Length > 2)
                        {
                            pars = RecField[1].Substring(0);
                            for (int j = 2; j < RecField.Length - 1; j += 2)
                            {
                                pars = RecField[1].Replace("M", "");//labid
                                pars += " , " + RecField[j];//attributecode
                                pars += " , " + DateTime.Now.ToString("dd/MM/yyyy");//SendOn
                                if (RecField[j].Trim().Equals("051"))
                                    res_value = Convert.ToDouble(RecField[j + 1].Substring(0)) / 10;
                                if (RecField[j].Trim().Equals("011"))
                                    res_value = Convert.ToDouble(RecField[j + 1].Substring(0)) / 10;

                                if (RecField[j].Trim().Equals("014"))
                                    res_value = Convert.ToDouble(RecField[j + 1].Substring(0)) / 100;

                                pars += " , " + res_value.ToString();//ResultS
                                InsertBooking(pars);
                                //}

                            }
                        }                  

                    }
                }
                catch { }
                    
                
            }
            catch (Exception exc)
            {
                //writeLog(DateTime.Now.ToString("yyyyMMddhhmmss") + " : Roche 902 Data : " + exc.Message);
                MessageBox.Show(exc.Message, "Hitachi912 data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void Fillcobas(string data)
        {
            string datetime = "";
            string labid = "";
            string attribresult = "";
            string attribcode = "";
            string[] sep1 = { "L|1" };

            char[] sep2 = { Convert.ToChar(13) };
            string[] abc = data.Split(sep1, StringSplitOptions.RemoveEmptyEntries);
            char[] sep3 = { '|' };
            char[] sep4 = { '^' };
            for (int i = 0; i <= abc.GetUpperBound(0); i++)
            {
                string[] def = abc[i].Split(sep2);
                for (int j = 0; j < def.GetUpperBound(0); j++)
                {
                    if (def[j].Contains("H|") && !def[j].Contains("O|") && !def[j].Contains("R|"))
                    {
                        // Get date time
                        // def[j] = def[j].Replace("||", "");

                        string[] header = def[j].Split(sep3);

                        datetime = header[13].ToString();
                    }
                    else if (def[j].Contains("O|") && def[j].Contains("R|") && def[j].IndexOf("O|") < def[j].IndexOf("R|"))
                    {
                        ///Get lab ID
                        string[] order = def[j].Split(sep3);
                        labid = order[2].ToString();
                    }
                    else if (def[j].Contains("R|"))
                    {
                        //Get Result
                        string[] result = def[j].Split(sep3);
                        attribresult = result[3].ToString();
                        string[] attcode = result[2].Split(sep4);
                        attribcode = attcode[3].ToString();
                        if (attribresult.Contains("-1^"))
                        {
                            attribresult = attribresult.Substring(attribresult.IndexOf("^") + 1) + "(Non-Reactive)";
                        }
                        else if(attribresult.Contains("1^"))
                        {
                            attribresult = attribresult.Substring(attribresult.IndexOf("^") + 1) + "(Reactive)";
                        }
                        string pars = labid + "," + attribcode + "," + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm") + "," + attribresult;
                        InsertBooking(pars);
                    }


                }
            }
        }

        private DataView GetAttribCodeFromChannel()
        {
            clsBLDBConnection objConnection = new clsBLDBConnection();
            clsBLTestAttribute objTestAttrib = new clsBLTestAttribute(objConnection);
            try
            {
                objConnection.Connection_Open();
                objTestAttrib.Machine_testid = clsSharedVariable.InstrumentID.ToString();
                return objTestAttrib.GetAll(2);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Attribute Code from Channel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                objConnection.Connection_Close();
                objConnection = null;
                objTestAttrib = null;
            }
        }

        private void btnAck_Click(object sender, EventArgs e)
        {

            byte[] send = new byte[1];

            send[0] = 0x06;

            Port.Write(send, 0, 1);

        }

        private void timer_getsetorders_Tick(object sender, EventArgs e)
        {
            if (clsSharedVariable.InstrumentName.Equals("Cell-Dyn Ruby"))
            {
                getsetorders("celldyn");
            }
            if (clsSharedVariable.InstrumentName.Trim().Equals("Architect i 1000 SR System"))
            {
                getsetorders("Architect");
            }
            if (clsSharedVariable.InstrumentName.Trim().Equals("cobas e 411"))
            {
                getsetorders("cobas");
            }
        }

        private void getsetorders(string machinename)
        {
            while (!Port.ReadExisting().ToString().Equals(""))
            {
                Thread.Sleep(500);
            }
            Port.Write(new byte[] { 0x05 }, 0, 1);
            Thread.Sleep(500);
            string xyz = Port.ReadExisting();
            // ASCIIEncoding encoding = new ASCIIEncoding();
            //byte[] abc = encoding.GetBytes(xyz);
            if (xyz == Convert.ToChar(6).ToString().Trim())
            {
                Writependingtest(machinename);
            }
        }

        private void Writependingtest(string machinename)
        {
            #region Cell-Dyn orders parsing
            if (machinename == "celldyn")
            {
                clsBLDBConnection obcon = new clsBLDBConnection();
                obcon.OraConnection_Open();
                clsBLTest objTest = new clsBLTest(obcon);
                DataView dv = objTest.OraGetAll(4);
                obcon.OraConnection_Close();
                DSerialNos = "";
                if (dv.Count > 0)
                {
                    string command = "1H|\\^&\r";
                    for (int i = 1; i <= dv.Count; i++)
                    {
                        command += "P|" + i.ToString() + "||" + dv[i - 1]["prno"].ToString().Replace("-", "") + "||" + dv[i - 1]["patientname"].ToString().Trim() + "|||" + dv[i - 1]["psex"].ToString().Substring(0, 1).Trim() + "|||||" + dv[i - 1]["referredby"].ToString().Trim() + "||" + dv[i - 1]["PatientWardInfo"].ToString().Replace(" ", "") + "^327-56-9567\r";
                        command += "O|1|" + dv[i - 1]["labid"].ToString().Substring(dv[i - 1]["labid"].ToString().Length - 5, 5).Trim() + "||^^^CBC^1^0|||||||||||Patient^Human\r";
                        DSerialNos += dv[i - 1]["DSerialno"].ToString().Trim() + ",";
                    }
                    dv.Dispose();

                    command += "L|1|N\r" + Convert.ToChar(3);


                    ASCIIEncoding encoding = new ASCIIEncoding();
                    byte[] array_check = encoding.GetBytes(command);
                    string c1c2 = FindCheckSum(array_check);

                    string fullcommand = Convert.ToChar(2) + command + c1c2 + "\r\n";
                    byte[] fullcommand_bytes = encoding.GetBytes(fullcommand);
                    // Console.WriteLine(fullcommand.Length);
                    //Console.WriteLine(fullcommand);
                    try
                    {
                        Port.Write(fullcommand_bytes, 0, fullcommand_bytes.Length);
                        //Thread.Sleep(8000);
                        //Console.WriteLine(Port.ReadExisting().ToString());
                        //if (Port.ReadExisting() == Convert.ToChar(6).ToString())
                        // {
                        //    Port.Write(new byte[1] { 0x04 }, 0, 1);
                        //JustRead();
                        //}
                        int i = 0;
                        while (!Port.ReadExisting().ToString().Contains(Convert.ToChar(6).ToString()) && i <= 10)
                        {

                            Thread.Sleep(500);
                            i++;
                        }
                        Port.Write(new byte[1] { 0x04 }, 0, 1);
                        updatedatabase();
                        //_port.Write(new byte[1] { 0x04 }, 0, 1);

                    }
                    catch
                    {
                        // Console.WriteLine("Unable to Write new test to the machine...");

                    }
                    finally
                    {

                        //Console.WriteLine("Data Successfully sent to the machine. Allah kare machine mein b order ban jaye. Ameen.");
                    }
                }
                else
                {
                    DSerialNos = "abcd";//Dummy
                    #region Depricated

                    //string PRNO1 = "12345";
                    //string p_Name1 = "Noor Elahi Gul";
                    //string Refferedby1 = "Qamar";
                    //string dob1 = "20000315";
                    //string sex1 = "M";
                    //string labid1 = "468798";

                    //string PRNO2 = "12346";
                    //string p_Name2 = "Omer Gul";
                    //string Refferedby2 = "Amina";
                    //string dob2 = "20000315";
                    //string sex2 = "M";
                    //string labid2 = "7894897";


                    //string header_command = "1H|\\^&\r";
                    //string patient1_Command = "P|1||" + PRNO1 + "||" + p_Name1 + "||" + dob1 + "|" + sex1 + "|||||" + Refferedby1 + "||ICU^327-56-9567\r";
                    //string oreder1_Command = "O|1|" + labid1 + "||^^^CBC^1^0|||19960810153030||||||||Patient^Human\r";
                    //string patient2_command = "P|2||" + PRNO2 + "||" + p_Name2 + "||" + dob2 + "|" + sex2 + "|||||" + Refferedby2 + "||ICU^327-56-9567\r";
                    //string order2_Command = "O|1|" + labid2 + "||^^^CBC^1^0|||19960810153030||||||||Patient^Human\r";
                    //string Terminator = "L|1|N\r";
                    //string command_checksum = header_command + patient1_Command + oreder1_Command + patient2_command + order2_Command + Terminator + Convert.ToChar(3);
                    //ASCIIEncoding encoding = new ASCIIEncoding();
                    //byte[] array_check = encoding.GetBytes(command_checksum);
                    //string c1c2 = FindCheckSum(array_check);
                    //string fullcommand = Convert.ToChar(2) + command_checksum + c1c2 + "\r\n";
                    //byte[] fullcommand_bytes = encoding.GetBytes(fullcommand);
                    //Console.WriteLine(fullcommand);
                    //try
                    //{
                    //    _port.Write(fullcommand_bytes, 0, fullcommand_bytes.Length);
                    //    //Thread.Sleep(4000);
                    //    if (_port.ReadExisting() == Convert.ToChar(6).ToString())
                    //    {
                    //        _port.Write(new byte[1] { 0x04 }, 0, 1);
                    //        //JustRead();
                    //    }


                    //}
                    //catch
                    //{
                    //    Console.WriteLine("Unable to Write new test to the machine...");

                    //}
                    //finally
                    //{
                    //    Console.WriteLine("Data Successfully sent to the machine. Allah kare machine mein b order ban jaye. Ameen.");



                    //}
                    #endregion
                }

                //JustRead();
                #region oldcoce

                // //string framenumber = "1";
                // string header_command = @"1H|\^&||||||||||P|LIS2-A\r";
                // string p_info_command = "P|2||A56342||David Jones||19640315|M|||||Roberts||ICU^327-56-9567\r";
                // string o_info_command = "O|1|120010209604||^^^RETIC^4^0|||19960810153028||||||||Patient^Human\r";
                // string terminator_command = "L|1|N";
                // byte[] CarriageReturn = new byte[1] { 0x0D };
                // byte[] StartofText = new byte[1] { 0x02 };
                // byte[] EndOfText = new byte[1] { 0x03 };
                // byte[] lineFeed = new byte[1] { 0x0A };
                // byte[] tobesentheader = StringToByteArray(header_command);
                // byte[] tobesentp_info = StringToByteArray(p_info_command);
                // byte[] tobesento_info = StringToByteArray(o_info_command);
                // byte[] tobesent_ter = StringToByteArray(terminator_command);
                // byte[] array_Checksum = new byte[tobesentheader.Length + tobesentp_info.Length + tobesento_info.Length + tobesent_ter.Length + 5];//6 is added for 4<CR>s,1<ETX> and firstframe
                //// System.Buffer.BlockCopy(firstframe, 0, array_Checksum, 0, firstframe.Length);
                // System.Buffer.BlockCopy(tobesentheader, 0, array_Checksum,0, tobesentheader.Length);
                // System.Buffer.BlockCopy(CarriageReturn, 0, array_Checksum, tobesentheader.Length, CarriageReturn.Length);
                // System.Buffer.BlockCopy(tobesentp_info, 0, array_Checksum,tobesentheader.Length + CarriageReturn.Length, tobesentp_info.Length);
                // System.Buffer.BlockCopy(CarriageReturn, 0, array_Checksum, tobesentheader.Length + CarriageReturn.Length + tobesentp_info.Length, CarriageReturn.Length);
                // System.Buffer.BlockCopy(tobesento_info, 0, array_Checksum,  tobesentheader.Length + CarriageReturn.Length + tobesentp_info.Length + CarriageReturn.Length, tobesento_info.Length);
                // System.Buffer.BlockCopy(CarriageReturn, 0, array_Checksum, tobesentheader.Length + CarriageReturn.Length + tobesentp_info.Length + CarriageReturn.Length + tobesento_info.Length, CarriageReturn.Length);
                // System.Buffer.BlockCopy(tobesent_ter, 0, array_Checksum, tobesentheader.Length + CarriageReturn.Length + tobesentp_info.Length + CarriageReturn.Length + tobesento_info.Length + CarriageReturn.Length, tobesent_ter.Length);
                // System.Buffer.BlockCopy(CarriageReturn, 0, array_Checksum, tobesentheader.Length + CarriageReturn.Length + tobesentp_info.Length + CarriageReturn.Length + tobesento_info.Length + CarriageReturn.Length + tobesent_ter.Length, CarriageReturn.Length);
                // System.Buffer.BlockCopy(EndOfText, 0, array_Checksum, tobesentheader.Length + CarriageReturn.Length + tobesentp_info.Length + CarriageReturn.Length + tobesento_info.Length + CarriageReturn.Length + tobesent_ter.Length + CarriageReturn.Length, EndOfText.Length);
                // string c1c2 = FindCheckSum(array_Checksum);
                // byte[] check_sum_bits = StringToByteArray(c1c2);
                // ASCIIEncoding encoding=new ASCIIEncoding();
                // string command = encoding.GetString(StartofText) + header_command + encoding.GetString(CarriageReturn) + p_info_command + encoding.GetString(CarriageReturn) + o_info_command + encoding.GetString(CarriageReturn) + terminator_command + encoding.GetString(CarriageReturn) + encoding.GetString(EndOfText) + encoding.GetString(check_sum_bits) + encoding.GetString(CarriageReturn) + encoding.GetString(lineFeed);

                // //  string command = encoding.GetString(StartofText) + header_command + encoding.GetString(CarriageReturn) + p_info_command + encoding.GetString(CarriageReturn) + o_info_command + encoding.GetString(CarriageReturn) + terminator_command + encoding.GetString(CarriageReturn) + encoding.GetString(EndOfText) + encoding.GetString(check_sum_bits) + encoding.GetString(CarriageReturn) + encoding.GetString(lineFeed);
                // try
                // {
                //     Console.WriteLine(command);
                //     //_port.Write(command);
                //     _port.Write(StartofText, 0, 1);
                //     _port.Write(header_command);
                //     _port.Write(CarriageReturn, 0, 1);
                //     _port.Write(p_info_command);
                //     _port.Write(CarriageReturn, 0, 1);
                //     _port.Write(o_info_command);
                //     _port.Write(CarriageReturn, 0, 1);
                //     _port.Write(terminator_command);
                //     _port.Write(CarriageReturn, 0, 1);
                //     _port.Write(EndOfText, 0, 1);
                //     _port.Write(check_sum_bits, 0, 2);
                //     _port.Write(CarriageReturn, 0, 1);
                //     _port.Write(lineFeed, 0, 1);


                // }

                // catch
                // {
                //     Console.WriteLine("Error Occured while writing data to serail port");
                // }
                // finally
                // {
                //     Console.WriteLine("Data Sent now waiting for response");
                //   //Console.WriteLine(command);
                //     Thread.Sleep(2000);
                //     if (_port.ReadExisting().Length > 0)
                //     {
                //         Console.WriteLine(_port.ReadExisting());

                //     }
                //     else
                //     {
                //         Console.WriteLine("Experiment failed");
                //     }
                // }
                #endregion

            }
            #endregion
            #region Architect orders parsing
            else if (machinename == "Architect")
            {
                #region new code
                try
                {
                    framenumber = 0;
                    clsBLDBConnection obcon = new clsBLDBConnection();
                    //Console.WriteLine("Getting Orders From Core_LIMS. Please Wait...");
                    obcon.OraConnection_Open();
                    clsBLTest objTest = new clsBLTest(obcon);
                    DataView dv = objTest.OraGetAll(5);
                    obcon.OraConnection_Close();
                    dv.RowFilter = "labid<>'08-001-0031021'";
                    objTest = null;
                    DSerialNos = "";
                    //string[] patids = new string[] { "123", "456", "789" };
                    //string[] pat_name = new string[3] { "Qamar", "Amman", "Noor" };
                    //string[] orders_1 = new string[4] { "1005", "1015","1010","1014" };
                    //string[] orders_2 = new string[2] { "1005", "1015" };
                    //string[] orders_3 = new string[2] { "1068", "1005" };
                    /////////////////////start of command//////////////////////////
                    if (dv.Count > 0)
                    {
                        string headercommand = getframenum().ToString() + "H|\\^&||||||||||P|1\r" + Convert.ToChar(3);
                        ASCIIEncoding encoding = new ASCIIEncoding();
                        byte[] array_check = encoding.GetBytes(headercommand);
                        string c1c2 = FindCheckSum(array_check);
                        string fullcommand1 = Convert.ToChar(2) + headercommand + c1c2 + "\r\n";
                        byte[] fullcommand1_bytes = encoding.GetBytes(fullcommand1);
                        //Console.WriteLine(fullcommand1);

                        Port.Write(fullcommand1_bytes, 0, fullcommand1_bytes.Length);
                        Thread.Sleep(100);
                        string afterwriting = Port.ReadExisting();
                        // Console.WriteLine(afterwriting);
                        if (afterwriting == Convert.ToChar(6).ToString())
                        {
                            int pat_number = 1;
                            for (int i = 0; i < dv.Count; i++)
                            {
                                string patientname = dv[i]["patientname"].ToString().Trim();
                                string Doctorname = dv[i]["ReferredBy"].ToString().Trim();
                                if (dv[i]["patientname"].ToString().Trim().Length >= 18)
                                {
                                    patientname = dv[i]["patientname"].ToString().Trim().Substring(0, 17);
                                }
                                if (dv[i]["Referredby"].ToString().Trim().Length >= 18)
                                {
                                    Doctorname = dv[i]["Referredby"].ToString().Trim().Substring(0, 17);
                                }
                                string pat_info_command = getframenum().ToString() + "P|" + pat_number + "|" + dv[i]["prno"].ToString().Replace("-", "").Trim() + "|" + dv[i]["prno"].ToString().Replace("-", "").Trim() + "||" + patientname.Trim() + "." + "||19620122|" + dv[i]["PSex"].ToString().Substring(0, 1) + "|||||" + Doctorname + "." + "||||||||||||" + dv[i]["patientwardinfo"].ToString() + "\r" + Convert.ToChar(3);
                                array_check = encoding.GetBytes(pat_info_command);
                                c1c2 = FindCheckSum(array_check);
                                fullcommand1 = Convert.ToChar(2) + pat_info_command + c1c2 + "\r\n";
                                fullcommand1_bytes = encoding.GetBytes(fullcommand1);
                                //       Console.WriteLine(fullcommand1);

                                Port.Write(fullcommand1_bytes, 0, fullcommand1_bytes.Length);
                                Thread.Sleep(100);
                                afterwriting = Port.ReadExisting();
                                //     Console.WriteLine(afterwriting);
                                if (afterwriting == Convert.ToChar(6).ToString())
                                {
                                    obcon.Connection_Open();
                                    objTest = new clsBLTest(obcon);
                                    objTest.Lims_testid = dv[i]["testids"].ToString().Trim();
                                    DataView dv_mactests = objTest.GetAll(8);
                                    obcon.Connection_Close();
                                    objTest = null;
                                    if (dv_mactests.Count > 0)
                                    {
                                        string assay_codes = "";
                                        for (int j = 0; j < dv_mactests.Count; j++)
                                        {
                                            assay_codes += "^^^" + dv_mactests[j]["machinetestcode"].ToString().Trim() + "\\";
                                        }
                                        string order_command = getframenum().ToString() + "O|1|" + Convert.ToInt32(dv[i]["labid"].ToString().Trim().Substring(dv[i]["labid"].ToString().Trim().Length - 7)).ToString().Trim() + "||" + assay_codes.Substring(0, assay_codes.LastIndexOf("\\")) + "|||20010223081223||||N|Hep|lipemic||serum||||||||||O\r" + Convert.ToChar(3);
                                        dv_mactests.Dispose();
                                        array_check = encoding.GetBytes(order_command);
                                        c1c2 = FindCheckSum(array_check);
                                        fullcommand1 = Convert.ToChar(2) + order_command + c1c2 + "\r\n";
                                        fullcommand1_bytes = encoding.GetBytes(fullcommand1);
                                        //       Console.WriteLine(fullcommand1);

                                        Port.Write(fullcommand1_bytes, 0, fullcommand1_bytes.Length);
                                        Thread.Sleep(100);
                                        afterwriting = Port.ReadExisting();
                                        //     Console.WriteLine(afterwriting);
                                        if (afterwriting == Convert.ToChar(6).ToString())
                                        {
                                            DSerialNos += dv[i]["DSerialNos"].ToString().Trim() + ",";
                                            pat_number++;
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        dv_mactests.Dispose();
                                        pat_number++;
                                        continue;
                                    }
                                }
                            }
                            dv.Dispose();
                            string terminator_command = getframenum().ToString() + "L|1\r" + Convert.ToChar(3);
                            array_check = encoding.GetBytes(terminator_command);
                            c1c2 = FindCheckSum(array_check);
                            fullcommand1 = Convert.ToChar(2) + terminator_command + c1c2 + "\r\n";
                            fullcommand1_bytes = encoding.GetBytes(fullcommand1);
                            //Console.WriteLine(fullcommand1);

                            Port.Write(fullcommand1_bytes, 0, fullcommand1_bytes.Length);
                            Thread.Sleep(100);
                            afterwriting = Port.ReadExisting();
                            //Console.WriteLine(afterwriting);
                            if (afterwriting == Convert.ToChar(6).ToString())
                            {
                                //  Console.WriteLine("ya Allah madad farma. Ameen");
                                Port.Write(new byte[1] { 0x04 }, 0, 1);

                                obcon.OraConnection_Open();
                                objTest = new clsBLTest(obcon);
                                objTest.DSerialnos = DSerialNos.Substring(0, DSerialNos.LastIndexOf(","));
                                if (objTest.oraupdate_ordereddtransaction())
                                {
                                    objTest = null;
                                    obcon.OraConnection_Close();
                                    obcon = null;
                                    ///
                                }
                                else
                                {
                                    objTest = null;
                                    obcon.OraConnection_Close();
                                    obcon = null;
                                    ///
                                }
                            }
                            //Console.ReadLine();
                        }
                        else
                        {
                            framenumber = 0;
                        }
                    }
                    else
                    {
                        Port.Write(new byte[1] { 0x04 }, 0, 1);
                    }
                }
                catch (Exception ee)
                {
                    writeLog("Wtrite Pending Test Architect: " + ee.ToString());
                }
                #endregion
            }
            #endregion
            #region cobas E411 orders parsing
            else if (machinename == "cobas")
            {
                #region new code
                try
                {
                    framenumber = 0;
                    clsBLDBConnection obcon = new clsBLDBConnection();
                    //Console.WriteLine("Getting Orders From Core_LIMS. Please Wait...");
                    obcon.OraConnection_Open();
                    clsBLTest objTest = new clsBLTest(obcon);
                    DataView dv = objTest.OraGetAll(5);
                    obcon.OraConnection_Close();
                    dv.RowFilter = "labid<>'08-001-0031021'";
                    objTest = null;
                    DSerialNos = "";
                    //string[] patids = new string[] { "123", "456", "789" };
                    //string[] pat_name = new string[3] { "Qamar", "Amman", "Noor" };
                    //string[] orders_1 = new string[4] { "1005", "1015","1010","1014" };
                    //string[] orders_2 = new string[2] { "1005", "1015" };
                    //string[] orders_3 = new string[2] { "1068", "1005" };
                    /////////////////////start of command//////////////////////////
                    if (dv.Count > 0)
                    {
                        string headercommand = getframenum().ToString() + "H|\\^&||||||||||P|1\r" + Convert.ToChar(3);
                        ASCIIEncoding encoding = new ASCIIEncoding();
                        byte[] array_check = encoding.GetBytes(headercommand);
                        string c1c2 = FindCheckSum(array_check);
                        string fullcommand1 = Convert.ToChar(2) + headercommand + c1c2 + "\r\n";
                        byte[] fullcommand1_bytes = encoding.GetBytes(fullcommand1);
                        //Console.WriteLine(fullcommand1);

                        Port.Write(fullcommand1_bytes, 0, fullcommand1_bytes.Length);
                        Thread.Sleep(100);
                        string afterwriting = Port.ReadExisting();
                        // Console.WriteLine(afterwriting);
                        if (afterwriting == Convert.ToChar(6).ToString())
                        {
                            int pat_number = 1;
                            for (int i = 0; i < dv.Count; i++)
                            {
                                string patientname = dv[i]["patientname"].ToString().Trim();
                                string Doctorname = dv[i]["ReferredBy"].ToString().Trim();
                                if (dv[i]["patientname"].ToString().Trim().Length >= 18)
                                {
                                    patientname = dv[i]["patientname"].ToString().Trim().Substring(0, 17);
                                }
                                if (dv[i]["Referredby"].ToString().Trim().Length >= 18)
                                {
                                    Doctorname = dv[i]["Referredby"].ToString().Trim().Substring(0, 17);
                                }
                                string pat_info_command = getframenum().ToString() + "P|" + pat_number.ToString() + "\r" + Convert.ToChar(3);// +pat_number + "|" + dv[i]["prno"].ToString().Replace("-", "").Trim() + "|" + dv[i]["prno"].ToString().Replace("-", "").Trim() + "||" + patientname.Trim() + "." + "||19620122|" + dv[i]["PSex"].ToString().Substring(0, 1) + "|||||" + Doctorname + "." + "||||||||||||" + dv[i]["patientwardinfo"].ToString() + "\r" + Convert.ToChar(3);
                                array_check = encoding.GetBytes(pat_info_command);
                                c1c2 = FindCheckSum(array_check);
                                fullcommand1 = Convert.ToChar(2) + pat_info_command + c1c2 + "\r\n";
                                fullcommand1_bytes = encoding.GetBytes(fullcommand1);
                                //       Console.WriteLine(fullcommand1);

                                Port.Write(fullcommand1_bytes, 0, fullcommand1_bytes.Length);
                                Thread.Sleep(100);
                                afterwriting = Port.ReadExisting();
                                //     Console.WriteLine(afterwriting);
                                if (afterwriting == Convert.ToChar(6).ToString())
                                {
                                    obcon.Connection_Open();
                                    objTest = new clsBLTest(obcon);
                                    objTest.Lims_testid = dv[i]["testids"].ToString().Trim();
                                    DataView dv_mactests = objTest.GetAll(8);
                                    obcon.Connection_Close();
                                    objTest = null;
                                    if (dv_mactests.Count > 0)
                                    {
                                        string assay_codes = "";
                                        for (int j = 0; j < dv_mactests.Count; j++)
                                        {
                                            assay_codes += "^^^" + dv_mactests[j]["machinetestcode"].ToString().Trim() + "\\";
                                        }
                                        string order_command = getframenum().ToString() + "O|1|" + Convert.ToInt32(dv[i]["labid"].ToString().Trim().Substring(dv[i]["labid"].ToString().Trim().Length - 7)).ToString().Trim() + "||" + assay_codes.Substring(0, assay_codes.LastIndexOf("\\")) + "|R||20010223081223||||N||||||||||||||Q\r" + Convert.ToChar(3);
                                        dv_mactests.Dispose();
                                        array_check = encoding.GetBytes(order_command);
                                        c1c2 = FindCheckSum(array_check);
                                        fullcommand1 = Convert.ToChar(2) + order_command + c1c2 + "\r\n";
                                        fullcommand1_bytes = encoding.GetBytes(fullcommand1);
                                        //       Console.WriteLine(fullcommand1);

                                        Port.Write(fullcommand1_bytes, 0, fullcommand1_bytes.Length);
                                        Thread.Sleep(100);
                                        afterwriting = Port.ReadExisting();
                                        //     Console.WriteLine(afterwriting);
                                        if (afterwriting == Convert.ToChar(6).ToString())
                                        {
                                            DSerialNos += dv[i]["DSerialNos"].ToString().Trim() + ",";
                                            pat_number++;
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        dv_mactests.Dispose();
                                        pat_number++;
                                        continue;
                                    }
                                }
                            }
                            dv.Dispose();
                            string terminator_command = getframenum().ToString() + "L|1|N\r" + Convert.ToChar(3);
                            array_check = encoding.GetBytes(terminator_command);
                            c1c2 = FindCheckSum(array_check);
                            fullcommand1 = Convert.ToChar(2) + terminator_command + c1c2 + "\r\n";
                            fullcommand1_bytes = encoding.GetBytes(fullcommand1);
                            //Console.WriteLine(fullcommand1);

                            Port.Write(fullcommand1_bytes, 0, fullcommand1_bytes.Length);
                            Thread.Sleep(100);
                            afterwriting = Port.ReadExisting();
                            //Console.WriteLine(afterwriting);
                            if (afterwriting == Convert.ToChar(6).ToString())
                            {
                                //  Console.WriteLine("ya Allah madad farma. Ameen");
                                Port.Write(new byte[1] { 0x04 }, 0, 1);

                                obcon.OraConnection_Open();
                                objTest = new clsBLTest(obcon);
                                objTest.DSerialnos = DSerialNos.Substring(0, DSerialNos.LastIndexOf(","));

                                if (objTest.oraupdate_ordereddtransaction())
                                {
                                    objTest = null;
                                    obcon.OraConnection_Close();
                                    obcon = null;
                                    ///
                                }
                                else
                                {
                                    objTest = null;
                                    obcon.OraConnection_Close();
                                    obcon = null;
                                    ///
                                }

                            }
                            //Console.ReadLine();
                        }
                        else
                        {
                            framenumber = 0;
                        }
                    }
                    else
                    {
                        Port.Write(new byte[1] { 0x04 }, 0, 1);
                    }
                }
                catch (Exception ee)
                {
                    writeLog("Wtrite Pending Test Architect: " + ee.ToString());
                }
                #endregion
            }
            #endregion
        }

        private string FindCheckSum(byte[] array)
        {
            int i = 0;
            int count_decvalue = 0;
            foreach (byte b in array)
            {
                count_decvalue += Convert.ToInt32(array[i]);
                i++;
            }


            count_decvalue = count_decvalue % 256;
            if (count_decvalue > 16)
            {
                return count_decvalue.ToString("X");
            }
            else
            {
                return "0" + count_decvalue.ToString("X");
            }
         
        }

        private static void updatedatabase()
        {
            clsBLDBConnection obcon = new clsBLDBConnection();
            obcon.OraConnection_Open();
            clsBLTest obj_test = new clsBLTest(obcon);
            obj_test.DSerialnos = DSerialNos.Substring(0, DSerialNos.Length - 1);
            if (obj_test.oraupdate_ordereddtransaction())
            {
                obcon.OraConnection_Close();
                obcon = null;
                obj_test = null;
               // Console.WriteLine("Database Successfully updated");
            }
            else
            {
                obcon.OraConnection_Close();
                obcon = null;
                obj_test = null;
                //Console.WriteLine(obj_test.StrErr);
            }
        }

        private int getframenum()
        {
            if (framenumber < 7)
            {
                framenumber++;
                return framenumber;
            }
            else
            {
                framenumber = 0;
                return framenumber;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clsSharedVariable.InstrumentName.Equals("Cell-Dyn Ruby"))
            {
                getsetorders("celldyn");
            }
            if (clsSharedVariable.InstrumentName.Trim().Equals("Architect i 1000 SR System"))
            {
                getsetorders("Architect");
            }
            if (clsSharedVariable.InstrumentName.Trim().Equals("cobas e 411"))
            {
                getsetorders("cobas");
            }
        }
    }
}