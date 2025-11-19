using System;
using Banking;

class CreateAccount
{
    static void Main()
    {
        try
        {
            // Создание счёта
            long accNo = Bank.CreateAccount(AccountType.Savings, 1000);
            BankAccount acc = Bank.GetAccount(accNo);

            // Операции
            acc.Deposit(500);
            acc.Withdraw(200);

            // Вывод результата
            Console.WriteLine($"Счёт №{acc.Number()}");
            Console.WriteLine($"Тип: {acc.Type()}");
            Console.WriteLine($"Баланс: {acc.Balance():C}");

            Console.WriteLine("\nТранзакции:");
            foreach (BankTransaction tran in acc.Transactions())
            {
                Console.WriteLine($"{tran.When()}\t{tran.Amount():C}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}
