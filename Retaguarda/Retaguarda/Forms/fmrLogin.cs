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
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tspLogin.Visible = true;
            tspLogin.Value = 0;
            if (ValidarCampos())
            {
                tspLogin.Value = 25;
                String Login = txtLogin.Text;
                String Senha = txtSenha.Text;
                tspLogin.Value = 50;
                try
                {
                    BehavioFmrLogin rep = new BehavioFmrLogin();
                    tspLogin.Value = 75;
                    if (rep.RealizarLogin(Login, Senha))
                    {
                        tspLogin.Value = 100;
                        fmrPrincipal f = new fmrPrincipal(UsuarioVO.Login, UsuarioVO.NomeCompleto);
                        f.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario e senha informados não foram encontrados no sistema!");
                        tspLogin.Visible = false;
                        statusStrip1.Refresh();
                    }
                    
                }
                catch (Exception ex)
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro +"\n"+ ex.Message);
                }
            }
        }

        private bool ValidarCampos()
        {
            Boolean ret = true;
            if (txtLogin.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            {
                ret = false;
                MessageBox.Show("Login ou senha não foram preenchidos");
            }
            return ret;
        }
    }
}
