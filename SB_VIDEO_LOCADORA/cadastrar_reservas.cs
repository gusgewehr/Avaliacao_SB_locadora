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
    public partial class cadastrar_reservas : Form
    {
        String cs = Globals.cs;

        private int i = 0;
        List<string> list_filmes = new List<string>();
        List<int> list_codfilme = new List<int>();





        public cadastrar_reservas()
        {
            InitializeComponent();

            i = 0;
            list_filmes.Clear();
            list_codfilme.Clear();
            lista_filmes.Text = "";
        }

    private void voltar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu fm = new menu();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void reservasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_locadoraDataSet);

        }

        private void cadastrar_reservas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_locadoraDataSet.Situacao'. Você pode movê-la ou removê-la conforme necessário.
            this.situacaoTableAdapter.Fill(this.bd_locadoraDataSet.Situacao);
            // TODO: esta linha de código carrega dados na tabela 'bd_locadoraDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bd_locadoraDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'bd_locadoraDataSet.Filme'. Você pode movê-la ou removê-la conforme necessário.
            this.filmeTableAdapter.Fill(this.bd_locadoraDataSet.Filme);
            // TODO: esta linha de código carrega dados na tabela 'bd_locadoraDataSet.Reservas'. Você pode movê-la ou removê-la conforme necessário.
            this.reservasTableAdapter.Fill(this.bd_locadoraDataSet.Reservas);

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            DataTable dt_cat = new DataTable();
            SqlCommand att = new SqlCommand("select * from Filme", conn);
            SqlDataAdapter adapt_att = new SqlDataAdapter(att);
            DataSet ds_att = new DataSet();
            adapt_att.Fill(this.bd_locadoraDataSet.Filme);
            conn.Close();
            conn.Open();
            DataTable dt_cl = new DataTable();
            SqlCommand cl = new SqlCommand("select * from Cliente", conn);
            SqlDataAdapter adapt_cal = new SqlDataAdapter(cl);
            adapt_cal.Fill(this.bd_locadoraDataSet.Cliente);
            conn.Close();

        }

        private void codClienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void codClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void dtInicioLabel_Click(object sender, EventArgs e)
        {

        }

        private void atualizar_btn_Click(object sender, EventArgs e)
        {

        }

        private void gravar_btn_Click(object sender, EventArgs e)
        {
            if (codFilmeComboBox.Text == "" || codClienteComboBox.Text == "" || dtInicioDateTimePicker.Text == "" || dtFimDateTimePicker.Text == "" || situacaoComboBox.Text == "")
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
                            SqlCommand cmd = new SqlCommand("insert into Reservas (Codigo, CodCliente,DtInicio, DtFim, Situacao, Observaco) values(@codigo,@codcliente,@dtinicio,@dtfim,@situacao, @observacao);", conn);
                            cmd.Parameters.AddWithValue("@codigo", cod_reserva + 1);
                            cmd.Parameters.AddWithValue("@codcliente", codClienteComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@dtinicio", dtFimDateTimePicker.Value);
                            cmd.Parameters.AddWithValue("@dtfim", dtFimDateTimePicker.Value);
                            cmd.Parameters.AddWithValue("@situacao", situacaoComboBox.SelectedValue);
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
                                        cmd2.Parameters.AddWithValue("@codcliente", codClienteComboBox.SelectedValue);
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
                            SqlCommand cmd = new SqlCommand("insert into Reservas (Codigo, CodCliente,DtInicio, DtFim, Situacao, Observaco) values(@codigo,@codcliente,@dtinicio,@dtfim,@situacao, @observacao);", conn);
                            cmd.Parameters.AddWithValue("@codigo", cod_reserva + 1);
                            cmd.Parameters.AddWithValue("@codcliente", codClienteComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@dtinicio", dtFimDateTimePicker.Value);
                            cmd.Parameters.AddWithValue("@dtfim", dtFimDateTimePicker.Value);
                            cmd.Parameters.AddWithValue("@situacao", situacaoComboBox.SelectedValue);
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
                                        cmd2.Parameters.AddWithValue("@codcliente", codClienteComboBox.SelectedValue);
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

        private void observacoLabel_Click(object sender, EventArgs e)
        {

        }

        private void lista_filmes_Click(object sender, EventArgs e)
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

        private void deletar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from FilmesReserva where CodReserva = @codigo; Delete from Reservas where codigo = @codigo; ", conn);
                cmd.Parameters.AddWithValue("@codigo", codigoNumericUpDown.Value);
                int j = cmd.ExecuteNonQuery();
                conn.Close();
                if (j > 0)
                {
                    MessageBox.Show("Registro deletado com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao deletar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login fm = new login();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }
    }
}
