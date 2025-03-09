using Domain.Entities.BankServices;

namespace Domain.Entities.BankClients
{
    internal class CompanyEmployee : Client
    {
        public SalaryProject SalaryProject { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
    }
}
