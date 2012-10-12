using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using myBudget.BusinessObject;

namespace myBudget.BusinessLogic
{
    public class AccountController : Account
    {

        public List<Account> Accounts { get; set; }

        public AccountController()
        {
            Accounts = new List<Account>();
        }

    }
}
