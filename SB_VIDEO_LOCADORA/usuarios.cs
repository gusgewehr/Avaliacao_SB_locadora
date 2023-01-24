using System;
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
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        private void voltar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu fm = new menu();
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
