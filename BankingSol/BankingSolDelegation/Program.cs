// See https://aka.ms/new-console-template for more information
using BankingSolDelegation;

Console.WriteLine("Hello, World!");

Account acct = new Account(5000);
EventArgs e  = new EventArgs();

AccountListener accountListener = new AccountListener();
//accountListener.DeactivateAccount(acct, e);
BankingHandler masterAgent = new BankingHandler(accountListener.DeactivateAccount);


BankingHandler agent1 = new BankingHandler(accountListener.SendEmail);
BankingHandler agent2 = new BankingHandler(accountListener.SendSMS);

masterAgent += agent1;
masterAgent += agent2;

masterAgent(acct, e);