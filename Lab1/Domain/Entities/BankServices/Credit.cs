namespace Domain.Entities.BankServices
{
    internal class Credit : BankService
    {
        public decimal InterestRate { get; set; }
        public decimal Amount { get; set;}
    }
}
