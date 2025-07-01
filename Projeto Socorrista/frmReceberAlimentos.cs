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
            MtxtDescricao.WordWrap = true;
            dgvRegistro.Rows[0].Cells["Descricao"].Value = "Este é um texto muito longo que deve quebrar em várias linhas dentro da célula se o WordWrap estiver funcionando.";

            configDataGridView();
        }

        private void configDataGridView() {
            // Estilo geral
            dgvRegistro.BorderStyle = BorderStyle.None;
            dgvRegistro.BackgroundColor = Color.White;
            dgvRegistro.EnableHeadersVisualStyles = false;
            dgvRegistro.GridColor = Color.LightGray;
            dgvRegistro.RowHeadersVisible = false;
            dgvRegistro.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvRegistro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Cores de linhas
            dgvRegistro.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgvRegistro.DefaultCellStyle.BackColor = Color.White;
            dgvRegistro.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvRegistro.DefaultCellStyle.ForeColor = Color.Black;
            dgvRegistro.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#e6e6e6");
            dgvRegistro.DefaultCellStyle.SelectionForeColor = Color.White;

            // Estilo do cabeçalho
            dgvRegistro.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvRegistro.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvRegistro.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvRegistro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRegistro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // colunas ocupam todo o espaço

            // Bordas das células
            dgvRegistro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Altura das linhas
            dgvRegistro.RowTemplate.Height = 35;

        }
    }
}
