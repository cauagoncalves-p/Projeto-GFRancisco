using MySql.Data.MySqlClient;
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
    public partial class frmEnviarSenha : Form
    {
        public frmEnviarSenha()
        {
            InitializeComponent();
            MtxtEmail.TextBoxBackColor = ColorTranslator.FromHtml("#FBF9F9");
            MtxtEmail.PlaceholderColor = Color.Black;
            MtxtEmail.BorderColorB = Color.Black;

        }

        private bool verificaEmail(string email) {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select email, from tbVoluntarios where email = @email";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;



            return false;
        }
    }
}
