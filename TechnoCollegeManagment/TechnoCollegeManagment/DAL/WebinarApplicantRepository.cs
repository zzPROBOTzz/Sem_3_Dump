using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoCollegeManagment.DAL
{
    public class WebinarApplicantRepository
    {
        private readonly string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=technoColloegeManagement;Integrated Security=True;";
        private DataSet dataSet;
        private SqlDataAdapter webinarApplicantAdapter;
        private SqlCommandBuilder webinarApplicantBuilder;

        public WebinarApplicantRepository()
        {
            dataSet = new DataSet();
            // intilalize or declare your object 
            webinarApplicantAdapter = new SqlDataAdapter("SELECT * FROM ApplicantsWebinars", connectionString);
            webinarApplicantBuilder = new SqlCommandBuilder(webinarApplicantAdapter);
        }

        // I want to add appplicantWebinar to my table (insert data to ApplicantsWebinars table)
        // Based on my database design I know we have two foreign keys 
        // ApplicanId, WebinarCode
        // you can pass the registration date select from form with dataTime picker or 
        // you can use now()
        public void RegisterApplicantToWebinar(int applicantId, string WebinarCode)
        {
            //connect to database  
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // prepare insert Query 
                string query = "INSERT INTO ApplicantsWebinars (ApplicanId, WebinarCode, RegistrationDate) VALUES (@ApplicanId,@WebinarCode,@RegistrationDate)";
                // use SqlCOmmand to run the query 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // My parameters 
                    command.Parameters.AddWithValue("@ApplicanId", applicantId);
                    command.Parameters.AddWithValue("@WebinarCode", WebinarCode);
                    command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);

                    connection.Open();
                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
