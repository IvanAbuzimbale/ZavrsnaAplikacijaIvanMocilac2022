using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZavrsnaAplikacijaIvanMocilac2022
{
    public partial class FormPregledIspisRezervacija : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();

        static string putanjaDokumenti = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string rezervacije = "Rezervacije.xml";
        static string putanjaRezervacije = Path.Combine(putanjaDokumenti, rezervacije);

        static string gosti = "Gosti.xml";
        static string putanjaGostiju = Path.Combine(putanjaDokumenti, gosti);

        static string objekti = "KucniObjekti.xml";
        static string putanjaObjekata = Path.Combine(putanjaDokumenti, objekti);

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtPregledPodataka.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
        }

        public FormPregledIspisRezervacija()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Rezervacije = XDocument.Load(putanjaRezervacije);
            var Gosti = XDocument.Load(putanjaGostiju);
            var Objekti = XDocument.Load(putanjaObjekata);
            txtPregledPodataka.Clear();
            txtPregledGostiju.Clear();
            txtPregledObjekta.Clear();

            IEnumerable<string> ListaRezervacija = from s in Rezervacije.Descendants("Rezervacija")
                                            where s.Element("Ime_Prezime_Vlasnika_Rezervacije").Value == txtImeVlasnika.Text
                                            select "\n\n\n" + s.Element("Ime_Prezime_Vlasnika_Rezervacije").Value +
                                                   "\n\n" + s.Element("Ime_Objekta").Value +
                                                   "\n\n" + s.Element("Broj_Skupine").Value +
                                                   "\n\n" + s.Element("Broj_Gostiju").Value + "\n\n";
            foreach (string s in ListaRezervacija) { txtPregledPodataka.Text += s; }

            IEnumerable<string> ListaGostiju = from g in Gosti.Descendants("Gost")
                                                   where g.Element("Broj_Skupine").Value == txtBrojSkupine.Text
                                                   select "\n\n\n" + g.Element("Ime_gosta").Value +
                                                          "\n\n" + g.Element("Ime_gosta").Value +
                                                          "\n\n" + g.Element("Ime_gosta").Value +
                                                          "\n\n" + g.Element("Ime_gosta").Value + "\n\n";
            foreach (string s in ListaGostiju) { txtPregledGostiju.Text += s; }

            IEnumerable<string> ListaObjekata = from o in Rezervacije.Descendants("Rezervacija")
                                                   where o.Element("Ime_Prezime_Vlasnika_Rezervacije").Value == txtObjekt.Text
                                                   select "\n\n\n" + o.Element("Ime_Prezime_Vlasnika_Rezervacije").Value +
                                                          "\n\n" + o.Element("Ime_Objekta").Value +
                                                          "\n\n" + o.Element("Broj_Skupine").Value +
                                                          "\n\n" + o.Element("Broj_Gostiju").Value + "\n\n";
            foreach (string s in ListaObjekata) { comboObjekt.Text += s; }
        }
    }
}
