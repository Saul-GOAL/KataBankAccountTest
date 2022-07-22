namespace KataBancAccountTest
{
    public class BankAccount
    {
        int balance = 0;
        public int Deposit(int deposit)
        {
           balance += deposit;
            return balance;
        }

        internal int Withdraw(int withdraw)
        {
            if(withdraw < balance)
                balance -= withdraw;
            return balance; ;
        }
    }
}