using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Socorrista
{
    public partial class frmEnviaCodigoCadastro : Form
    {
        private string _nomeVoluntario;
        private string _emailVoluntario;
        string codigoGerado;
        public frmEnviaCodigoCadastro(string nomeVolunario, string emailVoluntario)
        {
            InitializeComponent();
            _nomeVoluntario = nomeVolunario;
            _emailVoluntario = emailVoluntario;
        }

        // Declare no início da sua classe
        private TextBox[] textBoxes;

        private void frmEnviaCodigoCadastro_Load(object sender, EventArgs e)
        {
          
            codigoGerado = gerarCodigoAleatorio();
            enviarCodigo(_emailVoluntario, codigoGerado);
            lblEmail.Text = _emailVoluntario;
            picGif.Image = Properties.Resources.gif_senha;

            txtN1.BringToFront();
            txtN2.BringToFront();
            txtN3.BringToFront();
            txtN4.BringToFront();
            txtN5.BringToFront();
            txtN6.BringToFront();


            textBoxes = new TextBox[] { txtN1, txtN2, txtN3, txtN4, txtN5, txtN6 };

            foreach (var box in textBoxes)
            {
                box.KeyUp += TextBox_KeyUp;
                box.Leave += TextBox_Leave;
                box.Enter += TextBox_Enter;
            }
        }
        private bool TodosOsCamposPreenchidos()
        {

            if (textBoxes.All(tb => tb.Text.Length == 1))
            {
                return true;
            }
            return false;   
        }
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var currentTextBox = (TextBox)sender;

            if (e.KeyCode == Keys.Back)
            {
                if (currentTextBox.Text.Length == 0 && currentTextBox.SelectionStart == 0)
                {
                    MoveFocusToPrevious(currentTextBox);
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                string codigo = txtN1.Text + txtN2.Text + txtN3.Text + txtN4.Text + txtN5.Text + txtN6.Text;

                if (TodosOsCamposPreenchidos() && codigo == codigoGerado)
                {
                    DialogResult result = MessageBox.Show("Código confirmado 🎉", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK) {
                        
                    }
                }
                else if (TodosOsCamposPreenchidos() && codigo != codigoGerado) {
                    MessageBox.Show("O Código informado está incorreto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (currentTextBox.Text.Length == 1)
                {
                    MoveFocusToNext(currentTextBox);
                }
            }
        }
        private void MoveFocusToNext(TextBox current)
        {
            int index = Array.IndexOf(textBoxes, current);
            if (index >= 0 && index < textBoxes.Length - 1)
            {
                textBoxes[index + 1].Focus();
                textBoxes[index + 1].SelectAll();
            }
        }
        private void MoveFocusToPrevious(TextBox current)
        {
            int index = Array.IndexOf(textBoxes, current);
            if (index > 0)
            {
                textBoxes[index - 1].Focus();
                textBoxes[index - 1].SelectAll();
            }
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            if (currentTextBox.Text == "0")
            {
                currentTextBox.Text = "";
            }
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(currentTextBox.Text))
            {
                currentTextBox.Text = "0";
            }
        }

        private string gerarCodigoAleatorio() { 
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
                                Olá <strong>{_nomeVoluntario}</strong>,<br>
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

        private bool enviarCodigo(string destino, string codigo) {

            try {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("cauagoncalves2190@gmail.com");
                mail.To.Add(destino);
                mail.Subject = "Código de confirmação";  
                mail.Body = GerarCorpoEmail(codigo) ;

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
    }
}
