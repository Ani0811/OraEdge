namespace OraEdge
{
    partial class OraEdge_Parent
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
            this.MNU_EDGE = new System.Windows.Forms.MenuStrip();
            this.Mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Ora_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Ora_Panel_1 = new System.Windows.Forms.SplitContainer();
            this.Ora_Tree = new System.Windows.Forms.TreeView();
            this.Ora_Panel_2 = new System.Windows.Forms.SplitContainer();
            this.Ora_Text = new System.Windows.Forms.TextBox();
            this.Ora_Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Ora_DtGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MNU_EDGE.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ora_Panel_1)).BeginInit();
            this.Ora_Panel_1.Panel1.SuspendLayout();
            this.Ora_Panel_1.Panel2.SuspendLayout();
            this.Ora_Panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ora_Panel_2)).BeginInit();
            this.Ora_Panel_2.Panel1.SuspendLayout();
            this.Ora_Panel_2.Panel2.SuspendLayout();
            this.Ora_Panel_2.SuspendLayout();
            this.Ora_Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ora_DtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MNU_EDGE
            // 
            this.MNU_EDGE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_File,
            this.Mnu_Connect});
            this.MNU_EDGE.Location = new System.Drawing.Point(0, 0);
            this.MNU_EDGE.Name = "MNU_EDGE";
            this.MNU_EDGE.Size = new System.Drawing.Size(800, 24);
            this.MNU_EDGE.TabIndex = 1;
            this.MNU_EDGE.Text = "menuStrip1";
            // 
            // Mnu_File
            // 
            this.Mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ora_Exit});
            this.Mnu_File.Name = "Mnu_File";
            this.Mnu_File.Size = new System.Drawing.Size(37, 20);
            this.Mnu_File.Text = "&File";
            // 
            // Ora_Exit
            // 
            this.Ora_Exit.Name = "Ora_Exit";
            this.Ora_Exit.Size = new System.Drawing.Size(93, 22);
            this.Ora_Exit.Text = "E&xit";
            this.Ora_Exit.Click += new System.EventHandler(this.Ora_Exit_Click);
            // 
            // Mnu_Connect
            // 
            this.Mnu_Connect.Name = "Mnu_Connect";
            this.Mnu_Connect.Size = new System.Drawing.Size(64, 20);
            this.Mnu_Connect.Text = "&Connect";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Ora_Panel_1
            // 
            this.Ora_Panel_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ora_Panel_1.Location = new System.Drawing.Point(0, 24);
            this.Ora_Panel_1.Name = "Ora_Panel_1";
            // 
            // Ora_Panel_1.Panel1
            // 
            this.Ora_Panel_1.Panel1.Controls.Add(this.Ora_Tree);
            // 
            // Ora_Panel_1.Panel2
            // 
            this.Ora_Panel_1.Panel2.Controls.Add(this.Ora_Panel_2);
            this.Ora_Panel_1.Size = new System.Drawing.Size(800, 404);
            this.Ora_Panel_1.SplitterDistance = 303;
            this.Ora_Panel_1.TabIndex = 4;
            // 
            // Ora_Tree
            // 
            this.Ora_Tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ora_Tree.Location = new System.Drawing.Point(0, 0);
            this.Ora_Tree.Name = "Ora_Tree";
            this.Ora_Tree.Size = new System.Drawing.Size(303, 404);
            this.Ora_Tree.TabIndex = 0;
            // 
            // Ora_Panel_2
            // 
            this.Ora_Panel_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ora_Panel_2.Location = new System.Drawing.Point(0, 0);
            this.Ora_Panel_2.Name = "Ora_Panel_2";
            this.Ora_Panel_2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Ora_Panel_2.Panel1
            // 
            this.Ora_Panel_2.Panel1.Controls.Add(this.Ora_Text);
            // 
            // Ora_Panel_2.Panel2
            // 
            this.Ora_Panel_2.Panel2.Controls.Add(this.Ora_Tab);
            this.Ora_Panel_2.Size = new System.Drawing.Size(493, 404);
            this.Ora_Panel_2.SplitterDistance = 164;
            this.Ora_Panel_2.TabIndex = 0;
            // 
            // Ora_Text
            // 
            this.Ora_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ora_Text.Location = new System.Drawing.Point(0, 0);
            this.Ora_Text.Multiline = true;
            this.Ora_Text.Name = "Ora_Text";
            this.Ora_Text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Ora_Text.Size = new System.Drawing.Size(493, 164);
            this.Ora_Text.TabIndex = 0;
            // 
            // Ora_Tab
            // 
            this.Ora_Tab.Controls.Add(this.tabPage1);
            this.Ora_Tab.Controls.Add(this.tabPage2);
            this.Ora_Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ora_Tab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Ora_Tab.ItemSize = new System.Drawing.Size(300, 20);
            this.Ora_Tab.Location = new System.Drawing.Point(0, 0);
            this.Ora_Tab.Multiline = true;
            this.Ora_Tab.Name = "Ora_Tab";
            this.Ora_Tab.SelectedIndex = 0;
            this.Ora_Tab.Size = new System.Drawing.Size(493, 236);
            this.Ora_Tab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Ora_Tab.TabIndex = 0;
            this.Ora_Tab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Ora_Tab_DrawItem);
            this.Ora_Tab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ora_Tab_MouseClick);
            this.Ora_Tab.MouseLeave += new System.EventHandler(this.Ora_Tab_MouseLeave);
            this.Ora_Tab.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ora_Tab_MouseMove);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Ora_DtGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(485, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Ora_DtGrid
            // 
            this.Ora_DtGrid.AllowUserToAddRows = false;
            this.Ora_DtGrid.AllowUserToDeleteRows = false;
            this.Ora_DtGrid.AllowUserToResizeColumns = false;
            this.Ora_DtGrid.AllowUserToResizeRows = false;
            this.Ora_DtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ora_DtGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ora_DtGrid.Location = new System.Drawing.Point(3, 3);
            this.Ora_DtGrid.Name = "Ora_DtGrid";
            this.Ora_DtGrid.ReadOnly = true;
            this.Ora_DtGrid.Size = new System.Drawing.Size(479, 202);
            this.Ora_DtGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(485, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OraEdge_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ora_Panel_1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MNU_EDGE);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MNU_EDGE;
            this.Name = "OraEdge_Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle Edge";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OraEdge_Parent_FormClosed);
            this.Load += new System.EventHandler(this.OraEdge_Parent_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OraEdge_Parent_KeyDown);
            this.MNU_EDGE.ResumeLayout(false);
            this.MNU_EDGE.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Ora_Panel_1.Panel1.ResumeLayout(false);
            this.Ora_Panel_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ora_Panel_1)).EndInit();
            this.Ora_Panel_1.ResumeLayout(false);
            this.Ora_Panel_2.Panel1.ResumeLayout(false);
            this.Ora_Panel_2.Panel1.PerformLayout();
            this.Ora_Panel_2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ora_Panel_2)).EndInit();
            this.Ora_Panel_2.ResumeLayout(false);
            this.Ora_Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ora_DtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip MNU_EDGE;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Connect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem Ora_Exit;
        private System.Windows.Forms.SplitContainer Ora_Panel_1;
        private System.Windows.Forms.SplitContainer Ora_Panel_2;
        private System.Windows.Forms.TextBox Ora_Text;
        private System.Windows.Forms.TabControl Ora_Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Ora_DtGrid;
        private System.Windows.Forms.TreeView Ora_Tree;
    }
}

