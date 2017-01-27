using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1.DAL
{
    public static class ClientDAL
    {
        public static Common.Client getRow(int ID)
        {
            Common.Client client = null;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProjectSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Select_Client";
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Connection = con;
            SqlDataReader r = cmd.ExecuteReader();
            if(r.Read())
            {
                client = new Common.Client()
                {
                    Name1 = r.GetString(0),
                    ID1 = r.GetInt32(1),
                    Budget1=r.GetInt32(2),
                    Priority1=r.GetString(3),
                    Status1=r.GetString(4)
                };
            }
            return client;
        }
    }
}