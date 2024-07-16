using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAAS
{
    public partial class Grades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["username"] == null)
            {
                this.Response.Redirect("Default.aspx");
            }
            this.LoadData();
        }
        protected void GridViewContent_RowCommand(object sender,
       GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Select")
            {

                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow selectedRow = this.GridViewContent.Rows[index];
                TableCell firstCell = selectedRow.Cells[1];
                string id = firstCell.Text;
                this.Response.Redirect("GradeInfo.aspx?id=" + id);
            }
        }
        private void LoadData()
        {
            Configurator configurator = new Configurator();
            DataTable gradesData = configurator.LoadGrades();

            foreach (DataRow row in gradesData.Rows)
            {
                int Id = Convert.ToInt32(row["FNumber"]);
                Student student = configurator.LoadStudentById(Id);
                row["FNumber"] = student.Id;
            }

            foreach (DataRow row in gradesData.Rows)
            {
                int subjectId = Convert.ToInt32(row["subjectId"]);
                Subject subject = configurator.LoadSubjectById(subjectId);
                row["subjectId"] = subject.Name;
            }

            GridViewContent.DataSource = gradesData;
            GridViewContent.DataBind();
        }

    }
}