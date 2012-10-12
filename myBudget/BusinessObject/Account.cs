using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myBudget.BusinessObject
{
    public class Account
    {
        /// <summary>
        /// Gets or Sets the Users Account ID
        /// </summary>
        public int AccountID { get; set; }
        /// <summary>
        /// Gets or Sets the Users Unique ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Gets or Sets the Account Number
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Gets or Sets the Account Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets the Account Type (Checking, Savings)
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets the Current Balance of the Account
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// Gets or Sets the Last Account Reconcile TimeStamp
        /// </summary>
        public DateTime ReconcileTimeStamp { get; set; }

        public List<Account> Accounts { get; set; }

        public Account()
        {

        }

        /// <summary>
        /// Creates a New Account
        /// </summary>
        /// <param name="number">The Account Number</param>
        /// <param name="name">The Account Name</param>
        /// <param name="type">The Account Type (CHecking, Savings)</param>
        /// <param name="balance">The Account Balance</param>
        /// <param name="reconcileTimeStamp">The Date and Time the Account was Last Reconciled (Creation will Start a Reconcile of the Account)</param>
        public Account(int number, string name, string type, decimal balance, DateTime reconcileTimeStamp)
        {
            Number = number;
            Name = name;
            Type = type;
            Balance = balance;
            ReconcileTimeStamp = reconcileTimeStamp;
        }

    }
}
