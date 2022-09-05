// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using MyBankApp;

var account = new BankAccount("rahul", 10000);
var newAccount = new BankAccount("satyam", 5000);
//Console.WriteLine(account.Owner);
Console.WriteLine($"Account [{account.Number}] was created for [{account.Owner}] with [{account.Balance}] initial balance.");
//new account 
Console.WriteLine($"Account [{newAccount.Number}] was created for [{newAccount.Owner}] with [{newAccount.Balance}] initial balance.");



account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine($"your current balance = {account.Balance}");
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine($"your current balance = {account.Balance}");

//Test that the initial balances must be positive.
BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
    return;
}


// Test for a negative balance.
try
{
    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}