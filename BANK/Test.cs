using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Test
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        BankAccount b1 = new BankAccount("ACC001", 1500.50m);
        BankAccount b2 = new BankAccount("ACC002", 800.00m);
        BankAccount b3 = new BankAccount("ACC003", 2100.75m);

        List<BankAccount> banks = new List<BankAccount>();
        banks.Add(b1);
        banks.Add(b2);
        banks.Add(b3);

        banks.Sort();

        foreach (var item in banks)
        {
            Console.WriteLine($"\u0421\u0447\u0451\u0442: {item.Number}, \u0411\u0430\u043b\u0430\u043d\u0441: {item.Balance}");
        }
    }
}