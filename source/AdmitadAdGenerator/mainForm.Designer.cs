namespace AdmitadAdGenerator
{
    partial class mainForm
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
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.admitadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admitadAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admitadProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admitadToolStripMenuItem,
            this.операцииToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(822, 24);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "topMenu";
            // 
            // admitadToolStripMenuItem
            // 
            this.admitadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admitadAccountToolStripMenuItem,
            this.admitadProgramToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.admitadToolStripMenuItem.Name = "admitadToolStripMenuItem";
            this.admitadToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.admitadToolStripMenuItem.Text = "Admitad";
            // 
            // admitadAccountToolStripMenuItem
            // 
            this.admitadAccountToolStripMenuItem.Name = "admitadAccountToolStripMenuItem";
            this.admitadAccountToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.admitadAccountToolStripMenuItem.Text = "Аккаунты";
            // 
            // admitadProgramToolStripMenuItem
            // 
            this.admitadProgramToolStripMenuItem.Name = "admitadProgramToolStripMenuItem";
            this.admitadProgramToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.admitadProgramToolStripMenuItem.Text = "Программы";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(822, 484);
            this.Controls.Add(this.topMenu);
            this.MainMenuStrip = this.topMenu;
            this.Name = "mainForm";
            this.Text = "Генератор рекламных объявлений из фидов Admitad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem admitadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admitadAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admitadProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
    }
}