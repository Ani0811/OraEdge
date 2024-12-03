using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OraEdge
{
    public partial class OraEdge_Parent : Settings// Form
    {
        string strSelectedTxt = null;
        bool F5_Pressed = false;
        bool isHovered = false;
        Rectangle tab_Rect;
        Rectangle btn_Close_Rect;

        public OraEdge_Parent()
        {
            InitializeComponent();
            SetFontForAllControls(this);

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(OraEdge_Parent_KeyDown);

            Ora_Tab.DrawMode = TabDrawMode.OwnerDrawFixed;
            Ora_Tab.DrawItem += Ora_Tab_DrawItem;
            Ora_Tab.MouseClick += Ora_Tab_MouseClick;
            Ora_Tab.MouseMove += Ora_Tab_MouseMove;
            Ora_Tab.MouseLeave += Ora_Tab_MouseLeave;

            Ora_Tab.ItemSize = new Size(300, 20);
        }

        private void OraEdge_Parent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            Edge_Login OraLogin = new Edge_Login();
            OraLogin.Show();
            Ora_Tab.TabPages.Clear();
        }

        private void OraEdge_Parent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Mnu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Ora_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ora_Tab_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tab = Ora_Tab.TabPages[e.Index];

            e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);

            String tabTitle = tab.Text;
            Font tabFont = new Font("Segoe UI", 7);
            Brush textBrush = Brushes.Black;
            e.Graphics.DrawString(tabTitle, tabFont, textBrush, e.Bounds.Left + 5, e.Bounds.Top + 5);

            int btn_Close_Size = 10;
            btn_Close_Rect = new Rectangle(e.Bounds.Right - btn_Close_Size - 8, e.Bounds.Top + 5, btn_Close_Size, btn_Close_Size);

            if (e.Index == Ora_Tab.SelectedIndex && isHovered)
            {
                e.Graphics.FillRectangle(Brushes.Red, btn_Close_Rect);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.PaleVioletRed, btn_Close_Rect);
            }

            e.Graphics.DrawString("X", new Font("Verdana", 7, FontStyle.Bold), Brushes.White, btn_Close_Rect);

            e.Graphics.DrawRectangle(Pens.Black, e.Bounds);
        }
        private void Ora_Tab_MouseMove(object sender, MouseEventArgs e)
        {
            int selectedTabIndex = Ora_Tab.SelectedIndex;

            for (int i = 0; i < Ora_Tab.TabPages.Count; i++)
            {
                if (i == selectedTabIndex)
                {
                    tab_Rect = Ora_Tab.GetTabRect(i);
                    btn_Close_Rect = new Rectangle(tab_Rect.Right - 12 - 8, tab_Rect.Top + 5, 12, 12);

                    if (btn_Close_Rect.Contains(e.Location))
                    {
                        if (!isHovered)
                        {
                            isHovered = true;
                            Ora_Tab.Invalidate();
                        }
                        return;
                    }
                }
            }
            if (isHovered)
            {
                isHovered = false;
                Ora_Tab.Invalidate();
            }
        }

        private void Ora_Tab_MouseLeave(object sender, EventArgs e)
        {
            if (isHovered)
            {
                isHovered = false;
                Ora_Tab.Invalidate();
            }
        }

        private void Ora_Tab_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Ora_Tab.TabPages.Count; i++)
            {
                tab_Rect = Ora_Tab.GetTabRect(i);
                btn_Close_Rect = new Rectangle(tab_Rect.Right - 12 - 8, tab_Rect.Top + 5, 12, 12);

                if (btn_Close_Rect.Contains(e.Location))
                {
                    Ora_Tab.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        private void OraEdge_Parent_KeyDown(object sender, KeyEventArgs e)
        {
            Ora_DB_Helper oraHelp = null;
            DataTable[] dt = null;
            DataTable dt_result = null;
            DataTable dt_feedback = null;
            DataTable dt_error = null;

            String trimmed_query = null;
            int iCount = 0;
            int iRowsAffected = 0;
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    e.Handled = true;
                    if (!F5_Pressed)
                    {
                        F5_Pressed = true;
                        strSelectedTxt = Ora_Text.SelectedText.Trim();

                        if (!String.IsNullOrEmpty(strSelectedTxt))
                        {
                            String[] queries = strSelectedTxt.Trim()
                                                             .Replace('\r', ' ')
                                                             .Replace('\n', ' ')
                                                             .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                            oraHelp = new Ora_DB_Helper();
                            dt = new DataTable[queries.Count()];

                            foreach (String query in queries)
                            {
                                trimmed_query = query.Trim();

                                if (trimmed_query.StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                                {
                                    dt[iCount] = oraHelp.exec_OraData(trimmed_query);
                                    if (dt[iCount] != null && dt[iCount].Rows.Count > 0)
                                    {
                                        add_New_Tab(dt[iCount], trimmed_query);
                                    }
                                    else
                                    {
                                        dt_result = new DataTable();
                                        dt_result.Columns.Add("Output", typeof(String));
                                        dt_result.Rows.Add("No rows selected");
                                        add_New_Tab(dt_result, trimmed_query);
                                    }
                                }
                                else
                                {
                                    iRowsAffected = oraHelp.exec_NonQuery(trimmed_query);
                                    dt_feedback = new DataTable();
                                    dt_feedback.Columns.Add("Message", typeof(String));
                                    dt_feedback.Rows.Add($"Rows Affected: {iRowsAffected}");
                                    add_New_Tab(dt_feedback, trimmed_query);
                                }
                                iCount++;
                            }
                        }
                    }
                    else { F5_Pressed = false; }
                }
            }
            catch (Exception ex)
            {
                dt_error = new DataTable();
                dt_error.Columns.Add("Error", typeof(String));
                dt_error.Rows.Add($"Error executing query: {ex.Message}");
                add_New_Tab(dt_error, trimmed_query);
            }
            finally { oraHelp = null; dt = null; dt_result = null; dt_error = null; }
        }

        private void add_New_Tab(DataTable dt, String query)
        {
            TabPage newTab = new TabPage($"Tab {Ora_Tab.TabCount + 1}" + String.Empty.PadRight('\t'));
            newTab.ToolTipText = query;

            /*DataGridView gdView = new DataGridView
            {
                Dock = DockStyle.Fill,
                DataSource = dt,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
                {
                    BackColor = Color.LightSteelBlue,
                    ForeColor = Color.Black,
                    //Font = new Font("Verdana", 9, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                EnableHeadersVisualStyles = false
            };*/
            DataGridView gdView = new DataGridView();
            Settings settings = new Settings();
            settings.SetSettingsForGrid(gdView, dt);

            newTab.Controls.Add(gdView);

            Ora_Tab.TabPages.Add(newTab);
            Ora_Tab.SelectedTab = newTab;
        }
        private void add_TextBox_Tab(String tabTitle, String iniTxt = "")
        {
            TabPage newTab = new TabPage(tabTitle);

            TextBox tb = new TextBox()
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                Text = iniTxt,
                //Font = new Font("Verdana", 7),
                ScrollBars = ScrollBars.Both
            };

            newTab.Controls.Add(tb);

            Ora_Tab.TabPages.Add(newTab);
            Ora_Tab.SelectedTab = newTab;
        }
    }
}
