using System.Data;

namespace HotelManagement.DataAccess
{
    public static class AdditionalInfoForBillViewing
    {
        public static DataTable GetData(int BillID)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetAdditionalInfoForBillViewing @BillID", new object[] { BillID });
        }
    }
}
