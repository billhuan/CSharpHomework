using System;

namespace AccountApp
{
    public enum Category
    {
        Spending,
        Income,
    }

    [Serializable]
    public class AccountItem
    {

        public string Name
        {
            get; set;
        }

        public Category category;

        public string Content
        {
            get; set;
        }

        public string Note
        {
            get; set;
        }

        public Money Amount;

        public DateTime OccuredTime;

        // construct
        public AccountItem(string name, Category category, Money money)
        {
            this.Name = name;
            switch (category)
            {
                case Category.Spending:
                    this.category = Category.Spending;
                    break;
                case Category.Income:
                    this.category = Category.Income;
                    break;
                default:
                    Console.WriteLine("Haven't input the AccountItem category.");
                    break;
            }
            this.Amount = money;

            this.OccuredTime = DateTime.Now;
        }
        public AccountItem(string name, Category category, Money money, string content)
        {
            this.Name = name;
            switch (category)
            {
                case Category.Spending:
                    this.category = Category.Spending;
                    break;
                case Category.Income:
                    this.category = Category.Income;
                    break;
                default:
                    Console.WriteLine("Haven't input the AccountItem category.");
                    break;
            }
            this.Amount = money;
            this.Content = content;

            this.OccuredTime = DateTime.Now;
        }
        public AccountItem(string name, Category category, Money money, DateTime itemTime, string content, string note)
        {
            this.Name = name;
            switch (category)
            {
                case Category.Spending:
                    this.category = Category.Spending;
                    break;
                case Category.Income:
                    this.category = Category.Income;
                    break;
                default:
                    Console.WriteLine("Haven't input the AccountItem category.");
                    break;
            }
            this.Amount = money;
            this.OccuredTime = itemTime;
            this.Content = content;
            this.Note = note;
        }

        public override string ToString()
        {
            return this.Name + this.Amount.Amount + this.Amount.moneyCategory;
        }
        public string[] EachProperty()
        {
            string[] str = { this.Name, this.category.ToString(), this.Amount.Amount.ToString(), this.OccuredTime.ToString(), this.Content, this.Note };
            return str;
        }
 


    }
}
