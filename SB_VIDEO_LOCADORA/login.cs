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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        String cs = Globals.cs;

        private void entrar_btn_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "" || pass_txt.Text == "")
            {
                MessageBox.Show("Favor, forneça um usuário e senha válidos");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Usuario where Email=@username and Senha=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_user.Text);
                cmd.Parameters.AddWithValue("@password", pass_txt.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {                   
                        this.Hide();
                        menu fm = new menu();
                        fm.Closed += (s, args) => this.Close();
                        fm.Show();
                }
                else
                {
                    SqlConnection con_c = new SqlConnection(cs);
                    SqlCommand cmd_c = new SqlCommand("Select * from Cliente where Email=@username and Senha=@password", con_c);
                    cmd_c.Parameters.AddWithValue("@username", txt_user.Text);
                    cmd_c.Parameters.AddWithValue("@password", pass_txt.Text);
                    con_c.Open();
                    SqlDataAdapter adapt_c = new SqlDataAdapter(cmd_c);
                    DataSet ds_c = new DataSet();
                    adapt_c.Fill(ds_c);
                    con_c.Close();
                    int count_c = ds_c.Tables[0].Rows.Count;
                    if (count_c == 1)
                    {
                        object obj_cod = ds_c.Tables[0].Rows[0]["Codigo"];
                        int cod_user = (int)obj_cod;
                        this.Hide();
                        fazer_reserva fm = new fazer_reserva(cod_user);
                        fm.Closed += (s, args) => this.Close();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Falha no login");
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastrar_se fm = new cadastrar_se();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }
    }
}
