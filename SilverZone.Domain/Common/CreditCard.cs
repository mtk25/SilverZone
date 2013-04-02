using System;

namespace SilverZone.Domain.Common
{
    public class CreditCard
    {
        public CreditCardType CardType { get; set; }

        public string CardNumber { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public string SecurityCode { get; set; }

    }

    public enum CreditCardType
    {
        None,
        Visa,
        MasterCard,
        Amex
    }
}