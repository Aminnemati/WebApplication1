using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

namespace UI
{
    public static class UserConnect
    {
        static SqlConnection con;
        static SqlCommand cmd;

        static UserConnect()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=ProjectSystem;Integrated Security=True");
            cmd = new SqlCommand();
        }
        public static Common.User getUser(String user , String pass)
        {
            Common.User u = null;
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "SELECT_User";
            cmd.Parameters.AddWithValue("@UserName",user);
            cmd.Parameters.AddWithValue("@Pass",pass);
            cmd.Connection = con;
            SqlDataReader r= cmd.ExecuteReader();
            if (r.Read())
            {
                u = new Common.User
                {
                    Username1 = r.GetString(0),
                    Pass1 = r.GetString(1),
                    ID1 = r.GetInt32(2)
                };
            }
            con.Close();
            return u;
        }

    }
}