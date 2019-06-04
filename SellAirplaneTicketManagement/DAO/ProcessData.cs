using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellAirplaneTicketManagement.DAO
{
    /*class ProcessData
    {

        static string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLBanvechuyenbay;Integrated Security=True";
        public static DataTable LoadData(string sql)
        {

            SqlConnection conn = new SqlConnection(path);

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public static int Execute(string sql)
        {
            SqlConnection conn = new SqlConnection(path);

            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();

            var rs = command.ExecuteNonQuery();

            conn.Close();

            return rs;
        }
        
    }*/
}
