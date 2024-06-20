using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    public class SavingAccounts : Account
    {
        public SavingAccounts(int accountNumber,int customerID) : base(accountNumber, customerID)
        {
            this.CustomerID = customerID;   
            this.AccountNumber = accountNumber;
        }
    }
}
