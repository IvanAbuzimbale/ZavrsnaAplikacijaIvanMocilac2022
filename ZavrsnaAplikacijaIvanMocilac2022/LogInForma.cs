using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZavrsnaAplikacijaIvanMocilac2022
{
    public partial class LogInForma : Form
    {
        public LogInForma()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "Ivan" && txtLozinka.Text == "Mocilac")
            {
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                FormaNeZaAdmina forma = new FormaNeZaAdmina();
                forma.Show();
            }
        }
    }
}
