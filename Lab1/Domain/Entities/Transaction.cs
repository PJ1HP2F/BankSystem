using Domain.Entities.Core;

namespace Domain.Entities
{
    internal class Transaction : Entity
    {
        public BankRecord Recepient { get; set; }
        public BankRecord Receiver { get; set; }

        public bool IsCancelled { get; set; }
        public DateTime Date {  get; set; }
        public Decimal Amount { get; set; } 
    }
}
