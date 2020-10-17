using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_AddEditRoom : MetroFramework.Forms.MetroForm
    {
        public Form_AddEditRoom()
        {
            InitializeComponent();
            //get roomcount properties
            float[] sizeRoomCount = { lbRoomCount.Top , lbRoomCount.Font.Size, tbRoomCount.Font.Size, tbRoomCount.Top,
                                        tbRoomCount.Left, tbRoomCount.Height, tbRoomCount.Width};
            //get roomsize properties
            float[] sizeRoomSize = { lbRoomSize.Top , lbRoomSize.Font.Size, tbRoomsize.Font.Size, tbRoomsize.Top,
                                        tbRoomsize.Left, tbRoomsize.Height, tbRoomsize.Width};
            //get roomsize properties
            float[] sizeRoomPrice = { lbRoomPrice.Top , lbRoomPrice.Font.Size, tbRoomPrice.Font.Size, tbRoomPrice.Top,
                                        tbRoomPrice.Left, tbRoomPrice.Height, tbRoomPrice.Width};

            this.SizeChanged += (s, e) =>
             {
                 reSize(lbRoomCount, tbRoomCount, sizeRoomCount);
                 reSize(lbRoomSize, tbRoomsize, sizeRoomSize);
                 reSize(lbRoomPrice, tbRoomPrice, sizeRoomPrice);
             };

            void reSize(Label label, Zeroit.Framework.Metro.ZeroitMetroTextbox textBox, float[] size)
            {
                label.Top = (int)(size[0] * ((float)this.Height / 356));
                label.Font = new Font("Calibri", size[1] * ((float)this.Height / 356), FontStyle.Bold);
                textBox.Font = new Font("Calibri", size[2] * ((float)this.Height / 356), FontStyle.Bold);
                textBox.Top = (int)(size[3] * ((float)this.Height / 356));
                textBox.Left = (int)(size[4] * ((float)this.Width / 580));
                textBox.Height = (int)(size[5] * ((float)this.Height / 356));
                textBox.Width = (int)(size[6] * ((float)this.Width / 580));
            }

            //void reSize(Label label, FlowLayoutPanel flowLayoutPanel1, Panel panel, FlowLayoutPanel flowLayoutPanel2, float[] size)
            //{
            //    label.Top = (int)(size[0] * ((float)this.Height / 356));
            //    label.Font = new Font("Calibri", size[1] * ((float)this.Height / 356), FontStyle.Bold);

            //}
        }
    }
}
