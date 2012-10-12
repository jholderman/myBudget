using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using myBudget.BusinessObject;

namespace myBudget.BusinessLogic
{
    public class BillController : Bill
    {

        public List<Bill> Bills { get; set; }

        public BillController()
        {
            Bills = new List<Bill>();
        }

    }
}
