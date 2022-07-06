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
    public partial class fmrCadUsuario : Form
    {
        #region Propriedades

        private Boolean NovoUsuario { get; set; }

        private UsuarioPNVO Usuario { get; set; }

        #endregion

        public fmrCadUsuario()
        {
            this.InitializeComponent();

            this.NovoUsuario = true;

            this.Usuario = new UsuarioPNVO();

            this.AlterarStatusBotoes();

            this.dgvPesquisa.AutoGenerateColumns = false;
        }

        //Metodo para popular objeto com os campos da tela
        private void MapearCamposParaObjeto()
        {
            this.Usuario.Id = Convert.ToInt32(cbmParceiros.SelectedValue);
            this.Usuario.Logon = txtLogin.Text;
            this.Usuario.Senha = txtSenha.Text;
        }

        //Metodo para popular os campos da tela com os dados vindo do Objeto
        private void MapearObjetoParaCampo()
        {
            cbmParceiros.SelectedValue = this.Usuario.Id.GetValueOrDefault();
            txtLogin.Text = this.Usuario.Logon;
            txtSenha.Text = this.Usuario.Senha;
            txtReSenha.Text = this.Usuario.Senha;
        }

        private void LimparUsuarioTela()
        {
            this.NovoUsuario = true;

            this.Usuario = new UsuarioPNVO();
        }

        //Metodo que pergunta se ao alterar o cadastro deseja ativar novamente o cadastro
        private void VerificaUsuarioInativo()
        {
            if (!this.Usuario.Ativo)
            {
                DialogResult resultado = MessageBox.Show(this, "Deseja ativar o usuário selecionado?", "Ativar usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes.Equals(resultado))
                    this.Usuario.Ativo = true;
            }
        }

        private void ConfirmaExcluirUsuario()
        {
            DialogResult resultado = MessageBox.Show(this, "Deseja realmente inativar o usuário selecionado?", "Inativar usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes.Equals(resultado))
            {
                this.Usuario.Ativo = false;
            }
            if (DialogResult.No.Equals(resultado))
            {
                throw new OperationCanceledException("Operação cancelada pelo ususario!");
            }
        }

        //Metodo que controla o estado dos botões
        private void AlterarStatusBotoes()
        {
            this.btnSalvar.Enabled = true;
            this.btnCancelar.Enabled = true;            
            this.btnExcluir.Enabled = !this.NovoUsuario;
            this.cbmParceiros.Enabled = this.NovoUsuario;
        }

        #region Eventos

        private void EventoSalvarAtualizarUsuario(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCampos();

                this.MapearCamposParaObjeto();

                if (this.NovoUsuario)
                {
                    this.Usuario.Ativo = true;                    
                }
                else
                {
                    this.VerificaUsuarioInativo();
                }

                RepositorioFactory.Instancia.RepositorioUsuario.SalvarOuAtualizaUsuario(this.Usuario);

                this.LimparUsuarioTela();

                this.MapearObjetoParaCampo();

                this.CarregarDgvPesquisa();

                this.AlterarStatusBotoes();

                Util.ExibirMsg(Util.TipoMsg.Sucesso);
                sslCadUsuario.Text = "Cadastro de Usuario Realizado com sucesso!";
                statusStrip1.Refresh();
            }
            catch (OperationCanceledException ex)
            {
                Util.ExibirMsg(Util.TipoMsg.CampoObg + ex.Message);
            }
            catch (Exception ex)
            {
                Util.ExibirMsg(Util.TipoMsg.Erro + ex.Message);

                sslCadUsuario.Text = "Erro ao Salvar o cadastro de usuario!";

                statusStrip1.Refresh();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCampos();

                this.MapearCamposParaObjeto();

                this.ConfirmaExcluirUsuario();

                RepositorioFactory.Instancia.RepositorioUsuario.SalvarOuAtualizaUsuario(this.Usuario);

                this.LimparUsuarioTela();

                this.MapearObjetoParaCampo();

                this.CarregarDgvPesquisa();

                this.AlterarStatusBotoes();

                Util.ExibirMsg(Util.TipoMsg.Sucesso);
                sslCadUsuario.Text = "Exclusão de Usuario Realizado com sucesso!";
                statusStrip1.Refresh();
            }
            catch (OperationCanceledException ex)
            {
                Util.ExibirMsg(Util.TipoMsg.CampoObg + ex.Message);
                sslCadUsuario.Text = "Verifique os campos obrigatórios e tente novamente.";
                statusStrip1.Refresh();
            }
            catch (Exception ex)
            {
                Util.ExibirMsg(Util.TipoMsg.Erro + "\n" + ex.Message);
                sslCadUsuario.Text = "Erro ao excluir o cadastro de usuario!";
                statusStrip1.Refresh();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Util.LimparCamposGenerico(gpbDados);
            //CarregarCbmParceiroNegocio();
                        
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Visible = true;

            this.LimparUsuarioTela();

            this.MapearObjetoParaCampo();
        }

        private void fmrCadUsuario_Load(object sender, EventArgs e)
        {
            CarregarDgvPesquisa();

            CarregarCbmParceiroNegocio();
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesquisa.SelectedRows.Count > 0)
            {
                UsuarioPNVO objSlect = (UsuarioPNVO)dgvPesquisa.SelectedRows[0].DataBoundItem as UsuarioPNVO;

                this.Usuario = new UsuarioPNVO();

                this.Usuario.Id = objSlect.Id;
                this.Usuario.Ativo = objSlect.Ativo;
                this.Usuario.Senha = objSlect.Senha;
                this.Usuario.Logon = objSlect.Logon;

                this.MapearObjetoParaCampo();

                this.NovoUsuario = false;                

                this.AlterarStatusBotoes();

                sslCadUsuario.Text = "Carregado na tela os dados do Usuario " + objSlect.Logon + " para edição.";
                statusStrip1.Refresh();
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length > 0)
            {
                btnCancelar.Enabled = true;
            }
            else
            {
                btnCancelar.Enabled = false;
            }
        }

        #endregion

        #region Metodos

        private void ValidarCampos()
        {
            String mensagem = String.Empty;

            if (cbmParceiros.SelectedIndex == -1)
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Parceiro de Negócio não foi preenchido.";
                //throw new OperationCanceledException("O campo Parceiro de Negócio não foi preenchido.");
            }

            if (txtLogin.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo Login não foi preenchido.";
                //throw new OperationCanceledException("O campo Login não foi preenchido.");
            }

            if (txtSenha.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo senha não foi preenchido";
                //throw new OperationCanceledException("O campo senha não foi preenchido");
            }

            if (txtReSenha.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "O campo repetir senha não foi informado";
                //throw new OperationCanceledException("O campo repetir senha não foi informado");
            }


            if (txtReSenha.Text.Trim() != txtSenha.Text.Trim())
            {
                mensagem += Environment.NewLine;
                mensagem += "A senha informado não bate coma senha informada no campo Re-senha.";
                //throw new OperationCanceledException("A senha informado não bate coma senha informada no campo Re-senha.");
            }
            if (RepositorioFactory.Instancia.RepositorioUsuario.ValidarParceiro(Convert.ToInt64(this.Usuario.Id)))
            {
                mensagem += Environment.NewLine;
                mensagem += "O Parceiro de negócio selecionado ja possui um usuario cadastrado!";
            }
            //chamar aqui o repositorio que vai retornar um bool, se existir mostra pro cliente que o parceiro selecionado já tem um usuário (somente em modo de cadastro)

            if (!String.IsNullOrWhiteSpace(mensagem))
                throw new OperationCanceledException(mensagem);
        }

        private void CarregarCbmParceiroNegocio()
        {
            try
            {
                BehaviorCadUsuario rep = new BehaviorCadUsuario();
                List<UsuarioPNVO> lst = rep.CarregarComboPN();
                if (lst.Count <= 0)
                {
                    cbmParceiros.Text = "Não possui parceiro Disponivel!";
                }
                else
                {
                    cbmParceiros.DisplayMember = "NomeRazao";
                    cbmParceiros.ValueMember = "Id";
                    cbmParceiros.DataSource = lst;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel carregar a Combo de Parceiros.");
            }
        }

        public void CarregarDgvPesquisa()
        {
            IEnumerable<UsuarioPNVO> todosUsuario = RepositorioFactory.Instancia.RepositorioUsuario.ConsultaTodos<UsuarioPNVO>();

            dgvPesquisa.DataSource = todosUsuario.ToList();

            //BehaviorCadUsuario rep = new BehaviorCadUsuario();
            //dgvPesquisa.DataSource = rep.CarregarDgvPesquisa();

            //Util.VisibilidadeColunaGrid(dgvPesquisa, "Senha", false);
        }

        #endregion
    }
}
