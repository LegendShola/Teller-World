using System;

namespace TellerWorld
{   class CompoundInterest
    {
        string name;
        int accountNumber;
        int accountType;
        double amount;
        double rate, a;
        double vat = 7.5;
        int time;

        public void Display()
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your account number");
            accountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount you want to save");
            amount = double.Parse(Console.ReadLine());
            AccountType();
        }

        public void AccountType()
        {
            Console.WriteLine("Choose Your Account Type");
            Console.WriteLine("1: Savings\n2: Current\n3: Fixed\n4: Kids");
            accountType = int.Parse(Console.ReadLine());

            switch (accountType)
            {
                case 1:

                    rate = 2.5 / 100;
                    time = 12;
                    a = amount * Math.Pow((1 + rate / 6), time) - vat;

                    var months = new[] { 6, 9, 12, 24, 60 };
                    foreach (var i in months)
                    {
                        Console.WriteLine($"Your Commulative Amount for {i} is: {a} ");
                        a = amount * Math.Pow((1 + rate / i), (time * i)) - vat;
                    }
                    break;

                case 2:
                    rate = 2 / 100;
                    time = 12;
                    a = amount * Math.Pow((1 + rate / 12), time) - vat;

                    var month = new[] { 6, 9, 12, 24, 60 };
                    foreach (var i in month)
                    {
                        Console.WriteLine("Your Commulative Amount for " +i +"is: " +a);
                        a = amount * Math.Pow((1 + rate / i), (time * i)) - vat;
                    }
                    break;

                case 3:
                    rate = 2.6 / 100;
                    time = 12;
                    a = amount * Math.Pow((1 + rate / 6), time) - vat;

                    var mont = new[] { 6, 9, 12, 24, 60 };
                    foreach (var i in mont)
                    {
                        Console.WriteLine($"Your Commulative Amount for {i} is: {a} ");
                        a = amount * Math.Pow((1 + rate / i), (time * i)) - vat;
                    }
                    break;

                case 4:

                    rate = 5 / 100;
                    time = 12;
                    a = amount * Math.Pow((1 + rate / 6), time) - vat;

                    var mon = new[] { 6, 9, 12, 24, 60 };
                    foreach (var i in mon)
                    {
                        Console.WriteLine($"Your Commulative Amount for {i} is: {a} ");
                        a = amount * Math.Pow((1 + rate / i), (time * i)) - vat;
                    }
                    break;

                default:

                    Console.WriteLine("Invalid Choice Try Again!!!!");
                    break;
                    Display();
            }
        }
    }

}   
