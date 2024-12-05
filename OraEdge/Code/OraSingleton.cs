using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Threading.Tasks;
using OraEdge.Code;

namespace OraEdge
{
    public class OraSingleton : IOraSingleton
    {
        string strClassName = "OraEdge.";
        public OraSingleton() {; }

        public void Initialize_Form(string argClassName, 
                                        System.Windows.Forms.TabControl argTarget_TabCtrl)
        {
            try
            {
                strClassName = strClassName + argClassName;
                if (strClassName.Length > 0)
                {
                    Type objType = this.GetType().Assembly.GetType(strClassName);
                    object obj = Activator.CreateInstance(objType);
                    Form objForm = (Form)obj;

                    //argPanel.Controls.Remove(argGridVw);
                    objForm.TopLevel = false;
                    objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    /*objForm.Width = argPanel.ClientSize.Width;
                    objForm.Height = argPanel.ClientSize.Height;*/

                    //if (iCenterForm == 1) { objForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; }

                    System.Windows.Forms.TabPage o_TabPage = new System.Windows.Forms.TabPage();
                    argTarget_TabCtrl.TabPages.Add(o_TabPage);
                    o_TabPage.Controls.Add(objForm);
                    objForm.Dock = DockStyle.Fill;
                    try { objForm.Show(); } catch (Exception exp) {; }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error - Initialize_Form()", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { strClassName = null; }
        }
        public void Initialize_Form(string argClassName, Panel argPanel, 
                                        DataGridView argGridView)
        {
            try
            {
                strClassName = strClassName + argClassName;
                if (strClassName.Length > 0)
                {
                    Type objType = this.GetType().Assembly.GetType(strClassName);
                    object obj = Activator.CreateInstance(objType);
                    Form objForm = (Form)obj;
                    objForm.TopLevel = false;
                    objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

                    argPanel.Controls.Add(objForm);
                    objForm.Dock = DockStyle.Fill;
                    try { objForm.Show(); }catch (Exception exp) {; }
                }
            }
            catch (Exception exp) {; }
            finally { strClassName = null;  }
        }
    }
}
