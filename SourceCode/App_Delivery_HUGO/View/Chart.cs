using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using CartesianChart = LiveCharts.WinForms.CartesianChart;

namespace App_Delivery_HUGO
{
    public partial class Chart : UserControl
    {
        private CartesianChart chartBusiness;
        public Chart()
        {
            InitializeComponent();
            chartBusiness = new CartesianChart();
            Controls.Add(chartBusiness);
            chartBusiness.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(chartBusiness,0,1);
            tableLayoutPanel1.SetColumnSpan(chartBusiness,2);
            tableLayoutPanel1.SetRowSpan(chartBusiness,2);
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            configureChart();
        }

        public void configureChart()
        {
            //posicion y tamaño
            chartBusiness.Top = 10;
            chartBusiness.Left = 10;
            chartBusiness.Width = chartBusiness.Parent.Width - 10;
            chartBusiness.Height = chartBusiness.Parent.Height - 10;
            
            //configuracion de series ejes y leyendas
            chartBusiness.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Demanda de productos por Negocio", Values = new ChartValues<int>{},
                    DataLabels = true
                }
                
            };
            
            chartBusiness.AxisX.Add(new Axis{Labels = new List<string>()});
            chartBusiness.AxisX[0].Separator = new Separator(){Step = 1,IsEnabled = false};
            chartBusiness.AxisX[0].LabelsRotation = 15;
            chartBusiness.LegendLocation = LegendLocation.Top;
            
            //poblando el grafico
            foreach (var b in ChartDAO.getListChart())
            {
                chartBusiness.Series[0].Values.Add(b.TotalOrders);
                chartBusiness.AxisX[0].Labels.Add(b.Business);
            }
        }
    }
}