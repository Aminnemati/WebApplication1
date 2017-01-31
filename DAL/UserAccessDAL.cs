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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVHPT3F;Initial Catalog=Project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "User_Has_Access";
            cmd.Parameters.AddWithValue("@PageName", pageName);
            cmd.Parameters.AddWithValue("@IdUser", userID);
            result=Convert.ToBoolean (cmd.ExecuteScalar().ToString());
            con.Close();
            return result;
        }
    }
}