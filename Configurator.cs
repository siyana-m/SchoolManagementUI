using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectAAS
{
    public class Configurator
    {
        private DBManipulator manipulator;

        public Configurator()
        {
            this.manipulator = new DBManipulator();
        }

        public bool CheckLogin(string username, string password)
        {
            bool result = false;

            SqlConnection connection = this.manipulator.GetConnection();

            try
            {
                connection.Open();

                SqlCommand command = this.manipulator.GetCommand();

                command.CommandText = "SELECT id FROM Login WHERE username = @username AND password = @password";

                SqlParameter param = null;

                param = new SqlParameter("@username", SqlDbType.VarChar);
                param.Value = username;
                command.Parameters.Add(param);

                param = new SqlParameter("@password", SqlDbType.VarChar);
                param.Value = password;
                command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    if (reader.Read())
                    {
                        result = true;
                    }
                }
            }
            finally
            {
                connection.Close();
            }

            return result;
        }


        public DataTable LoadSpecialties()
        {
            DataTable result = new DataTable();

            result.Columns.Add("id");
            result.Columns.Add("name");

            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT SpecialtyId, Name FROM Specialty ORDER BY Name ASC";

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["SpecialtyId"]);
                    string name = Convert.ToString(reader["Name"]);

                    DataRow row = result.NewRow();

                    row[0] = id;
                    row[1] = name;

                    result.Rows.Add(row);
                }
            }

            connection.Close();

            return result;
        }

        public Specialty LoadSpecialtyById(int id)
        {
            Specialty result = null;

            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT * FROM Specialty WHERE SpecialtyId = @SpecialtyId";

            SqlParameter param = null;

            param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                if (reader.Read())
                {
                    result = new Specialty();

                    string name = Convert.ToString(reader["Name"]);

                    result.Id = id;
                    result.Name = name;
                }
            }

            connection.Close();

            return result;
        }

        public void UpdateSpecialty(int id, string name)
        {
            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "UPDATE Specialty SET Name = @Name WHERE SpecialtyId = @SpecialtyId";

            SqlParameter param = null;

            param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.VarChar);
            param.Value = name;
            command.Parameters.Add(param);

            command.ExecuteNonQuery();

            connection.Close();
        }


        public DataTable LoadSubjects()
        {
            DataTable result = new DataTable();

            result.Columns.Add("id");
            result.Columns.Add("name");

            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT SubjectId, Name FROM Subject ORDER BY Name ASC";

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["SubjectId"]);
                    string name = Convert.ToString(reader["Name"]);

                    DataRow row = result.NewRow();

                    row[0] = id;
                    row[1] = name;

                    result.Rows.Add(row);
                }
            }

            connection.Close();

            return result;
        }

        public Subject LoadSubjectById(int id)
        {
            Subject result = null;

            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT * FROM Subject WHERE SubjectId = @SubjectId";

            SqlParameter param = null;

            param = new SqlParameter("@SubjectId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                if (reader.Read())
                {
                    result = new Subject();

                    string name = Convert.ToString(reader["Name"]);

                    result.Id = id;
                    result.Name = name;
                }
            }

            connection.Close();

            return result;
        }

        public void UpdateSubject(int id, string name)
        {
            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "UPDATE Subject SET Name = @Name WHERE SubjectId = @SubjectId";

            SqlParameter param = null;

            param = new SqlParameter("@SubjectId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.VarChar);
            param.Value = name;
            command.Parameters.Add(param);

            command.ExecuteNonQuery();

            connection.Close();
        }


        public DataTable LoadStudents()
        {
            DataTable result = new DataTable();

            result.Columns.Add("fNumber");
            result.Columns.Add("specialtyId");
            result.Columns.Add("fName");
            result.Columns.Add("mName");
            result.Columns.Add("lName");
            result.Columns.Add("address");
            result.Columns.Add("phone");
            result.Columns.Add("email");

            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT FNumber, SpecialtyId, FName, MName, LName, Address, Phone, Email FROM Student ORDER BY FName ASC";

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    int fNumber = Convert.ToInt32(reader["FNumber"]);
                    int specialtyId = Convert.ToInt32(reader["SpecialtyId"]);
                    string fName = Convert.ToString(reader["FName"]);
                    string mName = Convert.ToString(reader["MName"]);
                    string lName = Convert.ToString(reader["LName"]);
                    string address = Convert.ToString(reader["Address"]);
                    string phone = Convert.ToString(reader["Phone"]);
                    string email = Convert.ToString(reader["Email"]);

                    DataRow row = result.NewRow();

                    row[0] = fNumber;
                    row[1] = specialtyId;
                    row[2] = fName;
                    row[3] = mName;
                    row[4] = lName;
                    row[5] = address;
                    row[6] = phone;
                    row[7] = email;

                    result.Rows.Add(row);
                }
            }

            connection.Close();

            return result;
        }

        public Student LoadStudentById(int fNumber)
        {
            Student result = null;

            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT * FROM Student WHERE FNumber = @FNumber";

            SqlParameter param = null;

            param = new SqlParameter("@FNumber", SqlDbType.Int);
            param.Value = fNumber;
            command.Parameters.Add(param);

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                if (reader.Read())
                {
                    result = new Student();

                    int specialtyId = Convert.ToInt32(reader["SpecialtyId"]);
                    string fName = Convert.ToString(reader["FName"]);
                    string mName = Convert.ToString(reader["MName"]);
                    string lName = Convert.ToString(reader["LName"]);
                    string address = Convert.ToString(reader["Address"]);
                    string phone = Convert.ToString(reader["Phone"]);
                    string email = Convert.ToString(reader["Email"]);

                    result.Id = fNumber;
                    result.SpecialtyId = specialtyId;
                    result.FName = fName;
                    result.MName = mName;
                    result.LName = lName;
                    result.Address = address;
                    result.Phone = phone;
                    result.EMail = email;
                }
            }

            connection.Close();

            return result;
        }

        public void UpdateStudent(int fNumber, int specialtyId, string fName, string mName, string lName, string address, string phone, string email)
        {
            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "UPDATE Student SET SpecialtyId = @SpecialtyId, FName = @FName, MName = @MName, LName = @LName, Address = @Address, Phone = @Phone, Email = @Email WHERE FNumber = @FNumber";

            SqlParameter param = null;

            param = new SqlParameter("@FNumber", SqlDbType.Int);
            param.Value = fNumber;
            command.Parameters.Add(param);

            param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
            param.Value = specialtyId;
            command.Parameters.Add(param);

            param = new SqlParameter("@FName", SqlDbType.VarChar);
            param.Value = fName;
            command.Parameters.Add(param);

            param = new SqlParameter("@MName", SqlDbType.VarChar);
            param.Value = mName;
            command.Parameters.Add(param);

            param = new SqlParameter("@LName", SqlDbType.VarChar);
            param.Value = lName;
            command.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.VarChar);
            param.Value = address;
            command.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.VarChar);
            param.Value = phone;
            command.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.VarChar);
            param.Value = email;
            command.Parameters.Add(param);

            command.ExecuteNonQuery();

            connection.Close();
        }



        public List<Specialty> LoadSpecialties1()
        {
            List<Specialty> result = new List<Specialty>();

            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT SpecialtyId, Name FROM Specialty ORDER BY Name ASC";

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    Specialty specialty = new Specialty();
                    specialty.Id = Convert.ToInt32(reader["SpecialtyId"]);
                    specialty.Name = Convert.ToString(reader["Name"]);
                    result.Add(specialty);
                }
            }

            connection.Close();

            return result;
        }



        public DataTable LoadGrades()
        {
            DataTable result = new DataTable();

            result.Columns.Add("fNumber");
            result.Columns.Add("subjectId");
            result.Columns.Add("finalGrade");

            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT FNumber, SubjectId, FinalGrade FROM StudentSubject ORDER BY FNumber ASC";

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    int fNumber = Convert.ToInt32(reader["FNumber"]);
                    int subjectId = Convert.ToInt32(reader["SubjectId"]);
                    int finalGrade = Convert.ToInt32(reader["FinalGrade"]);

                    DataRow row = result.NewRow();

                    row[0] = fNumber;
                    row[1] = subjectId;
                    row[2] = finalGrade;

                    result.Rows.Add(row);
                }
            }

            connection.Close();

            return result;
        }

        public Grade LoadGradeById(int fNumber)
        {
            Grade result = null;

            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT * FROM StudentSubject WHERE FNumber = @FNumber";

            SqlParameter param = null;

            param = new SqlParameter("@FNumber", SqlDbType.Int);
            param.Value = fNumber;
            command.Parameters.Add(param);

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                if (reader.Read())
                {
                    result = new Grade();

                    int subjectId = Convert.ToInt32(reader["SubjectId"]);
                    int finalGrade = Convert.ToInt32(reader["FinalGrade"]);

                    result.Id = fNumber;
                    result.SubjectId = subjectId;
                    result.FinalGrade = finalGrade;
                }
            }

            connection.Close();

            return result;
        }

        public void UpdateGrade(int fNumber, int subjectId, int finalGrade)
        {
            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "IF EXISTS (SELECT 1 FROM StudentSubject WHERE FNumber = @FNumber AND SubjectId = @SubjectId) " +
                                  "BEGIN " +
                                  "    UPDATE StudentSubject SET FinalGrade = @FinalGrade WHERE FNumber = @FNumber AND SubjectId = @SubjectId " +
                                  "END " +
                                  "ELSE " +
                                  "BEGIN " +
                                  "    INSERT INTO StudentSubject (FNumber, SubjectId, FinalGrade) VALUES (@FNumber, @SubjectId, @FinalGrade) " +
                                  "END";

            SqlParameter param = null;

            param = new SqlParameter("@FNumber", SqlDbType.Int);
            param.Value = fNumber;
            command.Parameters.Add(param);

            param = new SqlParameter("@SubjectId", SqlDbType.Int);
            param.Value = subjectId;
            command.Parameters.Add(param);

            param = new SqlParameter("@FinalGrade", SqlDbType.Int);
            param.Value = finalGrade;
            command.Parameters.Add(param);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public List<Student> LoadStudents1()
        {
            List<Student> result = new List<Student>();

            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT FNumber, FName, MName, LName FROM Student ORDER BY FName ASC";

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt32(reader["FNumber"]);
                    student.FName = Convert.ToString(reader["FName"]);
                    student.MName = Convert.ToString(reader["MName"]);
                    student.LName = Convert.ToString(reader["LName"]);
                    result.Add(student);
                }
            }

            connection.Close();

            return result;
        }

        public List<Subject> LoadSubjects1()
        {
            List<Subject> result = new List<Subject>();

            SqlConnection connection = this.manipulator.GetConnection();

            connection.Open();

            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT SubjectId, Name FROM Subject ORDER BY Name ASC";

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    Subject subject = new Subject();
                    subject.Id = Convert.ToInt32(reader["SubjectId"]);
                    subject.Name = Convert.ToString(reader["Name"]);
                    result.Add(subject);
                }
            }

            connection.Close();

            return result;
        }
    }
}