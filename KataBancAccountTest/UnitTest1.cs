namespace KataBancAccountTest
{
    public class Tests
    {
        [Test]
        public void Given_An_Amount_To_Deposit_Return_Deposit()
        {
            //Arrange
            int deposit = 100;
            int expected = 100;
            BankAccount account = new BankAccount();

            //Act
            int result = account.Deposit(deposit);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Given_Two_Amounts_To_Deposit_Return_Balance()
        {
            //Arrange
            int deposit1 = 100;
            int deposit2 = 300;
            int expected = 400;
            BankAccount account = new BankAccount();

            //Act
            int result = account.Deposit(deposit1);
            result = account.Deposit(deposit2);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Given_An_Amount_To_Withdraw_Return_Balance()
        {
            //Arrange
            int deposit1 = 500;
            int withdraw = 300;
            int expected = 200;
            BankAccount account = new BankAccount();
            //Act
            int result = account.Deposit(deposit1);
            result = account.Withdraw(withdraw);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Given_An_Amount_To_Withdraw_Bigger_Than_Deposit_Return_Last_Balance()
        {
            //Arrange
            int deposit1 = 300;
            int withdraw = 500;
            int expected = 300;
            BankAccount account = new BankAccount();
            //Act
            int result = account.Deposit(deposit1);
            result = account.Withdraw(withdraw);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}