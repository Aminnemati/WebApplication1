using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;

namespace WebApplication1.DAL
{
    public static class ProjectDAL
    {
        public static ArrayList GetProjectList(String ProjectName)
        {
            ArrayList projectArrayList = new ArrayList();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVHPT3F;Initial Catalog=Project;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Select_Project";
            cmd.Parameters.AddWithValue("@Name", ProjectName);
            cmd.Connection = con;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Common.Project project = new Common.Project()
                {
                    ID1 = r.GetInt32(0),
                    Name1 = r.GetString(1),
                    Assignment_date1 = r.GetDateTime(2),
                    Client = ClientDAL.getRow(r.GetInt32(3)),
                    Supervisor = SupervisorDAL.GetRow(r.GetInt32(4))
                };
            }
            con.Close();
            return projectArrayList;
        }
    }
}