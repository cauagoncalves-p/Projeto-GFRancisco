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
using System.Windows.Forms.DataVisualization.Charting;

namespace Projeto_Socorrista
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();

            PanelArredonda arredondador = new PanelArredonda();
            arredondador.ArredondarPanel(panelRecebimentos, 20);
            arredondador.ArredondarPanel(panelDistribuicoes, 20);
            arredondador.ArredondarPanel(panelTipoAlimento, 20);
            arredondador.ArredondarPanel(panelFamilias, 20);
            arredondador.ArredondarPanel(panelEstoque, 20);
            arredondador.ArredondarPanel(panelAlimentos, 20);
            arredondador.ArredondarPanel(panelGraficoRecebimentos, 20);
            arredondador.ArredondarPanel(panelGraficoTipoAlimento, 20);
            carregaGraficoAlimentos();
        }
        private string ObterNomeMes(int numeroMes)
        {
            DateTime data = new DateTime(2000, numeroMes, 1);
            return data.ToString("MMMM"); // retorna "Janeiro", "Fevereiro", etc.
        }
        private void carregaGraficoAlimentos()
        {
            MySqlDataReader reader = null;
            try
            {
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();
                chart1.ChartAreas.Add(new ChartArea("AreaPrincipal"));
                chart1.Titles.Clear();

                // Define título do gráfico explicando o que ele mostra
                chart1.Titles.Add("Quantidade Total de Alimentos Recebidos por Mês");

                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = @"
            SELECT 
                MONTH(data_recebimento) AS mes,
                SUM(quantidade) AS total
            FROM 
                tbDoacoes
            GROUP BY 
                mes
            ORDER BY
                mes;";
                comm.CommandType = CommandType.Text;

                comm.Connection = ConectaBanco.ObterConexao();
                reader = comm.ExecuteReader();

                // Mudei o nome da série para descrever melhor o que representa
                Series serieQuantidade = new Series("Total de Alimentos por Mês")
                {
                    ChartType = SeriesChartType.Column,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };
                serieQuantidade["PointWidth"] = "0.6";

                Dictionary<int, Color> coresPorMes = new Dictionary<int, Color>()
        {
            { 1, Color.SteelBlue },
            { 2, Color.ForestGreen },
            { 3, Color.Orange },
            { 4, Color.Salmon },
            { 5, Color.Purple },
            { 6, Color.Goldenrod },
            { 7, Color.CadetBlue },
            { 8, Color.Crimson },
            { 9, Color.MediumSeaGreen },
            { 10, Color.DarkViolet },
            { 11, Color.Tomato },
            { 12, Color.MediumSlateBlue }
        };

                while (reader.Read())
                {
                    int numeroMes = Convert.ToInt32(reader["mes"]);
                    decimal total = Convert.ToDecimal(reader["total"]);
                    string nomeMes = ObterNomeMes(numeroMes);

                    int pontoIndex = serieQuantidade.Points.AddXY(nomeMes, total);

                    if (coresPorMes.ContainsKey(numeroMes))
                    {
                        serieQuantidade.Points[pontoIndex].Color = coresPorMes[numeroMes];
                    }
                    else
                    {
                        serieQuantidade.Points[pontoIndex].Color = Color.Gray;
                    }
                }

                chart1.Series.Add(serieQuantidade);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar gráfico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null && !reader.IsClosed) reader.Close();
                ConectaBanco.FecharConexao();
            }
        }

    }
}
