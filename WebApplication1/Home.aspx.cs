using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(UIUtility.User != null)
            {

                if (UserAccessDAL.CheckUserAccess(UIUtility.User.ID1, "Home"))
                {
                    
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}