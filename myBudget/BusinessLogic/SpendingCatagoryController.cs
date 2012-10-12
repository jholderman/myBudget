using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using myBudget.BusinessObject;

namespace myBudget.BusinessLogic
{
    public class SpendingCatagoryController : SpendingCatagory
    {

        public List<SpendingCatagory> SpendingCatagories { get; set; }

        public SpendingCatagoryController()
        {
            SpendingCatagories = new List<SpendingCatagory>();
        }

        public List<string> GetAllSpendingCatagoryNames(List<SpendingCatagory> spendingCatagories)
        {

            List<string> spendingCatagoryNames = new List<string>();

            foreach (SpendingCatagory sc in spendingCatagories)
            {
                spendingCatagoryNames.Add(sc.CatagoryName);
            }

            return spendingCatagoryNames;

        }

    }
}
