using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            Common.User user = UserConnect.getUser(txtUserName.Text,txtPassWord.Text);
            if(user != null)
            {
                UIUtility.User = user;
                Response.Redirect("Home.aspx");
            }else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Error", "Username and password combination is wrong", true);
            }
        }
        
    }
}