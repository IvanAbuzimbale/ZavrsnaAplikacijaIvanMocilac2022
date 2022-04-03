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
using System.Xml;
using System.Xml.Linq;

namespace ZavrsnaAplikacijaIvanMocilac2022
{
    public partial class FormUpisNoveRezervacije : Form
    {
        List<Rezervacija> rezervacija = new List<Rezervacija>();
        static string dokumenti = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string putanja = Path.Combine(dokumenti, "Rezervacije.xml");

        static string dokumenti2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string putanja2 = Path.Combine(dokumenti2, "KucniObjekti.xml");
        
        public FormUpisNoveRezervacije()
        {
            InitializeComponent();
            XmlDocument doc = new XmlDocument();
            doc.Load(putanja2);
            XmlNodeList userList = doc.SelectNodes("Kucni_Objekti/Kucni_Objekt");
            using (XmlTextReader xmdatareader = new XmlTextReader(putanja2))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(xmdatareader);

                comboObjekt.DataSource = ds.Tables[0];
                comboObjekt.DisplayMember = "Ime_objekta";
            }
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {

            

            string poruka = "Želite li napraviti još jednu rezervaciju?";
            string naslov = "Upit";

            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon ikona = MessageBoxIcon.Information;
            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);

            Rezervacija rezer = new Rezervacija(dateTimeDolazak.Value, dateTimeOdlazak.Value, txtBrojSkupine.Text, txtIme.Text, txtBrojGostiju.Text, comboObjekt.Text);
            rezervacija.Add(rezer);

            if (rez == DialogResult.No)
            {
                try
                {
                    var NovaRezervacija = XDocument.Load(putanja);
                    foreach (Rezervacija objekt in rezervacija)
                    {
                        var Objekt = (new XElement("Rezervacija",
                        new XElement("Datum_Dolaska", objekt.DatumDolaska),
                        new XElement("Datum_Odlaska", objekt.DatumeOdlaska),
                        new XElement("Broj_Skupine", objekt.BrojSkupine),
                        new XElement("Ime_Prezime_Vlasnika_Rezervacije", objekt.ImeVlasnikaRezervacije),
                        new XElement("Broj_Gostiju", objekt.BrojGostiju),
                        new XElement("Ime_Objekta", objekt.ImeObjekta)));
                        NovaRezervacija.Root.Add(Objekt);
                    }
                    NovaRezervacija.Save(putanja);
                }
                catch (Exception ex)
                {
                    var NovaRezervacija = new XDocument();
                    NovaRezervacija.Add(new XElement("Kucni_Objekt"));
                    foreach (Rezervacija objekt in rezervacija)
                    {
                        var Objekt = (new XElement("Kucni_Objekt",
                        new XElement("Datum_Dolaska", objekt.DatumDolaska),
                        new XElement("Datum_Odlaska", objekt.DatumeOdlaska),
                        new XElement("Broj_Skupine", objekt.BrojSkupine),
                        new XElement("Ime_Vlasnika_Rezervacije", objekt.ImeVlasnikaRezervacije),
                        new XElement("Broj_Gostiju", objekt.BrojGostiju),
                        new XElement("Ime_Objekta", objekt.ImeObjekta)));
                        NovaRezervacija.Root.Add(Objekt);
                    }
                    NovaRezervacija.Save(putanja);
                }
                this.rezervacija.Clear();
                this.Close();
            }
        }
    }
}
