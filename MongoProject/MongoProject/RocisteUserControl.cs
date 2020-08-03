using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoProject.Repository;
using MongoProject.Models;

namespace MongoProject
{
    public partial class RocisteUserControl : UserControl
    {
        private string funkcija;
        private DatabaseContext databaseContext;
        
        public RocisteUserControl()
        {
            InitializeComponent();
        }
        public void DodajUplatu(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
            rocisteGB.Visible = false;
            UplataGB.Visible = true;
            NaslovLbl.Text = "Evidentiranje uplate";
            PostUplGB.Visible = false;
            NovaUplataGB.Visible = false;
            OkBtn.Visible = false;
        }
        public void DodajRociste(DatabaseContext databaseContext)
        {
            OkBtn.Visible = true;
            this.databaseContext = databaseContext;
            funkcija = "rociste";
            OkBtn.Text = "OK";
            NaslovLbl.Text = "Dodavanje novog ročišta";
            rocisteGB.Visible = true;
            UplataGB.Visible = false;
        }

        private void NovaRB_CheckedChanged(object sender, EventArgs e)
        {
            OkBtn.Visible = true;
            funkcija = "nova";
            PostUplGB.Visible = false;
            NovaUplataGB.Visible = true;
            OkBtn.Text = "Dodaj uplatu";
        }

        private void PostojecaRB_CheckedChanged(object sender, EventArgs e)
        {
            OkBtn.Visible = true;
            funkcija = "postojeca";
            PostUplGB.Visible = true;
            UplataDGV.Visible = false;
            NovaUplataGB.Visible = false;
            OkBtn.Text = "Uplati";
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            PredmetRepository predmetRepository = new PredmetRepository(databaseContext);
            PredmetRocisteRepository predmetRocisteRepository = new PredmetRocisteRepository(databaseContext);
            RocisteRepository rocisteRepository = new RocisteRepository(databaseContext);
            UplataRepository uplataRepository = new UplataRepository(databaseContext);

            switch (funkcija)
            {
                case "nova":
                    {
                        PredmetModel predmet = predmetRepository.Find(UplataBrPredmetaTxt.Text);
                        if (predmet == null)
                            MessageBox.Show("Ne postoji trazeni predmet");
                        else
                        {
                            uplataRepository.Add(predmet.Id, new UplataModel
                            {
                                Iznos = Double.Parse(iznosTxt.Text),
                                Uplatilac=PlatilacTxt.Text,
                                Placeno=placenoCB.Checked
                            });
                        }

                        }
                        break;
                case "postojeca":
                    {
                        PredmetModel predmet = predmetRepository.Find(PostUplBrPrTxt.Text);
                        try { 
                            uplataRepository.Update(predmet.Id, UplataDGV.SelectedRows[0].Cells["Id"].Value.ToString(), (bool)UplataDGV.SelectedRows[0].Cells["Placeno"].Value);
                            MessageBox.Show("Uspesna uplata");

                        }
                        catch (Exception )
                        {
                            MessageBox.Show("Morate selektovati ceo red");
                        }
                      
                    }
                        break;
                case "rociste":
                    {                   
                        PredmetModel predmet = predmetRepository.Find(BrPredmetaTxt.Text);
                        if (predmet == null)
                            MessageBox.Show("Ne postoji trazeni predmet");
                        else
                        {
                            predmetRocisteRepository.Add(predmet.Id, new PredmetRocisteModel
                            {
                                Datum = dateTimePicker1.Value.Date.ToString(),
                                Pozvan = true
                            });
                            rocisteRepository.Add(new RocisteModel
                            {
                                Datum = dateTimePicker1.Value.Date.ToString(),
                                PredmetId = predmet.Id
                            });
                        }
                    }
                        break;
                default:
                    break;
            }
            
            Clear(this.rocisteGB);
            Clear(this.UplataGB);
            Clear(this.NovaUplataGB);
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

        private void PrikaziUplBtn_Click(object sender, EventArgs e)
        {
            UplataDGV.Visible = true;

            PredmetRepository predmetRepository = new PredmetRepository(databaseContext);
            UplataRepository uplataRepository = new UplataRepository(databaseContext);

            PredmetModel predmet = predmetRepository.Find(PostUplBrPrTxt.Text);
            if (predmet == null)
                MessageBox.Show("Ne postoji trazeni predmet");
            else
            {
                List<UplataModel> list = new List<UplataModel>();
                BindingList<UplataModel> bindingList;
                list=uplataRepository.GetAll(predmet.Id);
                bindingList = new BindingList<UplataModel>(list);
                UplataDGV.DataSource = bindingList;
                this.UplataDGV.Columns["Id"].Visible = false;
            }

        }

        private void iznosTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
