using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SB_VIDEO_LOCADORA
{
    
    public partial class minhas_reservas : Form
    {
        int cod_cliente = 0;
        String cs = Globals.cs;
        public minhas_reservas(int cod_user)
        {
            InitializeComponent();
            cod_cliente = cod_user;
        }

        private void reservas_view_geralDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void minhas_reservas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_locadoraDataSet.reservas_view_geral'. Você pode movê-la ou removê-la conforme necessário.
            this.reservas_view_geralTableAdapter.Fill(this.bd_locadoraDataSet.reservas_view_geral);
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand att = new SqlCommand("select res.Codigo, cl.Nome,STRING_AGG(film.Descricao, '; ') Filmes, res.DtInicio, res.DtFim, st.Descricao, res.Observaco from Reservas res join Cliente cl ON cl.Codigo = res.CodCliente join FilmesReserva fr on fr.CodReserva = res.Codigo and fr.CodCliente = res.CodCliente join Filme film on film.Codigo = fr.CodFilme join Situacao st on st.Codigo = res.Situacao where res.CodCliente = @codcliente group by res.Codigo, cl.Nome,  res.DtInicio, res.DtFim, st.Descricao, res.Observaco Order by DtInicio desc, DtFim desc;", conn);
            att.Parameters.AddWithValue("@codcliente", cod_cliente);
            SqlDataAdapter adapt_att = new SqlDataAdapter(att);
            DataSet ds_att = new DataSet();
            adapt_att.Fill(ds_att);
            dt = ds_att.Tables[0];

            reservas_view_geralDataGridView.DataSource = dt;
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login fm = new login();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void voltar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fazer_reserva fm = new fazer_reserva(cod_cliente);
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }
    }
}
