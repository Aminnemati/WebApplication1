using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserConnect uc = new UserConnect();
            Common.User user = uc.getUser(txtUserName.Text,txtPassWord.Text);
            if(user != null)
            {
                Response.Redirect("Home.aspx");
            }else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "پیغام خطا", "اطلاعات اشتباه است", true);
            }


        }
    }
}