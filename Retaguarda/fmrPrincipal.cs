﻿using System;
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
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void parceiroNegocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrCadParceiroNegocio f = new fmrCadParceiroNegocio();
            f.ShowDialog();
        }

        private void tipoDePreçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrCadTipoPreco f = new fmrCadTipoPreco();
            f.ShowDialog();
        }
    }
}
