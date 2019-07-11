namespace AccountApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.NameInput = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.moneyCategoryBox = new System.Windows.Forms.ComboBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ContentInput = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.NoteInput = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.MoneyInput = new System.Windows.Forms.TextBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.DisplayPath = new System.Windows.Forms.TextBox();
            this.AccountListView = new System.Windows.Forms.ListView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpenditureView = new System.Windows.Forms.ListView();
            this.IncomeView = new System.Windows.Forms.ListView();
            this.RevenueView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(200, 50);
            this.NameInput.Multiline = true;
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(280, 32);
            this.NameInput.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("宋体", 7F);
            this.AddButton.Location = new System.Drawing.Point(50, 600);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(130, 42);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "add item";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Spending",
            "Income"});
            this.categoryBox.Location = new System.Drawing.Point(200, 100);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(280, 32);
            this.categoryBox.TabIndex = 5;
            // 
            // moneyCategoryBox
            // 
            this.moneyCategoryBox.FormattingEnabled = true;
            this.moneyCategoryBox.Items.AddRange(new object[] {
            "RMB",
            "USD",
            "JPY",
            "EUR",
            "GBP"});
            this.moneyCategoryBox.Location = new System.Drawing.Point(350, 150);
            this.moneyCategoryBox.Name = "moneyCategoryBox";
            this.moneyCategoryBox.Size = new System.Drawing.Size(130, 32);
            this.moneyCategoryBox.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(50, 50);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(58, 24);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(50, 100);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(106, 24);
            this.CategoryLabel.TabIndex = 9;
            this.CategoryLabel.Text = "Category";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(50, 150);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(82, 24);
            this.AmountLabel.TabIndex = 10;
            this.AmountLabel.Text = "Amount";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 35);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // ContentInput
            // 
            this.ContentInput.Location = new System.Drawing.Point(200, 250);
            this.ContentInput.Multiline = true;
            this.ContentInput.Name = "ContentInput";
            this.ContentInput.Size = new System.Drawing.Size(280, 130);
            this.ContentInput.TabIndex = 13;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(50, 200);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(58, 24);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "Time";
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(50, 250);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(94, 24);
            this.ContentLabel.TabIndex = 15;
            this.ContentLabel.Text = "Content";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(50, 400);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(58, 24);
            this.NoteLabel.TabIndex = 17;
            this.NoteLabel.Text = "Note";
            // 
            // NoteInput
            // 
            this.NoteInput.Location = new System.Drawing.Point(200, 400);
            this.NoteInput.Multiline = true;
            this.NoteInput.Name = "NoteInput";
            this.NoteInput.Size = new System.Drawing.Size(280, 32);
            this.NoteInput.TabIndex = 16;
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(50, 550);
            this.Path.Multiline = true;
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(430, 32);
            this.Path.TabIndex = 18;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(50, 500);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(226, 24);
            this.PathLabel.TabIndex = 19;
            this.PathLabel.Text = "Account path (add)";
            // 
            // MoneyInput
            // 
            this.MoneyInput.Location = new System.Drawing.Point(200, 150);
            this.MoneyInput.Multiline = true;
            this.MoneyInput.Name = "MoneyInput";
            this.MoneyInput.Size = new System.Drawing.Size(132, 32);
            this.MoneyInput.TabIndex = 20;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("宋体", 7F);
            this.DisplayButton.Location = new System.Drawing.Point(550, 600);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(237, 42);
            this.DisplayButton.TabIndex = 21;
            this.DisplayButton.Text = "display account";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(546, 500);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(274, 24);
            this.DisplayLabel.TabIndex = 22;
            this.DisplayLabel.Text = "Account path (display)";
            // 
            // DisplayPath
            // 
            this.DisplayPath.Location = new System.Drawing.Point(550, 550);
            this.DisplayPath.Multiline = true;
            this.DisplayPath.Name = "DisplayPath";
            this.DisplayPath.Size = new System.Drawing.Size(450, 32);
            this.DisplayPath.TabIndex = 23;
            // 
            // AccountListView
            // 
            this.AccountListView.Location = new System.Drawing.Point(550, 100);
            this.AccountListView.Name = "AccountListView";
            this.AccountListView.Size = new System.Drawing.Size(450, 332);
            this.AccountListView.TabIndex = 24;
            this.AccountListView.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(1050, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(214, 35);
            this.dateTimePicker2.TabIndex = 25;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1050, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Total expenditure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1050, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total income";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1050, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Total revenue";
            // 
            // ExpenditureView
            // 
            this.ExpenditureView.Location = new System.Drawing.Point(1050, 200);
            this.ExpenditureView.Name = "ExpenditureView";
            this.ExpenditureView.Size = new System.Drawing.Size(268, 38);
            this.ExpenditureView.TabIndex = 29;
            this.ExpenditureView.UseCompatibleStateImageBehavior = false;
            // 
            // IncomeView
            // 
            this.IncomeView.Location = new System.Drawing.Point(1050, 300);
            this.IncomeView.Name = "IncomeView";
            this.IncomeView.Size = new System.Drawing.Size(268, 38);
            this.IncomeView.TabIndex = 30;
            this.IncomeView.UseCompatibleStateImageBehavior = false;
            // 
            // RevenueView
            // 
            this.RevenueView.Location = new System.Drawing.Point(1050, 400);
            this.RevenueView.Name = "RevenueView";
            this.RevenueView.Size = new System.Drawing.Size(268, 38);
            this.RevenueView.TabIndex = 31;
            this.RevenueView.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Account item details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 705);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RevenueView);
            this.Controls.Add(this.IncomeView);
            this.Controls.Add(this.ExpenditureView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.AccountListView);
            this.Controls.Add(this.DisplayPath);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.MoneyInput);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.NoteInput);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ContentInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.moneyCategoryBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.ComboBox moneyCategoryBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox ContentInput;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.TextBox NoteInput;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox MoneyInput;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.TextBox DisplayPath;
        private System.Windows.Forms.ListView AccountListView;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ExpenditureView;
        private System.Windows.Forms.ListView IncomeView;
        private System.Windows.Forms.ListView RevenueView;
        private System.Windows.Forms.Label label4;
    }
}

