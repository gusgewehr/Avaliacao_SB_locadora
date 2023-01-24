﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB_VIDEO_LOCADORA
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void reservas_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservas fm = new reservas();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void cadastrar_reservas_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastrar_reservas fm = new cadastrar_reservas();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void filmes_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            filmes fm = new filmes();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void clientes_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes fm = new clientes();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void usuarios_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuarios fm = new usuarios();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void categorias_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            categorias fm = new categorias();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
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
