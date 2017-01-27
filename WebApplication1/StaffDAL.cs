using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;

namespace WebApplication1.DAL
{
    public static class StaffDAL
    {
        public static Common.Staff GetRow(int ID)
        {
            Common.Staff staff = null;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVHPT3F;Initial Catalog=Project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Select_Staff";
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Connection = con;
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                staff = new Common.Staff()
                {
                    FName1=r.GetString(0),
                    LName1=r.GetString(2),
                    ID_Num1=r.GetInt32(3),
                    Birth_Date1=r.GetDateTime(4),
                    E_Mail1=r.GetString(5),
                    Salary1=r.GetInt32(6)
                };
            }
            return staff;
        }
    }
}