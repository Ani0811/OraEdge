using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OraEdge.Forms
{
    public partial class OraEdge_Main : Form
    {
        static OraEdge_Main instance;
        public OraEdge_Main()
        {
            InitializeComponent();
            LoadForm_TxtBox();
        }
        public static OraEdge_Main getInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new OraEdge_Main();
            }
            return instance;
        }
        public void LoadForm_TxtBox()
        {
            Frm_TextBox tb_Form = new Frm_TextBox();
            pnl_TextBox.Controls.Clear();
            tb_Form.TopLevel = false;
            tb_Form.FormBorderStyle = FormBorderStyle.None;
            tb_Form.Dock = DockStyle.Fill;
            pnl_TextBox.Controls.Add(tb_Form);
            tb_Form.Show();
        }
    }
}
