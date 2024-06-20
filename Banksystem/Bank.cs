using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    internal class Bank
    {
        public string Name;
        public List<Customer>Customers;
        public Bank() { }   
        public Bank(string name)
        {
            Name = name;
            Customers = new List<Customer>();
        }
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);    
        }
        //public string RemoveCustomer(Customer customer) 
        //{
        //    return customer;
        //}
        public void GetCustomerDetails() 
        {
           foreach(var customer in Customers)
            {
                customer.GetAccountDetails();                                   
            }
        }
        public void TransferFunds()
        {

        }
    }
}
