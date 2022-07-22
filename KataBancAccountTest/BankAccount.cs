namespace KataBancAccountTest
{
    public class BankAccount
    {
        private int _balance;
        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public void Deposit(int deposit)
        {
           Balance += deposit;
        }

        public void Withdraw(int withdraw)
        {
            if(withdraw < Balance)
                Balance -= withdraw;
        }
    }
}