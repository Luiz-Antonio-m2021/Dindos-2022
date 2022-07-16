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
    public partial class fmrPesquisa : Form
    {
        public fmrPesquisa()
        {
            InitializeComponent();
        }

        private void fmrPesquisa_Load(object sender, EventArgs e)
        {
            BehaviorFmrCadTipoPreco rep = new BehaviorFmrCadTipoPreco();
            List<TipoPrecoVO> lstPesquisa = rep.CarregarTiposPreco();

            dgvPesquisa.DataSource = lstPesquisa;
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvPesquisa.RowCount > 0)
            //{
            //    TipoPrecoVO objSelec = (TipoPrecoVO)dgvPesquisa.CurrentRow.DataBoundItem;

            //    int Id = objSelec.Id;
            //    string Descricao = objSelec.Descricao;
            //}
        }

    }
}
