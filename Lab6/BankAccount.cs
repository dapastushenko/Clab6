
class BankAccount
{
    private static long nextAccNo = 123;
    private long accNo;
    private decimal accBal;
    private AccountType accType;

    public void Populate(decimal balance)
    {
        accNo = nextAccNo;
        accBal = balance;
        accType = AccountType.Checking;
    }

    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    //public AccountType Type()
    //{
    //    return accType;
    //}

    public string Type()
    {
        return accType.ToString();
    }

    private static long NextNumber()
    {
        return nextAccNo++;
    }
}