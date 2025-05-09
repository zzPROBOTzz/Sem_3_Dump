using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using technoCollegeManagement.DAL;

namespace technoCollegeManagement.BAL
{
    internal class RegistrationService
    {
        public ApplicantRepository applicantRepository;
        public WebinarRepository webinarRepository;
        public WebinarApplicationRepository WebinarApplicationRepository;

        public RegistrationService()
        {
            applicantRepository = new ApplicantRepository();
            webinarRepository = new WebinarRepository();
            WebinarApplicationRepository = new WebinarApplicationRepository();
        }

        public void AddApplicant(int appId, string firstName, string lastName, string email)
        {
            applicantRepository.AddApplicant(appId, firstName, lastName, email);
        }

        public void DeleteApplicant(int appId)
        {
            applicantRepository.DeleteApplicant(appId);
        }

        public void UpdateApplicant()
        {
            applicantRepository.UpdateApplicant();
        }

        public void deleteApplicant(int appId)
        {
            applicantRepository.DeleteApplicant(appId);
        }

        public void AddWebinarApplication(int appId, int webinarCode, DateTime applicationDate)
        {
            WebinarApplicationRepository.RegisterApplicantsToWebinar(appId, webinarCode, applicationDate);
        }

      

        public void AddWebinar(int webinarCode, string webinarName, DateTime startingDate, int totalHours, DateTime endingDate)
        {
            webinarRepository.addWebinar(webinarCode, webinarName, startingDate, totalHours, endingDate);
        }

        public void DeleteWebinar(int webinarCode)
        {
            webinarRepository.DeleteWebinar(webinarCode);
        }

        public void UpdateWebinar()
        {
            webinarRepository.UpdateWebinar();
        }

        public void getAllApplicants()
        {
            applicantRepository.GetAllApplicants();
        }

        public void getAllWebinars()
        {
            webinarRepository.GetAllWebinars();
        }

    }
}
