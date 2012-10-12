using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myBudget.BusinessObject
{
    public class Bill
    {
        /// <summary>
        /// Gets or Sets the Unique Bill ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Gets or Sets the Unique User ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Gets or Sets the Catagory for the Bill
        /// </summary>
        public string CatagoryName { get; set; }
        /// <summary>
        /// Gets or Sets the Name of the Payee for the Bill
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets the Due Date of the Bill
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Gets or Sets the Amount due for the Bill
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Gets or Sets the Duration untill the next Bill is Due in Days
        /// </summary>
        public int Frequency { get; set; }
        /// <summary>
        /// Gets or Sets the Start Date of the Bill
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or Sets the End Date of the Bill
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Gets or Sets if the Bill has been Paid
        /// </summary>
        public bool isPaid { get; set; }

        public Bill()
        {

        }

        public Bill(string catagoryName, string name, DateTime dueDate, decimal amount, int frequency, DateTime startDate, DateTime endDate)
        {
            CatagoryName = catagoryName;
            Name = name;
            DueDate = dueDate;
            Amount = amount;
            Frequency = frequency;
            StartDate = startDate;
            EndDate = endDate;
        }

    }
}
