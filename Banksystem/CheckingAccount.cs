using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    internal class CheckingAccount : Account
    {
        public CheckingAccount(int accountNumber, int customerID) : base(accountNumber,customerID)
        {
        }
    }
}
