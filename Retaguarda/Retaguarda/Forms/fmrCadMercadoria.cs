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

namespace Retaguarda.Retaguarda.Forms
{
    public partial class fmrCadMercadoria : Form
    {
        #region Propriedades

        public Boolean NovaMercadoria { get; set; }

        public MercadoriaVO Mercadoria { get; set; }

        public MercadoriaComboKitVO Combo { get; set; }

        public MercadoriaPrecoVO Preco { get; set; }

        public List<MercadoriaPrecoVO> PrecoLst { get; set; }

        public List<MercadoriaComboKitVO> ComboLst { get; set; }

        #endregion
        public fmrCadMercadoria()
        {
            InitializeComponent();

            dgvEstoque.AutoGenerateColumns = true;
            dgvPrecoMercadoria.AutoGenerateColumns = true;
            dgvMercadoriaCombo.AutoGenerateColumns = true;

            this.PreencherCbmTipoPreco();
            this.PreencherCbmMercadoriaCombo();
            this.PreencherCbmLocalEstoqueEntraSaida();
            this.Mercadoria = new MercadoriaVO();
            this.Combo = new MercadoriaComboKitVO();
            this.Preco = new MercadoriaPrecoVO();
            this.NovaMercadoria = true;
            this.PrecoLst = new List<MercadoriaPrecoVO>();
            this.ComboLst = new List<MercadoriaComboKitVO>();

            this.tabControl2.TabPages.RemoveByKey("tabCombo");
        }

