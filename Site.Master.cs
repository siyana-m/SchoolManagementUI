using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAAS
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (this.Session["username"] != null)
                {
                    this.LinkButtonLogin.Text = "Sign out";
                    this.LinkButtonSpecialties.Visible = true;
                    this.LinkButtonSubjects.Visible = true;
                    this.LinkButtonStudents.Visible = true;
                    this.LinkButtonGrades.Visible = true;
                }
            }
        }
        protected void LinkButtonLogin_Click(object sender, EventArgs e)
        {
            if (this.Session["username"] != null)
            {
                this.Session["username"] = null;
                this.Response.Redirect("Default.aspx");
            }
            else
            {
                this.Response.Redirect("Login.aspx");
            }
        }
        protected void LinkButtonSpecialties_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("Specialties.aspx");
        }
        protected void LinkButtonSubjects_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("Subjects.aspx");
        }
        protected void LinkButtonStudents_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("Students.aspx");
        }
        protected void LinkButtonGrades_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("Grades.aspx");
        }

    }
}