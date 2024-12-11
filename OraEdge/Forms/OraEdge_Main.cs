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
            //Ora_Split_Container.Orientation = Orientation.Horizontal;
            //Ora_Split_Container.Dock = DockStyle.Fill;

            _iOraSingleton.Initialize_Form("Frm_TreeView", Ora_Tree_Panel, "Frm_TreeView");
            _iOraSingleton.Initialize_Form("Frm_TabCtrl", Ora_Query_Panel, "Frm_Query_Pad");
            _iOraSingleton.Initialize_Form("Frm_DataGridView", Ora_View_Panel, "Frm_DataGridView");
            
        }
    }
}
