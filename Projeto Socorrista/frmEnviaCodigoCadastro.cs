using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Socorrista
{
    public partial class frmEnviaCodigoCadastro : Form
    {
        public frmEnviaCodigoCadastro()
        {
            InitializeComponent();
        }

        private void frmEnviaCodigoCadastro_Load(object sender, EventArgs e)
        {
            picGif.Image = Properties.Resources.gif_senha;
            txtN1.BringToFront();
            txtN2.BringToFront();
            txtN3.BringToFront();
            txtN4.BringToFront();
            txtN5.BringToFront();
            txtN6.BringToFront();

            txtN1.Enter += textBox_Enter;
            txtN2.Enter += textBox_Enter;
            txtN3.Enter += textBox_Enter;
            txtN4.Enter += textBox_Enter;
            txtN5.Enter += textBox_Enter;
            txtN6.Enter += textBox_Enter;

            txtN1.KeyUp += textBox_KeyUp;
            txtN2.KeyUp += textBox_KeyUp;
            txtN3.KeyUp += textBox_KeyUp;
            txtN4.KeyUp += textBox_KeyUp;
            txtN5.KeyUp += textBox_KeyUp;
            txtN6.KeyUp += textBox_KeyUp;
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox atual = sender as TextBox;
            int posicaoCursor = atual.SelectionStart;

            if (atual.Text.Length == 1)
            {
                this.SelectNextControl(atual, true, true, true, true);
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox atual = sender as TextBox;

            if (atual.Text == "0")  
            {
                atual.Text = "";
            }
        }
    }
}
