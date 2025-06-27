using MySql.Data.MySqlClient;
using Projeto_Socorrista.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Socorrista
{
    public partial class frmEnviarSenha : Form
    {
        public frmEnviarSenha()
        {
            InitializeComponent();
            MtxtEmail.TextBoxBackColor = ColorTranslator.FromHtml("#FBF9F9");
            MtxtEmail.PlaceholderColor = Color.Black;
            MtxtEmail.BorderColorB = Color.Black;
        }

        // criando metodo que verifica email existente
        private (string email, string nome) verificaEmail(string email)
        {
            string nomeVoluntario = "";
            string emailVoluntario = ""; 

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nomeVoluntario, email from tbVoluntario where email = @email;";

            comm.Parameters.Clear();
            comm.Parameters.Add("email", MySqlDbType.VarChar, 100).Value = email;

            comm.Connection = ConectaBanco.ObterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();

            nomeVoluntario = DR.GetString(0);
            emailVoluntario = DR.GetString(1);

            ConectaBanco.FecharConexao();

            return (email, nomeVoluntario);
        }

        // envia codigo para o email informado 
        private string gerarCodigoAleatorio()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private string GerarCorpoEmail(string codigo)
        {
            return $@"
          <!DOCTYPE html>
                <html lang=""pt-BR"">
                <head>
                    <meta charset=""UTF-8"">
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                    <title>Seu Código Chegou! ✨</title>
                </head>
                <body style=""font-family: Arial, sans-serif; background-color: #f5f5f5; margin: 0; padding: 0; color: #333;"">
                    <!-- Container Principal -->
                    <div style=""max-width: 600px; margin: 20px auto; background: white; border-radius: 10px; overflow: hidden; box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);"">
                        <!-- Cabeçalho -->
                        <div style=""background: #009E70; color: white; padding: 30px; text-align: center;"">
                            <!-- Imagem (substitua pelo seu link) -->
                            <img src=""https://raw.githubusercontent.com/cauagoncalves-p/imagem/main/logo1.png"" alt=""Logo da Empresa"" style="" width: 250px;"">
                            <h1 style=""margin: 0; font-size: 24px;"">Seu Código Chegou! ✨</h1>
                        </div>

                        <!-- Conteúdo -->
                        <div style=""padding: 30px; text-align: center;"">
                            <p style=""font-size: 16px; line-height: 1.6; margin-bottom: 25px;"">
                                Olá <strong>{verificaEmail(MtxtEmail.TextValue).nome}</strong>,<br>
                                Obrigado por se cadastrar! Use o código abaixo para confirmar seu e-mail:
                            </p>
            
                            <!-- Caixa do Código -->
                            <div style=""background: #f8f9fa; border: 1px dashed #009E70; border-radius: 8px; padding: 15px; margin: 20px auto; display: inline-block;"">
                                <div style=""font-size: 28px; font-weight: bold; letter-spacing: 5px; color: #009E70;"">{codigo}</div>
                            </div>
          
                            <p style=""margin-top: 25px; font-size: 14px; color: #777;"">
                                Se você não solicitou este código, ignore esta mensagem.
                            </p>
                        </div>

                        <!-- Rodapé -->
                        <div style=""background: #f8f9fa; padding: 20px; text-align: center; font-size: 12px; color: #777;"">
                            <p style=""margin: 0;"">© 2025 Grupo Socrrista. Todos os direitos reservados.</p>
                            <p style=""margin: 10px 0 0;"">
                                <a href=""#"" style=""color: #009E70; text-decoration: none;"">Política de Privacidade</a> | 
                                <a href=""#"" style=""color: #009E70; text-decoration: none;"">Ajuda</a>
                            </p>
                        </div>
                    </div>
                </body>
                </html>
            ";
        }

        private bool enviarCodigo(string destino, string codigo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("cauagoncalves2190@gmail.com");
                mail.To.Add(destino);
                mail.Subject = "Código de confirmação";
                mail.Body = GerarCorpoEmail(codigo);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("cauagoncalves2190@gmail.com", "nduu tkmc ayoe joes");
                smtp.EnableSsl = true;
                mail.IsBodyHtml = true;
                smtp.Send(mail);
                return true;
            }
            catch (SmtpFailedRecipientsException ex)
            {
                Console.WriteLine("Erro em destinatários: " + ex.Message);
                return false;
            }
            catch (SmtpFailedRecipientException ex)
            {
                Console.WriteLine("Erro em um destinatário: " + ex.Message);
                return false;
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("Erro SMTP: " + ex.Message);
                return false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Endereço de e-mail mal formatado: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro geral: " + ex.Message);
                return false;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string codigo = gerarCodigoAleatorio();


            if (enviarCodigo(verificaEmail(MtxtEmail.TextValue).email, codigo)) {
                this.Hide();
                frmEnviaCodigoCadastro codigoCadastro = new frmEnviaCodigoCadastro(codigo, verificaEmail(MtxtEmail.TextValue).email, "Password");
                codigoCadastro.ShowDialog();
                this.Show();
            }
        }
    }
}

