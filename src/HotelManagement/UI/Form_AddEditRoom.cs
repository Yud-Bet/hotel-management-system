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
        public XanderUI.XUIButton _btAdd
        {
            get { return btAddRoom; }
        }

        public XanderUI.XUIButton _btSave
        {
            get { return btSave; }
        }

        public Form_AddEditRoom()
        {
            InitializeComponent();
            //get roomcount properties
            float[] sizeRoomCount = { lbRoomCount.Top , lbRoomCount.Font.Size, tbRoomCount.Font.Size, tbRoomCount.Top,
                                        tbRoomCount.Left, tbRoomCount.Height, tbRoomCount.Width};
            //get roomsize properties
            float[] sizeRoomSize = { lbRoomSize.Top , lbRoomSize.Font.Size, tbRoomsize.Font.Size, tbRoomsize.Top,
                                        tbRoomsize.Left, tbRoomsize.Height, tbRoomsize.Width, lbM2.Top, lbM2.Left, lbM2.Font.Size};
            //get roomsize properties
            float[] sizeRoomPrice = { lbRoomPrice.Top , lbRoomPrice.Font.Size, tbRoomPrice.Font.Size, tbRoomPrice.Top,
                                        tbRoomPrice.Left, tbRoomPrice.Height, tbRoomPrice.Width, lbVND.Top, lbVND.Left, lbVND.Font.Size};
            //get roomtype properties
            float[] sizeRoomType = { lbRoomType.Top, lbRoomType.Font.Size, flowLayoutPanel2.Top, flowLayoutPanel2.Left,
                                        panel5.Top, panel5.Left, flowLayoutPanel3.Top, flowLayoutPanel3.Left };

            this.SizeChanged += (s, e) =>
             {
                 reSize(lbRoomCount, tbRoomCount, sizeRoomCount);
                 reSize(lbRoomSize, tbRoomsize, sizeRoomSize, lbM2);
                 reSize(lbRoomPrice, tbRoomPrice, sizeRoomPrice, lbVND);
                 reSize(lbRoomType, flowLayoutPanel2, panel5, flowLayoutPanel3, sizeRoomType);
             };
        }
        void reSize(Label label1, Zeroit.Framework.Metro.ZeroitMetroTextbox textBox, float[] size, Label label2 = null)
        {
            label1.Top = (int)(size[0] * ((float)this.Height / 356));
            label1.Font = new Font("Calibri", size[1] * ((float)this.Height / 356), FontStyle.Bold);
            textBox.Font = new Font("Calibri", size[2] * ((float)this.Height / 356), FontStyle.Bold);
            textBox.Top = (int)(size[3] * ((float)this.Height / 356));
            textBox.Left = (int)(size[4] * ((float)this.Width / 580));
            textBox.Height = (int)(size[5] * ((float)this.Height / 356));
            textBox.Width = (int)(size[6] * ((float)this.Width / 580));

            if (label2 != null)
            {
                label2.Top = (int)(size[7] * ((float)this.Height / 356));
                label2.Left = (int)(size[8] * ((float)this.Width / 580));
                label2.Font = new Font("Calibri", size[9] * ((float)this.Height / 356), FontStyle.Bold);
            }
        }

        void reSize(Label label, FlowLayoutPanel flowLayoutPanel1, Panel panel, FlowLayoutPanel flowLayoutPanel2, float[] size)
        {
            label.Top = (int)(size[0] * ((float)this.Height / 356));
            label.Font = new Font("Calibri", size[1] * ((float)this.Height / 356), FontStyle.Bold);
            flowLayoutPanel1.Top = (int)(size[2] * ((float)this.Height / 356));
            flowLayoutPanel1.Left = (int)(size[3] * ((float)this.Width / 580));           
            flowLayoutPanel2.Top = (int)(size[6] * ((float)this.Height / 356));
            flowLayoutPanel2.Left = (int)(size[7] * ((float)this.Width / 580));
            panel.Top = (int)(size[4] * ((float)this.Height / 356));
            panel.Left = (int)((float)(flowLayoutPanel2.Left + flowLayoutPanel1.Left + flowLayoutPanel1.Width) / 2);
        }

    }
}
