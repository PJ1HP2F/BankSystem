using Domain.Entities.Core;

namespace Domain.Entities.BankServices
{
    internal class BankService : Entity
    {
        public DateTime LastUpdateAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ClosedAt { get; set; }
        public int TermInMonth { get; set; }

        public BankRecord Record { get; set; }
        public bool IsApproved { get; set; }
    }
}
