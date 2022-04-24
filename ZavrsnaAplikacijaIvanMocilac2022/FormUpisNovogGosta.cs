using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZavrsnaAplikacijaIvanMocilac2022
{
    public partial class FormUpisNovogGosta : Form
    {
        List<Gost> gost = new List<Gost>();
        static string dokumenti = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string putanja = Path.Combine(dokumenti, "Gosti.xml");

        public FormUpisNovogGosta()
        {
            InitializeComponent();
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            string poruka = "Želite li dodati novog gosta?";
            string naslov = "Upit";

            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon ikona = MessageBoxIcon.Information;
            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);

            Gost gosti = new Gost(txtIme.Text, txtPrezime.Text, dateTimeRođenje.Value, txtBrojSkupine.Text, comboZemljaPrebivališta.Text);
            gost.Add(gosti);

            if (rez == DialogResult.No)
            {
                try
                {
                    var NoviGost = XDocument.Load(putanja);
                    foreach (Gost novigost in gost)
                    {
                        var Objekt = (new XElement("Gost",
                        new XElement("Ime_gosta", novigost.Ime),
                        new XElement("Prezime_gosta", novigost.Prezime),
                        new XElement("Datum_rođenja", novigost.DatumRođenja),
                        new XElement("Broj_skupine", novigost.BrojSkupine),
                        new XElement("Zemlja_prebivališta", novigost.MjestoPrebivališta)));
                        NoviGost.Root.Add(Objekt);
                    }
                    NoviGost.Save(putanja);
                }
                catch (Exception ex)
                {
                    var NoviGost = new XDocument();
                    NoviGost.Add(new XElement("Gost"));
                    foreach (Gost novigost in gost)
                    {
                        var Objekt = (new XElement("Gost",
                        new XElement("Ime_gosta", novigost.Ime),
                        new XElement("Prezime_gosta", novigost.Prezime),
                        new XElement("Datum_rođenja", novigost.DatumRođenja),
                        new XElement("Broj_skupine", novigost.BrojSkupine),
                        new XElement("Zemlja_prebivališta", novigost.MjestoPrebivališta)));
                        NoviGost.Root.Add(Objekt);
                    }
                    NoviGost.Save(putanja);
                }
                this.gost.Clear();
                this.Close();
            }
        }
    
    }
}
