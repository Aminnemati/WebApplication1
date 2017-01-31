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
                    LName1=r.GetString(1),
                    ID_Num1=r.GetInt32(2),
                    Birth_Date1=r.GetDateTime(3),
                    E_Mail1=r.GetString(4),
                    Salary1=r.GetInt32(5)
                };
            }
            return staff;
        }
        public static ArrayList GetAllStaff()
        {
            ArrayList allStaff = new ArrayList();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVHPT3F;Initial Catalog=Project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Select_All_Staff";
            cmd.Connection = con;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Common.Staff staff = new Common.Staff()
                {
                    FName1 = r.GetString(0),
                    LName1 = r.GetString(1),
                    ID_Num1 = r.GetInt32(2),
                    Birth_Date1=r.GetDateTime(3),
                    E_Mail1=r.GetString(4),
                    Salary1=r.GetInt32(5)
                };
                allStaff.Add(staff);
            }
            con.Close();
            return allStaff;
        }

        public static void Insert(String Fname,String Lname,DateTime Birth_Date,String E_Mail,int Salary)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVHPT3F;Initial Catalog=Project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Insert_Staff";
            cmd.Parameters.AddWithValue("@FName", Fname);
            cmd.Parameters.AddWithValue("@LName", Lname);
            cmd.Parameters.AddWithValue("@Birth_Date",Birth_Date);
            cmd.Parameters.AddWithValue("@E_Mail", E_Mail);
            cmd.Parameters.AddWithValue("@Salary", Salary);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}