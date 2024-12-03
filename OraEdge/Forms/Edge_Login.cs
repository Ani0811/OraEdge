using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace OraEdge
{
    public partial class Edge_Login : Settings// Form
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

                /*dtGridVw.Columns.Clear();
                dtGridVw.DataSource = dt;
                dtGridVw.Columns[0].Width = (dtGridVw.Width -10);
                dtGridVw.Refresh();*/

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
    }
}
