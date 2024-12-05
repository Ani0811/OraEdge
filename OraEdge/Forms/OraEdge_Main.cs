using OraEdge.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OraEdge
{
    public partial class OraEdge_Main : Form
    {
        private IOraSingleton _iOraSingleton;
        //static OraEdge_Main instance;
        public OraEdge_Main()
        {
            InitializeComponent();
            _iOraSingleton = new OraSingleton();
        }

        private void OraEdge_Main_Load(object sender, EventArgs e)
        {
            tab_textbox.TabPages.Clear();

            /*OraSingleton oraSingleton = new OraSingleton();
            oraSingleton.Initialize_Form("Frm_TextBox", tab_textbox);*/
            _iOraSingleton.Initialize_Form("Frm_TextBox", tab_textbox);

        }

        /*
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
*/
    }
}
