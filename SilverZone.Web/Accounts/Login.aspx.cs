using System;


namespace SilverZone.Web.Accounts
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("/");
            }
        }

        protected void LogIn_LoggingIn(object sender, System.Web.UI.WebControls.LoginCancelEventArgs e)
        {
            LogIn.UserName = LogIn.UserName.Trim(); 
            
        }

       
    }
}