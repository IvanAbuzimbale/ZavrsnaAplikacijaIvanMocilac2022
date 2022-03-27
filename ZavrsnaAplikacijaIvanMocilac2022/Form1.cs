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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNoviObjekt_Click(object sender, EventArgs e)
        {
            FormUpisNovogObjekta forma = new FormUpisNovogObjekta();
            forma.Show();
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            FormUpisNoveRezervacije forma = new FormUpisNoveRezervacije();
            forma.Show();
        }

        private void btnNoviGost_Click(object sender, EventArgs e)
        {
            FormUpisNovogGosta forma = new FormUpisNovogGosta();
            forma.Show();
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            FormPregledIspisRezervacija forma = new FormPregledIspisRezervacija();
            forma.Show();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
