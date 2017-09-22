using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace MachineInterfacing
{
	/// <summary>
	/// Summary description for Components.
	/// </summary>
	public class SComponents
	{
		public SComponents()
		{
		}

        public SComponents(PaintEventArgs pea)
        {
            this._Pea = pea;
        }

        //private Color FormColor = Color.FromArgb(226, 232, 237);
        //private Color PanelColorLight = Color.WhiteSmoke;
        //private Color PanelColorDark = Color.FromArgb(189, 216, 234);
        //private Color HeadingColor = Color.FromArgb(25, 100, 155);

        private Color FormColor = Color.WhiteSmoke;
        private Color PanelColorLight = Color.WhiteSmoke;
        //private Color PanelColorMedium = Color.Gainsboro;
        private Color PanelColorMedium = Color.LightGoldenrodYellow;
        private Color SelfColor = Color.FromArgb(235, 252, 222);
        private Color PanelColorDark = Color.DarkGray;
        private Color HeadingColor = Color.FromArgb(25, 80, 185);

        private PaintEventArgs _Pea;
		
		# region "Applying style to controls"

        /// <summary>
		/// Currently it can apply style to only Buttons, DataGrids, TextBoxes & Form
		/// </summary>
		/// <param name="f"></param>
		public void ApplyStyleToControls(Form f)
		{
            f.BackColor = FormColor;

            // root level controls
            foreach (Control c1 in f.Controls)
            {
                if (c1.GetType() == typeof(System.Windows.Forms.GroupBox) || c1.GetType() == typeof(System.Windows.Forms.Panel))
                {
                    if (c1.GetType() == typeof(System.Windows.Forms.GroupBox))
                    {
                        c1.BackColor = FormColor;
                        GroupBox gb = (GroupBox)c1;
                        ApplyStyleToGroupBox(gb, FormColor);
                    }
                    else if (c1.GetType() == typeof(System.Windows.Forms.Panel))
                    {
                        Panel pnl = (Panel)c1;
                        ApplyStyleToPanel(pnl);
                    }
                }
                else if (c1.GetType() == typeof(System.Windows.Forms.TabControl))
                {
                    TabControl tc = (TabControl)c1;
                    tc.BackColor = FormColor;

                    for (int index = 0; index < tc.TabCount; index++)
                    {
                        tc.TabPages[index].BackColor = FormColor;
                        tc.TabPages[index].Font = new Font("Verdana", float.Parse("9"), FontStyle.Bold, GraphicsUnit.Point);
                        tc.TabPages[index].ForeColor = Color.Black;

                        foreach (Control c2 in tc.TabPages[index].Controls)
                        {
                            if (c2.GetType() == typeof(System.Windows.Forms.GroupBox) || c2.GetType() == typeof(System.Windows.Forms.Panel))
                            {
                                foreach (Control c3 in c2.Controls)
                                {
                                    c2.BackColor = FormColor;
                                    ApplyStyleToControl(c3, FormColor);
                                }

                                if (c2.GetType() == typeof(System.Windows.Forms.GroupBox))
                                {
                                    GroupBox gb = (GroupBox)c2;

                                    if (!gb.Tag.ToString().Equals("NotSet"))
                                    {
                                        gb.Font = new Font("Verdana", float.Parse("8"), FontStyle.Bold, GraphicsUnit.Point);
                                        gb.ForeColor = Color.FromArgb(25, 100, 155);
                                    }
                                }
                            }
                            else
                            {
                                c1.BackColor = FormColor;
                                ApplyStyleToControl(c2, FormColor);
                            }
                        }
                    }
                }
                else
                {
                    ApplyStyleToControl(c1, FormColor);
                }
            }
		}

        private void ApplyStyleToGroupBox(GroupBox gb, Color col)
        {
            if (gb.Tag != null && gb.Tag.ToString().Equals("NotSet"))
            {
                gb.Font = new Font("Verdana", float.Parse("8"), FontStyle.Bold, GraphicsUnit.Point);
                gb.ForeColor = Color.FromArgb(25, 100, 155);
            }

            foreach (Control c2 in gb.Controls)
            {
                ApplyStyleToControl(c2, FormColor);

                if (c2.GetType() == typeof(System.Windows.Forms.GroupBox))
                {
                    ApplyStyleToGroupBox((GroupBox)c2, col);
                }
            }
        }

        private void ApplyStyleToPanel(Panel pnl)
        {
            if (pnl.Tag == null || pnl.Tag.Equals(""))
            {
                pnl.BackColor = PanelColorLight;
                foreach (Control c2 in pnl.Controls)
                {
                    ApplyStyleToControl(c2, PanelColorLight);

                    if (c2.GetType() == typeof(System.Windows.Forms.Panel))
                    {
                        ApplyStyleToPanel((Panel)c2);
                    }
                }
            }
            else if (pnl.Tag.ToString().Equals("top"))
            {
                pnl.BackColor = PanelColorDark;
                foreach (Control c2 in pnl.Controls)
                {
                    ApplyStyleToControl(c2, PanelColorDark);

                    if (c2.GetType() == typeof(System.Windows.Forms.Panel))
                    {
                        ApplyStyleToPanel((Panel)c2);
                    }
                }
            }
            else if (pnl.Tag.ToString().Equals("med"))
            {
                pnl.BackColor = PanelColorMedium;

                foreach (Control c2 in pnl.Controls)
                {
                    ApplyStyleToControl(c2, PanelColorMedium);

                    if (c2.GetType() == typeof(System.Windows.Forms.Panel))
                    {
                        ApplyStyleToPanel((Panel)c2);
                    }
                }
            }
            else if (pnl.Tag.ToString().Equals("self"))
            {
                pnl.BackColor = SelfColor;
                foreach (Control c2 in pnl.Controls)
                {
                    ApplyStyleToControl(c2, PanelColorMedium);

                    if (c2.GetType() == typeof(System.Windows.Forms.Panel))
                    {
                        ApplyStyleToPanel((Panel)c2);
                    }
                }
            }
        }

		private void ApplyStyleToControl(Control c, Color col)
		{
            if (c.GetType() == typeof(System.Windows.Forms.Button))
            {
                Button btn = (Button)c;

                if (btn.Tag == null)
                {
                    btn.Font = new Font("Verdana", float.Parse("8"), FontStyle.Regular, GraphicsUnit.Point);
                    btn.BackColor = Color.LightGray;
                    btn.ForeColor = Color.Black;
                }
                else if (btn.Tag.Equals("urdu"))
                {
                    btn.Font = new Font("AlKatib1", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.Black;
                }
                else if (btn.Tag.Equals("notset"))
                {
                    btn.BackColor = Color.LightGray;
                    btn.ForeColor = Color.Black;
                }
            }
            else if (c.GetType() == typeof(System.Windows.Forms.DataGridView))
            {
                DataGridView dg = (DataGridView)c;

                dg.Font = new Font("Arial", float.Parse("9"), GraphicsUnit.Point);
                dg.BackgroundColor = PanelColorLight;
                dg.ForeColor = Color.Black;
                dg.GridColor = Color.DimGray;

                dg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", float.Parse("9"), FontStyle.Bold, GraphicsUnit.Point);
                //dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(43, 78, 15);
                dg.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGoldenrodYellow;

                //dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(235, 241, 230);
                dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                dg.RowsDefaultCellStyle.BackColor = Color.White;

                dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 252, 222);

                dg.RowsDefaultCellStyle.SelectionBackColor = Color.Gainsboro;
                dg.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            }
            else if (c.GetType() == typeof(System.Windows.Forms.TextBox))
            {
                TextBox tb = (TextBox)c;
                if (tb.Tag == null)
                {
                    tb.Font = new Font("Verdana", float.Parse("8"), GraphicsUnit.Point);
                    tb.ForeColor = Color.Black;
                }
                else if (tb.Tag.Equals("urdu"))
                {
                    tb.Font = new Font("AlKatib1", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tb.ForeColor = Color.Black;
                }
                tb.BackColor = Color.White;
                tb.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (c.GetType() == typeof(System.Windows.Forms.CheckBox))
            {
                CheckBox cb = (CheckBox)c;
                //Font cbFont = new Font("Verdana", float.Parse("9"), GraphicsUnit.Point);

                if (cb.Tag == null)
                {
                    cb.Font = new Font("Arial", float.Parse("9"), GraphicsUnit.Point);
                    cb.TextAlign = ContentAlignment.MiddleLeft;
                }
                else if (cb.Tag.Equals("urdu"))
                {
                    cb.Font = new Font("AlKatib1", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    cb.TextAlign = ContentAlignment.MiddleRight;
                }
                else if (cb.Tag.Equals("none"))
                {
                    cb.BackColor = col;
                    cb.TextAlign = ContentAlignment.MiddleLeft;
                }
                else if (cb.Tag.Equals("trans"))
                {
                    cb.BackColor = Color.Transparent;
                    cb.TextAlign = ContentAlignment.MiddleLeft;
                }
                
            }
            else if (c.GetType() == typeof(System.Windows.Forms.Label))
            {
                Label lbl = (Label)c;

                if (lbl.Tag == null)
                {
                    lbl.ForeColor = Color.Black;
                    lbl.BackColor = col;
                }
                else if (lbl.Tag.ToString().Equals("display"))
                {
                    lbl.Font = new Font("Arial", float.Parse("9"), FontStyle.Bold, GraphicsUnit.Point);
                    lbl.ForeColor = Color.Black;
                    lbl.BackColor = col;
                }
                else if (lbl.Tag.ToString().Equals("heading"))
                {
                    lbl.ForeColor = Color.FromArgb(25, 100, 155);
                    lbl.Font = new Font("Arial", float.Parse("12"), FontStyle.Bold, GraphicsUnit.Point);
                    lbl.BackColor = col;
                }
                else if (lbl.Tag.ToString().Equals("trans"))
                {
                    lbl.ForeColor = Color.Black;
                }
                else if (lbl.Tag.ToString().Equals("transdisplay"))
                {
                    lbl.Font = new Font("Arial", float.Parse("9"), FontStyle.Bold, GraphicsUnit.Point);
                    lbl.ForeColor = Color.Black;
                }
                else if (lbl.Tag.ToString().Equals("transheading"))
                {
                    lbl.ForeColor = Color.FromArgb(25, 100, 155);
                    lbl.Font = new Font("Arial", float.Parse("12"), FontStyle.Bold, GraphicsUnit.Point);
                }
                else if (lbl.Tag.ToString().Equals("urdu"))
                {
                    lbl.ForeColor = Color.FromArgb(25, 100, 155);
                    lbl.Font = new Font("AlKatib1", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                
            }
            else if (c.GetType() == typeof(System.Windows.Forms.RadioButton))
            {
                RadioButton rbtn = (RadioButton)c;

                if (rbtn.Tag == null )
                {
                    rbtn.BackColor = col;
                }
                else if (rbtn.Tag.Equals("self"))
                {
                    rbtn.BackColor = Color.Transparent ;
                }
                rbtn.Font = new Font("Arial", float.Parse("8"), FontStyle.Regular, GraphicsUnit.Point);
                rbtn.ForeColor = Color.Black;
                rbtn.TextAlign = ContentAlignment.TopLeft;
            }
            else if (c.GetType() == typeof(System.Windows.Forms.ComboBox))
            {
                ComboBox cmb = (ComboBox)c;

                if (cmb.Tag == null)
                {
                    cmb.Font = new Font("Verdana", float.Parse("8"), FontStyle.Regular, GraphicsUnit.Point);
                }
                else if (cmb.Tag.ToString().Equals("urdu"))
                {
                    cmb.Font = new Font("AlKatib1", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

                cmb.ForeColor = Color.Black;
            }
		}

        public void ApplyStyleToDGTableStyle(DataGridTableStyle dgts)
        {
            //Font headerFont = new Font("Arial", float.Parse("10"), FontStyle.Bold, GraphicsUnit.Point);

            //dgts.AlternatingBackColor = Color.FromArgb(104, 186, 23);
            //dgts.ForeColor = Color.Black;
            //dgts.BackColor = Color.White;
            //dgts.GridLineColor = Color.DimGray;
            //dgts.GridLineStyle = DataGridLineStyle.Solid;
            //dgts.HeaderBackColor = Color.FromArgb(152, 172, 197);
            //dgts.HeaderFont = headerFont;
            //dgts.HeaderForeColor = Color.Black;
            //dgts.SelectionBackColor = Color.Silver;
            //dgts.SelectionForeColor = Color.Black;
        }

		# endregion

        #region "Fill ComboBox Methods"
        /// <summary>
        /// Bind DataView with Windows.Forms.ComboBox
        /// </summary>
        /// <param name="cmb">Reference of ComboBox</param>
        /// <param name="dv">DataView to bind with the ComboBox</param>
        /// <param name="strTextField">Column name to Display (Note: it is case sensitive, so if you have not alias the column header in the query then write in Upper case)</param>
        /// <param name="strValueField">Column name to assign value (Note: it is case sensitive, so if you have not alias the column header in the query then write in Upper case)</param>
        /// <param name="sort">true for Sorting</param>
        /// <param name="isSelect">true, if you want to add Select row</param>
        public void FillComboBox(ComboBox cmb, DataView dv, string strTextField, string strValueField, bool isSelect)
        {
            if (isSelect)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(strValueField);
                dt.Columns.Add(strTextField);

                DataRow dr = dt.NewRow();
                dr[strValueField] = "-1";
                dr[strTextField] = "Select";
                dt.Rows.Add(dr);

                foreach (DataRow drMain in dv.Table.Rows)
                {
                    dr = dt.NewRow();
                    dr[strValueField] = drMain[strValueField];
                    dr[strTextField] = drMain[strTextField];
                    dt.Rows.Add(dr);
                }

                cmb.ValueMember = strValueField;
                cmb.DisplayMember = strTextField;
                cmb.DataSource = dt;
            }
            else
            {
                cmb.ValueMember = strValueField;
                cmb.DisplayMember = strTextField;
                cmb.DataSource = dv;
            }
        }

        /// <summary>
        /// Fill ComboBox, when there is no need of Value field in ComboBox
        /// </summary>
        /// <param name="cmb">ComboBox reference</param>
        /// <param name="dv">DataView to load in Combo Box</param>
        /// <param name="strTextField">Display Member field</param>
        /// <param name="isSelect">true, if you want to add Select row</param>
        public void FillComboBox(ComboBox cmb, DataView dv, string strTextField, bool isSelect)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(strTextField);
            dt.Columns.Add("ValueField");

            if (isSelect)
            {
                DataRow dr = dt.NewRow();
                dr[strTextField] = "Select";
                dr["ValueField"] = "-1";
                dt.Rows.Add(dr);

                foreach (DataRow drMain in dv.Table.Rows)
                {
                    dr = dt.NewRow();
                    dr[strTextField] = drMain[strTextField];
                    dr["ValueField"] = drMain[strTextField];
                    dt.Rows.Add(dr);
                }

                cmb.DisplayMember = strTextField;
                cmb.ValueMember = "ValueField";
                cmb.DataSource = dt.DefaultView;
            }
            else
            {
                cmb.ValueMember = strTextField;
                cmb.DisplayMember = strTextField;
                cmb.DataSource = dv;
            }
        }

        public void FillComboBox(ComboBox cmb, DataView dv, string strTextField, string strValueField, bool isSelect, bool isAll)
        {
            if (isSelect || isAll)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add(strValueField);
                dt.Columns.Add(strTextField);

                if (isSelect)
                {
                    dr = dt.NewRow();
                    dr[strValueField] = "-1";
                    dr[strTextField] = "Select";
                    dt.Rows.Add(dr);
                }

                if (isAll)
                {
                    dr = dt.NewRow();
                    dr[strValueField] = "-2";
                    dr[strTextField] = "All";
                    dt.Rows.Add(dr);
                }

                foreach (DataRow drMain in dv.Table.Rows)
                {
                    dr = dt.NewRow();
                    dr[strValueField] = drMain[strValueField];
                    dr[strTextField] = drMain[strTextField];
                    dt.Rows.Add(dr);
                }

                cmb.ValueMember = strValueField;
                cmb.DisplayMember = strTextField;
                cmb.DataSource = dt;
            }
            else
            {
                cmb.ValueMember = strValueField;
                cmb.DisplayMember = strTextField;
                cmb.DataSource = dv;
            }
        }

        # endregion
    }
}