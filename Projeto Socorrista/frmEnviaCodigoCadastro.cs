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
        private string _codigoGerado;
        private string _emailVoluntario;

        public frmEnviaCodigoCadastro(string codigoGerado, string emailVoluntario)
        {
            InitializeComponent();
            _codigoGerado = codigoGerado;
            _emailVoluntario = emailVoluntario;
        }

        // Declare no início da sua classe
        private TextBox[] textBoxes;

        private void frmEnviaCodigoCadastro_Load(object sender, EventArgs e)
        {

   
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

                if (TodosOsCamposPreenchidos() && codigo == _codigoGerado)
                {
                    DialogResult result = MessageBox.Show("Código confirmado 🎉", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {

                    }
                }
                else if (TodosOsCamposPreenchidos() && codigo != _codigoGerado)
                {
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
    }
}
