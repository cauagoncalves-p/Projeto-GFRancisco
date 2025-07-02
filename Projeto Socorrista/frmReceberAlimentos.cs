using MySql.Data.MySqlClient;
using Projeto_Socorrista.Classes;
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
            configDataGridView();
            carregaDoacoes();
            cbxTipoDoacao.SelectedIndex = 0;
            cbxUnidadeMedida.SelectedIndex = 0; 
        }

        private void configDataGridView() {
            // Estilo geral
            dgvRegistro.BorderStyle = BorderStyle.None;
            dgvRegistro.BackgroundColor = Color.White;
            dgvRegistro.EnableHeadersVisualStyles = false;
            dgvRegistro.GridColor = Color.LightGray;
            dgvRegistro.RowHeadersVisible = false;

            dgvRegistro.RowTemplate.Height = 50;
            dgvRegistro.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
          
            // Cores de linhas
            dgvRegistro.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgvRegistro.DefaultCellStyle.BackColor = Color.White;
            dgvRegistro.DefaultCellStyle.Font = new Font("Microsoft New Tai Lue", 12);
            dgvRegistro.DefaultCellStyle.ForeColor = Color.Black;
            dgvRegistro.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#e6e6e6");
            dgvRegistro.DefaultCellStyle.SelectionForeColor = Color.White;

            // Estilo do cabeçalho
            dgvRegistro.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvRegistro.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvRegistro.ColumnHeadersHeight = 50;
            dgvRegistro.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvRegistro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRegistro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 

            // Bordas das células
            dgvRegistro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private int enviarDoacoes(string doador, string data, string contatoDoador, string tipoDoacao, int quantidade, string unidade, string descricao, string observacao) {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbDoacoes (nome_doador, data_recebimento, contato_doador, tipo_doacao, quantidade, unidade_medida, descricao, observacao) values " +
                "(@nome_doador, @data_recebimento, @contato_doador, @tipo_doacao, @quantidade, @unidade_medida, @descricao, @observacao);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("nome_doador", MySqlDbType.VarChar, 50).Value = doador;
            comm.Parameters.Add("@data_recebimento", MySqlDbType.Date).Value = data;
            comm.Parameters.Add("@contato_doador", MySqlDbType.VarChar, 100).Value = contatoDoador;
            comm.Parameters.Add("@tipo_doacao", MySqlDbType.VarChar, 50).Value = tipoDoacao;
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            comm.Parameters.Add("@unidade_medida", MySqlDbType.VarChar, 10).Value = unidade;
            comm.Parameters.Add("@descricao", MySqlDbType.Text).Value = descricao;
            comm.Parameters.Add("@observacao", MySqlDbType.VarChar, 200).Value = observacao;

            comm.Connection = ConectaBanco.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            ConectaBanco.FecharConexao();

            return resp;
        }

        private void carregaDoacoes()
        { 
            MySqlCommand comm = new MySqlCommand();
            string sql = "select * from  tbDoacoes order by data_recebimento limit 5";
            MySqlDataAdapter DA = new MySqlDataAdapter(sql, ConectaBanco.ObterConexao());
            DataTable dt = new DataTable();

            if (DA.Fill(dt) < 1)
            {
                dgvRegistro.DataSource = "Sem atribuições no momento";
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string dataFormatada = Convert.ToString(dr.ItemArray[2]);
                    dataFormatada = dataFormatada.Replace("00:00:00", "");
                    dgvRegistro.Rows.Add(dataFormatada, dr.ItemArray[1], dr.ItemArray[4], dr.ItemArray[5], dr.ItemArray[7]);
                } 
            }
            ConectaBanco.FecharConexao();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (MtxtDoador.TextValue.Equals("") || MtxtContatoDoador.TextValue.Equals("") || MtxtDataRecebemento.TextValue.Equals("") || MtxtDescricao.TextValue.Equals("") || MtxtInformacoes.TextValue.Equals("")
                || MtxtQuantidade.TextValue.Equals("") || cbxTipoDoacao.SelectedIndex == 0 || cbxUnidadeMedida.SelectedIndex == 0) {
                    MessageBox.Show("Um ou mais campos não foram preenchidos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }


           
        }
    }
}
