﻿namespace Domain.Entities.BankClients
{
    internal class Client : BankClient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PassportSeries { get; set; }
        public int PassportNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public string PhoneNumber { get; set; }
    }
}
