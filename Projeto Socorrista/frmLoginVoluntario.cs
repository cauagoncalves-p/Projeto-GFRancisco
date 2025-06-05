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
        private bool imagemAlternada = false;

        public frmLoginVoluntario()
        {
            InitializeComponent();
        }

        // configuração de senha e de confirma senha
        private void configuracaoDeSenha() 
        {
            MtxtConfirmeSenha.UseSystemPasswordChar = true;
            MtxtSenha.EnablePlaceholder = false;
            MtxtSenha.UseSystemPasswordChar = true;
            MtxtConfirmeSenha.EnablePlaceholder = false;
            MtxtConfirmeSenha.UseSystemPasswordChar = true;
        }

        // mudando o MaxLengh dos campos
        private void mudandoMaxLength()
        {
            MtxtConfirmeSenha.MaxLength = 20;
            MtxtSenha.MaxLength = 20;
            MtxtCEP.MaxLength = 9;
            MtxtCPF.MaxLength = 14;
            MtxtDataNascimento.MaxLength = 10;
            MtxtTelefone.MaxLength = 12;
            MtxtSobrenome.MaxLength = 30;
            MtxtNome.MaxLength = 20;
            MtxtEndereco.MaxLength = 100;
            MtxtEmail.MaxLength = 100;
            MtxtCidade.MaxLength = 50;
            MtxtComplemento.MaxLength = 50;
        }

        private void frmLoginVoluntario_Load(object sender, EventArgs e)
        {
            configuracaoDeSenha();
            mudandoMaxLength();
        }

        // Trocando imagem ao clicar
        private void picMonstrarSenha_Click(object sender, EventArgs e)
        {
            MtxtSenha.UseSystemPasswordChar = !MtxtSenha.UseSystemPasswordChar;

            if (imagemAlternada)
            {
                picMonstrarSenha.Image = Properties.Resources.SenhaEscondida;
            }
            else
            {
           
                picMonstrarSenha.Image = Properties.Resources.SenhaVisivel;
            }

            imagemAlternada = !imagemAlternada;
        }

        private void picMostrarSenha1_Click(object sender, EventArgs e)
        {
            MtxtConfirmeSenha.UseSystemPasswordChar = !MtxtConfirmeSenha.UseSystemPasswordChar;
        }
    }
}
