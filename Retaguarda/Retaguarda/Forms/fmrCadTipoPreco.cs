using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using Model;
using Repository.Projeto.Base;

namespace Retaguarda
{
    public partial class fmrCadTipoPreco : Form
    {
        public fmrCadTipoPreco()
        {
            InitializeComponent();

            this.NovoTipoPreco = true;

            this.TP = new TipoPrecoVO();

            this.AlterarStatusBotoes();

            this.dgvPesquisa.AutoGenerateColumns = false;
        }

        #region Propriedades

        private Boolean NovoTipoPreco { get; set; }

        private TipoPrecoVO TP { get; set; }

        #endregion

        #region Eventos

        private void fmrCadTipoPreco_Load(object sender, EventArgs e)
        { 

            CarregarDgvPesquisa();
        }

        private void SalvarOuAtualizarCadastro(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCampos();

                this.MapearCampoParaObjeto();

                if (this.NovoTipoPreco)
                {
                    this.TP.Ativo = true;
                }
                else
                {
                    this.VerificarAtivarPreco();
                }

                RepositorioFactory.Instancia.RepositorioTipoPreco.SalvarAtualizarTipoPreco(this.TP);

                this.LimparUsuarioTela();

                this.MapearObjetoParaCampo();

                this.AlterarStatusBotoes();

                this.CarregarDgvPesquisa();

                sslTipoPreco.Text = "Dados Salvos com Sucesso!!";
                statusStrip1.Refresh();
                Util.ExibirMsg(Util.TipoMsg.Sucesso);
                
            }
            catch (OperationCanceledException campo)
            {
                Util.ExibirMsg(Util.TipoMsg.CampoObg + Environment.NewLine + campo.Message);
                sslTipoPreco.Text = "Verifique os campos obrigatórios e tente novamente.";
                statusStrip1.Refresh();
            }
            catch (Exception ex)
            {
                Util.ExibirMsg(Util.TipoMsg.Erro + Environment.NewLine + ex.Message);
                sslTipoPreco.Text = "Não foi possivel salvar os dados!";
                statusStrip1.Refresh();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Util.LimparCamposGenerico(gpbCadastro);
            
            btnSalvar.Visible = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCampos();

                this.MapearCampoParaObjeto();

                this.ConfirmaExcluirTipoPreco();

                RepositorioFactory.Instancia.RepositorioTipoPreco.SalvarAtualizarTipoPreco(this.TP);

                this.LimparUsuarioTela();

                this.MapearObjetoParaCampo();

                this.CarregarDgvPesquisa();

                this.AlterarStatusBotoes();

                Util.ExibirMsg(Util.TipoMsg.Sucesso);
                sslTipoPreco.Text = "Exclusão de Usuario Realizado com sucesso!";
                statusStrip1.Refresh();
            }
            catch (OperationCanceledException ex)
            {
                Util.ExibirMsg(Util.TipoMsg.CampoObg + ex.Message);
                sslTipoPreco.Text = "Verifique os campos obrigatórios e tente novamente.";
                statusStrip1.Refresh();
            }
            catch (Exception ex)
            {
                Util.ExibirMsg(Util.TipoMsg.Erro + Environment.NewLine + ex.Message);
                sslTipoPreco.Text = "Não foi possivel inativar os dados!";
                statusStrip1.Refresh();
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvPesquisa.SelectedRows.Count > 0)
            {
                TipoPrecoVO objSelec = (TipoPrecoVO)dgvPesquisa.SelectedRows[0].DataBoundItem as TipoPrecoVO;

                this.TP = new TipoPrecoVO();

                this.TP.Id = objSelec.Id;
                this.TP.Descricao = objSelec.Descricao;
                this.TP.Ativo = objSelec.Ativo;

                this.MapearObjetoParaCampo();

                this.NovoTipoPreco = false;

                this.AlterarStatusBotoes();

                sslTipoPreco.Text = "Carregado na tela os dados do Tipo de Preço "+objSelec.Descricao+" para edição.";
                statusStrip1.Refresh();
            }
        }

        #endregion

        #region Metodos

        private void ConfirmaExcluirTipoPreco()
        {
            DialogResult resultado = MessageBox.Show(this, "Deseja realmente inativar o Tipo de Preço selecionado?", "Inativar Tipo de Preço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes.Equals(resultado))
            {
                this.TP.Ativo = false;
            }
            if (DialogResult.No.Equals(resultado))
            {
                throw new OperationCanceledException("Operação cancelada pelo ususario!");
            }
        }
        private void VerificarAtivarPreco()
        {
            if (!this.TP.Ativo)
            {
                DialogResult resultado = MessageBox.Show(this, "Ao fazer a alteração o tipo de preço será reativado. \n Deseja ativar o tipo de preço selecionado?", "Ativar Tipo de preço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes.Equals(resultado))
                {
                    this.TP.Ativo = true;
                }
            }
        }

        private void LimparUsuarioTela()
        {
            this.NovoTipoPreco = true;

            this.TP = new TipoPrecoVO();
        }

        private void MapearCampoParaObjeto()
        {
            this.TP.Descricao = this.txtDescricao.Text;
        }

        private void MapearObjetoParaCampo()
        {
            this.txtDescricao.Text = this.TP.Descricao;
        }

        private void AlterarStatusBotoes()
        {
            this.btnSalvar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.btnExcluir.Enabled = !this.NovoTipoPreco;
        }

        private void ValidarCampos()
        {
            string mensagem = "";
            if (txtDescricao.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Login não foi preenchido.";
                
            }
            if (!String.IsNullOrWhiteSpace(mensagem))
            {
                throw new OperationCanceledException(mensagem);
            }

        }

        private void CarregarDgvPesquisa()
        {
            try
            {
                IEnumerable<TipoPrecoVO> todosTipos = RepositorioFactory.Instancia.RepositorioTipoPreco.ConsultaTodos<TipoPrecoVO>();

                dgvPesquisa.DataSource = todosTipos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel carregar os tipos de preço.  \n"+ex.Message);
            }

        }

        #endregion


    }
}
