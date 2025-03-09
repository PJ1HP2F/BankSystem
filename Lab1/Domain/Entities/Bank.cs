using Domain.Entities.BankClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Bank : Company
    {
        public string BankIdentificationCode { get; set; }
        public ICollection<Client> Users { get; set; }

    }
}
