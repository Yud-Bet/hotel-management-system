using MaterialSkin.Controls;

namespace HotelManagement.UI
{
    public static class GetValueOfControl
    {
        public static RoomType GetRoomType(MaterialRadioButton normalButton, MaterialRadioButton VIPButton,
            MaterialRadioButton singleButton, MaterialRadioButton doubleButton)
        {
            if (normalButton.Checked && singleButton.Checked) return RoomType.Single;
            else if (normalButton.Checked && doubleButton.Checked) return RoomType.Double;
            else if (VIPButton.Checked && singleButton.Checked) return RoomType.SingleVIP;
            else return RoomType.DoubleVIP;
        }
    }
}
