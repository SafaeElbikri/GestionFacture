using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture
{
    public partial class Print_Facture : Form
    {
        public Print_Facture()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();
            Form1 LBE = new Form1();
            DataSet dscompt = new DataSet();

            dscompt = LBE.returndata();

            rpt.SetDataSource(dscompt.Tables["FactureCompt"]);
            this.crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();

        }
    }
}
