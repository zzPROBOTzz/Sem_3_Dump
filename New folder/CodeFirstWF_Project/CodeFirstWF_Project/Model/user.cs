using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWF_Project.Model
{
    public class user
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }

        public user () { }

    }
}
