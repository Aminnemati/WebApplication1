using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class UserConnect
    {
        SqlConnection con;
        SqlCommand cmd;
        public UserConnect()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=ProjectSystem;Integrated Security=True");
            cmd = new SqlCommand();
        }
        public Common.User getUser(String user , String pass)
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
                    Code1 = r.GetString(0),
                    ID1 = r.GetString(1)
                };
            }
            con.Close();
            return u;
        }

    }
}