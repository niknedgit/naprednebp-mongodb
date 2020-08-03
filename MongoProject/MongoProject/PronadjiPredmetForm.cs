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

namespace MongoProject
{
    public partial class PronadjiPredmetForm : Form
    {
        DatabaseContext databaseContext;
        private string predmetId;
        private bool rociste;
        public PronadjiPredmetForm()
        {
            InitializeComponent();
        }
        public PronadjiPredmetForm(DatabaseContext databaseContext)
        {
            InitializeComponent();
            this.databaseContext = databaseContext;
            predmetId = null;
            rociste = false;

        }
        public void PrikaziSvePredmete(bool visible)
        {
            groupBox1.Visible = visible;
            RocistePogledPredmetBtn.Visible = false;
            if (visible)
            {
                PredmetRepository repository = new PredmetRepository(databaseContext);

                List<PredmetModel> list = new List<PredmetModel>();
                BindingList<PredmetModel> bindingList;
                list = repository.GetAll();
                bindingList = new BindingList<PredmetModel>(list);
                dataGridView1.DataSource = bindingList;
                this.dataGridView1.Columns["Id"].Visible = false;
                this.dataGridView1.Columns["Tuzilac"].Visible = false;
                this.dataGridView1.Columns["Tuzeni"].Visible = false;
                this.Size = new Size(650, 600);
            }
            else
            {
                this.Size = new Size(650, 150);
            }
        }
        public void PredstojecaRocista()
        {
            label1.Text = "Prikaz predstojećih ročišta ";
            RocisteRepository repository = new RocisteRepository(databaseContext);
            
            List<RocisteModel> list = new List<RocisteModel>();
            BindingList<RocisteModel> bindingList;
            list = repository.Get();
            bindingList = new BindingList<RocisteModel>(list);
            dataGridView1.DataSource = bindingList;
            this.dataGridView1.Columns["Id"].Visible = false;
            this.dataGridView1.Columns["PredmetId"].Visible = false;
            rociste = true;
            Buttons(false);
            label3.Visible = true;
            
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            if (PrikaziTuzenogBtn.Visible || rociste)
            {
                this.Hide();
                this.Close();
                Form1 forma = new Form1();
                forma.ShowDialog();
            }
            else
            {
                Buttons(true);
                if (predmetId == null && !rociste)
                    PrikaziSvePredmete(true);
                else               
                    PronadjiPredmet();
            }
        }

        private void PrikazTuzilacBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TuzilacRepository repository = new TuzilacRepository(databaseContext);
                List<TuzilacModel> list = new List<TuzilacModel>();
                BindingList<TuzilacModel> bindingList;
                list.Add(repository.Get(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                bindingList = new BindingList<TuzilacModel>(list);
                dataGridView1.DataSource = bindingList;
                this.dataGridView1.Columns["Id"].Visible = false;
                this.dataGridView1.Columns["Advokat"].Visible = false;
                Buttons(false);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati ceo red!");
            }
        } 

        private void PrikaziTuzenogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TuzeniRepository repository = new TuzeniRepository(databaseContext);
                List<TuzeniModel> list = new List<TuzeniModel>();
                BindingList<TuzeniModel> bindingList;
                list.Add(repository.Get(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                bindingList = new BindingList<TuzeniModel>(list);
                dataGridView1.DataSource = bindingList;
                this.dataGridView1.Columns["Id"].Visible = false;
                this.dataGridView1.Columns["Advokat"].Visible = false;
                Buttons(false);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati ceo red!");
            }
        }

        private void PrikazAdvTuziocaBtn_Click(object sender, EventArgs e)
        {
            try { 
                AdvokatRepository repository = new AdvokatRepository(databaseContext);
                List<AdvokatModel> list = new List<AdvokatModel>();
                BindingList<AdvokatModel> bindingList;
                list.Add(repository.VratiAdvokataTuzioca(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                bindingList = new BindingList<AdvokatModel>(list);
                dataGridView1.DataSource = bindingList;
                this.dataGridView1.Columns["Id"].Visible = false;
                Buttons(false);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati ceo red!");
            }
        }

        private void PrikazAdvTuzenogBtn_Click(object sender, EventArgs e)
        {
            try { 
                AdvokatRepository repository = new AdvokatRepository(databaseContext);
                List<AdvokatModel> list = new List<AdvokatModel>();
                BindingList<AdvokatModel> bindingList;
                list.Add(repository.VratiAdvokataTuzenog(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                bindingList = new BindingList<AdvokatModel>(list);
                dataGridView1.DataSource = bindingList;
                this.dataGridView1.Columns["Id"].Visible = false;
                Buttons(false);
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati ceo red!");
            }
        }
        private void Buttons(bool enable)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Button))
                    c.Visible = enable;
            }
            Nazad.Visible = true;
            label3.Visible = enable;
            RocistePogledPredmetBtn.Visible = rociste;
        }

        private void RocistePogledPredmetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                predmetId = dataGridView1.SelectedRows[0].Cells["PredmetId"].Value.ToString();            
                label3.Visible = false;
                RocistePogledPredmetBtn.Visible = false;
                PronadjiPredmet();
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati ceo red!");
            }
        }
      
        private void PronadjiPredmetBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(650, 600);
            predmetId = brojPtxt.Text;
            PronadjiPredmet();
            Buttons(true);
            rociste = false;
        }
        private void PronadjiPredmet()
        {
            PredmetRepository repository = new PredmetRepository(databaseContext);
            List<PredmetModel> list = new List<PredmetModel>();
            BindingList<PredmetModel> bindingList;
            if(rociste)
                list.Add(repository.Get(predmetId));
            else
              list.Add(repository.Find(predmetId));
            bindingList = new BindingList<PredmetModel>(list);
            dataGridView1.DataSource = bindingList;
            this.dataGridView1.Columns["Id"].Visible = false;
            this.dataGridView1.Columns["Tuzilac"].Visible = false;
            this.dataGridView1.Columns["Tuzeni"].Visible = false;
        }
    }
}
