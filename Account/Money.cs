using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp
{
    public enum MoneyCategory
    {
        RMB,
        USD,
        JPY,
        EUR,
        GBP
    }

    [Serializable]
    public class Money
    {
        public double Amount;
        public MoneyCategory moneyCategory;

        public Money(MoneyCategory moneyCategory, double amount)
        {
            Amount = amount;

            switch (moneyCategory)
            {
                case MoneyCategory.RMB:
                    this.moneyCategory = MoneyCategory.RMB;
                    break;
                case MoneyCategory.USD:
                    this.moneyCategory = MoneyCategory.USD;
                    break;
                case MoneyCategory.JPY:
                    this.moneyCategory = MoneyCategory.JPY;
                    break;
                case MoneyCategory.EUR:
                    this.moneyCategory = MoneyCategory.EUR;
                    break;
                case MoneyCategory.GBP:
                    this.moneyCategory = MoneyCategory.GBP;
                    break;
                default:
                    Console.WriteLine("Haven't input the money category.");
                    break;
            }
        }

        public static Money operator +(Money a, Money b)
        {
            if (a.moneyCategory != b.moneyCategory)
            {
                ArgumentException moneyEx = new ArgumentException();
                throw moneyEx;
            }
            double resultAccount = a.Amount + b.Amount;
            Money result = new Money(a.moneyCategory, resultAccount);
            return result;
        }

        public static Money operator -(Money a, Money b)
        {
            if (a.moneyCategory != b.moneyCategory)
            {
                ArgumentException moneyEx = new ArgumentException();
                throw moneyEx;
            }
            double resultAccount = a.Amount - b.Amount;
            Money result = new Money(a.moneyCategory, resultAccount);
            return result;
        }

    }
}
