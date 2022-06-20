namespace Retaguarda
{
    partial class fmrPrincipal
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
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parceiroNegocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePreçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parceiroNegocioToolStripMenuItem,
            this.tipoDePreçoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // parceiroNegocioToolStripMenuItem
            // 
            this.parceiroNegocioToolStripMenuItem.Name = "parceiroNegocioToolStripMenuItem";
            this.parceiroNegocioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parceiroNegocioToolStripMenuItem.Text = "Parceiro Negocio";
            this.parceiroNegocioToolStripMenuItem.Click += new System.EventHandler(this.parceiroNegocioToolStripMenuItem_Click);
            // 
            // tipoDePreçoToolStripMenuItem
            // 
            this.tipoDePreçoToolStripMenuItem.Name = "tipoDePreçoToolStripMenuItem";
            this.tipoDePreçoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoDePreçoToolStripMenuItem.Text = "Tipo de Preço";
            this.tipoDePreçoToolStripMenuItem.Click += new System.EventHandler(this.tipoDePreçoToolStripMenuItem_Click);
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 620);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmrPrincipal";
            this.Text = "Sistema de Vendas - Retaguarda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parceiroNegocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePreçoToolStripMenuItem;
    }
}