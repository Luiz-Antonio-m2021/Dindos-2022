using Model;
using Repository.Projeto.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaguarda
{
    public partial class fmrCadParceiroNegocio : Form
    {
        #region Propriedades

        public Boolean NovoParceiro { get; set; }

        public ParceiroNegocioVO Parceiro { get; set; }

        #endregion
        public fmrCadParceiroNegocio()
        {
            InitializeComponent();

            dgvPesquisa.AutoGenerateColumns = false;

            this.tabDados.TabPages.RemoveByKey("tabTipoPNPrazo");
            this.tabDados.TabPages.RemoveByKey("tabTipoPNVista");

            this.CarregarCombosTipoPreco();
            this.CarregarComboEstado();
            this.CarregarDGVPesquisa();
            this.NovoParceiro = true;
            this.Parceiro = new ParceiroNegocioVO();

            this.AlterarStatusBotoes();
        }

        #region Eventos

        private void chkAPrazo_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkAPrazo.Checked)
            {
                this.tabDados.TabPages.Add(this.tabTipoPNPrazo);
            }
            else
            {
                this.tabDados.TabPages.RemoveByKey("tabTipoPNPrazo");
            }
        }

        private void chkAVista_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAVista.Checked)
            {
                this.tabDados.TabPages.Add(this.tabTipoPNVista);
            }
            else
            {
                this.tabDados.TabPages.RemoveByKey("tabTipoPNVista");
            }
        }

        private void cbmEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarComboCidade(Convert.ToInt16(cbmEstado.SelectedValue));
        }

        private void SalvarOuAtualizar(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCampos();

                this.MapearCamposParaObjeto();

                this.CalculaTipoPN();

                if (this.NovoParceiro)
                {
                    this.Parceiro.Ativo = true;
                }
                else
                {
                    this.VerificarParceiroAtivo();
                }

                RepositorioFactory.Instancia.RepositorioParceiroNegocio.SalvarOuAtualizarParceiro(this.Parceiro);

                this.LimparUsuarioTela();

                this.MapearObjetoParaCampo();

                this.CarregarDGVPesquisa();

                this.AlterarStatusBotoes();

                Util.ExibirMsg(Util.TipoMsg.Sucesso);
            }
            catch (OperationCanceledException ex)
            {
                Util.ExibirMsg(Util.TipoMsg.CampoObg + Environment.NewLine + ex.Message);
            }
            catch (Exception ex)
            {
                Util.ExibirMsg(Util.TipoMsg.Erro +Environment.NewLine+ ex.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCampos();

                this.MapearCamposParaObjeto();

                this.CalculaTipoPN();

                this.ConfirmaExcluirParceiro();

                RepositorioFactory.Instancia.RepositorioParceiroNegocio.SalvarOuAtualizarParceiro(this.Parceiro);

                this.LimparUsuarioTela();

                this.MapearObjetoParaCampo();

                this.CarregarDGVPesquisa();

                this.AlterarStatusBotoes();

                Util.ExibirMsg(Util.TipoMsg.Sucesso);
            }
            catch (OperationCanceledException ex)
            {
                Util.ExibirMsg(Util.TipoMsg.CampoObg + Environment.NewLine + ex.Message);
            }
            catch (Exception ex)
            {
                Util.ExibirMsg(Util.TipoMsg.Erro + Environment.NewLine + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimparUsuarioTela();

            this.MapearObjetoParaCampo();
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesquisa.SelectedRows.Count > 0)
            {
                ParceiroNegocioVO objSelect = (ParceiroNegocioVO)dgvPesquisa.SelectedRows[0].DataBoundItem as ParceiroNegocioVO;

                this.Parceiro.Ativo = objSelect.Ativo;
                this.Parceiro.Id = objSelect.Id;
                this.Parceiro.IdCidade = objSelect.IdCidade;
                this.Parceiro.IdEstado = objSelect.IdEstado;
                this.VerificarTipoPN(objSelect.TipoPN);
                this.Parceiro.NomeRazao = objSelect.NomeRazao;
                this.Parceiro.CpfCnpj = objSelect.CpfCnpj;
                this.Parceiro.RGIE = objSelect.RGIE;
                this.Parceiro.Telefone = objSelect.Telefone;
                this.Parceiro.Email = objSelect.Email;
                this.Parceiro.Logradouro = objSelect.Logradouro;
                this.Parceiro.Bairro = objSelect.Bairro;
                this.Parceiro.CEP = objSelect.CEP;
                this.Parceiro.IdPrecoAPrazo = objSelect.IdPrecoAPrazo;
                this.Parceiro.IdPrecoAVista = objSelect.IdPrecoAVista;

                this.MapearObjetoParaCampo();

                this.NovoParceiro = false;

                this.AlterarStatusBotoes();

                tabControl1.SelectTab("tabCadastrar");
               
            }
        }

        private void dgvPesquisa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.Equals("Inativo"))
            {
                dgvPesquisa.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        #endregion

        #region Métodos

        private void VerificarTipoPN(int TipoPN)
        {
            if (TipoPN == 1)
            {
                this.Parceiro.VistaAtivo = false;
                this.Parceiro.PrazoAtivo = false;
                this.Parceiro.FuncionarioAtivo = true;
            }
            if (TipoPN == 2)
            {
                this.Parceiro.VistaAtivo = false;
                this.Parceiro.PrazoAtivo = true;
                this.Parceiro.FuncionarioAtivo = false;
            }
            if (TipoPN == 3)
            {
                this.Parceiro.VistaAtivo = false;
                this.Parceiro.PrazoAtivo = true;
                this.Parceiro.FuncionarioAtivo = true;
            }
            if (TipoPN == 4)
            {
                this.Parceiro.VistaAtivo = true;
                this.Parceiro.PrazoAtivo = false;
                this.Parceiro.FuncionarioAtivo = false;
            }
            if (TipoPN == 5)
            {
                this.Parceiro.VistaAtivo = true;
                this.Parceiro.PrazoAtivo = false;
                this.Parceiro.FuncionarioAtivo = true;
            }
            if (TipoPN == 6)
            {
                this.Parceiro.VistaAtivo = true;
                this.Parceiro.PrazoAtivo = true;
                this.Parceiro.FuncionarioAtivo = false;
            }
            if (TipoPN == 7)
            {
                this.Parceiro.VistaAtivo = true;
                this.Parceiro.PrazoAtivo = true;
                this.Parceiro.FuncionarioAtivo = true;
            }
        }

        private void ConfirmaExcluirParceiro()
        {
            DialogResult resultado = MessageBox.Show(this, "Deseja realmente inativar o Parceiro de Negócio selecionado?", "Inativar Parceiro de Negócio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes.Equals(resultado))
            {
                this.Parceiro.Ativo = false;
            }
            if (DialogResult.No.Equals(resultado))
            {
                throw new OperationCanceledException("Operação cancelada pelo ususario!");
            }
        }

        public void ValidarCampos()
        {
            String mensagem = String.Empty;

            if (txtNomeRazao.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Nome / Razão Social não foi preenchido.";
            }
            if (txtCpfCnpj.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo CPF / CNPJ não foi preenchido.";
            }
            if (txtRgIe.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo RG / IE não foi preenchido.";
            }
            if (txtTelefone.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Telefone não foi preenchido.";
            }
            if (txtEmail.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Email não foi preenchido.";
            }
            if (cbmEstado.SelectedIndex == -1)
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Estado não foi preenchido.";
            }
            if (cbmCidade.SelectedIndex == -1)
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Cidade não foi preenchido.";
            }
            if (txtLogradouro.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Logradouro não foi preenchido.";
            }
            if (txtBairro.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Bairro não foi preenchido.";
            }
            if (txtCEP.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo CEP não foi preenchido.";
            }
            if (chkAPrazo.Checked == true && cbmTipoPrecoPrazo.SelectedIndex == -1)
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Preço a Prazo não foi preenchido.";
            }
            if (chkAVista.Checked == true && cbmTipoPrecoVista.SelectedIndex == -1)
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Preço a Vista não foi preenchido.";
            }
            if (!chkAVista.Checked && !chkAPrazo.Checked && !chkUsuario.Checked)
            {
                mensagem += Environment.NewLine;
                mensagem += "Selecione ao menos um tipo de parceiro.";
            }

            if (!String.IsNullOrWhiteSpace(mensagem))
                throw new OperationCanceledException(mensagem);
        }

        private void VerificarParceiroAtivo()
        {
            if (!this.Parceiro.Ativo)
            {
                DialogResult resultado = MessageBox.Show(this, "Deseja ativar o Parceiro selecionado?", "Ativar usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes.Equals(resultado))
                    this.Parceiro.Ativo = true;
            }
        }
        private void LimparUsuarioTela()
        {
            this.NovoParceiro = true;

            this.Parceiro = new ParceiroNegocioVO();
        }

        private void MapearCamposParaObjeto()
        {
            if (txtId.Text != "")
            {
                Parceiro.Id = Convert.ToInt16(txtId.Text);
            }
            Parceiro.NomeRazao = txtNomeRazao.Text;
            Parceiro.CpfCnpj = txtCpfCnpj.Text;
            Parceiro.RGIE = txtRgIe.Text;
            Parceiro.Telefone = txtTelefone.Text;
            Parceiro.Logradouro = txtLogradouro.Text;
            Parceiro.Bairro = txtBairro.Text;
            Parceiro.Email = txtEmail.Text;
            Parceiro.CEP = txtCEP.Text;
            Parceiro.IdCidade = Convert.ToInt16(cbmCidade.SelectedValue);
            Parceiro.PrazoAtivo = chkAPrazo.Checked;
            Parceiro.VistaAtivo = chkAVista.Checked;
            Parceiro.FuncionarioAtivo = chkUsuario.Checked;
            Parceiro.IdPrecoAPrazo = Convert.ToInt16(cbmTipoPrecoPrazo.SelectedValue);
            Parceiro.IdPrecoAVista = Convert.ToInt16(cbmTipoPrecoVista.SelectedValue);
        }

        private void MapearObjetoParaCampo()
        {
            txtId.Text = Parceiro.Id.ToString();
            txtNomeRazao.Text =  Parceiro.NomeRazao;
            txtCpfCnpj.Text = Parceiro.CpfCnpj;
            txtRgIe.Text = Parceiro.RGIE;
            txtTelefone.Text = Parceiro.Telefone;
            txtLogradouro.Text = Parceiro.Logradouro;
            txtBairro.Text = Parceiro.Bairro;
            txtEmail.Text = Parceiro.Email;
            txtCEP.Text = Parceiro.CEP;
            cbmCidade.SelectedValue = Parceiro.IdCidade;
            cbmEstado.SelectedValue = Parceiro.IdEstado;
            chkAPrazo.Checked = Parceiro.PrazoAtivo;
            chkAVista.Checked = Parceiro.VistaAtivo;
            chkUsuario.Checked = Parceiro.FuncionarioAtivo;
            cbmTipoPrecoPrazo.SelectedValue = Convert.ToInt16(Parceiro.IdPrecoAPrazo.GetValueOrDefault());
            cbmTipoPrecoVista.SelectedValue = Convert.ToInt16(Parceiro.IdPrecoAVista.GetValueOrDefault());
        }

        public void CalculaTipoPN()
        {
            int TipoPN = 0;

            if (chkAPrazo.Checked)
            {
                TipoPN += 2;
            }
            if (chkAVista.Checked)
            {
                TipoPN += 4;
            }
            if (chkUsuario.Checked)
            {
                TipoPN += 1;
            }

            Parceiro.TipoPN = TipoPN;
        }

        private void CarregarCombosTipoPreco()
        {
            IEnumerable<TipoPrecoVO> TipoPreco = RepositorioFactory.Instancia.RepositorioTipoPreco.ConsultaTodosAtivos<TipoPrecoVO>();

            cbmTipoPrecoPrazo.DisplayMember = "Descricao";
            cbmTipoPrecoPrazo.ValueMember = "Id";
            cbmTipoPrecoPrazo.DataSource = TipoPreco.ToList();
            

            cbmTipoPrecoVista.DisplayMember = "Descricao";
            cbmTipoPrecoVista.ValueMember = "Id";
            cbmTipoPrecoVista.DataSource = TipoPreco.ToList();
        }

        private void CarregarComboEstado()
        {
            IEnumerable<EstadoVO> Estado = RepositorioFactory.Instancia.RepositorioCidadeEstado.ConsultaTodos<EstadoVO>();

            cbmEstado.DisplayMember = "Descricao";
            cbmEstado.ValueMember = "Id";
            cbmEstado.DataSource = Estado;
        }

        private void CarregarComboCidade(int Estado)
        {
            IEnumerable<EstadoVO> Cidade = RepositorioFactory.Instancia.RepositorioCidadeEstado.ConsultaCidadeEstado<EstadoVO>(Estado);

            cbmCidade.DisplayMember = "Descricao";
            cbmCidade.ValueMember = "Id";
            cbmCidade.DataSource = Cidade;
        }

        private void AlterarStatusBotoes()
        {
            this.btnSalvar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.btnExcluir.Enabled = !this.NovoParceiro;
        }

        private void CarregarDGVPesquisa()
        {
            IEnumerable<ParceiroNegocioVO> parceiro = RepositorioFactory.Instancia.RepositorioParceiroNegocio.ConsultaTodos<ParceiroNegocioVO>();

            dgvPesquisa.DataSource = parceiro.ToList();

        }


        #endregion


    }
}
