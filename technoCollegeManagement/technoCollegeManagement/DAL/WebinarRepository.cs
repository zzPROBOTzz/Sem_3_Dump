using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technoCollegeManagement.DAL
{
    internal class WebinarRepository
    {
        private string connectionString = "Server=LAPTOP-UO4MA3MG\\SQLEXPRESS;Database=technoColloegeManagement;Integrated Security=True;";
        private DataSet dataSet;
        private SqlDataAdapter WebinarAdapter;
        private SqlCommandBuilder webinarBuilder;


        public WebinarRepository()
        {
            dataSet = new DataSet();
            WebinarAdapter = new SqlDataAdapter("select * from webinars", connectionString);
            webinarBuilder = new SqlCommandBuilder(WebinarAdapter);
            //WebinarAdapter.Fill(dataSet, "Webinar");
        }

        public void addWebinar(int WebinarCode, string WebinarName, DateTime StartingDate, int TotalHours, DateTime EndingDate)
        {
            DataRow webinarRow = dataSet.Tables["Webinar"].NewRow();
            webinarRow["WebinarCode"] = WebinarCode;
            webinarRow["WebinarName"] = WebinarName;
            webinarRow["StartingDate"] = StartingDate;
            webinarRow["TotalHours"] = TotalHours;
            webinarRow["EndingDate"] = EndingDate;
            dataSet.Tables["webinars"].Rows.Add(webinarRow);
            WebinarAdapter.Update(dataSet, "webinars");
        }

        public DataTable GetAllWebinars()
        {
            WebinarAdapter.Fill(dataSet, "Webinar");
            return dataSet.Tables["Webinar"];
        }

        public void UpdateWebinar()
        {
            WebinarAdapter.Update(dataSet, "Webinar");
        }

        public void DeleteWebinar(int WebinarCode)
        {
            DataRow[] rows = dataSet.Tables["Webinar"].Select($"WebinarCode = {WebinarCode}");
            rows[0].Delete();
            WebinarAdapter.Update(dataSet, "Webinar");
        }
    }
}
