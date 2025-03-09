namespace Domain.Entities.BankServices
{
    internal class Deposit : BankService
    {
        public decimal InterestRate { get; set; }
        public decimal Amount { get; set;}
    }
}
