﻿using System.Data;
using System.Data.SqlClient;

namespace HotelManagement.DataAccess
{
    public static class ExecuteQuery
    {
        public static DataTable ExecuteReader(string Query, object[] ParamList = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(Helper.ConnectionStringVal("HotelManagement")))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                AddParameter(Query, command, ParamList);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }
            return data;
        }
        public static int ExecuteNoneQuery(string Query, object[] ParamList = null)
        {
            using (SqlConnection connection = new SqlConnection(Helper.ConnectionStringVal("HotelManagement")))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                AddParameter(Query, command, ParamList);
                return command.ExecuteNonQuery();
            }
        }
        public static object ExecuteScalar(string Query, object[] ParamList = null)
        {
            object data = new object();
            using (SqlConnection connection = new SqlConnection(Helper.ConnectionStringVal("HotelManagement")))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                AddParameter(Query, command, ParamList);
                data = command.ExecuteScalar();
            }
            return data;
        }
        private static void AddParameter(string Query, SqlCommand command, object[] ParamList)
        {
            if (ParamList != null)
            {
                string[] parameters = Query.Split(' ');
                int i = 0;
                for (int j = 0; j < parameters.Length; j++)
                {
                    if (parameters[j].Contains("@"))
                    {
                        command.Parameters.AddWithValue(parameters[j], ParamList[i]);
                        i++;
                    }
                }
            }

        }
    }
}
