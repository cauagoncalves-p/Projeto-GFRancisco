using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Socorrista
{
    public partial class frmLoginVoluntario : Form
    {
        public frmLoginVoluntario()
        {
            InitializeComponent();
        }

        private void frmLoginVoluntario_Load(object sender, EventArgs e)
        {

        }

        private void lblLinkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmCadastroVoluntario frmCadastro = new frmCadastroVoluntario();
            frmCadastro.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblDoe_Click(object sender, EventArgs e)
        {

        }
    }
}
