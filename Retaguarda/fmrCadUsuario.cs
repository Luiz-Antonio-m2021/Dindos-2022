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
                try
                {
                    
                }
                catch
                {

                    throw;
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void fmrCadUsuario_Load(object sender, EventArgs e)
        {
            CarregarDgvPesquisa();
            CarregarCbmParceiroNegocio();
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region Metodos

        private Boolean ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtLogin.Text.Trim() == "")
            {
                ret = false;
                campos = "- O campo Login não foi preenchido. \n";
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
                //List<UsuarioPNVO> objPnvo = rep.CarregarComboPN();
                cbmParceiros.DisplayMember = "NomeRazao";
                cbmParceiros.ValueMember = "Id";
                cbmParceiros.DataSource = rep.CarregarComboPN();

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
        }

        #endregion

    }
}
