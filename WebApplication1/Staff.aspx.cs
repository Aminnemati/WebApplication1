using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList staffList = DAL.StaffDAL.GetAllStaff();
            foreach (Common.Staff sample in staffList)
            {

                TableRow tableRow = new TableRow();
                tableRow.Cells.Add(new TableCell() { Text = sample.FName1 });
                tableRow.Cells.Add(new TableCell() { Text = sample.LName1 });
                tableRow.Cells.Add(new TableCell() { Text = sample.ID_Num1.ToString() });
                tableRow.Cells.Add(new TableCell() { Text = sample.Birth_Date1.ToString() });
                tableRow.Cells.Add(new TableCell() { Text = sample.E_Mail1 });
                tableRow.Cells.Add(new TableCell() { Text = sample.Salary1.ToString() });
                tableProject.Rows.Add(tableRow);
            }
        }

        protected void Insertpage(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Staff.aspx");
        }
        protected void searchBtnClick(object sender, EventArgs e)
        {
            
        }
    }
}