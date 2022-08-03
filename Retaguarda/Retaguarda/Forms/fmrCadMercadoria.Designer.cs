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
            this.chkComboKit = new System.Windows.Forms.CheckBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabEstoque = new System.Windows.Forms.TabPage();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.IdLocalEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cbmPadraoSaida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmPadraoEntrada = new System.Windows.Forms.ComboBox();
            this.tabVenda = new System.Windows.Forms.TabPage();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.dgvPrecoMercadoria = new System.Windows.Forms.DataGridView();
            this.IdTipoPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoMercadoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbmTipoPreco = new System.Windows.Forms.ComboBox();
            this.tabCombo = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemoverMerc = new System.Windows.Forms.Button();
            this.dgvMercadoriaCombo = new System.Windows.Forms.DataGridView();
            this.IdMercadoriaCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoMercadoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdcionarMerc = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbmMercadoria = new System.Windows.Forms.ComboBox();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.tabVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecoMercadoria)).BeginInit();
            this.tabCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercadoriaCombo)).BeginInit();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // chkComboKit
            // 
            this.chkComboKit.AutoSize = true;
            this.chkComboKit.Location = new System.Drawing.Point(765, 32);
            this.chkComboKit.Name = "chkComboKit";
            this.chkComboKit.Size = new System.Drawing.Size(74, 17);
            this.chkComboKit.TabIndex = 7;
            this.chkComboKit.Text = "Combo Kit";
            this.chkComboKit.UseVisualStyleBackColor = true;
            this.chkComboKit.CheckedChanged += new System.EventHandler(this.chkComboKit_CheckedChanged);
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
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(18, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Estoque Padrão de Entrada";
            // 
            // cbmPadraoEntrada
            // 
            this.cbmPadraoEntrada.FormattingEnabled = true;
            this.cbmPadraoEntrada.Location = new System.Drawing.Point(52, 41);
            this.cbmPadraoEntrada.Name = "cbmPadraoEntrada";
            this.cbmPadraoEntrada.Size = new System.Drawing.Size(206, 21);
            this.cbmPadraoEntrada.TabIndex = 0;
            // 
            // tabVenda
            // 
            this.tabVenda.Controls.Add(this.btnRemover);
            this.tabVenda.Controls.Add(this.btnAdcionar);
            this.tabVenda.Controls.Add(this.dgvPrecoMercadoria);
            this.tabVenda.Controls.Add(this.label8);
            this.tabVenda.Controls.Add(this.label7);
            this.tabVenda.Controls.Add(this.txtPreco);
            this.tabVenda.Controls.Add(this.label6);
            this.tabVenda.Controls.Add(this.cbmTipoPreco);
            this.tabVenda.Location = new System.Drawing.Point(4, 22);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenda.Size = new System.Drawing.Size(882, 373);
            this.tabVenda.TabIndex = 1;
            this.tabVenda.Text = "Venda";
            this.tabVenda.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(400, 129);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.Location = new System.Drawing.Point(400, 100);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdcionar.TabIndex = 6;
            this.btnAdcionar.Text = "Adcionar";
            this.btnAdcionar.UseVisualStyleBackColor = true;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // dgvPrecoMercadoria
            // 
            this.dgvPrecoMercadoria.AllowUserToAddRows = false;
            this.dgvPrecoMercadoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecoMercadoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTipoPreco,
            this.TipoPreco,
            this.PrecoMercadoria,
            this.Prioridade});
            this.dgvPrecoMercadoria.Location = new System.Drawing.Point(49, 83);
            this.dgvPrecoMercadoria.Name = "dgvPrecoMercadoria";
            this.dgvPrecoMercadoria.ReadOnly = true;
            this.dgvPrecoMercadoria.RowHeadersVisible = false;
            this.dgvPrecoMercadoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrecoMercadoria.Size = new System.Drawing.Size(324, 274);
            this.dgvPrecoMercadoria.TabIndex = 5;
            // 
            // IdTipoPreco
            // 
            this.IdTipoPreco.DataPropertyName = "IdTipoPreco";
            this.IdTipoPreco.HeaderText = "IdTipoPreco";
            this.IdTipoPreco.Name = "IdTipoPreco";
            this.IdTipoPreco.ReadOnly = true;
            this.IdTipoPreco.Visible = false;
            // 
            // TipoPreco
            // 
            this.TipoPreco.DataPropertyName = "DescricaoPreco";
            this.TipoPreco.HeaderText = "Tipo de Preço";
            this.TipoPreco.Name = "TipoPreco";
            this.TipoPreco.ReadOnly = true;
            this.TipoPreco.Width = 120;
            // 
            // PrecoMercadoria
            // 
            this.PrecoMercadoria.DataPropertyName = "PrecoMercadoria";
            this.PrecoMercadoria.HeaderText = "Preço";
            this.PrecoMercadoria.Name = "PrecoMercadoria";
            this.PrecoMercadoria.ReadOnly = true;
            // 
            // Prioridade
            // 
            this.Prioridade.DataPropertyName = "Prioridade";
            this.Prioridade.HeaderText = "Prioridade";
            this.Prioridade.Name = "Prioridade";
            this.Prioridade.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Preço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tipo de Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(250, 35);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "=";
            // 
            // cbmTipoPreco
            // 
            this.cbmTipoPreco.FormattingEnabled = true;
            this.cbmTipoPreco.Location = new System.Drawing.Point(49, 35);
            this.cbmTipoPreco.Name = "cbmTipoPreco";
            this.cbmTipoPreco.Size = new System.Drawing.Size(155, 21);
            this.cbmTipoPreco.TabIndex = 0;
            // 
            // tabCombo
            // 
            this.tabCombo.Controls.Add(this.label10);
            this.tabCombo.Controls.Add(this.label9);
            this.tabCombo.Controls.Add(this.btnRemoverMerc);
            this.tabCombo.Controls.Add(this.dgvMercadoriaCombo);
            this.tabCombo.Controls.Add(this.btnAdcionarMerc);
            this.tabCombo.Controls.Add(this.txtQuantidade);
            this.tabCombo.Controls.Add(this.cbmMercadoria);
            this.tabCombo.Location = new System.Drawing.Point(4, 22);
            this.tabCombo.Name = "tabCombo";
            this.tabCombo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCombo.Size = new System.Drawing.Size(882, 373);
            this.tabCombo.TabIndex = 2;
            this.tabCombo.Text = "Combo Kit";
            this.tabCombo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(581, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Quantidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mercadorias";
            // 
            // btnRemoverMerc
            // 
            this.btnRemoverMerc.Location = new System.Drawing.Point(796, 99);
            this.btnRemoverMerc.Name = "btnRemoverMerc";
            this.btnRemoverMerc.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverMerc.TabIndex = 4;
            this.btnRemoverMerc.Text = "Remover";
            this.btnRemoverMerc.UseVisualStyleBackColor = true;
            this.btnRemoverMerc.Click += new System.EventHandler(this.btnRemoverMerc_Click);
            // 
            // dgvMercadoriaCombo
            // 
            this.dgvMercadoriaCombo.AllowUserToAddRows = false;
            this.dgvMercadoriaCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercadoriaCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMercadoriaCombo,
            this.DescricaoMercadoria,
            this.Quantidade});
            this.dgvMercadoriaCombo.Location = new System.Drawing.Point(16, 65);
            this.dgvMercadoriaCombo.Name = "dgvMercadoriaCombo";
            this.dgvMercadoriaCombo.ReadOnly = true;
            this.dgvMercadoriaCombo.RowHeadersVisible = false;
            this.dgvMercadoriaCombo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMercadoriaCombo.Size = new System.Drawing.Size(774, 295);
            this.dgvMercadoriaCombo.TabIndex = 3;
            // 
            // IdMercadoriaCombo
            // 
            this.IdMercadoriaCombo.DataPropertyName = "IdMercadoriaCombo";
            this.IdMercadoriaCombo.HeaderText = "IdMercadoriaCombo";
            this.IdMercadoriaCombo.Name = "IdMercadoriaCombo";
            this.IdMercadoriaCombo.ReadOnly = true;
            this.IdMercadoriaCombo.Visible = false;
            // 
            // DescricaoMercadoria
            // 
            this.DescricaoMercadoria.DataPropertyName = "DescricaoMercadoriaCombo";
            this.DescricaoMercadoria.HeaderText = "Descrição";
            this.DescricaoMercadoria.Name = "DescricaoMercadoria";
            this.DescricaoMercadoria.ReadOnly = true;
            this.DescricaoMercadoria.Width = 680;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // btnAdcionarMerc
            // 
            this.btnAdcionarMerc.Location = new System.Drawing.Point(699, 31);
            this.btnAdcionarMerc.Name = "btnAdcionarMerc";
            this.btnAdcionarMerc.Size = new System.Drawing.Size(75, 23);
            this.btnAdcionarMerc.TabIndex = 2;
            this.btnAdcionarMerc.Text = "Adcionar";
            this.btnAdcionarMerc.UseVisualStyleBackColor = true;
            this.btnAdcionarMerc.Click += new System.EventHandler(this.btnAdcionarMerc_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(559, 31);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 1;
            // 
            // cbmMercadoria
            // 
            this.cbmMercadoria.FormattingEnabled = true;
            this.cbmMercadoria.Location = new System.Drawing.Point(63, 31);
            this.cbmMercadoria.Name = "cbmMercadoria";
            this.cbmMercadoria.Size = new System.Drawing.Size(466, 21);
            this.cbmMercadoria.TabIndex = 0;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.dataGridView1);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisa.Size = new System.Drawing.Size(896, 493);
            this.tabPesquisa.TabIndex = 1;
            this.tabPesquisa.Text = "Pesquisa";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(156, 531);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(355, 531);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(558, 531);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.SalvarOuAtualizar);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // fmrCadMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 566);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tabControl1);
            this.Name = "fmrCadMercadoria";
            this.Text = "Cadastro de Mercadoria";
            this.tabControl1.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabEstoque.ResumeLayout(false);
            this.tabEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.tabVenda.ResumeLayout(false);
            this.tabVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecoMercadoria)).EndInit();
            this.tabCombo.ResumeLayout(false);
            this.tabCombo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercadoriaCombo)).EndInit();
            this.tabPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox cbmTipoPreco;
        private System.Windows.Forms.TabPage tabCombo;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.DataGridView dgvPrecoMercadoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemoverMerc;
        private System.Windows.Forms.DataGridView dgvMercadoriaCombo;
        private System.Windows.Forms.Button btnAdcionarMerc;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cbmMercadoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMercadoriaCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoMercadoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoMercadoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridade;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}