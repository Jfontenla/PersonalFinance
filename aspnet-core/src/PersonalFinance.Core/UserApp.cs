using PersonalFinance.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class UserApp : User
    {
        #region properties
        public string country { get; set; }
        public string Dni { get; set; }
        public string Phone { get; set; }
        #endregion

        #region Navigation to other entities

        #endregion
    }
}
