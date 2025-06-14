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

        // Declare no início da sua classe
        private TextBox[] textBoxes;

        private void frmEnviaCodigoCadastro_Load(object sender, EventArgs e)
        {
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
            return textBoxes.All(tb => tb.Text.Length == 1);
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
                if (TodosOsCamposPreenchidos())
                {
                    MessageBox.Show("Código completo! 🎉", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
