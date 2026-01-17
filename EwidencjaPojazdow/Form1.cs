using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EwidencjaPojazdow
{
    public partial class Form1 : Form
    {
        private List<Pojazd> listaPojazdow = new List<Pojazd>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Pojazd p = new Pojazd
            {
                NrRejestracyjny = txtRejestracja.Text,
                Marka = txtMarka.Text,
                Model = txtModel.Text,
                RokProdukcji = (int)numRok.Value,
                DataPrzegladu = dtPrzeglad.Value,
                Wlasciciel = txtWlasciciel.Text
            };

            listaPojazdow.Add(p);

            dgvPojazdy.Rows.Add(
                p.NrRejestracyjny,
                p.Marka,
                p.Model,
                p.RokProdukcji,
                p.DataPrzegladu.ToShortDateString(),
                p.Wlasciciel
            );

            txtRejestracja.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtWlasciciel.Clear();
        }

       

        private void btnRaport_Click(object sender, EventArgs e)
        {

            
            FormRaport fr = new FormRaport(listaPojazdow);
            fr.ShowDialog();
        }
    }
}
