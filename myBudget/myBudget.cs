using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myBudget
{
    public partial class myBudget : Form
    {
        public myBudget()
        {
            InitializeComponent();

            DateTime dt = GetStartOfCurrentWeek(DateTime.Now, DayOfWeek.Sunday);

            InitializeCalendar(dt);

        }

        public void InitializeCalendar(DateTime dt)
        {
            foreach (Control c in pnlCalendar.Controls)
            {
                DateTime date = dt.AddDays(double.Parse(c.Tag.ToString()) - 1);
                if (DateTime.Today == date)
                {
                    c.Text = date.ToString("ddd - MM/dd/yy");
                    c.Font = new Font(this.Font, FontStyle.Bold);
                }
                else
                {
                    c.Text = date.ToString("ddd - MM/dd/yy");
                }

            }
        }

        public DateTime GetStartOfCurrentWeek(DateTime dateInWeek, DayOfWeek startDayOfWeek)
        {

            DateTime dt = new DateTime();

            int dayOfWeek = (int)dateInWeek.DayOfWeek;
            int startOfWeek = (int)startDayOfWeek;

            int dayOffset = dayOfWeek - startOfWeek;

            if (dayOffset >= dateInWeek.Day)
            {

                if ((dateInWeek.Month - 1) == 0)
                {
                    int totalDaysInPrevMonth = DateTime.DaysInMonth((dateInWeek.Year - 1), 12);

                    dt = new DateTime(dateInWeek.Year, 12, (totalDaysInPrevMonth - (dayOffset - dateInWeek.Day)));
                }
                else
                {
                    int totalDaysInPrevMonth = DateTime.DaysInMonth(dateInWeek.Year, (dateInWeek.Month - 1));

                    dt = new DateTime(dateInWeek.Year, (dateInWeek.Month - 1), (totalDaysInPrevMonth - (dayOffset - dateInWeek.Day)));
                }

            }
            else
            {
                dt = new DateTime(dateInWeek.Year, dateInWeek.Month, (dateInWeek.Day - dayOffset));
            }

            return dt;

        }

        private void miRegister_RegisterManager_Click(object sender, EventArgs e)
        {
            RegisterManager rm = new RegisterManager();
            rm.ShowDialog();
        }

        private void miBills_BillManager_Click(object sender, EventArgs e)
        {
            BillManager bm = new BillManager();
            bm.ShowDialog();
        }

        private void miFile_New_Click(object sender, EventArgs e)
        {
            NewBudgetWizard nbm = new NewBudgetWizard();
            nbm.ShowDialog();
        }

    }
}
