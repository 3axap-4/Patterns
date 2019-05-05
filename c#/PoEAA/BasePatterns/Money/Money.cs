using System;
using System.Collections.Generic;

namespace PoEAA.Money
{
    public struct Money : IEquatable<Money>, IComparable<Money>
    {
        private long _amount;
        public decimal Amount
        {
            get
            {
                return _amount / (decimal)Cents[Currency];
            }
            private set { }
        }

        public Currencies Currency { get; set; }

        private static readonly IDictionary<Currencies, int> Cents = new Dictionary<Currencies, int>
        {
            { Currencies.EUR, 100 },
            { Currencies.RUB, 100 },
            { Currencies.USD, 100 }
        };

        public Money(double amount, Currencies currency)
        {
            _amount = (long)Math.Round(amount * CentFactor(currency));
            Currency = currency;
        }

        public Money(decimal amount, Currencies currency)
        {
            _amount = (long)Math.Round(amount * CentFactor(currency));
            Currency = currency;
        }

        public Money(long amount, Currencies currency)
        {
            _amount = amount * CentFactor(currency);
            Currency = currency;
        }

        public bool Equals(Money other)
        {
            return (_amount == other._amount) 
                && (Currency == other.Currency);
        }

        public override bool Equals(object obj)
        {
            if (obj is Money)
            {
                return this.Equals((Money)obj);
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = -259941593;
            hashCode = hashCode * -1521134295 + _amount.GetHashCode();
            hashCode = hashCode * -1521134295 + Currency.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Money first, Money second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Money first, Money second)
        {
            return !(first.Equals(second));
        }

        public static Money operator +(Money first, Money second)
        {
            AssertSameCurrencyAs(first, second);

            var amount = first._amount + second._amount;
            return new Money(amount, first.Currency);
        }

        public static Money operator -(Money first, Money second)
        {
            AssertSameCurrencyAs(first, second);

            var amount = first._amount - second._amount;
            return new Money(amount, first.Currency);
        }

        public static Money operator *(Money first, double amount)
        {
            return new Money(first.Amount * (decimal)amount, first.Currency);
        }

        private static void AssertSameCurrencyAs(Money first, Money second)
        {
            if(first.Currency != second.Currency)
            {
                throw new Exception("Money currency mismatch");
            }
        }

        private static int CentFactor(Money money)
        {
            return Cents[money.Currency];
        }

        private static int CentFactor(Currencies currency)
        {
            return Cents[currency];
        }

        public int CompareTo(Money other)
        {
            AssertSameCurrencyAs(this, other);
            if (Amount < other.Amount)
            {
                return -1;
            }
            else if (Amount == other.Amount)
            {
                return 0;
            }

            else return 1;
        }
    }
}
