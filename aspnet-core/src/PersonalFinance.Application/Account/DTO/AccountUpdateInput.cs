using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class AccountUpdateInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TransformationAccountToOtherId { get; set; }
    }
}
