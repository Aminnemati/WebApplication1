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
            con = new SqlConnection("Data Source =.; Initial Catalog = ProjectSystem; Integrated Security = True");
            cmd = new SqlCommand();
        }
        public Common.User getUser(string user , string pass)
        {
            Common.User u = null;
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "";
            cmd.Parameters.Add("@UserName",user);
            cmd.Parameters.Add("@Pass",pass);

            SqlDataReader r= cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            if (r.HasRows)
            {
                new Common.User
                {
                    Code1 = r[0].ToString(),
                    ID1 = r[1].ToString()
                };
            }
            return u;
        }

    }
}