using MySql.Data.MySqlClient;
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
    public partial class frmTrocarSenha : Form
    {
        private string emailVoluntario;
        public frmTrocarSenha(string emailVoluntario)
        {
            InitializeComponent();
            this.emailVoluntario = emailVoluntario;
        }

      
        // cria um numero aleatorio para conctenar com a senha 
        public string GerarSaltSeguro(int tamanho = 16)
        {
            byte[] saltBytes = new byte[tamanho];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // criando metodo que criptografa a senha do voluntário
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
        private int trocarSenha(string senha, string salt,string email) {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbVoluntario set senha = @senha, salt = @salt where email = @email;";
            comm.CommandType =  CommandType.Text;
            
            comm.Parameters.Clear();
            comm.Parameters.Add("senha", MySqlDbType.VarChar, 256).Value = senha;
            comm.Parameters.Add("email", MySqlDbType.VarChar, 100).Value = email;
            comm.Parameters.Add("salt", MySqlDbType.VarChar, 100).Value = salt;


            comm.Connection = Classes.ConectaBanco.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            Classes.ConectaBanco.FecharConexao();

            return resp;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MtxtSenha.TextValue.Equals("") && MtxtConfimeSenha.TextValue.Equals("")) {
                MessageBox.Show("Um ou mais campos estão vazios!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MtxtSenha.TextValue.Equals("SenhaForte@2025")) {
                MessageBox.Show("A senha não pode ser igual a senha de exemplo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MtxtConfimeSenha.TextValue != MtxtSenha.TextValue) {
                MessageBox.Show("As senha precisam ser iguais!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Você confirma a redefinição de sua senha?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes){
                string salt = GerarSaltSeguro();
                string senhaCriptografada = GerarHashComSalt(MtxtSenha.TextValue, salt);

                if (trocarSenha(senhaCriptografada,salt,emailVoluntario) == 1)
                {
                    MessageBox.Show("Redefinição de senha concluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmLoginVoluntario login = new frmLoginVoluntario();
                    login.ShowDialog();
                    this.Show();
                }
                else {
                    MessageBox.Show("Erro na redefinição, verique os campos informados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

