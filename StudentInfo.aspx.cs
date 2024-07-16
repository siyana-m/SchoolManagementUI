using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ProjectAAS
{
    public partial class StudentInfo : System.Web.UI.Page
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
                    this.Response.Redirect("Students.aspx");
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
                this.Response.Redirect("Students.aspx");
            }
            Configurator configurator = new Configurator();
            Student student = configurator.LoadStudentById(id);

            StudentDropDownList();
            this.NumericUpDown1.SelectedValue = student.Id.ToString();
            SpecialtyDropDownList();
            this.ComboBox1.SelectedValue = student.SpecialtyId.ToString();
            this.TextBox1.Text = student.FName;
            this.TextBox2.Text = student.MName;
            this.TextBox3.Text = student.LName;
            this.TextBox4.Text = student.Address;
            this.TextBox5.Text = student.Phone;
            this.TextBox6.Text = student.EMail;
            this.ViewState["id"] = id;
        }

        private void StudentDropDownList()
        {
            Configurator configurator = new Configurator();

            List<Student> students = configurator.LoadStudents1();

            ComboBox1.Items.Clear();
            foreach (Student student in students)
            {
                ComboBox1.Items.Add(new ListItem($"{student.FName} {student.MName} {student.LName}", student.Id.ToString()));
            }
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
                int specialtyId = Convert.ToInt32(this.ComboBox1.SelectedValue);
                Configurator configurator = new Configurator();
                configurator.UpdateStudent(id, specialtyId, this.TextBox1.Text, this.TextBox2.Text, this.TextBox3.Text, this.TextBox4.Text, this.TextBox5.Text, this.TextBox6.Text);
                this.Response.Redirect("Students.aspx");
            }

        }
    }
}