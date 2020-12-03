using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private VetBusiness vetBusiness;
        public Form1()
        {
            InitializeComponent();
            this.vetBusiness = new VetBusiness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Vet> vets = this.vetBusiness.GetAllVets();

            foreach (Vet v in vets)
            {
                listBoxVets.Items.Add(v);
            }

        }

       private void listBoxVets_SelectedIndexChanged(object sender, EventArgs e)
       {

        }

        private void buttonInsertVet_Click(object sender, EventArgs e)
        {
            Vet v= new Vet(0, textBoxName.Text, textBoxSpeciality.Text, Convert.ToInt32(textBoxYears.Text));

            this.vetBusiness.insertVet(v);

            listBoxVets.Items.Clear();

            List<Vet> vets = this.vetBusiness.GetAllVets();

            foreach (Vet x in vets)
            {
                listBoxVets.Items.Add(x);
            }
            textBoxName.Text = "";
            textBoxSpeciality.Text ="";
            textBoxYears.Text = "";

        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            List<Vet> vets = this.vetBusiness.getVetsWithHigherExp(Convert.ToInt32(textBoxYearsForComparation.Text));

            listBoxExp.Items.Clear();

            foreach(Vet v in vets)
            {
                listBoxExp.Items.Add(v);
            }
            textBoxYearsForComparation.Text = "";
        }
    }
}