        #region Eventos
        private void chkComboKit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComboKit.Checked)
            {
                this.tabControl2.TabPages.Add(this.tabCombo);
                this.tabControl2.TabPages.RemoveByKey("tabEstoque");
                this.tabControl2.SelectTab("tabCombo");
                Mercadoria.TipoMercadoria = 1;
            }
            if (!chkComboKit.Checked)
            {
                this.tabControl2.TabPages.Add(this.tabEstoque);
                this.tabControl2.TabPages.RemoveByKey("tabCombo");
                this.tabControl2.SelectTab("tabEstoque");
                Mercadoria.TipoMercadoria = 0;
            }
        }

        private void SalvarOuAtualizar(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCampos();

                this.MapearCamposParaObjeto();

                if (this.NovaMercadoria)
                {
                    this.Mercadoria.Ativo = true;
                }
                else
                {
                    this.VerificarMercadoriaAtiva();
                }

                RepositorioFactory.Instancia.RepositorioMercadoria.SalvarOuAtualizarMercadoria(Mercadoria,ComboLst,PrecoLst);

                this.LimparTelaMercadoria();

                this.MapearObjetoParaCampos();


                Util.ExibirMsg(Util.TipoMsg.Sucesso);
            }
            catch (OperationCanceledException exec)
            {
                Util.ExibirMsg(Util.TipoMsg.CampoObg + Environment.NewLine + exec.Message);
            }
            catch (Exception ex)
            {
                Util.ExibirMsg(Util.TipoMsg.Erro + Environment.NewLine + ex.Message);
            }

        }

        private void btnAdcionarMerc_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCamposGridMercadoriaCombo();

                this.ValidarMercadoriaJaInformada();

                this.MapearCampoTabParaObjeto();

                this.CarregarDgvMercadoriaCombo();
            }
            catch (OperationCanceledException exec)
            {
                Util.ExibirMsg(Util.TipoMsg.CampoObg + Environment.NewLine + exec.Message);
            }
            catch (Exception ex)
            {
                Util.ExibirMsg(Util.TipoMsg.Erro + Environment.NewLine + ex.Message);
            }
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCamposGridPreco();

                this.ValidarPrecoJaInformado();

                this.MapearCampoTabVendaParaObjet();

                this.CarregarDgvPreco();

            }
            catch (OperationCanceledException exec)
            {
                Util.ExibirMsg(Util.TipoMsg.CampoObg + Environment.NewLine + exec.Message);
            }
            catch (Exception ex)
            {
                Util.ExibirMsg(Util.TipoMsg.Erro + Environment.NewLine + ex.Message);
            }
        }

        private void btnRemoverMerc_Click(object sender, EventArgs e)
        {
            try
            {
                this.RemoverLinhaDgvMercadoriaCombo();
                this.CarregarDgvPreco();
            }
            catch (Exception ex)
            {

                Util.ExibirMsg(Util.TipoMsg.Erro + Environment.NewLine + ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                this.RemoverLinhaDgvTipoPreco();
                this.CarregarDgvPreco();
            }
            catch (Exception ex)
            {

                Util.ExibirMsg(Util.TipoMsg.Erro + Environment.NewLine + ex.Message);
            }
        }

        #endregion

        #region Metodos

        private void MapearObjetoParaCampos()
        {
            txtCodBarras.Text = Mercadoria.CodBarras.ToString();
            txtDescricao.Text = Mercadoria.Descricao;
            if (Mercadoria.Id is null)
            {
                txtId.Clear();
            }
            else
            {
                txtId.Text = Mercadoria.Id.ToString();
            }
            txtPreco.Clear();
            txtQuantidade.Clear();
            cbmPadraoEntrada.SelectedValue = Mercadoria.IdLocalEstoqueEntrada.GetValueOrDefault();
            cbmPadraoSaida.SelectedValue = Mercadoria.IdLocalEstoqueSaida.GetValueOrDefault();
        }

        private void LimparTelaMercadoria()
        {
            this.NovaMercadoria = true;

            this.Mercadoria = new MercadoriaVO();

            this.PrecoLst = new List<MercadoriaPrecoVO>();

            this.ComboLst = new List<MercadoriaComboKitVO>();

            this.CarregarDgvPreco();
        }

        private void VerificarMercadoriaAtiva()
        {
            if (!this.Mercadoria.Ativo)
            {
                DialogResult resultado = MessageBox.Show(this, "Deseja ativar a Mercadoria selecionada?", "Ativar Mercadoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes.Equals(resultado))
                    this.Mercadoria.Ativo = true;
            }
        }

        private void MapearCamposParaObjeto()
        {
            if (txtId.Text != "")
            {
                this.Mercadoria.Id = Convert.ToInt64(txtId.Text);
            }
            this.Mercadoria.Descricao = txtDescricao.Text;
            this.Mercadoria.CodBarras = Convert.ToInt64(txtCodBarras.Text);
            this.Mercadoria.IdLocalEstoqueEntrada = Convert.ToInt64(cbmPadraoEntrada.SelectedValue);
            this.Mercadoria.IdLocalEstoqueSaida = Convert.ToInt64(cbmPadraoSaida.SelectedValue);
        }

        private void RemoverLinhaDgvMercadoriaCombo()
        {
            if (dgvMercadoriaCombo.SelectedRows.Count > 0)
            {
                MercadoriaComboKitVO objRemover = (MercadoriaComboKitVO)dgvMercadoriaCombo.SelectedRows[0].DataBoundItem as MercadoriaComboKitVO;

                ComboLst.Remove(objRemover);
            }
        }

        private void RemoverLinhaDgvTipoPreco()
        {
            if (dgvPrecoMercadoria.SelectedRows.Count > 0)
            {
                MercadoriaPrecoVO objremover = (MercadoriaPrecoVO)dgvPrecoMercadoria.SelectedRows[0].DataBoundItem as MercadoriaPrecoVO;

                PrecoLst.Remove(objremover);
            }
        }

        private void ValidarMercadoriaJaInformada()
        {
            for (int i = 0; i < dgvMercadoriaCombo.Rows.Count; i++)
            {
                for (int j = 0; j < dgvMercadoriaCombo.Columns.Count; j++)
                {
                    if (dgvMercadoriaCombo.Rows[i].Cells[j].Value.ToString() == cbmMercadoria.Text)
                    {
                        dgvMercadoriaCombo.Rows[i].Cells[j].Selected = true;
                        throw new OperationCanceledException("Mercadoria ja informado no grid.");
                    }
                }
            }
        }

        private void ValidarPrecoJaInformado()
        {
            for (int i = 0; i < dgvPrecoMercadoria.Rows.Count; i++)
            {
                for (int j = 0; j < dgvPrecoMercadoria.Columns.Count; j++)
                {
                    if (dgvPrecoMercadoria.Rows[i].Cells[j].Value.ToString() == cbmTipoPreco.Text)
                    {
                        dgvPrecoMercadoria.Rows[i].Cells[j].Selected = true;
                        throw new OperationCanceledException("Tipo de preço ja informado no grid.");
                    }
                }
            }
        }

        private void CarregarDgvMercadoriaCombo()
        {
            this.dgvMercadoriaCombo.DataSource = ComboLst.ToList();
        }

        private void MapearCampoTabParaObjeto()
        {
            ComboLst.Add(new MercadoriaComboKitVO {
                IdMercadoriaCombo = Convert.ToInt64(cbmMercadoria.SelectedValue),
                DescricaoMercadoriaCombo = cbmMercadoria.Text,
                Quantidade = Convert.ToDecimal(txtQuantidade.Text)
            });
        }

        public void CarregarDgvPreco()
        {
            this.dgvPrecoMercadoria.DataSource = PrecoLst.ToList();
        }

        private void MapearCampoTabVendaParaObjet()
        {
            PrecoLst.Add(new MercadoriaPrecoVO
            {
                DescricaoPreco = cbmTipoPreco.Text,
                Prioridade = dgvPrecoMercadoria.Rows.Count + 1,
                PrecoMercadoria = Convert.ToDecimal(txtPreco.Text),
                IdTipoPreco = Convert.ToInt64(cbmTipoPreco.SelectedValue)
            });
        }

        private void ValidarCamposGridPreco()
        {
            String mensagem = "";

            if (cbmTipoPreco.SelectedIndex == -1)
            {
                mensagem += Environment.NewLine;
                mensagem += "Informe um tipo de preço.";
            }

            if (txtPreco.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "Informe o preço para o tipo de preço.";
            }
            if (!String.IsNullOrWhiteSpace(mensagem))
                throw new OperationCanceledException(mensagem);

        }

        private void ValidarCamposGridMercadoriaCombo()
        {
            String mensagem = "";

            if (cbmMercadoria.SelectedIndex == -1)
            {
                mensagem += Environment.NewLine;
                mensagem += "Informe uma mercadoria.";
            }

            if (txtQuantidade.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "Informe a quantidade de mercadoria a ser adicionada.";
            }
            if (!String.IsNullOrWhiteSpace(mensagem))
                throw new OperationCanceledException(mensagem);

        }

        private void ValidarCampos()
        {
            String mensagem = "";

            if (txtCodBarras.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "Informe um código para o código de barras.";
            }
            if (txtDescricao.Text.Trim() == "")
            {
                mensagem += Environment.NewLine;
                mensagem += "Informe uma Descricao para a mercadoria.";
            }
            if (dgvPrecoMercadoria.Rows.Count <= 0)
            {
                mensagem += Environment.NewLine;
                mensagem += "Informe ao menos um preço para a mercadoria.";
            }
            if (chkComboKit.Checked)
            {
                if (dgvMercadoriaCombo.Rows.Count <= 0 )
                {
                    mensagem += Environment.NewLine;
                    mensagem += "Informe uma ou mais mercadorias para cadastrar a mercadoria combo kit.";
                }
            }
            if (!chkComboKit.Checked)
            {
                if (cbmPadraoEntrada.SelectedIndex == -1)
                {
                    mensagem += Environment.NewLine;
                    mensagem += "É necessario Informar o local de Entrada no Estoque.";
                }
                if (cbmPadraoSaida.SelectedIndex == -1)
                {
                    mensagem += Environment.NewLine;
                    mensagem += "É necessario Informar o local de Saida no Estoque.";
                }
            }

            if (!String.IsNullOrWhiteSpace(mensagem))
                throw new OperationCanceledException(mensagem);
        }

        private void PreencherCbmLocalEstoqueEntraSaida()
        {
            IEnumerable<LocalEstoqueVO> localEntrada = RepositorioFactory.Instancia.RepositorioLocalEstoque.ConsultaTodosAtivos<LocalEstoqueVO>();
            IEnumerable<LocalEstoqueVO> localSaida = RepositorioFactory.Instancia.RepositorioLocalEstoque.ConsultaTodosAtivos<LocalEstoqueVO>();

            cbmPadraoEntrada.DisplayMember = "Descricao";
            cbmPadraoEntrada.ValueMember = "Id";
            cbmPadraoEntrada.DataSource = localEntrada;

            cbmPadraoSaida.DisplayMember = "Descricao";
            cbmPadraoSaida.ValueMember = "Id";
            cbmPadraoSaida.DataSource = localSaida;
        }

        private void PreencherCbmTipoPreco()
        {
            IEnumerable<TipoPrecoVO> precos = RepositorioFactory.Instancia.RepositorioTipoPreco.ConsultaTodosAtivos<TipoPrecoVO>();

            cbmTipoPreco.DisplayMember = "Descricao";
            cbmTipoPreco.ValueMember = "Id";
            cbmTipoPreco.DataSource = precos;
        }

        private void PreencherCbmMercadoriaCombo()
        {
            IEnumerable<MercadoriaVO> MercCombo = RepositorioFactory.Instancia.RepositorioMercadoria.ConsultaTodos<MercadoriaVO>();

            cbmMercadoria.DisplayMember = "Descricao";
            cbmMercadoria.ValueMember = "Id";
            cbmMercadoria.DataSource = MercCombo;
        }


        #endregion
    }
}
