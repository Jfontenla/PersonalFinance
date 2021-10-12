using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class Account :  FullAuditedEntity
    {
        #region Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public int TransformationAccountToOtherId { get; set; }
        #endregion

        #region Navigation to oder entities
        public ICollection<Transaction_Account> Transactions { get; set; }
        public UserApp User { get; set; }
        public int UserId { get; set; }
        #endregion
    }
}
