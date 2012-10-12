using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myBudget.BusinessObject
{
    public class User
    {
        /// <summary>
        /// Gets or Sets the Users Unique ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Gets or Sets the Users Email Address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Gets or Sets the Users Password
        /// </summary>
        public string Password { get; set; }

        public User()
        {

        }

        public User(string emailAddress, string password)
        {
            EmailAddress = emailAddress;
            Password = password;
        }

    }
}
