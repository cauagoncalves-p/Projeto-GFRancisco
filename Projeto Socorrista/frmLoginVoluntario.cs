using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MosaicoSolutions.ViaCep;
using MySql.Data.MySqlClient;
using Projeto_Socorrista.Classes;

namespace Projeto_Socorrista
{
    public partial class frmLoginVoluntario : Form
    {
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
            MtxtConfirmeSenha.MaxLength = 15;
            MtxtSenha.MaxLength = 15;
            MtxtCEP.MaxLength = 9; 
            MtxtCPF.MaxLength = 14;
            MtxtDataNascimento.MaxLength = 10;
            MtxtTelefone.MaxLength = 15;
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

        private void picMostrarSenha1_Click(object sender, EventArgs e)
        {
            bool imagemAlternada1 = false;
            MtxtConfirmeSenha.UseSystemPasswordChar = !MtxtConfirmeSenha.UseSystemPasswordChar;

            if (imagemAlternada1)
            {
                picMostrarSenha1.Image = Properties.Resources.SenhaEscondida;
            }
            else
            {
                picMostrarSenha1.Image = Properties.Resources.SenhaVisivel;
            }

            imagemAlternada1 = !imagemAlternada1;
        }

        private void MtxtCPF_TextChanged(object sender, EventArgs e)
        {
            bool editandoInterno = false;

            if (editandoInterno) return; // impede loop infinito

            editandoInterno = true;

            string campoCPF = MtxtCPF.TextValue.Replace(".", "").Replace("-", "");

            string campoFormatado = "";

            if (campoCPF.Length <= 3)
                campoFormatado = campoCPF;
            else if (campoCPF.Length <= 6)
                campoFormatado = campoCPF.Substring(0, 3) + "." + campoCPF.Substring(3);
            else if (campoCPF.Length <= 9)
                campoFormatado = campoCPF.Substring(0, 3) + "." + campoCPF.Substring(3, 3) + "." + campoCPF.Substring(6);
            else
                campoFormatado = campoCPF.Substring(0, 3) + "." + campoCPF.Substring(3, 3) + "." + campoCPF.Substring(6, 3) + "-" + campoCPF.Substring(9);

            MtxtCPF.TextValue = campoFormatado;

            // tenta manter o cursor no final

            MtxtCPF.SelectionStart = MtxtCPF.TextValue.Length;
            editandoInterno = false;
        }

        private void MtxtTelefone_TextChanged(object sender, EventArgs e)
        {
            bool editandoInternoTelefone = false;

            if (editandoInternoTelefone) return; // impede loop infinito

            editandoInternoTelefone = true;

            string CampoTelefone = MtxtTelefone.TextValue.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            string campoFormatadoTelefone = "";
         
            if (CampoTelefone.Length <= 2)
            {
                campoFormatadoTelefone = "(" + CampoTelefone;
            }
            else if (CampoTelefone.Length <= 6)
            {
                campoFormatadoTelefone = "(" + CampoTelefone.Substring(0, 2) + ") " + CampoTelefone.Substring(2);
            }
            else if (CampoTelefone.Length <= 10)
            {
                campoFormatadoTelefone = "(" + CampoTelefone.Substring(0, 2) + ") " + CampoTelefone.Substring(2, 4) + "-" + CampoTelefone.Substring(6);
            }
            else
            {
                campoFormatadoTelefone = "(" + CampoTelefone.Substring(0, 2) + ") " + CampoTelefone.Substring(2, 5) + "-" + CampoTelefone.Substring(7, 4);
            }

            MtxtTelefone.TextValue = campoFormatadoTelefone;

            // tenta manter o cursor no final

            MtxtTelefone.SelectionStart = MtxtTelefone.TextValue.Length;
            editandoInternoTelefone = false;
        }

        private void MtxtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            bool editandoInternoDataNascimento = false;

            if (editandoInternoDataNascimento) return;

            editandoInternoDataNascimento = true;

