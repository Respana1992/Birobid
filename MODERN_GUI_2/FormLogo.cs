using MODERN_GUI_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MODERN_GUI_2
{
    public partial class FormLogo : Form
    {
        public FormLogo()
        {
            InitializeComponent();
        }

        private void FormLogo_Load(object sender, EventArgs e)
        {
            BindChart();
        }

        private void BindChart()
        {
            using (BDAPOLOFEEntities db = new BDAPOLOFEEntities())
            {
                try
                {
                    chartFacturas.DataSource = db.APFACTURACAB.Where(x => x.ESTADOPROCESO == "P").ToList();
                    chartFacturas.Series["Series1"].XValueMember = "NUMERO";
                    chartFacturas.Series["Series1"].YValueMembers = "RUC";
                    // Set the chart title
                    this.chartFacturas.Titles.Add("FACTURAS AUTORIZADAS");
                    // Set chart type like Bar chart, Pie chart 
                    chartFacturas.Series["Series1"].ChartType = SeriesChartType.Pie;
                    // To show chart value           
                    chartFacturas.Series["Series1"].IsValueShownAsLabel = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sistema Apolo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
