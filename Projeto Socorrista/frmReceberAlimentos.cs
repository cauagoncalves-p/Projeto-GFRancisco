using MySql.Data.MySqlClient;
using Projeto_Socorrista.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private int enviarDoacoes(string doador, string data, string contatoDoador, string tipoDoacao, int quantidade, string unidade, string descricao, string informacao) {
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
            comm.Parameters.Add("@observacao", MySqlDbType.VarChar, 200).Value = informacao;

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

                    string nomeDoador = dr.ItemArray[1] != DBNull.Value ? dr.ItemArray[1].ToString() : "";
                    string tipoDoacao = dr.ItemArray[4] != DBNull.Value ? dr.ItemArray[4].ToString() : "";
                    string quantidade = dr.ItemArray[5] != DBNull.Value ? dr.ItemArray[5].ToString() : "";
                    string unidadeMedida = dr.ItemArray[6] != DBNull.Value ? dr.ItemArray[6].ToString() : "";
                    string descricao = dr.ItemArray[7] != DBNull.Value ? dr.ItemArray[7].ToString() : "";

                    dgvRegistro.Rows.Add(dataFormatada, nomeDoador, tipoDoacao, quantidade + " " + unidadeMedida, descricao);
                } 
            }
            ConectaBanco.FecharConexao();
        }

        private bool VerificaFormatacaoDosCampos() {
            if (Regex.IsMatch(MtxtDoador.TextValue, @"\d"))
            {
                MessageBox.Show("Nome do doador(a) não pode conter números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtDoador.Focus();
                return false;
            }

            string dataRececimento = MtxtDataRecebemento.TextValue.Replace("/", "");
            if (dataRececimento.Length < 8)
            {
                MessageBox.Show("Data de recebimento inválida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtDataRecebemento.Focus();
                return false;
            }

            DateTime.TryParse(MtxtDataRecebemento.TextValue, out DateTime dataRecebimento);
            if (dataRecebimento > DateTime.Today)
            {
                MessageBox.Show("Você inseriu uma data futura", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtDataRecebemento.Focus();
                return false;
            }

            if (dataRecebimento < DateTime.Now.AddMonths(-3)) {
                MessageBox.Show("O periodo para cadastro de doação excedeu!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtDataRecebemento.Focus();
                return false;
            }
               
            if (Regex.IsMatch(MtxtQuantidade.TextValue, @"[a-zA-Z]"))
            {
                MessageBox.Show("Quantidade inválida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtQuantidade.Focus();
                return false;
            }
            return true;
        }
        private string SimplificarUnidade(string unidadeSelecionada)
        {
            switch (unidadeSelecionada)
            {
                case "Quilogramas (kg)":
                    return "kg";
                case "Gramas (g)":
                    return "g";
                case "Litros (l)":
                    return "l";
                case "Mililitros (ml)":
                    return "ml";
                case "Unidades":
                    return "un";
                case "Caixas":
                    return "cx";
                default:
                    return ""; 
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (MtxtDoador.TextValue.Equals("") || MtxtContatoDoador.TextValue.Equals("") || MtxtDataRecebemento.TextValue.Equals("") || MtxtDescricao.TextValue.Equals("") || MtxtInformacoes.TextValue.Equals("")
                || MtxtQuantidade.TextValue.Equals("") || cbxTipoDoacao.SelectedIndex == 0 || cbxUnidadeMedida.SelectedIndex == 0)
            {
                MessageBox.Show("Um ou mais campos não foram preenchidos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!VerificaFormatacaoDosCampos()) {
                return;
            }
            string dataRecebimento = MtxtDataRecebemento.TextValue.Replace("/", "");
            DateTime data = DateTime.ParseExact(dataRecebimento, "ddMMyyyy", null);
            string dataFormatada = data.ToString("yyyy-MM-dd");
            int quantidade = Convert.ToInt32(MtxtQuantidade.TextValue);
            string tipoDoacao = cbxTipoDoacao.Text; ;
            string tipoUnidade = SimplificarUnidade(cbxUnidadeMedida.Text);

            if (enviarDoacoes(MtxtDoador.TextValue, dataFormatada, MtxtContatoDoador.TextValue, tipoDoacao, quantidade, tipoUnidade, MtxtDescricao.TextValue, MtxtInformacoes.TextValue) == 1)
            {
                MessageBox.Show("Doação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvRegistro.Rows.Clear();
                carregaDoacoes();
            }
            else {
                MessageBox.Show("Erro ao cadastrar doação!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MtxtDataRecebemento_TextChanged(object sender, EventArgs e)
        {
            
            bool editandoInternoDataNascimento = false;

            if (editandoInternoDataNascimento) return;

            editandoInternoDataNascimento = true;

            string campoNascimento = MtxtDataRecebemento.TextValue.Replace("/", "");

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
                campoFormatadoNascimento += campoNascimento.Substring(0, 2) + "/" + campoNascimento.Substring(2, 2) + "/" + campoNascimento.Substring(4);
            }

            MtxtDataRecebemento.TextValue = campoFormatadoNascimento;

            // tenta manter o cursor no final

            MtxtDataRecebemento.SelectionStart = MtxtDataRecebemento.TextValue.Length;
            editandoInternoDataNascimento = false;
        }
    }
}
