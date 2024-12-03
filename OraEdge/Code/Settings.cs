using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OraEdge
{
    public class Settings: Form
    {
        public Settings() { }
        public void SetFontForAllControls(Control control)
        {
            Font newFont = new Font("Segoe UI", 9f);
            control.Font = newFont;
            foreach (Control childControl in control.Controls)
            {
                SetFontForAllControls(childControl);
            }
        }
        public void SetSettingsForGrid(DataGridView gdView, Object dt)
        {
            if (gdView == null) { return; }

            Font generalFont = new Font("Segoe UI", 9f);

            gdView.Dock = DockStyle.Fill;

            if(dt != null) { gdView.DataSource = dt; }

            gdView.ReadOnly = true;
            gdView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gdView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            gdView.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            gdView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            gdView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gdView.RowHeadersDefaultCellStyle.Font = generalFont;
            gdView.RowHeadersDefaultCellStyle.BackColor = Color.Beige;

            gdView.DefaultCellStyle.Font = generalFont;
            gdView.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            gdView.DefaultCellStyle.SelectionForeColor = Color.Black;

            gdView.EnableHeadersVisualStyles = false;
            gdView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            gdView.BorderStyle = BorderStyle.FixedSingle;
            gdView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            foreach(DataGridViewRow row in gdView.Rows)
            {
                row.DefaultCellStyle.Font = generalFont;
                row.Height = 25;
            }
            foreach(DataGridViewColumn column in gdView.Columns)
            {
                column.DefaultCellStyle.Font = generalFont;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }
    }
}
