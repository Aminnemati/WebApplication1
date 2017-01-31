using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Insert_Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void cancelclick(object sender, EventArgs e)
        {
            Response.Redirect("Staff.aspx");
        }
        protected void saveclick(object sender, EventArgs e)
        {
            DAL.StaffDAL.Insert(txtStaffFName.Text,txtStaffLName.Text,DateTime.Parse(txtBirthDate.Text),txtEmail.Text,Int32.Parse(txtSalary.Text));
            Response.Redirect("SaveSucceeded.aspx");
        }
    }
}