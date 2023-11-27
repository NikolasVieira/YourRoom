namespace YourRoom.Views
{
    partial class frmPrincipal
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
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedesF3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentaçãoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospedesF3ToolStripMenuItem,
            this.quartosF2ToolStripMenuItem,
            this.usuariosF4ToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // hospedesF3ToolStripMenuItem
            // 
            this.hospedesF3ToolStripMenuItem.Name = "hospedesF3ToolStripMenuItem";
            this.hospedesF3ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.hospedesF3ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.hospedesF3ToolStripMenuItem.Text = "Hospedes";
            this.hospedesF3ToolStripMenuItem.Click += new System.EventHandler(this.hospedesF3ToolStripMenuItem_Click);
            // 
            // quartosF2ToolStripMenuItem
            // 
            this.quartosF2ToolStripMenuItem.Name = "quartosF2ToolStripMenuItem";
            this.quartosF2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.quartosF2ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.quartosF2ToolStripMenuItem.Text = "Quartos";
            this.quartosF2ToolStripMenuItem.Click += new System.EventHandler(this.quartosF2ToolStripMenuItem_Click);
            // 
            // usuariosF4ToolStripMenuItem
            // 
            this.usuariosF4ToolStripMenuItem.Name = "usuariosF4ToolStripMenuItem";
            this.usuariosF4ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.usuariosF4ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.usuariosF4ToolStripMenuItem.Text = "Usuarios";
            this.usuariosF4ToolStripMenuItem.Click += new System.EventHandler(this.usuariosF4ToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospedesF3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartosF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosF4ToolStripMenuItem;
    }
}