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
            //tab_Ctrl.TabPages.Clear();
            _iOraSingleton.Initialize_Form("Frm_TabCtrl", splitContainer1.Panel1, tab_Ctrl);
            _iOraSingleton.Initialize_Form("Frm_DataGridView", splitContainer1.Panel2, gd_view);
            _iOraSingleton.Initialize_Form("Frm_TreeView", panel1, tr_View);
        }
    }
}
