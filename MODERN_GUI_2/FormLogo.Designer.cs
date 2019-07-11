namespace MODERN_GUI_2
{
    partial class FormLogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFacturas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNCR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRetencion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGuia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRetencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGuia)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFacturas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFacturas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFacturas.Legends.Add(legend1);
            this.chartFacturas.Location = new System.Drawing.Point(12, 12);
            this.chartFacturas.Name = "chartFacturas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFacturas.Series.Add(series1);
            this.chartFacturas.Size = new System.Drawing.Size(423, 300);
            this.chartFacturas.TabIndex = 0;
            this.chartFacturas.Text = "Facturas Autorizadas";
            // 
            // chartNCR
            // 
            chartArea2.Name = "ChartArea1";
            this.chartNCR.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartNCR.Legends.Add(legend2);
            this.chartNCR.Location = new System.Drawing.Point(599, 12);
            this.chartNCR.Name = "chartNCR";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartNCR.Series.Add(series2);
            this.chartNCR.Size = new System.Drawing.Size(423, 300);
            this.chartNCR.TabIndex = 1;
            this.chartNCR.Text = "Notas de Credito Autorizadas";
            // 
            // chartRetencion
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRetencion.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRetencion.Legends.Add(legend3);
            this.chartRetencion.Location = new System.Drawing.Point(12, 330);
            this.chartRetencion.Name = "chartRetencion";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRetencion.Series.Add(series3);
            this.chartRetencion.Size = new System.Drawing.Size(423, 300);
            this.chartRetencion.TabIndex = 2;
            this.chartRetencion.Text = "Retenciones Autorizadas";
            // 
            // chartGuia
            // 
            chartArea4.Name = "ChartArea1";
            this.chartGuia.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartGuia.Legends.Add(legend4);
            this.chartGuia.Location = new System.Drawing.Point(599, 330);
            this.chartGuia.Name = "chartGuia";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartGuia.Series.Add(series4);
            this.chartGuia.Size = new System.Drawing.Size(423, 300);
            this.chartGuia.TabIndex = 3;
            this.chartGuia.Text = "Guias de Remision Autorizadas";
            // 
            // FormLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1034, 646);
            this.Controls.Add(this.chartGuia);
            this.Controls.Add(this.chartRetencion);
            this.Controls.Add(this.chartNCR);
            this.Controls.Add(this.chartFacturas);
            this.Name = "FormLogo";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.FormLogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRetencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGuia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFacturas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNCR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRetencion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGuia;
    }
}