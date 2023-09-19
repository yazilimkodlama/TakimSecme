using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Label_Ornek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBesiktas_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "BEŞİKTAŞ";
            lblTakim.BackColor = Color.Black;
            lblTakim.ForeColor = Color.White;
        }

        private void btnBayern_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "BAYERN MUNİH";
            lblTakim.BackColor = Color.DarkBlue;
            lblTakim.ForeColor = Color.DarkRed;
        }

        private void btnManchester_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "MANCHESTER UNITED";
            lblTakim.BackColor = Color.Red;
            lblTakim.ForeColor = Color.White;
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "REAL MADRID";
            lblTakim.BackColor = Color.Purple;
            lblTakim.ForeColor = Color.White;
        }
    }
}
