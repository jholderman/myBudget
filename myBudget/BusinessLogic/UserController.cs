using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myBudget.BusinessObject;

namespace myBudget.BusinessLogic
{
    public class UserController : User
    {

        public List<User> Users { get; set; }

        public UserController()
        {
            Users = new List<User>();
        }

    }
}
