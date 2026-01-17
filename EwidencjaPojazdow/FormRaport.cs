using Microsoft.Reporting.WinForms;
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
    public partial class FormRaport : Form
    {
        private List<Pojazd> listaPojazdow;
        public FormRaport(List<Pojazd> pojazdy)
        {
            InitializeComponent();
            listaPojazdow = pojazdy;
        }

        private void FormRaport_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.ReportEmbeddedResource =
                "EwidencjaPojazdow.RaportPojazdow.rdlc";
            var pojazdyDoRaportu = listaPojazdow
            .Where(p => p.DataPrzegladu.Month == DateTime.Now.Month)
            .ToList();

            ReportDataSource rds = new ReportDataSource(
            "DataSet1",
            pojazdyDoRaportu);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
       

    }
}
