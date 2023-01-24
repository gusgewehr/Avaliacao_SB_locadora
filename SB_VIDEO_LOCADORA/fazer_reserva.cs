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
    public partial class fazer_reserva : Form
    {

        int cod_cliente = 0;

        String cs = Globals.cs;

        private int i = 0;
        List<string> list_filmes = new List<string>();

        List<int> list_codfilme = new List<int>();

        public fazer_reserva(int cod_user)
        {
            InitializeComponent();
            
            cod_cliente = cod_user;

            i = 0;
            list_filmes.Clear();
            list_codfilme.Clear();
            lista_filmes.Text = "";
        }

        private void fazer_reserva_Load(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            DataTable dt_cat = new DataTable();
            SqlCommand att = new SqlCommand("select * from Filme", conn);
            SqlDataAdapter adapt_att = new SqlDataAdapter(att);
            DataSet ds_att = new DataSet();
            adapt_att.Fill(this.bd_locadoraDataSet.Filme);
            conn.Close();
            
        }

        private void observacoLabel_Click(object sender, EventArgs e)
        {

        }

        private void observacoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_filme_Click(object sender, EventArgs e)
        {
            if (list_codfilme.Contains((int)codFilmeComboBox.SelectedValue))
            {
                MessageBox.Show("Filme já selecionado");
            }
            else
            {
                if (codFilmeComboBox.Text == "")
                {
                    MessageBox.Show("Selecione um filme para reservar");
                }
                else
                {
                    if (i == 10)
                    {
                        MessageBox.Show("Só é possível alugar até 10 filmes de uma vez");
                    }
                    else
                    {
                        list_filmes.Add(codFilmeComboBox.Text);
                        list_codfilme.Add((int)codFilmeComboBox.SelectedValue);

                        i++;

                        lista_filmes.Text = string.Join("\n", list_filmes);

                    }
                }
            }

        }

        private void rmv_filme_Click(object sender, EventArgs e)
        {
            try
            {
                list_filmes.Remove(codFilmeComboBox.Text);
                list_codfilme.Remove((int)codFilmeComboBox.SelectedValue);
                i--;
                lista_filmes.Text = String.Join("\n", list_filmes);
            }
            catch
            {
                MessageBox.Show("Erro ao remover filme");
            }
        }

        private void gravar_btn_Click(object sender, EventArgs e)
        {
            if (codFilmeComboBox.Text == "" ||  dtInicioDateTimePicker.Text == "" || dtFimDateTimePicker.Text == "")
            {
                MessageBox.Show("Campos obrigatórios vazios");
            }
            else
            {
                SqlConnection conn = new SqlConnection(cs);
                try
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand("Select max(Codigo) as Codigo from Reservas", conn);
                    SqlDataAdapter adapt_c = new SqlDataAdapter(com);
                    DataSet ds_c = new DataSet();
                    adapt_c.Fill(ds_c);
                    object obj_cod = ds_c.Tables[0].Rows[0][0];
                    int cod_reserva = (int)obj_cod;
                    int count_c = ds_c.Tables[0].Rows.Count;
                    try
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("insert into Reservas (Codigo, CodCliente,DtInicio, DtFim, Situacao, Observaco) values(@codigo,@codcliente,@dtinicio,@dtfim,'N', @observacao);", conn);
                            cmd.Parameters.AddWithValue("@codigo", cod_reserva + 1);
                            cmd.Parameters.AddWithValue("@codcliente", cod_cliente);
                            cmd.Parameters.AddWithValue("@dtinicio", dtFimDateTimePicker.Value);
                            cmd.Parameters.AddWithValue("@dtfim", dtFimDateTimePicker.Value);
                            cmd.Parameters.AddWithValue("@observacao", observacoTextBox.Text);
                            int j = cmd.ExecuteNonQuery();
                            conn.Close();
                            foreach (int filme in list_codfilme)
                            {
                                if (filme != 0)
                                {
                                    try
                                    {
                                        conn.Open();
                                        SqlCommand cmd2 = new SqlCommand("insert into FilmesReserva (CodReserva, CodCliente, CodFilme) values (@codres, @codcliente, @codfilme)", conn);
                                        cmd2.Parameters.AddWithValue("@codres", cod_reserva + 1);
                                        cmd2.Parameters.AddWithValue("@codcliente", cod_cliente);
                                        cmd2.Parameters.AddWithValue("@codfilme", filme);
                                        cmd2.ExecuteNonQuery();
                                        conn.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Erro: " + ex.ToString());
                                        conn.Close();
                                    }
                                }
                            }
                            if (j > 0)
                            {

                                MessageBox.Show("Reserva efetuada");

                            }
                            else
                            {
                                MessageBox.Show("Falha na execução");

                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Erro: " + ex.ToString());
                            conn.Close();
                        }
                    }
                    catch
                    {
                        cod_reserva = 0;
                        SqlCommand cmd = new SqlCommand("insert into Reservas (Codigo, CodCliente,DtInicio, DtFim, Situacao, Observaco) values(@codigo,@codcliente,@dtinicio,@dtfim,'N', @observacao);", conn);
                        cmd.Parameters.AddWithValue("@codigo", cod_reserva + 1);
                        cmd.Parameters.AddWithValue("@codcliente", cod_cliente);
                        cmd.Parameters.AddWithValue("@dtinicio", dtFimDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@dtfim", dtFimDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@observacao", observacoTextBox.Text);
                        int j = cmd.ExecuteNonQuery();
                        conn.Close();
                        foreach (int filme in list_codfilme)
                        {
                            if (filme != 0)
                            {
                                try
                                {
                                    conn.Open();
                                    SqlCommand cmd2 = new SqlCommand("insert into FilmesReserva (CodReserva, CodCliente, CodFilme) values (@codres, @codcliente, @codfilme)", conn);
                                    cmd2.Parameters.AddWithValue("@codres", cod_reserva + 1);
                                    cmd2.Parameters.AddWithValue("@codcliente", cod_cliente);
                                    cmd2.Parameters.AddWithValue("@codfilme", filme);
                                    cmd2.ExecuteNonQuery();
                                    conn.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    conn.Close();
                                }
                            }
                        }
                        if (j > 0)
                        {

                            MessageBox.Show("Reserva efetuada");

                        }
                        else
                        {
                            MessageBox.Show("Falha na execução");

                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }


            }
        }

        private void minhas_reservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            minhas_reservas fm = new minhas_reservas(cod_cliente);
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void voltar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login fm = new login();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }
    }
}
