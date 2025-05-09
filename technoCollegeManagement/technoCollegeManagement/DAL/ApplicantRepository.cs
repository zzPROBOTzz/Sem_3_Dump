using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technoCollegeManagement.DAL
{
    public class ApplicantRepository
    {
        private string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=technoColloegeManagement;Integrated Security=True;";
        private DataSet dataSet;
        private SqlDataAdapter ApplicantAdapter;
        private SqlCommandBuilder applicantBuilder;

        public ApplicantRepository()
        {
            dataSet = new DataSet();
            ApplicantAdapter = new SqlDataAdapter("select * from applicants", connectionString);
            applicantBuilder = new SqlCommandBuilder(ApplicantAdapter);
           // ApplicantAdapter.Fill(dataSet, "Applicant");
        }

        public void AddApplicant(int AppId, string firstName, string lastName, string email)
        {
            DataRow applicantRow = dataSet.Tables["Applicant"].NewRow();
            applicantRow["AppId"] = AppId;
            applicantRow["FirstName"] = firstName;
            applicantRow["LastName"] = lastName;
            applicantRow["Email"] = email;
            dataSet.Tables["applicants"].Rows.Add(applicantRow);
            ApplicantAdapter.Update(dataSet, "applicants");
        }

        //Add Applicant
        public DataTable GetAllApplicants()
        {
            ApplicantAdapter.Fill(dataSet, "Applicant");
            return dataSet.Tables["Applicant"];
        }

        public void UpdateApplicant()
        {
            ApplicantAdapter.Update(dataSet, "Applicant");
        }

        public void DeleteApplicant(int AppId)
        {
            DataRow[] rows = dataSet.Tables["Applicant"].Select($"AppId = {AppId}");
            rows[0].Delete();
            ApplicantAdapter.Update(dataSet, "Applicant");
        }
    }
}
