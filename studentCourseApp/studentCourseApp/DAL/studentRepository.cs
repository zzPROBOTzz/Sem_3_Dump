using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using studentCourseApp.model;

namespace studentCourseApp.DAL
{
    public class studentRepository
    {
        private readonly string connenctionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=StudentDB;Integrated Security=True;";
        private DataSet dataSet;
        private SqlDataAdapter adapter;
        private SqlCommand builder;

        public studentRepository()
        {
        }


        public void addStudent(student student)
        {
            DataRow dataRow = dataSet.Tables["students"].NewRow();
            dataRow["studentName"] = student.StudentName;
            dataRow["studentEmail"] = student.StudentEmail;
            dataRow["studentAge"] = student.StudentAge;
            dataRow["RegistrationDate"] = student.RegistrationDate;

            dataSet.Tables["students"].Rows.Add(dataRow);

        }
    }
}
