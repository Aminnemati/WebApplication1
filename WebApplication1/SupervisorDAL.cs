using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;

namespace WebApplication1.DAL
{
    public static class SupervisorDAL
    {
        public static Common.Supervisor GetRow(int ID)
        {
            Common.Supervisor s = null;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVHPT3F;Initial Catalog=Project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Select_Supervisor";
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Connection = con;
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                s.Staff = StaffDAL.GetRow(r.GetInt32(0));
            }
            return s;
        }
    }
}