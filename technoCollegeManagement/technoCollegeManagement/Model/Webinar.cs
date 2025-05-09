using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technoCollegeManagement.Model
{
    internal class Webinar
    {
        private int WebinarCode;
        private string WebinarName;
        private DateTime StartingDate;
        private int TotalHours;
        private DateTime EndingDate;

        public Webinar()
        { }

        public int WebinarCode1 { get => WebinarCode; set => WebinarCode = value; }
        public string WebinarName1 { get => WebinarName; set => WebinarName = value; }
        public DateTime StartingDate1 { get => StartingDate; set => StartingDate = value; }
        public int TotalHours1 { get => TotalHours; set => TotalHours = value; }
        public DateTime EndingDate1 { get => EndingDate; set => EndingDate = value; }
    }
}
