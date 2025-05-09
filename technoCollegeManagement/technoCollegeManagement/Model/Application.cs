using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technoCollegeManagement.Model
{
    internal class Applicant
    {
        private int appId;
        private string firstName;
        private string lastName;
        private string email;
        public Applicant()
        { }

        public int AppId { get => appId; set => appId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
    }
}
