using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public class exportExcel
    {

        public void exportRevenue(string staffName, RevenueType revenueType, List<string> listDate,List<double> listRoomRevenue, List<double> listEatServiceRevenue, List<double> listLaudryServiceRevenue)
        {
            Excel._Application xlApp = new Excel.Application();
            Excel._Workbook workbook = xlApp.Workbooks.Add(System.Reflection.Missing.Value);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;

            worksheet.Columns.ColumnWidth = 20;
            worksheet.Columns.RowHeight = 17;
            worksheet.Cells.Font.Name = "Segoe UI";
            worksheet.Cells.Font.Size = 13;

            addText(worksheet, "A1", "E1", "HDH HOTEL", 25, 24);

            string type1 = "", type2 = "";
            switch (revenueType)
            {
                case RevenueType.DateRevenue:
                    type1 = "NGÀY";
                    type2 = "Ngày";
                    break;
                case RevenueType.MonthRevenue:
                    type1 = "THÁNG";
                    type2 = "Tháng";
                    break;
                case RevenueType.QuarterRevenue:
                    type1 = "QUÝ";
                    type2 = "Quý";
                    break;
                case RevenueType.YearRevenue:
                    type1 = "NĂM";
                    type2 = "Năm";
                    break;
            }
            addText(worksheet, "A2", "E2", "BÁO CÁO DOANH THU THEO " + type1, 20, 16);
            addText(worksheet, "A8", "A8", type2, 13, Color.FromArgb(27, 152, 224), Color.White);

            if (listDate.Count == 1)
            {
                addText(worksheet, "A3", "E3", type2 + " " + listDate[0], 20, 16);
            } 
            else
            {
                addText(worksheet, "A3", "E3", type2 + " " + listDate[0] + " - " + type2 + " " + listDate[listDate.Count - 1], 20, 16);
            }

            addText(worksheet, "A5", "B5", "Người Lập Báo Cáo", 13, Color.FromArgb(27, 152, 224), Color.White);
            addText(worksheet, "A6", "B6", staffName, 17, 13);

            addText(worksheet, "E5", "E5", "Ngày lập", 13, Color.FromArgb(27, 152, 224), Color.White);
            addText(worksheet, "E6", "E6", DateTime.Now.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")), 17, 13);

            addText(worksheet, "B8", "B8", "Doanh thu phòng", 13, Color.FromArgb(27, 152, 224), Color.White);
            addText(worksheet, "C8", "C8", "Doanh thu ăn uống", 13, Color.FromArgb(27, 152, 224), Color.White);
            addText(worksheet, "D8", "D8", "Doanh thu giặt ủi", 13, Color.FromArgb(27, 152, 224), Color.White);
            addText(worksheet, "E8", "E8", "Tổng", 13, Color.FromArgb(27, 152, 224), Color.White);

            int n = listDate.Count();
            double totalRevenue = 0;

            for(int i=0; i < n; i++)
            {
                worksheet.Range["B" + (9 + i).ToString(), "E" + (9 + i).ToString()].NumberFormat = "#,###";

                double totalItemRevenue = listRoomRevenue[i] + listEatServiceRevenue[i] + listLaudryServiceRevenue[i];
                totalRevenue += totalItemRevenue;

                //addText(worksheet, "A" + (9 + i).ToString(), "A" + (9 + i).ToString(), listDate[i], 17, 13);
                //worksheet.Cells[9 + i, 1]
                worksheet.Cells[9 + i, 1] = listDate[i];
                worksheet.Cells[9 + i, 2] = listRoomRevenue[i];
                worksheet.Cells[9 + i, 3] = listEatServiceRevenue[i];
                worksheet.Cells[9 + i, 4] = listLaudryServiceRevenue[i];
                worksheet.Cells[9 + i, 5] = totalItemRevenue;
            }

            int endIdx = 8 + listDate.Count + 2;
            addText(worksheet, "D" + endIdx.ToString(), "D" + endIdx.ToString(), "Tổng Doanh Thu", 13, Color.FromArgb(27, 152, 224), Color.White);
            worksheet.Range["E" + endIdx.ToString(), "E" + endIdx.ToString()].NumberFormat = "#,###";
            worksheet.Cells[endIdx, 5] = totalRevenue;

            showFile(xlApp, workbook);
        }

        private void addText(Excel._Worksheet worksheet, string startRange, string endRange, string text, int rowHeigth, int fontSize)
        {
            Excel.Range fmRange;

            fmRange = worksheet.Range[startRange, endRange];
            fmRange.Merge();
            fmRange.Value = text;
            fmRange.Columns.RowHeight = rowHeigth;
            fmRange.Font.Size = fontSize;
            fmRange.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            fmRange.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
        }

        private void addText(Excel._Worksheet worksheet, string startRange, string endRange, string text, int fontSize, Color backColor, Color forceColor)
        {
            Excel.Range fmRange;

            fmRange = worksheet.Range[startRange, endRange];
            fmRange.Merge();
            fmRange.Value = text;
            fmRange.Font.Size = fontSize;
            fmRange.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            fmRange.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fmRange.Font.Color = forceColor;
            fmRange.Interior.Color = backColor;
        }

        private void showFile(Excel._Application xlApp, Excel._Workbook workbook)
        {
            if (MessageBox.Show("Bạn có muốn xem file trước không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                xlApp.WindowState = Excel.XlWindowState.xlMinimized;
                xlApp.WindowState = Excel.XlWindowState.xlMaximized;
                xlApp.Visible = true;
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "output";
                saveFileDialog.DefaultExt = ".xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                workbook.Close(0, null, null);
                xlApp.Quit();
            }
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
        }
    }
}
