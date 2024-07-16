using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProjectAAS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["username"] != null)
            {
                this.Response.Redirect("Default.aspx");
            }
        }
        protected void submit_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;
            Configurator configurator = new Configurator();
            if (configurator.CheckLogin(username, password))
            {
                this.Session["username"] = username;
                this.Response.Redirect("Default.aspx");
            }
        }
    }
}