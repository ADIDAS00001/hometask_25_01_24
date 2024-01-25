namespace hw4;

public class BankAccount
{
    int _accountld;
    decimal _balance;
    public string OwnerName {get;set;}
    bool _isFrozen;
    public BankAccount(int accountld,decimal balance,string  ownerName)
    {
        _accountld = accountld;    
        _balance=balance;
        OwnerName= ownerName;
    }
    public void Deposit(decimal amount)
    {
        
    }
}
