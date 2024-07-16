using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAAS
{
    public partial class SpecialtyInfo : System.Web.UI.Page
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
                    this.Response.Redirect("Specialties.aspx");
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
                this.Response.Redirect("Specialties.aspx");
            }
            Configurator configurator = new Configurator();
            Specialty specialty = configurator.LoadSpecialtyById(id);
            
            SpecialtyDropDownList();
            this.NumericUpDown1.SelectedValue = specialty.Id.ToString();
            this.TextBox1.Text = specialty.Name;
            this.ViewState["id"] = id;
        }

        private void SpecialtyDropDownList()
        {
            Configurator configurator = new Configurator();
            List<Specialty> specialties = configurator.LoadSpecialties1();

            NumericUpDown1.Items.Clear();
            foreach (Specialty specialty in specialties)
            {
                NumericUpDown1.Items.Add(new ListItem(specialty.Name, specialty.Id.ToString()));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.ViewState["id"] != null)
            {
                int id = Convert.ToInt32(this.ViewState["id"]);
                Configurator configurator = new Configurator();
                configurator.UpdateSpecialty(id, this.TextBox1.Text);
                this.Response.Redirect("Specialties.aspx");
            }

        }
    }
}