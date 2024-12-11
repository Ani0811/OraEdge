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

        public void Initialize_Form(string argClassName, Panel argPanel, System.Windows.Forms.TabControl argTarget_TabCtrl)
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
                    try { objForm.Show(); } catch (Exception exp) {; }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error - Initialize_Form()", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { strClassName = null; }
        }
        public void Initialize_Form(string argClassName, System.Windows.Forms.Panel argPanel, System.Windows.Forms.DataGridView argGridView)
        {
            try
            {
                strClassName = strClassName + argClassName;

                if (strClassName.Length > 0)
                {
                    Type objType = this.GetType().Assembly.GetType(strClassName);
                    if (objType != null)
                    {
                        object obj = Activator.CreateInstance(objType);
                        Form objForm = (Form)obj;

                        argPanel.Controls.Remove(argGridView);
                        objForm.TopLevel = false;
                        objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

                        argPanel.Controls.Add(objForm);
                        objForm.Dock = DockStyle.Fill;
                        try { objForm.Show(); } catch (Exception exp) {; }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error - Initialize_Form()", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { strClassName = null;  }
        }
        public void Initialize_Form(string argClassName, System.Windows.Forms.Panel arg_Target_Panel, string arg_Form_Name)
        {
            try
            {
                strClassName = strClassName + arg_Form_Name;

                if (strClassName.Length > 0)
                {
                    Type objType = this.GetType().Assembly.GetType(strClassName);
                    if (objType != null)
                    {
                        object obj = Activator.CreateInstance(objType);
                        Form objForm = (Form)obj;
                        objForm.TopLevel = false;
                        objForm.Dock = DockStyle.Fill;

                        arg_Target_Panel.Controls.Add(objForm);
                        objForm.Show();
                        arg_Target_Panel.Dock = DockStyle.Fill;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error - Initialize_Form()", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { strClassName = null; }
        }
    }
}
