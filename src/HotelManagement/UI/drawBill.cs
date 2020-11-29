using System;
using System.Drawing;

namespace HotelManagement.UI
{
    class DrawBill
    {
        Brush brush = Brushes.Black;
        Font font60 = new Font("Calibri", 60, FontStyle.Bold);
        Font font30 = new Font("Calibri", 30, FontStyle.Bold);
        Font font20 = new Font("Calibri", 20, FontStyle.Regular);
        Font font15 = new Font("Calibri", 15, FontStyle.Regular);
        int posY = 0;
        Graphics g;

        public DrawBill(Graphics g)
        {
            this.g = g;
        }

        public void drawBillHeader()
        {
            g.DrawString("HDH HOTEL",font60 , brush, new Point(225, 0));
            g.DrawString("HÓA ĐƠN THANH TOÁN DỊCH VỤ",font30 , brush, new Point(145, 100));
            g.DrawString("Ngày: "+ DateTime.Now.ToShortDateString(), font20, brush, new Point(10, 180));
            g.DrawString("--------------------------------------------------------------------------------------------------", font20, brush, new Point(0, 220));
        }

        public void drawCustomerInfo(string customerName, int roomID, string phoneNum, string address, string dateCheckIn, string dateCheckOut)
        {
            g.DrawString("Tên khách hàng:  " + customerName, font20, brush, new Point(10, 250));
            g.DrawString("Số phòng: " + roomID.ToString(), font20, brush, new Point(600, 250));
            g.DrawString("Số điện thoại:      " + phoneNum, font20, brush, new Point(10, 280));
            g.DrawString("Địa chỉ:                 " + address, font20, brush, new Point(10, 310));
            g.DrawString("Ngày đến:             " + dateCheckIn, font20, brush, new Point(10, 340));
            g.DrawString("Ngày đi:                " + dateCheckOut, font20, brush, new Point(10, 370));
            g.DrawString("--------------------------------------------------------------------------------------------------", font20, brush, new Point(0, 400));
            g.DrawString("Tên dịch vụ", font15, brush, new Point(10, 425));
            g.DrawString("Số lượng", font15, brush, new Point(350, 425));
            g.DrawString("Đơn giá", font15, brush, new Point(500, 425));
            g.DrawString("Thành tiền", font15, brush, new Point(730, 425));
            g.DrawString("--------------------------------------------------------------------------------------------------", font20, brush, new Point(0, 440));
            posY = 470;
        }

        public void drawItem(string itemName, int quanity, int price)
        {
            g.DrawString(itemName, font15, brush, new Point(10, posY));
            g.DrawString(quanity.ToString(), font15, brush, new Point(350, posY));
            g.DrawString(price.ToString(), font15, brush, new Point(500, posY));
            g.DrawString((quanity * price).ToString(), font15, brush, new Point(820- (quanity * price).ToString().Length*11, posY));
            posY += 30;
        }

        public void drawEndOfBill(string staffName, int total, int discount)
        {
            g.DrawString("--------------------------------------------------------------------------------------------------", font20, brush, new Point(0, posY-10));
            posY += 30;
            g.DrawString("Tên nhân viên: " + staffName, font20, brush, new Point(10, posY));
            posY += 5;
            g.DrawString("Tổng tiền:         " + total.ToString() + " VNĐ", font15, brush, new Point(500, posY));
            posY += 20;
            g.DrawString("Giảm giá:          " + discount.ToString() + " %", font15, brush, new Point(500, posY));
            posY += 20;
            g.DrawString("Tổng tiền trả:   " + (total - total * ((float)discount / 100)).ToString() + " VNĐ", font15, brush, new Point(500, posY));
        }
    }
}
