using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace OraEdge
{
    public partial class Edge_Login : Settings
    {
        public Edge_Login()
        {
            InitializeComponent();
            SetFontForAllControls(this);
        }

        private void Edge_Login_Load(object sender, EventArgs e)
        {
            Ora_DB_Helper OraHelp = null;
            DataTable dt = null;

            try
            {
                OraHelp = new Ora_DB_Helper();
                dt = OraHelp.get_Oracle_Instances();

                lst_OraInstances.Items.Clear();

                lst_OraInstances.Columns.Clear();
                lst_OraInstances.Columns.Add("Oracle Instance", 194, HorizontalAlignment.Left);
                if (dt != null || dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows) 
                    {
                        lst_OraInstances.Items.Add(dr["INSTANCE_NAME"].ToString());
                    }
                }

                dt = OraHelp.get_DBA_Users();

                cmb_DB.DataSource = dt.DefaultView;
                cmb_DB.DisplayMember = "USERNAME";
                cmb_DB.ValueMember = "USER_ID";
                cmb_DB.BindingContext = this.BindingContext;
            }
            catch (Exception ex) {; }
            finally
            {
                if (dt != null) { dt.Dispose(); } OraHelp = null; 
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            String username = null;
            String password = null;
            String database = null;
            String selectedInstance = null;
            String default_username = null;
            String default_password = null;

            try
            {
                username = txt_UserName.Text.Trim();
                password = txt_PWD.Text.Trim();

                if (lst_OraInstances.SelectedItems.Count > 0)
                {
                    selectedInstance = lst_OraInstances.SelectedItems[0].Text;
                }
                else
                {
                    selectedInstance = null;
                }

                if (cmb_DB.SelectedValue != null)
                {
                    database = cmb_DB.SelectedValue.ToString();
                }
                else
                {
                    database = null;
                }

                default_username = Environment.GetEnvironmentVariable("ORACLE_SYS_USERNAME");
                default_password = Environment.GetEnvironmentVariable("ORACLE_SYS_PASSWORD");

                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (String.IsNullOrEmpty(selectedInstance))
                {
                    MessageBox.Show("Please select an Oracle instance.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (username == default_username && password == default_password)
                {
                    MessageBox.Show("Successfully connected as SYSTEM user.", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { username = null; password = null; database = null; selectedInstance = null; }
        }
    }
}
