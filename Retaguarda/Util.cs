using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retaguarda
{
    public static class Util
    {
        public enum TipoMsg
        {
            Sucesso,
            Erro,
            ErroExclusao,
            DadosNaoEncontrado,
            CampoObg
        }
        public enum EstadoTela
        {
            Novo,
            Alterar
        }
        public static bool PerguntaAntesExclusao()
        {
            if (MessageBox.Show(UtilMensagens.Msg.MensagemErroExclusao, UtilMensagens.Msg.TituloAviso, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void VisibilidadeColunaGrid(DataGridView grid, string colum, bool visible)
        {
            grid.Columns[colum].Visible = visible;
        }

        public static void HeaderColunaGrid(DataGridView grid, string colum, string header)
        {
            grid.Columns[colum].HeaderText = header;
        }

        public static void ConfigurarGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public static void ConfigurarCombo(ComboBox c, string display, string value)
        {
            c.DisplayMember = display;
            c.ValueMember = value;
        }

        public static void ExibirMsg(TipoMsg tipo)
        {
            switch (tipo)
            {
                case TipoMsg.Sucesso:


                    MessageBox.Show(UtilMensagens.Msg.MensagemSucesso, UtilMensagens.Msg.TituloSucesso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case TipoMsg.Erro:

                    MessageBox.Show(UtilMensagens.Msg.MensagemErro, UtilMensagens.Msg.TituloErro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TipoMsg.ErroExclusao:

                    MessageBox.Show(UtilMensagens.Msg.MensagemErroExclusao, UtilMensagens.Msg.TituloErro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TipoMsg.DadosNaoEncontrado:

                    MessageBox.Show(UtilMensagens.Msg.MensagemRegistroNaoEncontrado, UtilMensagens.Msg.TituloAviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }

        }
        public static void ExibirMsg(string campos)
        {
            MessageBox.Show(UtilMensagens.Msg.MensagemRegistroNaoEncontrado + "\n" + campos + "\n", UtilMensagens.Msg.TituloAviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void EstadoBotao(EstadoTela estado, Button btnSalvar, Button btnExcluir)
        {
            switch (estado)
            {
                case EstadoTela.Novo:
                    btnSalvar.Text = "Cadastrar";
                    btnExcluir.Visible = false;
                    break;
                case EstadoTela.Alterar:
                    btnSalvar.Text = "Alterar";
                    btnExcluir.Visible = true;
                    break;
            }
        }
        public static void LimparCamposGenerico(GroupBox g)
        {
            for (int i = 0; i < g.Controls.Count; i++)
            {
                switch (g.Controls[i].GetType().Name)
                {
                    case "TextBox":
                        TextBox campo = (TextBox)(g.Controls[i]);
                        campo.Clear();
                        break;
                    case "ComboBox":
                        ComboBox combo = (ComboBox)(g.Controls[i]);
                        combo.SelectedIndex = -1;
                        break;
                }
            }

        }
    }
}
