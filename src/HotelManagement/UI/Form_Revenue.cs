using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Globalization;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace HotelManagement.UI
{
    public partial class Form_Revenue : UserControl
    {
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        List<string> listDate = new List<string>();
        List<double> listRoomRevenue = new List<double>();
        List<double> listEatServiceRevenue = new List<double>();
        List<double> listLaudryServiceRevenue = new List<double>();
        bool isUseBarChart = true;
        Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format(CultureInfo.GetCultureInfo("vi-VN").NumberFormat, "{0:C} ", chartPoint.Y, chartPoint.Participation);
        string Username;
        Form ParentRef;
        CancellationTokenSource cts;

        enum ChartType
        {
            barChart = 1,
            lineChart = 2
        }

        public Form_Revenue(string Username, Form ParentRef)
        {
            InitializeComponent();
            getListDate(RevenueType.DateRevenue);
            btBarChart.Hide();
            this.Username = Username;
            this.ParentRef = ParentRef;
            cts = new CancellationTokenSource();
            cbTypeOfRevenue.SelectedIndex = 0;

            this.Disposed += delegate { _dispose(); GC.Collect(); };
        }

        #region revenueChart
        private void createRevenueChart(List<string> listLable, ChartValues<Double> listRevenue, RevenueType revenueType, ChartType chartType)
        {
            revenueChart.AxisX.Clear();
            revenueChart.AxisY.Clear();
            revenueChart.Visible = true;
            if (listRevenue.Count() > 31)
            {
                revenueChart.Width += (listRevenue.Count() - 31) * 20;
                revenueChart.Height -= 21;
            } else
            {
                revenueChart.Size = new Size(661, 530);
            }

            switch (chartType)
            {
                case ChartType.barChart:
                    addValuesAxisYColumn(listRevenue);
                    break;
                case ChartType.lineChart:
                    addValuesAxisYLine(listRevenue);
                    break;
            }
            
            switch (revenueType)
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

            revenueChart.AxisY.Add(new Axis
            {
                Title = "Doanh thu",
                LabelFormatter = value => value.ToString("C", cul.NumberFormat)
            });
        }

        private void addValuesAxisYColumn(ChartValues<Double> listRevenue)
        {
            revenueChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Doanh thu",
                    Values = new ChartValues<double>(),
                }
            };
            revenueChart.Series[0].Values = listRevenue;
        }

        private void addValuesAxisYLine(ChartValues<Double> listRevenue)
        {
            revenueChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Doanh thu",
                    Values = new ChartValues<double>(),
                }
            };
            revenueChart.Series[0].Values = listRevenue;
        }

        private void createAxisX(List<string> listLable, string type)
        {
            revenueChart.AxisX.Add(new Axis
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
                    while (DateTime.Compare(start.Date, end.Date) < 1)
                    {
                        listDate.Add(start.ToShortDateString());
                        start = start.Date.AddDays(1);
                    }
                    break;
                case RevenueType.MonthRevenue:
                    while (DateTime.Compare(start.Date, end.Date) < 1)
                    {
                        listDate.Add(start.Month.ToString() + "/" + start.Year.ToString());
                        start = start.Date.AddMonths(1);
                        start = start.Date.AddDays(-start.Day + 1);
                    }
                    break;
                case RevenueType.QuarterRevenue:
                    while (DateTime.Compare(start.Date, end.Date) < 1)
                    {
                        listDate.Add(Math.Ceiling((float)start.Month / 3).ToString() + " . " + start.Year.ToString());
                        start = start.Date.AddMonths(3);
                        start = start.Date.AddDays(-start.Day + 1);
                    }
                    if (listDate[listDate.Count - 1] != Math.Ceiling((float)end.Month / 3).ToString() + " . " + end.Year.ToString())
                    {
                        listDate.Add(Math.Ceiling((float)end.Month / 3).ToString() + " . " + end.Year.ToString());
                    }
                    break;
                case RevenueType.YearRevenue:
                    while (DateTime.Compare(start.Date, end.Date) < 1)
                    {
                        listDate.Add(start.Year.ToString());
                        start = start.Date.AddYears(1);
                        start = start.Date.AddDays(-start.Day + 1);
                        start = start.Date.AddMonths(-start.Month + 1);

                    }
                    break;
            }
        }
        #endregion

        #region pieChart
        private void createPieChart(double room, double eatService, double laundryService)
        {
            pieChart.Visible = true;

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
            loadChartData(isUseBarChart ? ChartType.barChart : ChartType.lineChart);
        }
        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtStart.Value > dtEnd.Value)
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu nhỏ hơn ngày kết thúc!", "Lỗi!");
                return;
            }
            loadChartData(isUseBarChart ? ChartType.barChart : ChartType.lineChart);

        }

        private async void btExportExcel_Click(object sender, EventArgs e)
        {
            if (listDate.Count > 0)
            {
                OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                overlay.Show();
                exportExcel exporter = new exportExcel();
                await exporter.exportRevenue(Username, (RevenueType)(cbTypeOfRevenue.SelectedIndex + 1),
                    listDate, listRoomRevenue, listEatServiceRevenue, listLaudryServiceRevenue);

                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
                ParentRef.Focus();
            }
        }

        private void loadChartData(ChartType chartType)
        {
            try
            {
                OverlayForm overlay = new OverlayForm(ParentRef, new LoadingForm(cts.Token));
                overlay.Show();

                double sum = 0;
                ChartValues<double> listRevenue = new ChartValues<double>();
                getListDate((RevenueType)(cbTypeOfRevenue.SelectedIndex + 1));
                int revenueType = cbTypeOfRevenue.SelectedIndex + 1;
                DataTable dataRoomRevenue = DataAccess.Report.GetRoomRevenue(revenueType, dtStart.Value, dtEnd.Value);
                int indexDataRoom = 0;
                DataTable dataEatServiceRevenue = DataAccess.Report.GetEatServiceRevenue(revenueType, dtStart.Value, dtEnd.Value);
                int indexDataEat = 0;
                DataTable dataLaudryServiceRevenue = DataAccess.Report.GetLaudryServiceRevenue(revenueType, dtStart.Value, dtEnd.Value);
                int indexDataLaudry = 0;
                listRoomRevenue.Clear();
                listEatServiceRevenue.Clear();
                listLaudryServiceRevenue.Clear();

                int n = listDate.Count();
                if (n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (indexDataRoom < dataRoomRevenue.Rows.Count &&
                            Convert.ToInt32(dataRoomRevenue.Rows[indexDataRoom].ItemArray[0]) == i)
                        {
                            listRoomRevenue.Add(Convert.ToInt32(dataRoomRevenue.Rows[indexDataRoom].ItemArray[1]));
                            indexDataRoom++;
                        }
                        else
                            listRoomRevenue.Add(0);
                        if (indexDataEat < dataEatServiceRevenue.Rows.Count &&
                            Convert.ToInt32(dataEatServiceRevenue.Rows[indexDataEat].ItemArray[0]) == i)
                        {
                            listEatServiceRevenue.Add(Convert.ToInt32(dataEatServiceRevenue.Rows[indexDataEat].ItemArray[1]));
                            indexDataEat++;
                        }
                        else
                            listEatServiceRevenue.Add(0);
                        if (indexDataLaudry < dataLaudryServiceRevenue.Rows.Count &&
                            Convert.ToInt32(dataLaudryServiceRevenue.Rows[indexDataLaudry].ItemArray[0]) == i)
                        {
                            listLaudryServiceRevenue.Add(Convert.ToInt32(dataLaudryServiceRevenue.Rows[indexDataLaudry].ItemArray[1]));
                            indexDataLaudry++;
                        }
                        else
                            listLaudryServiceRevenue.Add(0);

                        listRevenue.Add(listRoomRevenue[i] + listEatServiceRevenue[i] + listLaudryServiceRevenue[i]);
                        sum += listRevenue[i];
                    }
                }
                createRevenueChart(listDate, listRevenue, RevenueType.DateRevenue, chartType);
                createPieChart(listRoomRevenue[0], listEatServiceRevenue[0], listLaudryServiceRevenue[0]);

                lbDate.Text = listDate[0];
                lbRevenueValue.Text = listRevenue[0].ToString("C", cul.NumberFormat);
                lbTotalRevenue.Text = sum.ToString("C", cul.NumberFormat);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Lỗi khi kết nối đến server!", "Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
                ParentRef.Focus();
            }
        }

        private void btLineChart_Click(object sender, EventArgs e)
        {
            btBarChart.Show();
            btLineChart.Hide();

            isUseBarChart = false;

            loadChartData(ChartType.lineChart);
        }

        private void btBarChart_Click(object sender, EventArgs e)
        {
            btBarChart.Hide();
            btLineChart.Show();

            isUseBarChart = true;

            loadChartData(ChartType.barChart);
        }

        private void _dispose()
        {
            revenueChart.AxisX.Clear();
            revenueChart.AxisY.Clear();
            revenueChart.Series[0].Erase(true);
            pieChart.Series.Clear();
            labelPoint = null;
            
        }
    }
}
