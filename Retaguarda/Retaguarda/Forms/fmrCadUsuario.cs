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

namespace Retaguarda
{
    public partial class fmrCadUsuario : Form
    {
        public fmrCadUsuario()
        {
            InitializeComponent();
        }

        #region Eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                sslCadUsuario.Text = "Salvando os dados, aguarde...";
                statusStrip1.Refresh();
                int Id = Convert.ToInt32(cbmParceiros.SelectedValue);
                String Login = txtLogin.Text;
                String Senha = txtSenha.Text;
                try
                {
                    BehaviorCadUsuario rep = new BehaviorCadUsuario();
                    bool ret = rep.CadastrarUsuario(Id, Login, Senha);
                    if (ret)
                    {
                        Util.LimparCamposGenerico(gpbDados);
                        sslCadUsuario.Text = "Cadastro de Usuario Realizado com sucesso!";
                        statusStrip1.Refresh();
                        btnCancelar.Enabled = false;
                        Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    }
                    else
                    {
                        Util.ExibirMsg(Util.TipoMsg.Erro);
                        sslCadUsuario.Text = "Erro ao realizar o cadastro de usuario!";
                        statusStrip1.Refresh();
                    }  
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                    sslCadUsuario.Text = "Erro ao realizar o cadastro de usuario!";
                    statusStrip1.Refresh();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                sslCadUsuario.Text = "Salvando os dados, aguarde...";
                statusStrip1.Refresh();
                int Id = Convert.ToInt32(cbmParceiros.SelectedValue);
                String Login = txtLogin.Text;
                String Senha = txtSenha.Text;
                try
                {
                    BehaviorCadUsuario rep = new BehaviorCadUsuario();
                    rep.AlterarUsuario(Id, Login, Senha);
                    Util.LimparCamposGenerico(gpbDados);
                    sslCadUsuario.Text = "Cadastro de Usuario Alterado com sucesso!";
                    statusStrip1.Refresh();
                    btnExcluir.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnAlterar.Visible = false;
                    btnSalvar.Visible = true;
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    CarregarCbmParceiroNegocio();
                    CarregarDgvPesquisa();
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                    sslCadUsuario.Text = "Erro ao Alterar o cadastro de usuario!";
                    statusStrip1.Refresh();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.PerguntaAntesExclusao())
            {
                if (cbmParceiros.SelectedIndex == -1)
                {
                    MessageBox.Show("Não foi selecionado nenhum parceiro para exclusão so Usuario!");
                }
                else
                {
                    int id = Convert.ToInt32(cbmParceiros.SelectedValue);

                    try
                    {
                        BehaviorCadUsuario rep = new BehaviorCadUsuario();
                        rep.ExcluirUsuario(id);
                        Util.LimparCamposGenerico(gpbDados);
                        sslCadUsuario.Text = "Cadastro de Usuario Alterado com sucesso!";
                        statusStrip1.Refresh();
                        btnExcluir.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnAlterar.Visible = false;
                        btnSalvar.Visible = true;
                        Util.ExibirMsg(Util.TipoMsg.Sucesso);
                        CarregarCbmParceiroNegocio();
                        CarregarDgvPesquisa();
                    }
                    catch (Exception ex)
                    {
                        Util.ExibirMsg(Util.TipoMsg.Erro + "\n" + ex.Message);
                        sslCadUsuario.Text = "Erro ao Alterar o cadastro de usuario!";
                        statusStrip1.Refresh();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Util.LimparCamposGenerico(gpbDados);
            CarregarCbmParceiroNegocio();

            btnAlterar.Visible = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Visible = true;
        }

        private void fmrCadUsuario_Load(object sender, EventArgs e)
        {
            CarregarDgvPesquisa();
            CarregarCbmParceiroNegocio();
            btnAlterar.Visible = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesquisa.RowCount > 0)
            {
                UsuarioPNVO objSlect = (UsuarioPNVO)dgvPesquisa.CurrentRow.DataBoundItem;
                List<UsuarioPNVO> lst = new List<UsuarioPNVO>();
                lst.Add(objSlect);

                //Para carregar o ComboBox somente com o PN que foi selecionado na DGV
                cbmParceiros.DisplayMember = "NomeRazao";
                cbmParceiros.ValueMember = "Id";
                cbmParceiros.DataSource = lst;

                txtLogin.Text = objSlect.Logon;
                txtSenha.Text = objSlect.Senha;
                txtReSenha.Text = objSlect.Senha;

                btnSalvar.Visible = false;
                btnAlterar.Visible = true;
                btnCancelar.Enabled = true;
                if (objSlect.Ativo == "Inativo")
                {
                    btnExcluir.Enabled = false;
                }
                else
                {
                    btnExcluir.Enabled = true;
                }

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

        private Boolean ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (cbmParceiros.SelectedIndex == -1)
            {
                ret = false;
                campos = "- O campo Parceiro de Negócio não foi preenchido. \n";
            }
            if (txtLogin.Text.Trim() == "")
            {
                ret = false;
                campos += "- O campo Login não foi preenchido. \n";
            }
            if (txtSenha.Text.Trim() == "")
            {
                ret = false;
                campos += "- O campo senha não foi preenchido. \n";
            }
            if (txtReSenha.Text.Trim() == "")
            {
                ret = false;
                campos += "- O campo repetir senha não foi informado. \n";
            }
            if (txtReSenha.Text.Trim() != txtSenha.Text.Trim())
            {
                ret = false;
                campos += "- A senha informado não bate coma senha informada no campo Re-senha. \n";
            }
            if (!ret)
            {
                Util.ExibirMsg(campos);
                sslCadUsuario.Text = "O campos da tela não foram preenchidos corretamente!";
                statusStrip1.Refresh();
            }

            return ret;
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
            BehaviorCadUsuario rep = new BehaviorCadUsuario();
            dgvPesquisa.DataSource = rep.CarregarDgvPesquisa();

            Util.VisibilidadeColunaGrid(dgvPesquisa, "Senha", false);
        }

        #endregion
    }
}
