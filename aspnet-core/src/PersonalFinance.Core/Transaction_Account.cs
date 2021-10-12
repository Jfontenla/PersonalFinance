using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class Transaction_Account :FullAuditedEntity
    {
        #region Properties
        public decimal Import { get; set; }
        public string Description { get; set; }
        #endregion

        #region Relations with other entities
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public Transaction Transaction { get; set; }
        public int TransactionId { get; set; }
        #endregion

    }
}
