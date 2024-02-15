using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MedicalStoreManagementSystem
{
    internal class DataBase
    {
        private SqlConnection connectDB = new SqlConnection("Server=Omkar\\SQLEXPRESS; Database=medicalStoreDatabase; Trusted_Connection=True");

        internal void closeConnection()
        {
            connectDB.Close();
        }


        internal SqlDataReader getSingleData(string query)
        {
            connectDB.Open();
            SqlCommand cmd = new SqlCommand(query, connectDB);
            return cmd.ExecuteReader();
        }


    }
}
