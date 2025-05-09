using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using technoCollegeManagement.Model;

namespace technoCollegeManagement.DAL
{
    internal class WebinarApplicationRepository
    {
        private string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=technoColloegeManagement;Integrated Security=True;";
        private DataSet dataSet;
        private SqlDataAdapter WebinarApplicationAdapter;
        private SqlCommandBuilder webinarApplicationBuilder;

        public WebinarApplicationRepository()
        {
            dataSet = new DataSet();
            WebinarApplicationAdapter = new SqlDataAdapter("select * from webinarApplications", connectionString);
            webinarApplicationBuilder = new SqlCommandBuilder(WebinarApplicationAdapter);
            //WebinarApplicationAdapter.Fill(dataSet, "WebinarApplication");
        }

        public void RegisterApplicantsToWebinar(int AppId, int WebinarCode, DateTime applicationDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // prepare insert Query 
                string query = "INSERT INTO ApplicantsWebinars (AppId, WebinarCode, RegistrationDate) VALUES (@AppId,@WebinarCode,@RegistrationDate)";
                // use SqlCOmmand to run the query 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // My parameters 
                    command.Parameters.AddWithValue("@AppId", AppId);
                    command.Parameters.AddWithValue("@WebinarCode", WebinarCode);
                    command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);

                    connection.Open();
                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
