using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAAS
{
    public partial class SubjectInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["username"] == null)
            {
                this.Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
            {
                if (this.Request["id"] != null)
                {
                    string param = this.Request["id"];
                    this.LoadData(param);
                }
                else
                {
                    this.Response.Redirect("Subjects.aspx");
                }
            }
        }
        private void LoadData(string param)
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(param);
            }
            catch
            {
                this.Response.Redirect("Subjects.aspx");
            }
            Configurator configurator = new Configurator();
            Subject subject = configurator.LoadSubjectById(id);

            SubjectDropDownList();
            this.NumericUpDown1.SelectedValue = subject.Id.ToString();
            this.TextBox1.Text = subject.Name;
            this.ViewState["id"] = id;
        }
        private void SubjectDropDownList()
        {
            Configurator configurator = new Configurator();
            List<Subject> subjects = configurator.LoadSubjects1();

            NumericUpDown1.Items.Clear();
            foreach (Subject subject in subjects)
            {
                NumericUpDown1.Items.Add(new ListItem(subject.Id.ToString(), subject.Name));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.ViewState["id"] != null)
            {
                int id = Convert.ToInt32(this.ViewState["id"]);
                Configurator configurator = new Configurator();
                configurator.UpdateSpecialty(id, this.TextBox1.Text);
                this.Response.Redirect("Subjects.aspx");
            }

        }

    }
}