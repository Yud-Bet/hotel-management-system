using MaterialSkin.Controls;

namespace HotelManagement.UI
{
    public static class SetValueForControl
    {
        public static void SetRoomType(RoomType type, MaterialRadioButton normalButton,
            MaterialRadioButton VIPButton, MaterialRadioButton singleButton, MaterialRadioButton doubleButton)
        {
            normalButton.Checked = (type == RoomType.Single || type == RoomType.Double) ? true : false;
            VIPButton.Checked = (type == RoomType.SingleVIP || type == RoomType.DoubleVIP) ? true : false;
            singleButton.Checked = (type == RoomType.Single || type == RoomType.SingleVIP) ? true : false;
            doubleButton.Checked = (type == RoomType.Double || type == RoomType.DoubleVIP) ? true : false;
        }
        public static void SetSex(Sex sex, MaterialRadioButton male, MaterialRadioButton female)
        {
            male.Checked = (sex == Sex.Male) ? true : false;
            female.Checked = (sex == Sex.Female) ? true : false;
        }

    }
}
