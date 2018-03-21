using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace StudentManager.App
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegisterNumber { get; set; }
        public string StudentCategory { get; set; }
        public void Save()
        {
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

            SqlConnection con = new SqlConnection(conStr);

            try
            {
                con.Open();

                string insertStudentSql = "INSERT INTO Student(Name, RegisterNumber, StudentCategory)" + "Values(@Name,@RegisterNumber,@StudentCategory);"
                                            + "SELECT SCOPE_IDENTITY()";

                SqlCommand insertCommand = new SqlCommand(insertStudentSql, con);
                insertCommand.Parameters.AddWithValue("@Name", this.Name);
                insertCommand.Parameters.AddWithValue("@RegisterNumber", this.RegisterNumber);
                insertCommand.Parameters.AddWithValue("@StudentCategory", this.StudentCategory);

                //insertCommand.ExecuteNonQuery();
                int retValue = int.Parse(insertCommand.ExecuteScalar().ToString());
                this.Id = retValue;

            }
            catch (Exception excp)
            {
                throw;
            }

        }

        public static List<Student> GetStudents()
        {
            List<Student> student = new List<Student>();
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string selectStudentQuery = "SELECT * FROM STUDENT";
                SqlCommand cmd = new SqlCommand(selectStudentQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student s = new Student();
                    s.Id = (int)reader["Id"];
                    s.Name = (string)reader["Name"];
                    s.RegisterNumber = (string)reader["RegisterNumber"];
                    student.Add(s);

                }

            }
            catch (Exception excp)
            {
                throw;
            }

            return student;
        }

        public static Student GetStudent(int id)
        {
            Student student = new  Student();
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string selectStudentQuery = "SELECT * FROM STUDENT";
                SqlCommand cmd = new SqlCommand(selectStudentQuery, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {   
                    Student s = new Student();
                    s.Id = (int)reader["Id"];
                    s.Name = (string)reader["Name"];
                    s.RegisterNumber = (string)reader["RegisterNumber"];


                }

            }
            catch (Exception excp)
            {
                throw;
            }

            return student;
        }

        public static int GetTotalStudentCount()
        {
            int totalStudent = 0;
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);

            try

            {
                con.Open();
                string sqlQuery = "SELECT * FROM STUDENT";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                totalStudent = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception excp)
            {
                throw;
            }
            return totalStudent;

        }

        public static DataTable GetDataList()
        {
            DataTable StudentDetalis = new DataTable("StudentList");
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

            SqlConnection con = new SqlConnection(conStr);

            try
            {
                string sqlQuery = "SELECT * FROM sTUDENT";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(StudentDetalis);


            }
            catch(Exception excp)
            {
                throw;
            }
            return StudentDetalis;
        }
    }
}