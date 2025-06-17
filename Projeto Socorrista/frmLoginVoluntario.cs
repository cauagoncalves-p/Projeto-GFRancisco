using MySql.Data.MySqlClient;
using Projeto_Socorrista.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void picMonstrarSenha_Click(object sender, EventArgs e)
        {
            bool imagemAlternada = false;
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

        public string GerarHashComSalt(string senha, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string senhaComSalt = salt + senha;
                byte[] bytes = Encoding.UTF8.GetBytes(senhaComSalt);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }

        public bool verificaUsers(string email, string senha) {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT senha, salt from tbvoluntario WHERE email = @email";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@email", MySqlDbType.VarChar,100).Value = email;  
            comm.Connection = ConectaBanco.ObterConexao();

            using (MySqlDataReader dr = comm.ExecuteReader())
            {
                if (dr.Read())
                {
                    // Pega hash e salt do banco
                    string hashBanco = dr.GetString("senha");
                    string saltBanco = dr.GetString("salt");

                    // Gera o hash da senha digitada com o salt recuperado
                    string hashDigitado = GerarHashComSalt(MtxtSenha.TextValue, saltBanco);

                    ConectaBanco.FecharConexao();

                    // Compara e retorna true se bater
                    return hashDigitado == hashBanco;
                }
                else
                {
                    // Email não encontrado
                    ConectaBanco.FecharConexao();
                    return false;
                }
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = MtxtEmail.TextValue;
            string senha = MtxtSenha.TextValue;

            if (verificaUsers(email, senha))
            {
                MessageBox.Show("Login efetuado com sucesso!");
                
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.");
            }
        }
    }
}
