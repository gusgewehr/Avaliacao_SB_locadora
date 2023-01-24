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
    public partial class filmes : Form
    {
        String cs = Globals.cs;
        public filmes()
        {
            InitializeComponent();
            
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand att = new SqlCommand("select * from Filme", conn);
            SqlDataAdapter adapt_att = new SqlDataAdapter(att);
            DataSet ds_att = new DataSet();
            adapt_att.Fill(ds_att);
            dt = ds_att.Tables[0];

            filmeDataGridView.DataSource = dt;
            conn.Close();

            descricaoTextBox.Text = "";
            codigoNumericUpDown.Value = 0;
            anoLancamentoTextBox.Text = "";
            valorNumericUpDown.Value = 0;
        }

        private void voltar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu fm = new menu();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void filmes_Load(object sender, EventArgs e)
        {

            
            // TODO: esta linha de código carrega dados na tabela 'bd_locadoraDataSet1.CategoriaFilme'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaFilmeTableAdapter.Fill(this.bd_locadoraDataSet1.CategoriaFilme);

            // TODO: esta linha de código carrega dados na tabela 'bd_locadoraDataSet.Filme'. Você pode movê-la ou removê-la conforme necessário.
            this.filmeTableAdapter.Fill(this.bd_locadoraDataSet.Filme);

            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            DataTable dt_cat = new DataTable();
            SqlCommand att = new SqlCommand("select * from CategoriaFilme", conn);
            SqlDataAdapter adapt_att = new SqlDataAdapter(att);
            DataSet ds_att = new DataSet();
            adapt_att.Fill(this.bd_locadoraDataSet1.CategoriaFilme);
            conn.Close();

            descricaoTextBox.Text = "";
            codigoNumericUpDown.Value = 0;
            anoLancamentoTextBox.Text = "";
            valorNumericUpDown.Value = 0;
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriaFilmeTableAdapter.FillBy1(this.bd_locadoraDataSet.CategoriaFilme);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void valorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.filmeTableAdapter.FillBy(this.bd_locadoraDataSet.Filme);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gravar_btn_Click(object sender, EventArgs e)
        {
            if (descricaoTextBox.Text == "" ||  codCat_combobox.Text == ""  ||  valorNumericUpDown.Text == "")
            {
                MessageBox.Show("Campos obrigatórios vazios");
            }
            else
            {
                SqlConnection conn = new SqlConnection(cs);
                    try
                    {
                        conn.Open();
                        SqlCommand com = new SqlCommand("Select max(codigo) as Codigo from Filme", conn);
                        SqlDataAdapter adapt_c = new SqlDataAdapter(com);
                        DataSet ds_c = new DataSet();
                        adapt_c.Fill(ds_c);
                        int count_c = ds_c.Tables[0].Rows.Count;
                        try 
                        {
                            object obj_cod = ds_c.Tables[0].Rows[0][0];
                            int cod_filme = (int)obj_cod;
                            SqlCommand cmd = new SqlCommand("insert into Filme (Codigo, CodCategoria,Descricao, AnoLancamento, Valor) values(@codigo,@codcat,@descricao,@ano,@valor);", conn);
                            cmd.Parameters.AddWithValue("@codigo", cod_filme + 1);
                            cmd.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                            cmd.Parameters.AddWithValue("@codcat", codCat_combobox.SelectedValue);
                            cmd.Parameters.AddWithValue("@ano", anoLancamentoTextBox.Text);
                            cmd.Parameters.AddWithValue("@valor", valorNumericUpDown.Value);
                            int i = cmd.ExecuteNonQuery();
                            conn.Close();
                            if (i > 0)
                            {
                                conn.Open();
                                DataTable dt = new DataTable();
                                descricaoTextBox.Text = "";
                                descricaoTextBox.Text = "";
                                codigoNumericUpDown.Value = 0;
                                anoLancamentoTextBox.Text = "";
                                valorNumericUpDown.Value = 0;
                                SqlCommand att = new SqlCommand("select * from Filme", conn);
                                SqlDataAdapter adapt_att = new SqlDataAdapter(att);
                                DataSet ds_att = new DataSet();
                                adapt_att.Fill(ds_att);
                                dt = ds_att.Tables[0];

                                filmeDataGridView.DataSource = dt;
                                conn.Close();


                            }
                            else
                            {
                                MessageBox.Show("Falha na execução");

                            }
                        }
                        catch
                        {
                            int cod_filme = 0;
                            SqlCommand cmd = new SqlCommand("insert into Filme (Codigo, CodCategoria,Descricao, AnoLancamento, Valor) values(@codigo,@codcat,@descricao,@ano,@valor);", conn);
                            cmd.Parameters.AddWithValue("@codigo", cod_filme + 1);
                            cmd.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                            cmd.Parameters.AddWithValue("@codcat", codCat_combobox.SelectedValue);
                            cmd.Parameters.AddWithValue("@ano", anoLancamentoTextBox.Text);
                            cmd.Parameters.AddWithValue("@valor", valorNumericUpDown.Value);
                            int i = cmd.ExecuteNonQuery();
                            conn.Close();
                            if (i > 0)
                            {
                                conn.Open();
                                DataTable dt = new DataTable();
                                descricaoTextBox.Text = "";
                                descricaoTextBox.Text = "";
                                codigoNumericUpDown.Value = 0;
                                anoLancamentoTextBox.Text = "";
                                valorNumericUpDown.Value = 0;
                                SqlCommand att = new SqlCommand("select * from Filme", conn);
                                SqlDataAdapter adapt_att = new SqlDataAdapter(att);
                                DataSet ds_att = new DataSet();
                                adapt_att.Fill(ds_att);
                                dt = ds_att.Tables[0];

                                filmeDataGridView.DataSource = dt;
                                conn.Close();


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

        private void atualizar_btn_Click(object sender, EventArgs e)
        {
            if (descricaoTextBox.Text == "" || codigoNumericUpDown.Text == "" || codCat_combobox.Text == "" || anoLancamentoTextBox.Text == "" || valorNumericUpDown.Text == "")
            {
                MessageBox.Show("Campos obrigatórios vazios");
            }
            else
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                SqlCommand comando = new SqlCommand("Select * from Filme where codigo=@codigo", conn);
                comando.Parameters.AddWithValue("@codigo", codigoNumericUpDown.Value);


                SqlDataAdapter adapt = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    try
                    {

                        conn.Open();
                        SqlCommand cmd = new SqlCommand("update Filme set Codigo=@codigo, CodCategoria=@codcat,Descricao=@descricao, AnoLancamento=@ano, Valor=@valor where Codigo=@codigo;", conn);
                        cmd.Parameters.AddWithValue("@codigo", codigoNumericUpDown.Text);
                        cmd.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                        cmd.Parameters.AddWithValue("@codcat", codCat_combobox.SelectedValue);
                        cmd.Parameters.AddWithValue("@ano", anoLancamentoTextBox.Text);
                        cmd.Parameters.AddWithValue("@valor", valorNumericUpDown.Value);
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (i > 0)
                        {
                            conn.Open();
                            DataTable dt = new DataTable();
                            descricaoTextBox.Text = "";
                            codigoNumericUpDown.Value = 0;
                            anoLancamentoTextBox.Text = "";
                            valorNumericUpDown.Value = 0;

                            SqlCommand att = new SqlCommand("select * from Filme", conn);
                            SqlDataAdapter adapt_att = new SqlDataAdapter(att);
                            DataSet ds_att = new DataSet();
                            adapt_att.Fill(ds_att);
                            dt = ds_att.Tables[0];

                            filmeDataGridView.DataSource = dt;
                            conn.Close();


                        }
                        else
                        {
                            MessageBox.Show("Falha na execução");

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Código de produto não existente");
                    this.Hide();
                    categorias fm = new categorias();
                    fm.Show();
                }
            }
        }

        private void deletar_btn_Click(object sender, EventArgs e)
        {
            if (codigoNumericUpDown.Text == "")
            {
                MessageBox.Show("Campos obrigatórios vazios");
            }
            else
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                SqlCommand comando = new SqlCommand("Select * from Filme where codigo=@codigo", conn);
                comando.Parameters.AddWithValue("@codigo", codigoNumericUpDown.Value);


                SqlDataAdapter adapt = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    try
                    {

                        conn.Open();
                        SqlCommand cmd = new SqlCommand("delete from Filme  where Codigo=@codigo;", conn);
                        cmd.Parameters.AddWithValue("@codigo", codigoNumericUpDown.Text);                        
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (i > 0)
                        {
                            conn.Open();
                            DataTable dt = new DataTable();
                            descricaoTextBox.Text = "";
                            SqlCommand att = new SqlCommand("select * from Filme", conn);
                            SqlDataAdapter adapt_att = new SqlDataAdapter(att);
                            DataSet ds_att = new DataSet();
                            adapt_att.Fill(ds_att);
                            dt = ds_att.Tables[0];

                            filmeDataGridView.DataSource = dt;
                            conn.Close();


                        }
                        else
                        {
                            MessageBox.Show("Falha na execução");

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Código de produto não existente");
                    this.Hide();
                    categorias fm = new categorias();
                    fm.Show();
                }
            }
        }

        private void valorNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

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
