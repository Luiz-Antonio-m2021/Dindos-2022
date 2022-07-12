namespace Retaguarda
{
    partial class fmrCadParceiroNegocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.txtRgIe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeRazao = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDados = new System.Windows.Forms.TabControl();
            this.tabDadosPN = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkUsuario = new System.Windows.Forms.CheckBox();
            this.chkAVista = new System.Windows.Forms.CheckBox();
            this.chkAPrazo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbmCidade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbmEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabTipoPNPrazo = new System.Windows.Forms.TabPage();
            this.cbmTipoPrecoPrazo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabTipoPNVista = new System.Windows.Forms.TabPage();
            this.cbmTipoPrecoVista = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPesquisar = new System.Windows.Forms.TabPage();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivoProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrazoAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVistaAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRGIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdPrecoAPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdPrecoAVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.tabDadosPN.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTipoPNPrazo.SuspendLayout();
            this.tabTipoPNVista.SuspendLayout();
            this.tabPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabPesquisar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.Gainsboro;
            this.tabCadastrar.Controls.Add(this.txtRgIe);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.txtCpfCnpj);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Controls.Add(this.txtNomeRazao);
            this.tabCadastrar.Controls.Add(this.label);
            this.tabCadastrar.Controls.Add(this.txtId);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.tabDados);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(800, 441);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar";
            // 
            // txtRgIe
            // 
            this.txtRgIe.Location = new System.Drawing.Point(633, 28);
            this.txtRgIe.Name = "txtRgIe";
            this.txtRgIe.Size = new System.Drawing.Size(147, 20);
            this.txtRgIe.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RG / IE";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(480, 28);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(147, 20);
            this.txtCpfCnpj.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF / CNPJ";
            // 
            // txtNomeRazao
            // 
            this.txtNomeRazao.Location = new System.Drawing.Point(73, 28);
            this.txtNomeRazao.Name = "txtNomeRazao";
            this.txtNomeRazao.Size = new System.Drawing.Size(391, 20);
            this.txtNomeRazao.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(73, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(112, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Nome / Razão Social:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(7, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 20);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.tabDadosPN);
            this.tabDados.Controls.Add(this.tabTipoPNPrazo);
            this.tabDados.Controls.Add(this.tabTipoPNVista);
            this.tabDados.Location = new System.Drawing.Point(3, 67);
            this.tabDados.Name = "tabDados";
            this.tabDados.SelectedIndex = 0;
            this.tabDados.Size = new System.Drawing.Size(796, 371);
            this.tabDados.TabIndex = 0;
            // 
            // tabDadosPN
            // 
            this.tabDadosPN.Controls.Add(this.groupBox3);
            this.tabDadosPN.Controls.Add(this.groupBox2);
            this.tabDadosPN.Controls.Add(this.groupBox1);
            this.tabDadosPN.Location = new System.Drawing.Point(4, 22);
            this.tabDadosPN.Name = "tabDadosPN";
            this.tabDadosPN.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosPN.Size = new System.Drawing.Size(788, 345);
            this.tabDadosPN.TabIndex = 0;
            this.tabDadosPN.Text = "Dados Principais";
            this.tabDadosPN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkUsuario);
            this.groupBox3.Controls.Add(this.chkAVista);
            this.groupBox3.Controls.Add(this.chkAPrazo);
            this.groupBox3.Location = new System.Drawing.Point(436, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 136);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo Parceiro:";
            // 
            // chkUsuario
            // 
            this.chkUsuario.AutoSize = true;
            this.chkUsuario.Location = new System.Drawing.Point(47, 83);
            this.chkUsuario.Name = "chkUsuario";
            this.chkUsuario.Size = new System.Drawing.Size(81, 17);
            this.chkUsuario.TabIndex = 2;
            this.chkUsuario.Text = "Funcionario";
            this.chkUsuario.UseVisualStyleBackColor = true;
            // 
            // chkAVista
            // 
            this.chkAVista.AutoSize = true;
            this.chkAVista.Location = new System.Drawing.Point(47, 59);
            this.chkAVista.Name = "chkAVista";
            this.chkAVista.Size = new System.Drawing.Size(101, 17);
            this.chkAVista.TabIndex = 1;
            this.chkAVista.Text = "Parceiro A Vista";
            this.chkAVista.UseVisualStyleBackColor = true;
            this.chkAVista.CheckedChanged += new System.EventHandler(this.chkAVista_CheckedChanged);
            // 
            // chkAPrazo
            // 
            this.chkAPrazo.AutoSize = true;
            this.chkAPrazo.Location = new System.Drawing.Point(47, 36);
            this.chkAPrazo.Name = "chkAPrazo";
            this.chkAPrazo.Size = new System.Drawing.Size(105, 17);
            this.chkAPrazo.TabIndex = 0;
            this.chkAPrazo.Text = "Parceiro A Prazo";
            this.chkAPrazo.UseVisualStyleBackColor = true;
            this.chkAPrazo.CheckStateChanged += new System.EventHandler(this.chkAPrazo_CheckStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCEP);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtLogradouro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbmCidade);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbmEstado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 194);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(25, 143);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(147, 20);
            this.txtBairro.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Bairro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(25, 98);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(393, 20);
            this.txtLogradouro.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Logradouro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "/";
            // 
            // cbmCidade
            // 
            this.cbmCidade.FormattingEnabled = true;
            this.cbmCidade.Location = new System.Drawing.Point(212, 43);
            this.cbmCidade.Name = "cbmCidade";
            this.cbmCidade.Size = new System.Drawing.Size(179, 21);
            this.cbmCidade.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cidade:";
            // 
            // cbmEstado
            // 
            this.cbmEstado.FormattingEnabled = true;
            this.cbmEstado.Location = new System.Drawing.Point(25, 42);
            this.cbmEstado.Name = "cbmEstado";
            this.cbmEstado.Size = new System.Drawing.Size(147, 21);
            this.cbmEstado.TabIndex = 1;
            this.cbmEstado.SelectedIndexChanged += new System.EventHandler(this.cbmEstado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Estado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 136);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contato:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(25, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(393, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "e-mail:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(25, 38);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(147, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefone:";
            // 
            // tabTipoPNPrazo
            // 
            this.tabTipoPNPrazo.Controls.Add(this.cbmTipoPrecoPrazo);
            this.tabTipoPNPrazo.Controls.Add(this.label13);
            this.tabTipoPNPrazo.Location = new System.Drawing.Point(4, 22);
            this.tabTipoPNPrazo.Name = "tabTipoPNPrazo";
            this.tabTipoPNPrazo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTipoPNPrazo.Size = new System.Drawing.Size(788, 345);
            this.tabTipoPNPrazo.TabIndex = 1;
            this.tabTipoPNPrazo.Text = "Parceiro A Prazo";
            this.tabTipoPNPrazo.UseVisualStyleBackColor = true;
            // 
            // cbmTipoPrecoPrazo
            // 
            this.cbmTipoPrecoPrazo.FormattingEnabled = true;
            this.cbmTipoPrecoPrazo.Location = new System.Drawing.Point(41, 59);
            this.cbmTipoPrecoPrazo.Name = "cbmTipoPrecoPrazo";
            this.cbmTipoPrecoPrazo.Size = new System.Drawing.Size(192, 21);
            this.cbmTipoPrecoPrazo.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tipo de Preço A Prazo";
            // 
            // tabTipoPNVista
            // 
            this.tabTipoPNVista.Controls.Add(this.cbmTipoPrecoVista);
            this.tabTipoPNVista.Controls.Add(this.label14);
            this.tabTipoPNVista.Location = new System.Drawing.Point(4, 22);
            this.tabTipoPNVista.Name = "tabTipoPNVista";
            this.tabTipoPNVista.Size = new System.Drawing.Size(788, 345);
            this.tabTipoPNVista.TabIndex = 2;
            this.tabTipoPNVista.Text = "Parceiro A Vista";
            this.tabTipoPNVista.UseVisualStyleBackColor = true;
            // 
            // cbmTipoPrecoVista
            // 
            this.cbmTipoPrecoVista.FormattingEnabled = true;
            this.cbmTipoPrecoVista.Location = new System.Drawing.Point(33, 55);
            this.cbmTipoPrecoVista.Name = "cbmTipoPrecoVista";
            this.cbmTipoPrecoVista.Size = new System.Drawing.Size(192, 21);
            this.cbmTipoPrecoVista.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tipo de Preço A Vista";
            // 
            // tabPesquisar
            // 
            this.tabPesquisar.Controls.Add(this.txtPesquisar);
            this.tabPesquisar.Controls.Add(this.label1);
            this.tabPesquisar.Controls.Add(this.dgvPesquisa);
            this.tabPesquisar.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisar.Name = "tabPesquisar";
            this.tabPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisar.Size = new System.Drawing.Size(800, 441);
            this.tabPesquisar.TabIndex = 1;
            this.tabPesquisar.Text = "Pesquisar";
            this.tabPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(110, 25);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(524, 20);
            this.txtPesquisar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar:";
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colAtivoProxy,
            this.colPrazoAtivo,
            this.colVistaAtivo,
            this.colNomeRazao,
            this.colCpfCnpj,
            this.colEmail,
            this.colIdCidade,
            this.colDescCidade,
            this.colIdEstado,
            this.colDescEstado,
            this.colRGIE,
            this.colTelefone,
            this.colLogradouro,
            this.colBairro,
            this.colCEP,
            this.colTipoPN,
            this.colIdPrecoAPrazo,
            this.colIdPrecoAVista});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPesquisa.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPesquisa.Location = new System.Drawing.Point(6, 73);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.RowHeadersVisible = false;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(788, 362);
            this.dgvPesquisa.TabIndex = 0;
            this.dgvPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisa_CellDoubleClick);
            this.dgvPesquisa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPesquisa_CellFormatting);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(219, 497);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(392, 497);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(568, 497);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.SalvarOuAtualizar);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(214, 143);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(147, 20);
            this.txtCEP.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(211, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "CEP:";
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Código";
            this.colId.Name = "colId";
            // 
            // colAtivoProxy
            // 
            this.colAtivoProxy.DataPropertyName = "AtivoProxy";
            this.colAtivoProxy.HeaderText = "Status";
            this.colAtivoProxy.Name = "colAtivoProxy";
            // 
            // colPrazoAtivo
            // 
            this.colPrazoAtivo.HeaderText = "PrazoAtivo";
            this.colPrazoAtivo.Name = "colPrazoAtivo";
            this.colPrazoAtivo.Visible = false;
            // 
            // colVistaAtivo
            // 
            this.colVistaAtivo.HeaderText = "VistaAtivo";
            this.colVistaAtivo.Name = "colVistaAtivo";
            this.colVistaAtivo.Visible = false;
            // 
            // colNomeRazao
            // 
            this.colNomeRazao.DataPropertyName = "NomeRazao";
            this.colNomeRazao.HeaderText = "Nome / Razão Social";
            this.colNomeRazao.Name = "colNomeRazao";
            // 
            // colCpfCnpj
            // 
            this.colCpfCnpj.DataPropertyName = "CpfCnpj";
            this.colCpfCnpj.HeaderText = "CPF / CNPJ";
            this.colCpfCnpj.Name = "colCpfCnpj";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.Name = "colEmail";
            // 
            // colIdCidade
            // 
            this.colIdCidade.DataPropertyName = "IdCidade";
            this.colIdCidade.HeaderText = "IdCidade";
            this.colIdCidade.Name = "colIdCidade";
            this.colIdCidade.Visible = false;
            // 
            // colDescCidade
            // 
            this.colDescCidade.DataPropertyName = "DescCidade";
            this.colDescCidade.HeaderText = "Cidade";
            this.colDescCidade.Name = "colDescCidade";
            // 
            // colIdEstado
            // 
            this.colIdEstado.DataPropertyName = "IdEstado";
            this.colIdEstado.HeaderText = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.Visible = false;
            // 
            // colDescEstado
            // 
            this.colDescEstado.DataPropertyName = "DescEstado";
            this.colDescEstado.HeaderText = "Estado";
            this.colDescEstado.Name = "colDescEstado";
            // 
            // colRGIE
            // 
            this.colRGIE.DataPropertyName = "RGIE";
            this.colRGIE.HeaderText = "RG / IE";
            this.colRGIE.Name = "colRGIE";
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "Telefone";
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            // 
            // colLogradouro
            // 
            this.colLogradouro.DataPropertyName = "Logradouro";
            this.colLogradouro.HeaderText = "Logradouro";
            this.colLogradouro.Name = "colLogradouro";
            // 
            // colBairro
            // 
            this.colBairro.DataPropertyName = "Bairro";
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.Name = "colBairro";
            // 
            // colCEP
            // 
            this.colCEP.DataPropertyName = "CEP";
            this.colCEP.HeaderText = "CEP";
            this.colCEP.Name = "colCEP";
            // 
            // colTipoPN
            // 
            this.colTipoPN.DataPropertyName = "TipoPN";
            this.colTipoPN.HeaderText = "TipoPN";
            this.colTipoPN.Name = "colTipoPN";
            this.colTipoPN.Visible = false;
            // 
            // colIdPrecoAPrazo
            // 
            this.colIdPrecoAPrazo.DataPropertyName = "IdPrecoAPrazo";
            this.colIdPrecoAPrazo.HeaderText = "IdPrecoAPrazo";
            this.colIdPrecoAPrazo.Name = "colIdPrecoAPrazo";
            this.colIdPrecoAPrazo.Visible = false;
            // 
            // colIdPrecoAVista
            // 
            this.colIdPrecoAVista.DataPropertyName = "IdPrecoAVista";
            this.colIdPrecoAVista.HeaderText = "IdPrecoAVista";
            this.colIdPrecoAVista.Name = "colIdPrecoAVista";
            this.colIdPrecoAVista.Visible = false;
            // 
            // fmrCadParceiroNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 544);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tabControl1);
            this.Name = "fmrCadParceiroNegocio";
            this.Text = "Cadastro de Pareiro de Negocio";
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabDados.ResumeLayout(false);
            this.tabDadosPN.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTipoPNPrazo.ResumeLayout(false);
            this.tabTipoPNPrazo.PerformLayout();
            this.tabTipoPNVista.ResumeLayout(false);
            this.tabTipoPNVista.PerformLayout();
            this.tabPesquisar.ResumeLayout(false);
            this.tabPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabPesquisar;
        private System.Windows.Forms.TabControl tabDados;
        private System.Windows.Forms.TabPage tabDadosPN;
        private System.Windows.Forms.TabPage tabTipoPNPrazo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.TextBox txtRgIe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeRazao;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbmCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbmEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkUsuario;
        private System.Windows.Forms.CheckBox chkAVista;
        private System.Windows.Forms.CheckBox chkAPrazo;
        private System.Windows.Forms.ComboBox cbmTipoPrecoPrazo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabTipoPNVista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbmTipoPrecoVista;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtivoProxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrazoAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVistaAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeRazao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRGIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPrecoAPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPrecoAVista;
    }
}