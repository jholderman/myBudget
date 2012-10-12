using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myBudget.BusinessObject
{
    public class SpendingCatagory
    {
        /// <summary>
        /// Gets or Sets the Unique Spending Catagory ID
        /// </summary>
        public int SpendingCatagoryID { get; set; }
        /// <summary>
        /// Gets or Sets the Unique User ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Gets or Sets the Catagory Name
        /// </summary>
        public string CatagoryName { get; set; }
        /// <summary>
        /// Gets or Sets the Allocated Amount of Money for the Catagory
        /// </summary>
        public decimal CatagoryLimit { get; set; }
        /// <summary>
        /// Gets or Sets the Frequency in Days for the Spending Catagory
        /// </summary>
        public int CatagoryFrequency { get; set; }

        public SpendingCatagory()
        {

        }

        public SpendingCatagory(string catagoryName, decimal catagoryLimit, int catagoryFrequency)
        {
            CatagoryName = catagoryName;
            CatagoryLimit = catagoryLimit;
            CatagoryFrequency = catagoryFrequency;
        }

    }
}
