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
    public partial class Frm_TabCtrl : Form
    {
        static Frm_TabCtrl instance;
        public Frm_TabCtrl()
        {
            InitializeComponent();
            Add_TxtBox();
        }
        public static Frm_TabCtrl GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Frm_TabCtrl();
            }
            return instance;
        }
        private void Add_TxtBox()
        {
            try
            {
                TextBox tab_TextBox = new TextBox();
                this.Controls.Add(tab_TextBox); 
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error adding dynamic TextBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {; }

        }
    }
}
