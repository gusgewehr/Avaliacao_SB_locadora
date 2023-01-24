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
    public partial class cadastrar_se : Form
    {
        String cs = Globals.cs;
        public cadastrar_se()
        {
            InitializeComponent();
        }

        private void head_Click(object sender, EventArgs e)
        {

        }

        private void gravar_btn_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text == "" || cPFTextBox.Text == "" || telefoneTextBox.Text == "" || emailTextBox.Text == "" || senhaTextBox.Text == "")
            {
                MessageBox.Show("Campos obrigatórios vazios");
            }
            else
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                SqlCommand comando = new SqlCommand("Select max(codigo) as Codigo from Cliente", conn);
                SqlDataAdapter adapt = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                object obj_cod = ds.Tables[0].Rows[0][0];
                int cod_user = (int)obj_cod;
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into Cliente (Codigo,Nome,CPF,Telefone,Endereco,Bairro,Cidade,Email,Senha) values(@codigo,@nome,@cpf,@telefone,@endereco,@bairro,@cidade,@email,@senha);", conn);
                        cmd.Parameters.AddWithValue("@codigo", cod_user+1);
                        cmd.Parameters.AddWithValue("@nome", nomeTextBox.Text);
                        cmd.Parameters.AddWithValue("@cpf", cPFTextBox.Text);
                        cmd.Parameters.AddWithValue("@telefone", telefoneTextBox.Text);
                        cmd.Parameters.AddWithValue("@endereco", enderecoTextBox.Text);
                        cmd.Parameters.AddWithValue("@bairro", bairroTextBox.Text);
                        cmd.Parameters.AddWithValue("@cidade", cidadeTextBox.Text);
                        cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@senha", senhaTextBox.Text);
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (i > 0)
                        {
                            MessageBox.Show("Usuário cadastrado");
                            this.Hide();
                            login fm = new login();
                            fm.Closed += (s, args) => this.Close();
                            fm.Show();
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
        }

        private void atualizar_btn_Click(object sender, EventArgs e)
        {

        }

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bairroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void codigoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cPFLabel_Click(object sender, EventArgs e)
        {

        }

        private void cPFTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void deletar_btn_Click(object sender, EventArgs e)
        {

        }

        private void voltar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login  fm = new login();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void senhaLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void cidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bairroLabel_Click(object sender, EventArgs e)
        {

        }

        private void enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
