using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    internal class Customer
    {
        public string CustomerID;
        public string Name;
        public string Email;
        public List<Account>accounts;

        public Customer() { }   
        public Customer( string CustomerID , string Name , string Email)
        {
            this.CustomerID = CustomerID;
            this.Name = Name;
            this.Email = Email;
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }
        public void RemoveAccount(Account account) 
        {
            accounts.Remove(account);
        }
        public void GetAccountDetails()
        {
            Console.WriteLine($"Your Account Details: {CustomerID} {Name} {Email} {accounts}");
        }
    }
}
