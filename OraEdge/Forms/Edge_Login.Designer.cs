namespace OraEdge
{
    partial class Edge_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_DB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PWD = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lst_OraInstances = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lst_OraInstances);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 263);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmb_DB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_PWD);
            this.panel2.Controls.Add(this.txt_UserName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(207, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 263);
            this.panel2.TabIndex = 1;
            // 
            // cmb_DB
            // 
            this.cmb_DB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DB.FormattingEnabled = true;
            this.cmb_DB.Location = new System.Drawing.Point(77, 64);
            this.cmb_DB.Name = "cmb_DB";
            this.cmb_DB.Size = new System.Drawing.Size(246, 21);
            this.cmb_DB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Database :";
            // 
            // txt_PWD
            // 
            this.txt_PWD.Location = new System.Drawing.Point(77, 35);
            this.txt_PWD.Name = "txt_PWD";
            this.txt_PWD.Size = new System.Drawing.Size(246, 20);
            this.txt_PWD.TabIndex = 2;
            this.txt_PWD.UseSystemPasswordChar = true;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(77, 8);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(246, 20);
            this.txt_UserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Close);
            this.panel3.Controls.Add(this.btn_Connect);
            this.panel3.Location = new System.Drawing.Point(3, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 30);
            this.panel3.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(461, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "C&lose";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(380, 3);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "&Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // lst_OraInstances
            // 
            this.lst_OraInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_OraInstances.FullRowSelect = true;
            this.lst_OraInstances.GridLines = true;
            this.lst_OraInstances.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_OraInstances.HideSelection = false;
            this.lst_OraInstances.LabelWrap = false;
            this.lst_OraInstances.Location = new System.Drawing.Point(0, 0);
            this.lst_OraInstances.MultiSelect = false;
            this.lst_OraInstances.Name = "lst_OraInstances";
            this.lst_OraInstances.ShowGroups = false;
            this.lst_OraInstances.Size = new System.Drawing.Size(198, 263);
            this.lst_OraInstances.TabIndex = 0;
            this.lst_OraInstances.UseCompatibleStateImageBehavior = false;
            this.lst_OraInstances.View = System.Windows.Forms.View.Details;
            // 
            // Edge_Login
            // 
            this.AcceptButton = this.btn_Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(551, 302);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edge_Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle Connect";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Edge_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PWD;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_DB;
        private System.Windows.Forms.ListView lst_OraInstances;
    }
}