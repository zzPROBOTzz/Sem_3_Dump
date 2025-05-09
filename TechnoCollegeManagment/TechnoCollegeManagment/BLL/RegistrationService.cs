using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoCollegeManagment.DAL;
using TechnoCollegeManagment.Models;

namespace TechnoCollegeManagment.BLL
{
    public class RegistrationService
    {
        // All the objects of Repositories
        public ApplicantRepository applicantRepository;
        public WebinarRepository webinarRepository;
        public WebinarApplicantRepository webinarApplicantRepository;


        public RegistrationService()
        {
            // you can intialize or declare an object here in constructor 
            applicantRepository = new ApplicantRepository();
            webinarRepository = new WebinarRepository();
            webinarApplicantRepository = new WebinarApplicantRepository();
        }

        public void AddApplicant(int appId , string appFirstName, string appLastName, string appEmail)
        {
            applicantRepository = new ApplicantRepository();

            Applicant newApplicant = new Applicant();
            newApplicant.AppId = appId;
            newApplicant.FirstName = appFirstName;
            newApplicant.LastName = appLastName;
            newApplicant.Email = appEmail;

            // pass an object of Applicant to the repository 
            applicantRepository.AddApplicant(newApplicant);
        }

        public void DeleteApplicant(int AppId)
        {
           applicantRepository.DeleteApplicant(AppId);
        }

        public void GetAllApplicants()
        {
           applicantRepository.GetAllApplicants();
        }

        public void AddWebinar(string WebinarCode ,string WebinarName, DateTime StartingDate, int TotalHours, DateTime EndingDate)
        {
            webinarRepository = new WebinarRepository();

            Webinar newWebinar = new Webinar();
            newWebinar.WebinarCode1 = WebinarCode;
            newWebinar.WebinarName1 = WebinarName;
            newWebinar.StartingDate1 = StartingDate;
            newWebinar.TotalHours1 = TotalHours;
            newWebinar.EndingDate1 = EndingDate;

            // pass an object of Webinar to the repository
            webinarRepository.AddWebinar(newWebinar);
        }
        public void DeleteWebinar(int WebinarCode)
        {
            webinarRepository.DeleteWebinar(WebinarCode);
        }
        public void GetAllWebinars()
        {

        }

        // I have two FK keys and I need to pass two data 
        //applicantId , webinarId
        public void RegisterApplicantToWebinar(int applicantId, string WebinarCode)
        {
            webinarApplicantRepository.RegisterApplicantToWebinar(applicantId, WebinarCode);
        }

        //public void RegisterApplicantToWebinar(int applicantId, string webinarId)
        //{
        //    webinarApplicantRepository.RegisterApplicantToWebinar(applicantId, webinarId);
        //}
        // we will keep all the data 

        public void updateDataBase()
        {
            webinarRepository.SaveChanges();
            applicantRepository.SaveChanges();
        }

    }
}
