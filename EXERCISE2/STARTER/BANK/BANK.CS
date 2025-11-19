using System.Collections.Generic;

namespace Banking
{
    public class Bank
    {
        private static Dictionary<long, BankAccount> accounts = new Dictionary<long, BankAccount>();

        public static long CreateAccount()
        {
            BankAccount newAcc = new BankAccount();
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }

        public static long CreateAccount(AccountType aType)
        {
            BankAccount newAcc = new BankAccount(aType);
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }

        public static long CreateAccount(decimal aBal)
        {
            BankAccount newAcc = new BankAccount(aBal);
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }

        public static long CreateAccount(AccountType aType, decimal aBal)
        {
            BankAccount newAcc = new BankAccount(aType, aBal);
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }

        public static BankAccount GetAccount(long accNo)
        {
            return accounts.ContainsKey(accNo) ? accounts[accNo] : null;
        }

        public static bool CloseAccount(long accNo)
        {
            if (accounts.Remove(accNo))
            {
                accounts[accNo].Dispose();
                return true;
            }
            return false;
        }

        private Bank() { }
    }
}
