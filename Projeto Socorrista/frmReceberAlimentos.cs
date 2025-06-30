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
    public partial class frmReceberAlimentos : Form
    {
        public frmReceberAlimentos()
        {
            InitializeComponent();
        }

        private void frmReceberAlimentos_Load(object sender, EventArgs e)
        {
            lblTitulo.BringToFront();
        }
    }
}