            string campoNascimento = MtxtDataNascimento.TextValue.Replace("/", "");

            string campoFormatadoNascimento = "";

            if (campoNascimento.Length <= 2)
            {
                campoFormatadoNascimento += campoNascimento;
                //14
            }
            else if (campoNascimento.Length <= 4)
            {
                //14082006
                campoFormatadoNascimento += campoNascimento.Substring(0, 2) + "/" + campoNascimento.Substring(2);
            }
            else 
             {
                //14/08/2006
                campoFormatadoNascimento += campoNascimento.Substring(0, 2) + "/" + campoNascimento.Substring(2, 2) + "/" + campoNascimento.Substring(4) ;
            }
        
            MtxtDataNascimento.TextValue = campoFormatadoNascimento;

            // tenta manter o cursor no final

            MtxtDataNascimento.SelectionStart = MtxtDataNascimento.TextValue.Length;
            editandoInternoDataNascimento = false;
        }

        private void MtxtCEP_TextChanged(object sender, EventArgs e)
        {
            bool editandoInternoCEP = false;

            if (editandoInternoCEP) return;

            editandoInternoCEP = true;

            string campoCEP = MtxtCEP.TextValue.Replace("-", "");

            string campoFormatadoCEP = "";

            if (campoCEP.Length <= 5)
            {
                campoFormatadoCEP = campoCEP;
            }
            else 
            {
                //12345678 → 12345-678
                campoFormatadoCEP =
                    campoCEP.Substring(0, 5) + "-" +
                    campoCEP.Substring(5);
            }

            MtxtCEP.TextValue = campoFormatadoCEP;

            // tenta manter o cursor no final

            MtxtCEP.SelectionStart = MtxtCEP.TextValue.Length;
            editandoInternoCEP = false;
        }

        //criando o método busca cep
        public void buscaCEP(string cep)
        {
            var viaCEPService = ViaCepService.Default();
            var endereco = viaCEPService.ObterEndereco(cep);

            MtxtEndereco.TextValue = endereco.Logradouro;
            MtxtCidade.TextValue = endereco.Localidade;
            MtxtComplemento.TextValue = endereco.Complemento;
        }

        private void MtxtCEP_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                string cep = MtxtCEP.TextValue.Replace("-", "");
                buscaCEP(cep);
            }
        }

        // Criando metodo que envia os dados do voluntário para o banco de dados
        private int enviarVoluntario(
            string nome, string sobrenome, string email, char cpf, char telefone, string dataNascimento, string senha, char cep, string endereco, string complemeto, string cidade ) { 
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntario(nomeVoluntario, sobrenomeVoluntario, telCel, cpf, email, dataNascimento, endereco_rua, endereco_cep, endereco_complemento, endereco_cidade, senha) " +
                "values (@nomeVoluntario, @sobrenomeVoluntario, @telCel, @cpf, @email, @dataNascimento, @endereco_rua, @endereco_cep, @endereco_complemento, @endereco_cidade, @senha);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeVoluntario", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@sobrenomeVoluntario", MySqlDbType.VarChar, 100).Value = sobrenome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
            comm.Parameters.Add("cpf", MySqlDbType.VarChar, 14).Value = cpf;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 11).Value = telefone;
            comm.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = dataNascimento;
            comm.Parameters.Add("senha", MySqlDbType.VarChar, 15).Value = senha;
            comm.Parameters.Add("@endereco_rua", MySqlDbType.VarChar, 100).Value = endereco;
            comm.Parameters.Add("@endereco_cep", MySqlDbType.VarChar, 8).Value = cep;
            comm.Parameters.Add("@endereco_complemento", MySqlDbType.VarChar, 50).Value = complemeto;
            comm.Parameters.Add("@endereco_cidade", MySqlDbType.VarChar, 50).Value = cidade;

            comm.Connection = ConectaBanco.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            ConectaBanco.FecharConexao();

            return resp;
        }
    }
}

