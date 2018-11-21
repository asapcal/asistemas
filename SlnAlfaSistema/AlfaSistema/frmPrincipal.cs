using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfaSistema
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");


        }

        private void wordPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadfun frmcl = new cadfun();
            frmcl.Show();


        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadfornecedor frmcl = new cadfornecedor();
            frmcl.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadCliente frmcl = new cadCliente();
            frmcl.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadProduto frmcl = new cadProduto();
            frmcl.Show();
        }
    }
}
