using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBLL
{
    public class AuthorBLL
    {
        public static DataTable GetAuthors()
        {
            return AuthorDAL.GetAllAuthors();
        }
    }
}
