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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            if ((textBox1.Text == "asaph") && (textBox2.Text == "17"))
            {
                frmPrincipal frmp = new frmPrincipal();
                frmp.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuários ou Senha Inválidos","Erro de Autenticação",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
