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
    public partial class Frm_TreeView : Form
    {
        static Frm_TreeView instance;
        public Frm_TreeView()
        {
            InitializeComponent();
        }
        public static Frm_TreeView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Frm_TreeView();
            }
            return instance;
        }
    }
}
