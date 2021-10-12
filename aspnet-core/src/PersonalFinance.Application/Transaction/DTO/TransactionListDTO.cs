using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;

namespace PersonalFinance
{
    [AutoMapFrom(typeof (Transaction))]
    public class TransactionListDTO : EntityDto, IHasCreationTime
    {
        public decimal Amount { get; set; }
        public DateTime StartToApply { get; set; }
        public DateTime EndToApply { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
    }
}