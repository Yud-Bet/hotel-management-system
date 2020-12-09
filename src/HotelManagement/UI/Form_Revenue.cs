using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Globalization;

namespace HotelManagement.UI
{
    public partial class Form_Revenue : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        List<string> listDate = new List<string>();
        List<double> listRoomRevenue = new List<double>();
        List<double> listEatServiceRevenue = new List<double>();
        List<double> listLaudryServiceRevenue = new List<double>();
        //ChartValues<double> listRevenue = new ChartValues<double>();
        
        public Form_Revenue()
        {
            InitializeComponent();
            getListDate(RevenueType.DateRevenue);
            

            cbTypeOfRevenue.SelectedIndex = 0;

            

        }

        #region barChart
        private void createBarChart(List<string> listLable, ChartValues<Double> listRevenue, RevenueType type)
        {
            barChart.AxisX.Clear();
            barChart.AxisY.Clear();
            barChart.Visible = true;
            if (listRevenue.Count() > 31)
            {
                barChart.Width += (listRevenue.Count() - 31) * 20;
                barChart.Height -= 21;
            } else
            {
                barChart.Size = new Size(661, 530);
            }

            addValuesAxisY(listRevenue);
            switch (type)
            {
                case RevenueType.DateRevenue:
                    createAxisX(listLable, "Ngày");
                    break;
                case RevenueType.MonthRevenue:
                    createAxisX(listLable, "Tháng");
                    break;
                case RevenueType.QuarterRevenue:
                    createAxisX(listLable, "Quý");
                    break;
                case RevenueType.YearRevenue:
                    createAxisX(listLable, "Năm");
                    break;
            }

            barChart.AxisY.Add(new Axis
            {
                Title = "Doanh thu",
                LabelFormatter = value => value.ToString("C", cul.NumberFormat)
            });
        }

        private void addValuesAxisY(ChartValues<Double> listRevenue)
        {
            barChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Doanh thu",
                    Values = new ChartValues<double>(),
                }
            };
            barChart.Series[0].Values = listRevenue;
        }

        private void createAxisX(List<string> listLable, string type)
        {
            barChart.AxisX.Add(new Axis
            {
                Title = type,
                Labels = listLable,
                LabelsRotation = 30,
                Separator = new Separator
                {
                    Step = 1
                }
            });
        }

        private void barChart_DataClick(object sender, ChartPoint chartPoint)
        {
            lbDate.Text = listDate[(int)chartPoint.X];
            createPieChart(listRoomRevenue[(int)chartPoint.X], listEatServiceRevenue[(int)chartPoint.X], listLaudryServiceRevenue[(int)chartPoint.X]);
            lbRevenueValue.Text = chartPoint.Y.ToString("C", cul.NumberFormat);
        }
        #endregion

        #region date
        private void getListDate(RevenueType revenueType)
        {
            DateTime start = dtStart.Value, end = dtEnd.Value;
            listDate.Clear();
            //MessageBox.Show(DateTime.Compare(start.Date.AddDays(0),end.Date).ToString());
            switch (revenueType)
            {
                case RevenueType.DateRevenue:
                    while (DateTime.Compare(start.Date, end.Date) != 1)
                    {
                        listDate.Add(start.ToShortDateString());
                        start = start.Date.AddDays(1);
                    }
                    break;
                case RevenueType.MonthRevenue:
                    while (DateTime.Compare(start.Date, end.Date) != 1)
                    {
                        listDate.Add(start.Month.ToString() + "/" + start.Year.ToString());
                        start = start.Date.AddMonths(1);
                    }
                    break;
                case RevenueType.QuarterRevenue:
                    while (DateTime.Compare(start.Date, end.Date) != 1)
                    {
                        listDate.Add(Math.Ceiling((float)start.Month / 3).ToString() + " . " + start.Year.ToString());
                        start = start.Date.AddMonths(3);
                    }
                    if (listDate[listDate.Count - 1] != Math.Ceiling((float)end.Month / 3).ToString() + " . " + end.Year.ToString())
                    {
                        listDate.Add(Math.Ceiling((float)end.Month / 3).ToString() + " . " + end.Year.ToString());
                    }
                    break;
                case RevenueType.YearRevenue:
                    while (DateTime.Compare(start.Date, end.Date) != 1)
                    {
                        listDate.Add(start.Year.ToString());
                        start = start.Date.AddYears(1);
                    }
                    break;
            }
        }
        #endregion

        #region pieChart
        private void createPieChart(double room, double eatService, double laundryService)
        {
            pieChart.Visible = true;
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format(cul.NumberFormat, "{0:C} ", chartPoint.Y, chartPoint.Participation);

            pieChart.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Phòng",
                    Values = new ChartValues<double> {room},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Ăn uống",
                    Values = new ChartValues<double> {eatService},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Giặt ủi",
                    Values = new ChartValues<double> {laundryService},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
            };

            pieChart.LegendLocation = LegendLocation.Bottom;
        }
        #endregion

        private void cbTypeOfRevenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            double sum = 0;
            ChartValues<double> listRevenue = new ChartValues<double>();
            getListDate((RevenueType)(cbTypeOfRevenue.SelectedIndex + 1));

            listRoomRevenue.Clear();
            listEatServiceRevenue.Clear();
            listLaudryServiceRevenue.Clear();

            Random rd = new Random();
            int n = listDate.Count();
            if (n > 0)
            {
                for(int i=0; i < n; i++)
                {
                    listRoomRevenue.Add(rd.Next(3000000, 9000000));
                    listEatServiceRevenue.Add(rd.Next(3000000, 9000000));
                    listLaudryServiceRevenue.Add(rd.Next(3000000, 9000000));

                    listRevenue.Add(listRoomRevenue[i] + listEatServiceRevenue[i] + listLaudryServiceRevenue[i]);
                    sum += listRevenue[i];
                }
            }
            createBarChart(listDate, listRevenue, RevenueType.DateRevenue);
            createPieChart(listRoomRevenue[0], listEatServiceRevenue[0], listLaudryServiceRevenue[0]);
            
            lbDate.Text = listDate[0];
            lbRevenueValue.Text = listRevenue[0].ToString("C", cul.NumberFormat);
            lbTotalRevenue.Text = sum.ToString("C", cul.NumberFormat);
        }

        private void btExportExcel_Click(object sender, EventArgs e)
        {
            if (listDate.Count > 0)
            {
                (new exportExcel()).exportRevenue("Lê Trung Hiếu", (RevenueType)(cbTypeOfRevenue.SelectedIndex + 1), listDate, listRoomRevenue,
                    listEatServiceRevenue, listLaudryServiceRevenue);
            }
        }
    }
}
