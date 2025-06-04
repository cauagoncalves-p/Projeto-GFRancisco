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
        public frmLoginVoluntario()
        {
            InitializeComponent();
        }

        private void frmLoginVoluntario_Load(object sender, EventArgs e)
        {
            fontes();
        }


        private void fontes() {
            //lblTituloPrincipal.Font = new Font("Montserrat", 30, FontStyle.Bold);
        }

     
    }
}
