using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace UI
{
    public static class UserAccessDAL
    {
        public static Boolean CheckUserAccess(int userID,string pageName)
        {
            Boolean result=false;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ProjectSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "User_Has_Access";
            cmd.Parameters.AddWithValue("@Page_Name", pageName);
            cmd.Parameters.AddWithValue("@User_ID", userID);
            result=Convert.ToBoolean (cmd.ExecuteScalar().ToString());
            return result;
        }
    }
}