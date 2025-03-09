using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.BankServices
{
    internal class Installment : BankService
    {
        public decimal InterestRate { get; set; }
        public decimal Amount { get; set; }
    }
}
