using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace AccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Text))
            {
                Account newAccount = new Account();
                SaveAccount(newAccount, Path.Text);
            }

            Account account = OpenAccount(Path.Text);

            Category selectedCategory = (Category)Enum.Parse(typeof(Category), categoryBox.SelectedItem.ToString());
            MoneyCategory selectedMoneyCategory = (MoneyCategory)Enum.Parse(typeof(MoneyCategory), moneyCategoryBox.SelectedItem.ToString());
            Money money = new Money(selectedMoneyCategory, Convert.ToDouble(MoneyInput.Text));
            AccountItem item = new AccountItem(NameInput.Text, selectedCategory, money, dateTimePicker1.Value, ContentInput.Text, NoteInput.Text);

            account.Add(item);

            SaveAccount(account, Path.Text);
        }

        private Account OpenAccount(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Account account = bf.Deserialize(fs) as Account;
            fs.Close();
            return account;
        }

        private void SaveAccount(Account account, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, account);
            fs.Close();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            InitialListView(AccountListView);
            Account account = OpenAccount(DisplayPath.Text);

            foreach (AccountItem item in account.accountList)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = item.Name;
                lvi.SubItems.Add(item.category.ToString());
                lvi.SubItems.Add(item.Amount.Amount.ToString()+item.Amount.moneyCategory.ToString());
                lvi.SubItems.Add(item.OccuredTime.ToString());
                lvi.SubItems.Add(item.Content);
                lvi.SubItems.Add(item.Note);

                AccountListView.Items.Add(lvi);
            }
        }

        private void InitialListView(ListView list)
        {
            ColumnHeader c1 = new ColumnHeader();
            c1.Width = 100;
            c1.Text = "Name";

            ColumnHeader c2 = new ColumnHeader();
            c2.Width = 100;
            c2.Text = "Category";

            ColumnHeader c3 = new ColumnHeader();
            c3.Width = 100;
            c3.Text = "Money";

            ColumnHeader c4 = new ColumnHeader();
            c4.Width = 100;
            c4.Text = "Time";

            ColumnHeader c5 = new ColumnHeader();
            c5.Width = 100;
            c5.Text = "Content";

            ColumnHeader c6 = new ColumnHeader();
            c6.Width = 100;
            c6.Text = "Note";

            AccountListView.GridLines = true;  //显示网格线
            AccountListView.FullRowSelect = true;  //显示全行
            AccountListView.MultiSelect = false;  //设置只能单选
            AccountListView.View = View.Details;  //设置显示模式为详细
            AccountListView.HoverSelection = true;  //当鼠标停留数秒后自动选择

            AccountListView.Columns.Add(c1);
            AccountListView.Columns.Add(c2);
            AccountListView.Columns.Add(c3);
            AccountListView.Columns.Add(c4);
            AccountListView.Columns.Add(c5);
            AccountListView.Columns.Add(c6);
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (File.Exists(DisplayPath.Text))
            {
                Account account = OpenAccount(DisplayPath.Text);

                ExpenditureView.Items.Clear();
                IncomeView.Items.Clear();
                RevenueView.Items.Clear();

                ExpenditureView.Items.Add(account.TotalExpenditure(dateTimePicker2.Value).Amount.ToString() + "RMB");
                IncomeView.Items.Add(account.TotalIncome(dateTimePicker2.Value).Amount.ToString() + "RMB");
                RevenueView.Items.Add(account.TotalRevenue(dateTimePicker2.Value).Amount.ToString() + "RMB");
            }
        }
    }
}
