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
        private int _codeEmpresa;
        public FormLogo(int code)
        {
            InitializeComponent();
            _codeEmpresa = code;
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
                    chartFacturas.DataSource = db.APFACTURACAB.Where(x => x.ESTADOPROCESO == "P" && x.EMPRESA == _codeEmpresa).ToList();
                    chartFacturas.Series["Series1"].XValueMember = "NUMERO";
                    chartFacturas.Series["Series1"].YValueMembers = "RUC";
                    // Set the chart title
                    this.chartFacturas.Titles.Add("FACTURAS AUTORIZADAS");
                    // Set chart type like Bar chart, Pie chart 
                    chartFacturas.Series["Series1"].ChartType = SeriesChartType.Pie;
                    // To show chart value           
                    chartFacturas.Series["Series1"].IsValueShownAsLabel = true;

                    chartGuia.DataSource = db.APGUIACAB.Where(x => x.ESTADOPROCESO == "P" && x.EMPRESA == _codeEmpresa).ToList();
                    chartGuia.Series["Series1"].XValueMember = "NUMERO";
                    chartGuia.Series["Series1"].YValueMembers = "RUCCLI";
                    // Set the chart title
                    this.chartGuia.Titles.Add("GUIAS DE REMISION AUTORIZADAS");
                    // Set chart type like Bar chart, Pie chart 
                    chartGuia.Series["Series1"].ChartType = SeriesChartType.Pie;
                    // To show chart value           
                    chartGuia.Series["Series1"].IsValueShownAsLabel = true;

                    chartRetencion.DataSource = db.APRETENCION.Where(x => x.ESTADOPROCESO == "P" && x.EMPRESA == _codeEmpresa).ToList();
                    chartRetencion.Series["Series1"].XValueMember = "NUMERORET";
                    chartRetencion.Series["Series1"].YValueMembers = "RUCRET";
                    // Set the chart title
                    this.chartRetencion.Titles.Add("RETENCIONES DE PROVEEDORES AUTORIZADAS");
                    // Set chart type like Bar chart, Pie chart 
                    chartRetencion.Series["Series1"].ChartType = SeriesChartType.Pyramid;
                    // To show chart value           
                    chartRetencion.Series["Series1"].IsValueShownAsLabel = true;

                    chartNCR.DataSource = db.APNCRCAB.Where(x => x.ESTADOPROCESO == "P" && x.EMPRESA == _codeEmpresa).ToList();
                    chartNCR.Series["Series1"].XValueMember = "NUMERO";
                    chartNCR.Series["Series1"].YValueMembers = "RUC";
                    // Set the chart title
                    this.chartNCR.Titles.Add("NOTAS DE CREDITOS AUTORIZADAS");
                    // Set chart type like Bar chart, Pie chart 
                    chartNCR.Series["Series1"].ChartType = SeriesChartType.Pyramid;
                    // To show chart value           
                    chartNCR.Series["Series1"].IsValueShownAsLabel = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sistema Apolo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
