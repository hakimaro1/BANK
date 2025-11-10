
using System;

public class BankAccount : IComparable<BankAccount>
{
    private decimal accBal;
    private string number;

    public BankAccount(string number, decimal balance)
    {
        this.number = number;
        accBal = balance;
    }

    public string Number => number;
    public decimal Balance => accBal;

    public int CompareTo(BankAccount? other)
    {
        if (other == null)
        {
            return 1;
        }

        return accBal.CompareTo(other.accBal);
    }
}
