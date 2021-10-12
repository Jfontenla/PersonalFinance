using Abp.AutoMapper;
using System;

namespace PersonalFinance
{
    [AutoMapFrom(typeof (Account))]
    public class AccountDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public int TransformationAccountToOtherId { get; set; }
    }
}