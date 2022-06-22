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
    public partial class fmrCadTipoPreco : Form
    {
        public fmrCadTipoPreco()
        {
            InitializeComponent();
        }

        #region Eventos

        private void fmrCadTipoPreco_Load(object sender, EventArgs e)
        {
            btnAlterar.Visible = false;
            btnCadastrar.Visible = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;

            CarregarDgvPesquisa();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            BehaviorFmrCadTipoPreco rep = new BehaviorFmrCadTipoPreco();
            if (ValidarCampos())
            {
                sslTipoPreco.Text = "Salvando os dados, aguarde...";
                statusStrip1.Refresh();

                string Descricao = txtDescricao.Text;

                try
                {
                    rep.CadastrarTipoPreco(Descricao);
                    sslTipoPreco.Text = "Dados Salvos com Sucesso!!";
                    statusStrip1.Refresh();
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    CarregarDgvPesquisa();
                    Util.LimparCamposGenerico(gpbCadastro);
                    btnCancelar.Enabled = false;

                }
                catch 
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                    sslTipoPreco.Text = "Não foi possivel salvar os dados!";
                    statusStrip1.Refresh();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Util.LimparCamposGenerico(gpbCadastro);
            btnAlterar.Visible = false;
            btnCadastrar.Visible = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            TipoPrecoVO objVo = new TipoPrecoVO();
            BehaviorFmrCadTipoPreco rep = new BehaviorFmrCadTipoPreco();
            if (ValidarCampos())
            {
                sslTipoPreco.Text = "Salvando os dados, aguarde...";
                statusStrip1.Refresh();

                objVo.Descricao = txtDescricao.Text;
                objVo.Id = Convert.ToInt32(txtId.Text);

                try
                {
                    rep.AlterarTipoPreco(objVo);
                    sslTipoPreco.Text = "Dados Alterados com Sucesso!!";
                    statusStrip1.Refresh();
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    CarregarDgvPesquisa();
                    Util.LimparCamposGenerico(gpbCadastro);
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCadastrar.Visible = true;
                    btnAlterar.Visible = false;
                }
                catch
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                    sslTipoPreco.Text = "Não foi possivel realizar a alteração!";
                    statusStrip1.Refresh();
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.PerguntaAntesExclusao())
            {
                if (txtId.Text == "")
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                    sslTipoPreco.Text = "Não foi possivel realizar a exclusão!";
                    statusStrip1.Refresh();
                }
                else
                {
                    BehaviorFmrCadTipoPreco rep = new BehaviorFmrCadTipoPreco();
                    sslTipoPreco.Text = "Inativando o Tipo de Preço, aguarde...";
                    statusStrip1.Refresh();

                    int Ativo = 0;
                    int Id = Convert.ToInt32(txtId.Text);

                    try
                    {
                        rep.InativarTipoPreco(Ativo, Id);
                        sslTipoPreco.Text = "Dados Inativados com Sucesso!!";
                        statusStrip1.Refresh();
                        Util.ExibirMsg(Util.TipoMsg.Sucesso);
                        CarregarDgvPesquisa();
                        Util.LimparCamposGenerico(gpbCadastro);
                        btnCancelar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnAlterar.Visible = false;
                        btnCadastrar.Visible = true;
                    }
                    catch
                    {
                        Util.ExibirMsg(Util.TipoMsg.Erro);
                        sslTipoPreco.Text = "Não foi possivel inativar os dados!";
                        statusStrip1.Refresh();
                    }
                }
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Length <= 0)
            {
                btnCancelar.Enabled = false;
            }
            else
            {
                btnCancelar.Enabled = true;
            }
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPesquisa.RowCount > 0)
            {
                TipoPrecoVO objSelec = (TipoPrecoVO)dgvPesquisa.CurrentRow.DataBoundItem;

                txtId.Text = objSelec.Id.ToString();
                txtDescricao.Text = objSelec.Descricao;

                btnCadastrar.Visible = false;
                btnAlterar.Visible = true;
                btnExcluir.Enabled = true;
                if (objSelec.Ativo == "Inativo")
                {
                    btnExcluir.Enabled = false;
                }
                else
                {
                    btnExcluir.Enabled = true;
                }

                sslTipoPreco.Text = "Carregado na tela os dados do Tipo de Preço "+objSelec.Descricao+" para edição.";
                statusStrip1.Refresh();
            }
        }

        #endregion

        #region Metodos

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";
            if (txtDescricao.Text.Trim() == "")
            {
                ret = false;
                campos = " - O Campo Descrição não foi preenchido. \n";
            }
            if (!ret)
            {
                Util.ExibirMsg(campos);
                sslTipoPreco.Text = "Os dados não foram preenchidos corretamente!";
                statusStrip1.Refresh();
            }

            return ret;
        }

        private void CarregarDgvPesquisa()
        {
            BehaviorFmrCadTipoPreco rep = new BehaviorFmrCadTipoPreco();
            List<TipoPrecoVO> lstPesquisa = rep.CarregarTiposPreco();

            dgvPesquisa.DataSource = lstPesquisa;
            
        }





        #endregion


    }
}
