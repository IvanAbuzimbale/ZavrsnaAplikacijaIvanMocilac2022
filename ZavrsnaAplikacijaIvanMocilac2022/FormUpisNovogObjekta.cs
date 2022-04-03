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
    public partial class FormUpisNovogObjekta : Form
    {
        List<KucniObjekt> kucniObjekti= new List<KucniObjekt>();
        static string dokumenti = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string putanja = Path.Combine(dokumenti, "KucniObjekti.xml");

        public FormUpisNovogObjekta()
        {
            InitializeComponent();
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            string poruka = "Želite li dodati novi kućni objekt?";
            string naslov = "Upit";

            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon ikona = MessageBoxIcon.Information;
            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);

            KucniObjekt kuca = new KucniObjekt(txtImeObjekta.Text, txtVlasnikObjekta.Text, txtCijena.Text);
            kucniObjekti.Add(kuca);

                if (rez == DialogResult.No)
                {
                    try
                    {
                        var NoviObjekt = XDocument.Load(putanja);
                        foreach (KucniObjekt objekt in kucniObjekti)
                        {
                            var Objekt = (new XElement("Kucni_Objekt",
                            new XElement("Ime_objekta", objekt.ImeObjekta),
                            new XElement("Vlasnik", objekt.VlasnikObjekta),
                            new XElement("Cijena", objekt.Cijena)));
                            NoviObjekt.Root.Add(Objekt);
                        }
                        NoviObjekt.Save(putanja);
                    }
                    catch (Exception ex)
                    {
                        var NoviObjekt = new XDocument();
                        NoviObjekt.Add(new XElement("Kucni_Objekti"));
                        foreach (KucniObjekt objekt in kucniObjekti)
                        {
                            var Objekt = (new XElement("Kucni_Objekt",
                            new XElement("Ime_objekta", objekt.ImeObjekta),
                            new XElement("Vlasnik", objekt.VlasnikObjekta),
                            new XElement("Cijena", objekt.Cijena)));
                            NoviObjekt.Root.Add(Objekt);
                        }
                        NoviObjekt.Save(putanja);
                    }
                    this.kucniObjekti.Clear();
                    this.Close();
                }
            }
    }
}
