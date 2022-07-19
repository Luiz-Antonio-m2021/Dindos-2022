namespace Retaguarda.Retaguarda.Forms
{
    partial class fmrCadMercadoria
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabEstoque = new System.Windows.Forms.TabPage();
            this.tabVenda = new System.Windows.Forms.TabPage();
            this.tabCombo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkComboKit = new System.Windows.Forms.CheckBox();
            this.cbmPadraoEntrada = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbmPadraoSaida = new System.Windows.Forms.ComboBox();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.IdLocalEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabEstoque.SuspendLayout();
            this.tabVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDados);
            this.tabControl1.Controls.Add(this.tabPesquisa);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDados
            // 
            this.tabDados.BackColor = System.Drawing.Color.Silver;
            this.tabDados.Controls.Add(this.chkComboKit);
            this.tabDados.Controls.Add(this.txtCodBarras);
            this.tabDados.Controls.Add(this.label3);
            this.tabDados.Controls.Add(this.txtDescricao);
            this.tabDados.Controls.Add(this.label2);
            this.tabDados.Controls.Add(this.txtId);
            this.tabDados.Controls.Add(this.label1);
            this.tabDados.Controls.Add(this.tabControl2);
            this.tabDados.Location = new System.Drawing.Point(4, 22);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(896, 493);
            this.tabDados.TabIndex = 0;
            this.tabDados.Text = "Cadastro";
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisa.Size = new System.Drawing.Size(896, 493);
            this.tabPesquisa.TabIndex = 1;
            this.tabPesquisa.Text = "Pesquisa";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabEstoque);
            this.tabControl2.Controls.Add(this.tabVenda);
            this.tabControl2.Controls.Add(this.tabCombo);
            this.tabControl2.Location = new System.Drawing.Point(3, 88);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(890, 399);
            this.tabControl2.TabIndex = 0;
            // 
            // tabEstoque
            // 
            this.tabEstoque.Controls.Add(this.dgvEstoque);
            this.tabEstoque.Controls.Add(this.label5);
            this.tabEstoque.Controls.Add(this.cbmPadraoSaida);
            this.tabEstoque.Controls.Add(this.label4);
            this.tabEstoque.Controls.Add(this.cbmPadraoEntrada);
            this.tabEstoque.Location = new System.Drawing.Point(4, 22);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstoque.Size = new System.Drawing.Size(882, 373);
            this.tabEstoque.TabIndex = 0;
            this.tabEstoque.Text = "Estoque";
            this.tabEstoque.UseVisualStyleBackColor = true;
            // 
            // tabVenda
            // 
            this.tabVenda.Controls.Add(this.comboBox1);
            this.tabVenda.Location = new System.Drawing.Point(4, 22);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenda.Size = new System.Drawing.Size(882, 373);
            this.tabVenda.TabIndex = 1;
            this.tabVenda.Text = "Venda";
            this.tabVenda.UseVisualStyleBackColor = true;
            // 
            // tabCombo
            // 
            this.tabCombo.Location = new System.Drawing.Point(4, 22);
            this.tabCombo.Name = "tabCombo";
            this.tabCombo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCombo.Size = new System.Drawing.Size(882, 373);
            this.tabCombo.TabIndex = 2;
            this.tabCombo.Text = "Combo Kit";
            this.tabCombo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(18, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(142, 29);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(394, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição da Mercadoria";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(566, 29);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(144, 20);
            this.txtCodBarras.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "GTIN / EAN";
            // 
            // chkComboKit
            // 
            this.chkComboKit.AutoSize = true;
            this.chkComboKit.Location = new System.Drawing.Point(765, 32);
            this.chkComboKit.Name = "chkComboKit";
            this.chkComboKit.Size = new System.Drawing.Size(74, 17);
            this.chkComboKit.TabIndex = 7;
            this.chkComboKit.Text = "Combo Kit";
            this.chkComboKit.UseVisualStyleBackColor = true;
            // 
            // cbmPadraoEntrada
            // 
            this.cbmPadraoEntrada.FormattingEnabled = true;
            this.cbmPadraoEntrada.Location = new System.Drawing.Point(52, 41);
            this.cbmPadraoEntrada.Name = "cbmPadraoEntrada";
            this.cbmPadraoEntrada.Size = new System.Drawing.Size(206, 21);
            this.cbmPadraoEntrada.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Estoque Padrão de Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Estoque Padrão de Saída";
            // 
            // cbmPadraoSaida
            // 
            this.cbmPadraoSaida.FormattingEnabled = true;
            this.cbmPadraoSaida.Location = new System.Drawing.Point(323, 41);
            this.cbmPadraoSaida.Name = "cbmPadraoSaida";
            this.cbmPadraoSaida.Size = new System.Drawing.Size(206, 21);
            this.cbmPadraoSaida.TabIndex = 2;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLocalEstoque,
            this.Descricao,
            this.Qtd});
            this.dgvEstoque.Location = new System.Drawing.Point(54, 102);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.Size = new System.Drawing.Size(505, 254);
            this.dgvEstoque.TabIndex = 4;
            // 
            // IdLocalEstoque
            // 
            this.IdLocalEstoque.HeaderText = "ID";
            this.IdLocalEstoque.Name = "IdLocalEstoque";
            this.IdLocalEstoque.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // Qtd
            // 
            this.Qtd.HeaderText = "Quantidade em estoque";
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Width = 200;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // fmrCadMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 566);
            this.Controls.Add(this.tabControl1);
            this.Name = "fmrCadMercadoria";
            this.Text = "Cadastro de Mercadoria";
            this.tabControl1.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabEstoque.ResumeLayout(false);
            this.tabEstoque.PerformLayout();
            this.tabVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.CheckBox chkComboKit;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabEstoque;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLocalEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbmPadraoSaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmPadraoEntrada;
        private System.Windows.Forms.TabPage tabVenda;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabCombo;
        private System.Windows.Forms.TabPage tabPesquisa;
    }
}