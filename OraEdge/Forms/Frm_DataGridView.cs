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
    public partial class Frm_DataGridView : Form
    {
        static Frm_DataGridView instance;
        public Frm_DataGridView()
        {
            InitializeComponent();
        }
        public static Frm_DataGridView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Frm_DataGridView();
            }
            return instance;
        }
    }
}
