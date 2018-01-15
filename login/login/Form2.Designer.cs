namespace login
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrasiUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambilCucianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.menu2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrasiUserToolStripMenuItem,
            this.submenu2ToolStripMenuItem,
            this.submenu3ToolStripMenuItem,
            this.submenu4ToolStripMenuItem,
            this.ambilCucianToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.menu1ToolStripMenuItem.Text = "Menu 1";
            // 
            // registrasiUserToolStripMenuItem
            // 
            this.registrasiUserToolStripMenuItem.Name = "registrasiUserToolStripMenuItem";
            this.registrasiUserToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.registrasiUserToolStripMenuItem.Text = "registrasi user";
            this.registrasiUserToolStripMenuItem.Click += new System.EventHandler(this.registrasiUserToolStripMenuItem_Click);
            // 
            // submenu2ToolStripMenuItem
            // 
            this.submenu2ToolStripMenuItem.Name = "submenu2ToolStripMenuItem";
            this.submenu2ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.submenu2ToolStripMenuItem.Text = "data pelanggan";
            this.submenu2ToolStripMenuItem.Click += new System.EventHandler(this.submenu2ToolStripMenuItem_Click);
            // 
            // submenu3ToolStripMenuItem
            // 
            this.submenu3ToolStripMenuItem.Name = "submenu3ToolStripMenuItem";
            this.submenu3ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.submenu3ToolStripMenuItem.Text = "transaksi";
            // 
            // submenu4ToolStripMenuItem
            // 
            this.submenu4ToolStripMenuItem.Name = "submenu4ToolStripMenuItem";
            this.submenu4ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.submenu4ToolStripMenuItem.Text = "paket";
            this.submenu4ToolStripMenuItem.Click += new System.EventHandler(this.submenu4ToolStripMenuItem_Click);
            // 
            // ambilCucianToolStripMenuItem
            // 
            this.ambilCucianToolStripMenuItem.Name = "ambilCucianToolStripMenuItem";
            this.ambilCucianToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ambilCucianToolStripMenuItem.Text = "type";
            this.ambilCucianToolStripMenuItem.Click += new System.EventHandler(this.ambilCucianToolStripMenuItem_Click);
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu1ToolStripMenuItem,
            this.submenu2ToolStripMenuItem1,
            this.submenu3ToolStripMenuItem1});
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.menu2ToolStripMenuItem.Text = "Menu 2";
            // 
            // submenu1ToolStripMenuItem
            // 
            this.submenu1ToolStripMenuItem.Name = "submenu1ToolStripMenuItem";
            this.submenu1ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.submenu1ToolStripMenuItem.Text = "submenu1";
            // 
            // submenu2ToolStripMenuItem1
            // 
            this.submenu2ToolStripMenuItem1.Name = "submenu2ToolStripMenuItem1";
            this.submenu2ToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.submenu2ToolStripMenuItem1.Text = "submenu2";
            // 
            // submenu3ToolStripMenuItem1
            // 
            this.submenu3ToolStripMenuItem1.Name = "submenu3ToolStripMenuItem1";
            this.submenu3ToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.submenu3ToolStripMenuItem1.Text = "submenu3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 411);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrasiUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submenu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submenu3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submenu4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submenu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submenu2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem submenu3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ambilCucianToolStripMenuItem;
    }
}