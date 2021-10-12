using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class Transaction : FullAuditedEntity
    {
        #region Properties
        public decimal Amount { get; set; }
        public DateTime StartToApply { get; set; }
        public DateTime EndToApply { get; set; }
        public string Description { get; set; }
        #endregion

        #region Navigation to other properties
        public ICollection<Transaction_Account> Accounts { get; set; }
        #endregion

    }

    public enum TypeTransaction
    {
        Spend,
        Income,
    }
}
