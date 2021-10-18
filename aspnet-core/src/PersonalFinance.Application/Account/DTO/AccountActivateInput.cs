using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class AccountActivateInput
    {
        #region Construnctor
        public AccountActivateInput(int id, bool active)
        {
            Id = id;
            Active = active;
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        public bool Active { get; set; }

        #endregion


    }
}
