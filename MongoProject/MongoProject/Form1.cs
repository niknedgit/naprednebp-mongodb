using MongoProject.Models;
using MongoProject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MongoProject
{
    public partial class Form1 : Form
    {
        public DatabaseSettings databaseSettings;
        public DatabaseContext databaseContext;
        public Form1()
        {
            InitializeComponent();
            databaseSettings = new DatabaseSettings();
            databaseSettings.ConnectionString = "mongodb://localhost:27017";
            databaseSettings.DatabaseName = "vestaci";
            databaseSettings.ServerResponeWaitTime = 2000;
            databaseSettings.PredmetCollectionName = "predmet";
            databaseSettings.RocisteCollectionName = "rociste";
            databaseContext = new DatabaseContext(databaseSettings);
            DodajPredmetGB.Visible = false;
            tuzeniAdvokatGB.Visible = false;
            tuzilacAdvGB.Visible = false;
            rocisteUserControl1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)//dodaj Predmet
        {
            DodajPredmetGB.Visible = true;
            PocetniGB.Visible = false;
            dateTimePicker1.Visible = false;
            rocisteUserControl1.Visible = false;
        }

        private void PronadjiPBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PronadjiPredmetForm forma = new PronadjiPredmetForm(databaseContext);
            forma.PrikaziSvePredmete(false);
            forma.ShowDialog();

        }

        private void UplataBtn_Click(object sender, EventArgs e)
        {
            rocisteUserControl1.Visible = false;
            PocetniGB.Visible = false;
            rocisteUserControl1.Visible = true;
            rocisteUserControl1.DodajUplatu(databaseContext);
            DodajPredmetGB.Visible = false;
        }

        private void RocisteBtn_Click(object sender, EventArgs e)
        {
            PocetniGB.Visible = false;
            rocisteUserControl1.Visible = true;
            rocisteUserControl1.DodajRociste(databaseContext);
            DodajPredmetGB.Visible = false;
        }

        private void RocistaPredstojeceBtn_Click(object sender, EventArgs e)
        {
            //   PocetniGB.Visible = false;
            this.Hide();
            PronadjiPredmetForm forma = new PronadjiPredmetForm(databaseContext);
            forma.PredstojecaRocista();
            forma.ShowDialog();
           
        }

        private void prikazSvihPredmetaBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PronadjiPredmetForm forma = new PronadjiPredmetForm(databaseContext);
            forma.PrikaziSvePredmete(true);
            forma.ShowDialog();

        }

        private void PredmetOkBtn(object sender, EventArgs e)
        {
            PredmetRepository repository = new PredmetRepository(databaseContext);
            TuzeniRepository tuzeniRepository = new TuzeniRepository(databaseContext);
            TuzilacRepository tuzilacRepository = new TuzilacRepository(databaseContext);
            PredmetRocisteRepository predmetRocisteRepository = new PredmetRocisteRepository(databaseContext);
            RocisteRepository rocisteRepository = new RocisteRepository(databaseContext);
            AdvokatRepository advokatRepository = new AdvokatRepository(databaseContext);
            UplataRepository uplataRepository = new UplataRepository(databaseContext);

            if (repository.Find(brojPtxt.Text) == null)
            {
                repository.Add(new PredmetModel
                {
                    BrPredmeta = brojPtxt.Text,
                    Mesto = MestoTxt.Text,
                    Godina = GodinaTxt.Text,
                    Podaci = PodaciTxt.Text,
                    NazivSuda = NazivTxt.Text,
                    Sudija = SudijaTxt.Text,
                    Vrsta = vrstaPtxt.Text
                });
                PredmetModel predmet = repository.Find(brojPtxt.Text);
                tuzeniRepository.Add(predmet.Id, new TuzeniModel
                {
                    PunoIme = tuzeniImeTxt.Text,
                    Telefon = TuzeniTelTxt.Text
                });
                tuzilacRepository.Add(predmet.Id, new TuzilacModel
                {
                    PunoIme = TuzilacImeTxt.Text,
                    Telefon = TuzilacTelTxt.Text
                });
                if (pozvanCB.Checked)
                {
                    predmetRocisteRepository.Add(predmet.Id, new PredmetRocisteModel
                    {
                        Datum = dateTimePicker1.Value.Date.ToString(),
                        Pozvan = pozvanCB.Checked
                    });
                    rocisteRepository.Add(new RocisteModel
                    {
                        Datum = dateTimePicker1.Value.Date.ToString(),
                        PredmetId = predmet.Id
                    });
                }

                advokatRepository.DodajAdvokataTuzenom(predmet.Id, new AdvokatModel
                {
                    PunoIme = TuzeniAdvImeTxt.Text,
                    Telefon = tuzeniAdvokatTelTxt.Text
                });
                advokatRepository.DodajAdvokataTuziocu(predmet.Id, new AdvokatModel
                {
                    PunoIme = tuzilacImeAdvTxt.Text,
                    Telefon = TuzilacAdvTelTxt.Text
                });
                
                if (IznosTxt.Text != "")
                {
                    uplataRepository.Add(predmet.Id, new UplataModel
                    {
                        Iznos = Double.Parse(IznosTxt.Text),
                        Placeno = PlacenoCB.Checked,
                        Uplatilac = PlatilacTxt.Text
                    });
                }     
                Clear(this.DodajPredmetGB);
                GetALlControls(this.DodajPredmetGB);
            }
            else
                MessageBox.Show("Vec postoji predmet sa zadatim brojem");

        }
        private void GetALlControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                GetALlControls(c);
                if (c is GroupBox)
                    this.Clear((GroupBox)c);
            }
        }
        private void Clear(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    control.Text = "";
            }
           foreach (Control control in groupBox.Controls)
           {
                if (control.GetType() == typeof(CheckBox))
                    ((CheckBox)control).Checked = false;
           }
        }
        private void pozvanCB_CheckedChanged(object sender, EventArgs e)
        {
                dateTimePicker1.Visible = pozvanCB.Checked;
        }

        private void tuzilacAdvCB_CheckedChanged(object sender, EventArgs e)
        {
            tuzilacAdvGB.Visible = tuzilacAdvCB.Checked;
        }

        private void tuzeniAdvCB_CheckedChanged(object sender, EventArgs e)
        {
            tuzeniAdvokatGB.Visible = tuzeniAdvCB.Checked;
        }

        private void rocisteUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void IznosTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ObrisiPredmetBtn_Click(object sender, EventArgs e)
        {
            PredmetRepository predmetRepository = new PredmetRepository(databaseContext);
            RocisteRepository rocisteRepository = new RocisteRepository(databaseContext);
            
            String brPredmeta= Interaction.InputBox("\r\n \r\n Unesite broj predmeta", "Obrisi predmet", "", -1, -1);
            var predmet = predmetRepository.Find(brPredmeta);
            if (predmet != null)
            {
                predmetRepository.Delete(brPredmeta);
                rocisteRepository.Delete(predmet.Id);
            }
            else MessageBox.Show("Ne postoji predmet sa zadatim brojem");
        }
    }
}
