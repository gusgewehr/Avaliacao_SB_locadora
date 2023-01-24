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
    public partial class categorias : Form
    {
        String cs = Globals.cs;

        public categorias()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand att = new SqlCommand("select * from CategoriaFilme", conn);
            SqlDataAdapter adapt_att = new SqlDataAdapter(att);
            DataSet ds_att = new DataSet();
            adapt_att.Fill(ds_att);
            dt = ds_att.Tables[0];

            categoriaFilmeDataGridView.DataSource = dt;
            conn.Close();
        }

        private void voltar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu fm = new menu();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void categoriaFilmeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaFilmeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_locadoraDataSet);

        }

        private void categorias_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_locadoraDataSet.CategoriaFilme'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaFilmeTableAdapter.Fill(this.bd_locadoraDataSet.CategoriaFilme);

            descricaoTextBox.Text = "";

        }

        

        private void gravar_btn_Click(object sender, EventArgs e)
        {
            
            if (descricaoTextBox.Text == "")
            {
                MessageBox.Show("Campos obrigatórios vazios");
            }
            else
            {
                SqlConnection conn = new SqlConnection(cs);
                    try
                    {
                        
                        conn.Open();
                        SqlCommand com = new SqlCommand("Select max(codigo) as Codigo from CategoriaFilme", conn);
                        SqlDataAdapter adapt_c = new SqlDataAdapter(com);
                        DataSet ds_c = new DataSet();
                        adapt_c.Fill(ds_c);
                        try
                        {
                            object obj_cod = ds_c.Tables[0].Rows[0][0];
                            int cod_cat = (int)obj_cod;

                            SqlCommand cmd = new SqlCommand("insert into CategoriaFilme (codigo, descricao) values(@codigo,@descricao);", conn);
                            cmd.Parameters.AddWithValue("@codigo", cod_cat + 1);
                            cmd.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                            int i = cmd.ExecuteNonQuery();
                            conn.Close();
                            if (i > 0)
                            {
                                conn.Open();
                                DataTable dt = new DataTable();
                                descricaoTextBox.Text = "";
                                SqlCommand att = new SqlCommand("select * from CategoriaFilme", conn);
                                SqlDataAdapter adapt_att = new SqlDataAdapter(att);
                                DataSet ds_att = new DataSet();
                                adapt_att.Fill(ds_att);
                                dt = ds_att.Tables[0];

                                categoriaFilmeDataGridView.DataSource = dt;
                                conn.Close();


                            }
                            else
                            {
                                MessageBox.Show("Falha na execução");

                            }
                        }
                        catch
                        {
                            int cod_cat = 0;

                            SqlCommand cmd = new SqlCommand("insert into CategoriaFilme (codigo, descricao) values(@codigo,@descricao);", conn);
                            cmd.Parameters.AddWithValue("@codigo", cod_cat + 1);
                            cmd.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                            int i = cmd.ExecuteNonQuery();
                            conn.Close();
                            if (i > 0)
                            {
                                conn.Open();
                                DataTable dt = new DataTable();
                                descricaoTextBox.Text = "";
                                SqlCommand att = new SqlCommand("select * from CategoriaFilme", conn);
                                SqlDataAdapter adapt_att = new SqlDataAdapter(att);
                                DataSet ds_att = new DataSet();
                                adapt_att.Fill(ds_att);
                                dt = ds_att.Tables[0];

                                categoriaFilmeDataGridView.DataSource = dt;
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

        private void descricaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void atualizar_btn_Click(object sender, EventArgs e)
        {
            if (descricaoTextBox.Text == "" || codigoNumericUpDown.Text == "")
            {
                MessageBox.Show("Campos obrigatórios vazios");
            }
            else
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                SqlCommand comando = new SqlCommand("Select * from CategoriaFilme where codigo=@codigo", conn);
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
                        SqlCommand cmd = new SqlCommand("update CategoriaFilme set codigo=@codigo, descricao=@descricao where codigo=@codigo;", conn);
                        cmd.Parameters.AddWithValue("@codigo", codigoNumericUpDown.Text);
                        cmd.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (i > 0)
                        {
                            conn.Open();
                            DataTable dt = new DataTable();
                            descricaoTextBox.Text = "";
                           
                            SqlCommand att = new SqlCommand("select * from CategoriaFilme", conn);
                            SqlDataAdapter adapt_att = new SqlDataAdapter(att);
                            DataSet ds_att = new DataSet();
                            adapt_att.Fill(ds_att);
                            dt = ds_att.Tables[0];

                            categoriaFilmeDataGridView.DataSource = dt;
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
                SqlCommand comando = new SqlCommand("Select * from CategoriaFilme where codigo=@codigo", conn);
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
                        SqlCommand cmd = new SqlCommand("delete from CategoriaFilme where codigo=@codigo;", conn);
                        cmd.Parameters.AddWithValue("@codigo", codigoNumericUpDown.Text);
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (i > 0)
                        {
                            conn.Open();
                            DataTable dt = new DataTable();
                            descricaoTextBox.Text = "";
                            SqlCommand att = new SqlCommand("select * from CategoriaFilme", conn);
                            SqlDataAdapter adapt_att = new SqlDataAdapter(att);
                            DataSet ds_att = new DataSet();
                            adapt_att.Fill(ds_att);
                            dt = ds_att.Tables[0];

                            categoriaFilmeDataGridView.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login fm = new login();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }
    }
}
