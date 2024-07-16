using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAAS
{
    public partial class Students : System.Web.UI.Page
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
                this.Response.Redirect("StudentInfo.aspx?id=" + id);
            }
        }
        private void LoadData()
        {
            Configurator configurator = new Configurator();
            DataTable studentsData = configurator.LoadStudents();

            foreach (DataRow row in studentsData.Rows)
            {
                int Id = Convert.ToInt32(row["FNumber"]);
                Student student = configurator.LoadStudentById(Id);
                row["FNumber"] = student.Id;
            }

            foreach (DataRow row in studentsData.Rows)
            {
                int specialtyId = Convert.ToInt32(row["specialtyId"]);
                Specialty specialty = configurator.LoadSpecialtyById(specialtyId);
                row["specialtyId"] = specialty.Name;
            }

            GridViewContent.DataSource = studentsData;
            GridViewContent.DataBind();
        }
    }
}