using Banksystem;
using System.Security.Cryptography;
using System.Xml.Linq;

internal class Program
{
   public static Bank bank= new Bank("AJ");
    public static Account accounts=new Account();
    public static Customer cutomers=new Customer(); 
    
    static  void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Menu();
        
    }
    public static void Menu()
    {
        Console.WriteLine("1.Create a Customer 2.Create an Account 3.Deposit Funds 4.Withdraw Funds 5.Transfer Funds 6.View Customer Details 7.Exit");
        int value1 = Convert.ToInt32( Console.ReadLine());
        switch (value1)
        {
            case 1:
                CustomerCreate(); 
                break;
            case 2:
                Deposit();
                break;
            case 3:
                Deposit();
                break;
            case 4:
                Console.WriteLine("Enter Your Name");
                break;
            case 5:
                Console.WriteLine("Enter Your Name");
                break;
            case 6:
                Console.WriteLine("Enter Your Name");
                break;
        }
        
    }
    public static void CustomerCreate()
    {
      
        Console.Write("Enter Your ID :");
        string Name = Console.ReadLine();
        Console.Write("Enter Your Name :");
        string CustomerID= Console.ReadLine();
        Console.Write("Enter Your Email :");
        string Email=Console.ReadLine();
        bank.AddCustomer(new Customer(Name, CustomerID, Email));
       Console.WriteLine("Customer Create Sucessfully");
        bank.GetCustomerDetails();
        
    }
    public static void Deposit()
    {
        Console.Write("Enter Customer id :");
        int CustomerID = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your AccountNo :");
        int AccountNo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Account  :\n 1.Saving Account \n 2.Checking Account");
        Console.WriteLine("Enter :");
        int Accounts = Convert.ToInt32(Console.ReadLine());
        switch (Accounts)
        {
            case 1:
               
                SavingAccounts save=new SavingAccounts(CustomerID, AccountNo);
                Console.WriteLine("Saving Account");
                Console.WriteLine("Your Customer ID :" + save.CustomerID);
                Console.WriteLine("your Account NO :" + save.AccountNumber);
                break;
            case 2:
                CheckingAccount check = new CheckingAccount(CustomerID, AccountNo);
                Console.WriteLine("Checking" +
                    " Account");
                Console.WriteLine("Your Customer ID :"+check.CustomerID);
                Console.WriteLine("your Account NO :"+check.AccountNumber);
                break;
             default:
                Console.WriteLine("Plz Enter Your correct value");
                break;
        }
            
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Console.WriteLine("Account Create Sucessfully");

       
    }
}