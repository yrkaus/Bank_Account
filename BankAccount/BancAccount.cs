namespace Lecture5
{
    public class Account
    {
        public string lastname;
        public string number;
        public double percent;
        public double totalMoney;

        public Account(string accountHolder, string accountNumber, double percent, double money)
        {
            lastname = accountHolder;
            number = accountNumber;
            this.percent = percent;
            totalMoney = money;
        }

        public void ChangeAccountHolder(string newAccountHolder)
        {
            lastname = newAccountHolder;
        }

        public void PickMoney(double money)
        {
            totalMoney -= money;
        }

        public void PutMoney(double money)
        {
            totalMoney += money;
        }

        public void SetPercents()
        {
            totalMoney += totalMoney * percent;
        }

        public double ConvertToDollars(double course = 28.0)
        {
            return totalMoney / course;
        }

        public double ConvertToEuro(double course = 32.0)
        {
            return totalMoney / course;
        }

        public override string ToString()
        {
            // TODO
            return base.ToString();
        }
    }
}
