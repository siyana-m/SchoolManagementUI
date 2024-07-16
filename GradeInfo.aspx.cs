using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAAS
{
    public partial class GradeInfo : System.Web.UI.Page
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
                    LoadData(param);
                }
                else
                {
                    this.Response.Redirect("Grades.aspx");
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
                this.Response.Redirect("Grades.aspx");
            }

            Configurator configurator = new Configurator();
            Grade grade = configurator.LoadGradeById(id);

            StudentDropDownList();
            ComboBox1.SelectedValue = grade.Id.ToString();
            SubjectsDropDownList();
            ComboBox2.SelectedValue = grade.SubjectId.ToString();
            NumericUpDown1.Text = grade.FinalGrade.ToString();

            ViewState["id"] = id;
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

            private void SubjectsDropDownList()
        {
            Configurator configurator = new Configurator();
           
            List<Subject> subjects = configurator.LoadSubjects1();

            ComboBox2.Items.Clear();
            foreach (Subject subject in subjects)
            {
                ComboBox2.Items.Add(new ListItem(subject.Name, subject.Id.ToString()));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["id"] != null)
            {
                int id = Convert.ToInt32(ViewState["id"]);
                Configurator configurator = new Configurator();
                int subjectId = Convert.ToInt32(ComboBox2.SelectedValue);
                configurator.UpdateGrade(id, subjectId, int.Parse(NumericUpDown1.Text));

                Response.Redirect("Grades.aspx");
            }
        }

    }
}