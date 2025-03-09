using Domain.Entities.BankClients;
using Domain.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public BankClient? BankClient { get; set; }
    }
}
