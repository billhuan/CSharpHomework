using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp
{
    [Serializable]
    public class Account
    {
        public List<AccountItem> accountList;
        public string AccountName;

        public Account()
        {
            this.accountList = new List<AccountItem>();
        }

        public void Add(AccountItem item)
        {
            this.accountList.Add(item);
        }

        public void Remove(AccountItem item)
        {
            this.accountList.Remove(item);
        }

        public Money TotalRevenue(DateTime time)
        {
            Money totalRevenue = TotalIncome(time) - TotalExpenditure(time);
            return totalRevenue;
        }

        public Money TotalExpenditure(DateTime time)
        {
            Money totalExpenditure = new Money(MoneyCategory.RMB, 0);
            foreach (AccountItem item in accountList)
            {
                if (InSameMonth(item.OccuredTime, time) && item.category == Category.Spending && item.Amount.moneyCategory == MoneyCategory.RMB)
                {
                    totalExpenditure += item.Amount;
                }
            }
            return totalExpenditure;
        }

        public Money TotalIncome(DateTime time)
        {
            Money totalIncome = new Money(MoneyCategory.RMB, 0);
            foreach (AccountItem item in accountList)
            {
                if (InSameMonth(item.OccuredTime, time) && item.category == Category.Income && item.Amount.moneyCategory == MoneyCategory.RMB)
                {
                    totalIncome += item.Amount;
                }
            }
            return totalIncome;
        }

        private bool InSameMonth(DateTime time1, DateTime time2)
        {
            if(time1.Year == time2.Year && time1.Month == time2.Month)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerator<AccountItem> GetEnumerator(DateTime time)
        {
            IEnumerable<AccountItem> accountItemsEnumerable = Display(time);
            return accountItemsEnumerable.GetEnumerator();

        }

        public IEnumerable<AccountItem> Display(DateTime time)
        {
            foreach (AccountItem item in accountList)
            {
                if (item.OccuredTime.Year == time.Year && item.OccuredTime.Month == time.Month)
                {
                    yield return item;
                }
            }

        }

    }
}
