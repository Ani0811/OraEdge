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
    public partial class Frm_TextBox : Form
    {
        static Frm_TextBox instance;
        public Frm_TextBox()
        {
            InitializeComponent();
        }
        public static Frm_TextBox GetInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new Frm_TextBox();
            }
            return instance;
        }
    }
}
