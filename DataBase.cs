using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem
{
    internal class DataBase
    {
        private SqlConnection connectDB = new SqlConnection(@"Server=Omkar\SQLEXPRESS; Database=medicalStoreDatabase; Trusted_Connection=True");
        private SqlCommand cmd;

        internal void closeConnection()
        {
            connectDB.Close();
        }

        internal SqlDataReader getData(string query)
        {
            connectDB.Open();
            cmd = new SqlCommand(query, connectDB);
            return cmd.ExecuteReader();
        }

        internal DataTable getTable(string query)
        {
            connectDB.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connectDB);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        internal void setData(string query)
        {
            connectDB.Open();
            cmd = new SqlCommand(query, connectDB);
            cmd.ExecuteNonQuery();
            connectDB.Close();
        }

    }
}
