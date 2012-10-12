using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using myBudget.BusinessObject;
using myBudget.BusinessLogic;

namespace myBudget
{
    public partial class NewBudgetWizard : Form
    {

        public int CurrentStep { get; set; }

        public Account TempAccount = new Account();
        public AccountController TempAccountController = new AccountController();

        public SpendingCatagory TempSpendingCatagory = new SpendingCatagory();
        public SpendingCatagoryController TempSpendingCatagoryController = new SpendingCatagoryController();

        public Bill TempBill = new Bill();
        public BillController TempBillController = new BillController();

        public User TempUser = new User();
        public UserController TempUserController = new UserController();

        public NewBudgetWizard()
        {

            ////
            // All Steps
            ////

            InitializeComponent();
            CurrentStep = 1;
            pnlStepOne.Visible = true;
            pnlStepTwo.Visible = false;
            pnlStepThree.Visible = false;
            pnlStepFour.Visible = false;
            btnBack.Enabled = false;

            ////
            // Step 1
            ////

            cbxAccountType.Items.Add("Checking");
            cbxAccountType.Items.Add("Savings");
            cbxAccountType.SelectedIndex = 0;

            ////
            // Step 2
            ////
            
            cbxSpendingFrequency.Items.Add("Monthly");
            cbxSpendingFrequency.Items.Add("Weekly");
            cbxSpendingFrequency.SelectedIndex = 0;

            ////
            // Step 3
            ////

            cbxBillFrequency.Items.Add("Monthly");
            cbxBillFrequency.Items.Add("Bi-Weekly");
            cbxBillFrequency.Items.Add("Weekly");
            cbxBillFrequency.Items.Add("Once");

            dtpBillDueDate.Value = DateTime.Today;
            dtpBillEndDate.Value = DateTime.Today.AddYears(1);
            dtpBillStartDate.Value = DateTime.Today;

            cbxBillFrequency.SelectedIndex = 0;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (btnNext.Text == "Finish")
            {
                createUserList(tbxEmailAddress.Text, mtbxPassword.Text);
                //uploadBudgetToDatabase(User TempUser, List<Account> listAccounts, List<SpendingCatagory> listSpending, List<Bill> listBills);
                uploadBudgetToDB(TempUser, TempAccount)
            }
            else
            {

                CurrentStep++;
                switch (CurrentStep)
                {
                    case 1:
                        pnlStepOne.Visible = true;
                        pnlStepTwo.Visible = false;
                        pnlStepThree.Visible = false;
                        pnlStepFour.Visible = false;
                        btnNext.Text = "Next";
                        btnBack.Enabled = false;
                        break;
                    case 2:
                        pnlStepOne.Visible = false;
                        pnlStepTwo.Visible = true;
                        pnlStepThree.Visible = false;
                        pnlStepFour.Visible = false;
                        btnNext.Text = "Next";
                        btnBack.Enabled = true;
                        createAccountList(lvAccounts);
                        break;
                    case 3:
                        pnlStepOne.Visible = false;
                        pnlStepTwo.Visible = false;
                        pnlStepThree.Visible = true;
                        pnlStepFour.Visible = false;
                        btnNext.Text = "Next";
                        btnBack.Enabled = true;
                        createSpendingCatagoryList(lvSpendingCatagories);
                        fillBillCatagoryControlWithValues(TempSpendingCatagoryController);
                        cbxBillCatagory.SelectedIndex = 0;
                        break;
                    case 4:
                        pnlStepOne.Visible = false;
                        pnlStepTwo.Visible = false;
                        pnlStepThree.Visible = false;
                        pnlStepFour.Visible = true;
                        btnNext.Text = "Finish";
                        btnBack.Enabled = true;
                        createBillCatagoryList(lvBillOverview);

                        if (Properties.Settings.Default.SaveLocation != String.Empty)
                        {
                            tbxSaveLocation.Text = Properties.Settings.Default.SaveLocation;
                        }

                        break;
                }

            }

        }

        private void createUserList(string emailAddress, string password)
        {

            if (TempUserController.Users.Count > 0)
            {
                TempUserController.Users.Clear();
            }

            User tempUser = new User(emailAddress, password);
            TempUserController.Users.Add(tempUser);

        }

        private void createBillCatagoryList(ListView lvBillOverview)
        {

            if (TempBillController.Bills.Count > 0)
            {
                TempBillController.Bills.Clear();
            }

            string tempBillCatagoryName;
            string tempBillName;
            DateTime tempBillDueDate;
            decimal tempBillAmount;
            int tempBillFrequency;
            DateTime tempBillStartDate;
            DateTime tempBillEndDate;

            foreach (ListViewItem lvi in lvBillOverview.Items)
            {
                tempBillCatagoryName = lvi.SubItems[0].Text;
                tempBillName = lvi.SubItems[1].Text;
                tempBillDueDate = DateTime.Parse(lvi.SubItems[2].Text);
                tempBillAmount = decimal.Parse(lvi.SubItems[3].Text, NumberStyles.Currency);

                switch (lvi.SubItems[4].Text)
                {
                    case "Monthly":
                        tempBillFrequency = 30;
                        break;
                    case "Bi-Weekly":
                        tempBillFrequency = 14;
                        break;
                    case "Weekly":
                        tempBillFrequency = 7;
                        break;
                    case "Once":
                        tempBillFrequency = 0;
                        break;
                    default:
                        tempBillFrequency = 0;
                        break;
                }

                tempBillStartDate = DateTime.Parse(lvi.SubItems[5].Text);
                tempBillEndDate = DateTime.Parse(lvi.SubItems[6].Text);

                Bill tempBill = new Bill(tempBillCatagoryName, tempBillName, tempBillDueDate, tempBillAmount, tempBillFrequency, tempBillStartDate, tempBillEndDate);
                TempBillController.Bills.Add(tempBill);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CurrentStep--;
            switch (CurrentStep)
            {
                case 1:
                    pnlStepOne.Visible = true;
                    pnlStepTwo.Visible = false;
                    pnlStepThree.Visible = false;
                    pnlStepFour.Visible = false;
                    btnNext.Text = "Next";
                    btnBack.Enabled = false;
                    break;
                case 2:
                    pnlStepOne.Visible = false;
                    pnlStepTwo.Visible = true;
                    pnlStepThree.Visible = false;
                    pnlStepFour.Visible = false;
                    btnNext.Text = "Next";
                    btnBack.Enabled = true;
                    break;
                case 3:
                    pnlStepOne.Visible = false;
                    pnlStepTwo.Visible = false;
                    pnlStepThree.Visible = true;
                    pnlStepFour.Visible = false;
                    btnNext.Text = "Next";
                    btnBack.Enabled = true;
                    break;
                case 4:
                    pnlStepOne.Visible = false;
                    pnlStepTwo.Visible = false;
                    pnlStepThree.Visible = false;
                    pnlStepFour.Visible = true;
                    btnNext.Text = "Finish";
                    btnBack.Enabled = true;
                    break;
            }
        }

        /// <summary>
        /// An Event when the User Clicks on the Add Button
        /// (Step 1 in Accounts)
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnAccountAdd_Click(object sender, EventArgs e)
        {

            int newAccNumber = int.Parse(tbxAccountNumber.Text);
            string newAccName = tbxAccountName.Text;
            string newAccType = cbxAccountType.SelectedItem.ToString();
            decimal newAccBalance = decimal.Parse(tbxAccountBalance.Text, NumberStyles.Currency);
            DateTime newAccReconcileDateTime = DateTime.Today;

            string[] row = { newAccName, newAccType, String.Format("{0:c}", newAccBalance) };

            lvAccounts.Items.Add(newAccNumber.ToString()).SubItems.AddRange(row);

        }

        /// <summary>
        /// An Event when the User Leaves the Account Balace Textbox in (User to Stylize to Currency Style)
        /// (Step 1 in Accounts)
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void tbxAccountBalance_Leave(object sender, EventArgs e)
        {
            decimal newAccBalance = decimal.Parse(tbxAccountBalance.Text, NumberStyles.Currency);
            tbxAccountBalance.Text = String.Format("{0:c}", newAccBalance);
        }

        /// <summary>
        /// An Event when the Accounts List View Control Changes its Index (To Fill Textboxes with Currently Selected List View Item)
        /// (Step 1 in Accounts)
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void lvAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvAccounts.SelectedItems.Count > 0)
            {
                tbxAccountNumber.Text = lvAccounts.SelectedItems[0].SubItems[0].Text;
                tbxAccountName.Text = lvAccounts.SelectedItems[0].SubItems[1].Text;
                cbxAccountType.SelectedIndex = cbxAccountType.FindStringExact(lvAccounts.SelectedItems[0].SubItems[2].Text);
                tbxAccountBalance.Text = lvAccounts.SelectedItems[0].SubItems[3].Text;
            }

        }

        /// <summary>
        /// An Event when the user Clicks the Edit Button
        /// (Step 1 in Accounts)
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnAccountEdit_Click(object sender, EventArgs e)
        {

            if (lvAccounts.SelectedItems.Count > 0)
            {
                lvAccounts.SelectedItems[0].SubItems[0].Text = tbxAccountNumber.Text;
                lvAccounts.SelectedItems[0].SubItems[1].Text = tbxAccountName.Text;
                lvAccounts.SelectedItems[0].SubItems[2].Text = cbxAccountType.SelectedItem.ToString();
                lvAccounts.SelectedItems[0].SubItems[3].Text = tbxAccountBalance.Text;
            }

        }

        /// <summary>
        /// An Event when the user Clicks the Delete Button
        /// (Step 1 in Accounts)
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void btnAccountDelete_Click(object sender, EventArgs e)
        {

            if (lvAccounts.SelectedItems.Count > 0)
            {
                lvAccounts.SelectedItems[0].Remove();

                // Remove the Contents From the TextBox

                tbxAccountNumber.Text = String.Empty;
                tbxAccountName.Text = String.Empty;
                cbxAccountType.SelectedIndex = 0;
                tbxAccountBalance.Text = String.Empty;

            }

        }

        private void createAccountList(ListView lvAccounts)
        {

            if (TempAccountController.Accounts.Count > 0)
            {
                TempAccountController.Accounts.Clear();
            }

            foreach (ListViewItem lvi in lvAccounts.Items)
            {

                int tempAccNumber = Int32.Parse(lvi.SubItems[0].Text);
                string tempAccName = lvi.SubItems[1].Text;
                string tempAccType = lvi.SubItems[2].Text;
                decimal tempAccBalance = decimal.Parse(lvi.SubItems[3].Text, NumberStyles.Currency);

                Account tempAccount = new Account(tempAccNumber, tempAccName, tempAccType, tempAccBalance, DateTime.Today);
                TempAccountController.Accounts.Add(tempAccount);

            }

        }

        private void createSpendingCatagoryList(ListView lvSpendingCatagories)
        {

            if (TempSpendingCatagoryController.SpendingCatagories.Count > 0)
            {
                TempSpendingCatagoryController.SpendingCatagories.Clear();
            }

            foreach (ListViewItem lvi in lvSpendingCatagories.Items)
            {

                string tempCatagoryName = lvi.SubItems[0].Text;
                decimal tempCatagoryAmount = Decimal.Parse(lvi.SubItems[1].Text, NumberStyles.Currency);
                int tempCatagoryFrequency = 7;

                SpendingCatagory tempSpendingCatagory = new SpendingCatagory(tempCatagoryName, tempCatagoryAmount, tempCatagoryFrequency);
                TempSpendingCatagoryController.SpendingCatagories.Add(tempSpendingCatagory);

            }

        }

        private void btnSpendingAdd_Click(object sender, EventArgs e)
        {

            string newSpendingCatagoryName = tbxSpendingCatagoryName.Text;
            decimal newSpendingCatagoryAmount = decimal.Parse(tbxSpendingAmount.Text, NumberStyles.Currency);
            decimal newSpendingCatagoryMonthly = Decimal.Zero;
            decimal newSpendingCatagoryWeekly = Decimal.Zero;

            if (cbxSpendingFrequency.SelectedItem.ToString() == "Monthly")
            {
                newSpendingCatagoryMonthly = newSpendingCatagoryAmount;
                newSpendingCatagoryWeekly = Decimal.Divide(newSpendingCatagoryAmount, 4M);
            }
            else if (cbxSpendingFrequency.SelectedItem.ToString() == "Weekly")
            {
                newSpendingCatagoryMonthly = Decimal.Multiply(newSpendingCatagoryAmount, 4M);
                newSpendingCatagoryWeekly = newSpendingCatagoryAmount;
            }

            string[] row = { String.Format("{0:c}", newSpendingCatagoryWeekly), String.Format("{0:c}", newSpendingCatagoryMonthly) };
            lvSpendingCatagories.Items.Add(newSpendingCatagoryName).SubItems.AddRange(row);

        }

        private void btnSpendingEdit_Click(object sender, EventArgs e)
        {
            if (lvSpendingCatagories.SelectedItems.Count > 0)
            {

                string newSpendingCatagoryName = tbxSpendingCatagoryName.Text;
                decimal newSpendingCatagoryAmount = decimal.Parse(tbxSpendingAmount.Text, NumberStyles.Currency);
                decimal newSpendingCatagoryMonthly = Decimal.Zero;
                decimal newSpendingCatagoryWeekly = Decimal.Zero;

                if (cbxSpendingFrequency.SelectedItem.ToString() == "Monthly")
                {
                    newSpendingCatagoryMonthly = newSpendingCatagoryAmount;
                    newSpendingCatagoryWeekly = Decimal.Divide(newSpendingCatagoryAmount, 4M);
                }
                else if (cbxSpendingFrequency.SelectedItem.ToString() == "Weekly")
                {
                    newSpendingCatagoryMonthly = Decimal.Multiply(newSpendingCatagoryAmount, 4M);
                    newSpendingCatagoryWeekly = newSpendingCatagoryAmount;
                }

                lvSpendingCatagories.SelectedItems[0].SubItems[0].Text = newSpendingCatagoryName;
                lvSpendingCatagories.SelectedItems[0].SubItems[1].Text = String.Format("{0:c}", newSpendingCatagoryWeekly);
                lvSpendingCatagories.SelectedItems[0].SubItems[2].Text = String.Format("{0:c}", newSpendingCatagoryMonthly);
            }
        }

        private void btnSpendingDelete_Click(object sender, EventArgs e)
        {

            if (lvSpendingCatagories.SelectedItems.Count > 0)
            {
                lvSpendingCatagories.SelectedItems[0].Remove();

                // Remove the Contents From the TextBox

                tbxSpendingCatagoryName.Text = String.Empty;
                cbxAccountType.SelectedIndex = 0;
                tbxSpendingAmount.Text = String.Empty;

            }

        }

        private void lvSpendingCatagories_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvSpendingCatagories.SelectedItems.Count > 0)
            {

                tbxSpendingCatagoryName.Text = lvSpendingCatagories.SelectedItems[0].SubItems[0].Text;
                cbxSpendingFrequency.SelectedIndex = 0;
                tbxSpendingAmount.Text = lvSpendingCatagories.SelectedItems[0].SubItems[2].Text;

            }

        }

        private void fillBillCatagoryControlWithValues(SpendingCatagoryController spendingCatagories)
        {

            List<string> catagoryNames = TempSpendingCatagoryController.GetAllSpendingCatagoryNames(spendingCatagories.SpendingCatagories);

            foreach (string s in catagoryNames)
            {
                cbxBillCatagory.Items.Add(s);
            }

        }

        private void btnBillAdd_Click(object sender, EventArgs e)
        {

            string newBillTitle;
            string newBillCatagory;
            DateTime newBillDueDate;
            decimal newBillAmount;
            string newBillFrequency;
            DateTime newBillStartDate;
            DateTime newBillEndDate;

            string dateFormat = "MM-dd-yy";

            if (cbxBillFrequency.SelectedItem.ToString() == "Once")
            {
                newBillTitle = tbxBillTitle.Text;
                newBillCatagory = cbxBillCatagory.SelectedItem.ToString();
                newBillDueDate = dtpBillDueDate.Value;
                newBillAmount = decimal.Parse(tbxBillAmount.Text, NumberStyles.Currency);
                newBillFrequency = cbxBillFrequency.SelectedItem.ToString();

                // ////
                // Since the Frequency is only Once, Start and End Date Would be the Same as the Due Date
                // ////

                newBillStartDate = dtpBillDueDate.Value;
                newBillEndDate = dtpBillDueDate.Value;
            }
            else
            {
                newBillTitle = tbxBillTitle.Text;
                newBillCatagory = cbxBillCatagory.SelectedItem.ToString();
                newBillDueDate = dtpBillDueDate.Value;
                newBillAmount = decimal.Parse(tbxBillAmount.Text, NumberStyles.Currency);
                newBillFrequency = cbxBillFrequency.SelectedItem.ToString();
                newBillStartDate = dtpBillStartDate.Value;
                newBillEndDate = dtpBillEndDate.Value;
            }

            string[] row = { newBillCatagory, newBillDueDate.ToString(dateFormat), String.Format("{0:c}", newBillAmount), newBillFrequency, newBillStartDate.ToString(dateFormat), newBillEndDate.ToString(dateFormat) };
            
            lvBillOverview.Items.Add(newBillTitle).SubItems.AddRange(row); ;

        }

        private void btnBillEdit_Click(object sender, EventArgs e)
        {

            if (lvBillOverview.SelectedItems.Count > 0)
            {

                string newBillTitle;
                string newBillCatagory;
                DateTime newBillDueDate;
                decimal newBillAmount;
                string newBillFrequency;
                DateTime newBillStartDate;
                DateTime newBillEndDate;

                string dateFormat = "MM-dd-yy";

                if (cbxBillFrequency.SelectedItem.ToString() == "Once")
                {
                    newBillTitle = tbxBillTitle.Text;
                    newBillCatagory = cbxBillCatagory.SelectedItem.ToString();
                    newBillDueDate = dtpBillDueDate.Value;
                    newBillAmount = decimal.Parse(tbxBillAmount.Text, NumberStyles.Currency);
                    newBillFrequency = cbxBillFrequency.SelectedItem.ToString();

                    // ////
                    // Since the Frequency is only Once, Start and End Date Would be the Same as the Due Date
                    // ////

                    newBillStartDate = dtpBillDueDate.Value;
                    newBillEndDate = dtpBillDueDate.Value;
                }
                else
                {
                    newBillTitle = tbxBillTitle.Text;
                    newBillCatagory = cbxBillCatagory.SelectedItem.ToString();
                    newBillDueDate = dtpBillDueDate.Value;
                    newBillAmount = decimal.Parse(tbxBillAmount.Text, NumberStyles.Currency);
                    newBillFrequency = cbxBillFrequency.SelectedItem.ToString();
                    newBillStartDate = dtpBillStartDate.Value;
                    newBillEndDate = dtpBillEndDate.Value;
                }

                lvBillOverview.SelectedItems[0].SubItems[0].Text = newBillTitle;
                lvBillOverview.SelectedItems[0].SubItems[1].Text = newBillCatagory;
                lvBillOverview.SelectedItems[0].SubItems[2].Text = newBillDueDate.ToString(dateFormat);
                lvBillOverview.SelectedItems[0].SubItems[3].Text = String.Format("{0:c}", newBillAmount);
                lvBillOverview.SelectedItems[0].SubItems[4].Text = newBillFrequency;
                lvBillOverview.SelectedItems[0].SubItems[5].Text = newBillStartDate.ToString(dateFormat);
                lvBillOverview.SelectedItems[0].SubItems[6].Text = newBillEndDate.ToString(dateFormat);

            }



        }

        private void btnBillDelete_Click(object sender, EventArgs e)
        {

            if (lvBillOverview.SelectedItems.Count > 0)
            {
                lvBillOverview.SelectedItems[0].Remove();

                // Remove the Contents From the TextBox

                tbxBillTitle.Text = String.Empty;
                cbxBillCatagory.SelectedIndex = 0;
                dtpBillDueDate.Value = DateTime.Today;
                tbxBillAmount.Text = String.Format("0:c", 0);
                cbxBillFrequency.SelectedIndex = 0;
                dtpBillDueDate.Value = DateTime.Today;
                dtpBillDueDate.Value = DateTime.Today;

            }

        }

        private void lvBillOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvBillOverview.SelectedItems.Count > 0)
            {

                string newBillTitle = lvBillOverview.SelectedItems[0].SubItems[0].Text;
                string newBillCatagory = lvBillOverview.SelectedItems[0].SubItems[1].Text;
                DateTime newBillDueDate = DateTime.Parse(lvBillOverview.SelectedItems[0].SubItems[2].Text);
                decimal newBillAmount = decimal.Parse(lvBillOverview.SelectedItems[0].SubItems[3].Text, NumberStyles.Currency);
                string newBillFrequency = lvBillOverview.SelectedItems[0].SubItems[4].Text;
                DateTime newBillStartDate = DateTime.Parse(lvBillOverview.SelectedItems[0].SubItems[5].Text);
                DateTime newBillEndDate = DateTime.Parse(lvBillOverview.SelectedItems[0].SubItems[6].Text);

                if (lvBillOverview.SelectedItems[0].SubItems[4].Text == "Once")
                {
                    dtpBillStartDate.Enabled = false;
                    dtpBillEndDate.Enabled = false;
                }
                else
                {
                    dtpBillStartDate.Enabled = true;
                    dtpBillEndDate.Enabled = true;
                }

                tbxBillTitle.Text = newBillTitle;
                cbxBillCatagory.SelectedIndex = cbxBillCatagory.FindStringExact(newBillCatagory);
                dtpBillDueDate.Value = newBillDueDate;
                tbxBillAmount.Text = String.Format("0:c", newBillAmount);
                cbxBillFrequency.SelectedIndex = cbxBillFrequency.FindStringExact(newBillFrequency);
                dtpBillDueDate.Value = newBillStartDate;
                dtpBillDueDate.Value = newBillEndDate;

            }

        }

        /// <summary>
        /// When the User Selects a Value From the Bill Frequency it will Disable the End Date and Start Date Controls
        /// if the Selected Value is "Once". If Now it will Enable the Controls
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Args</param>
        private void cbxBillFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBillFrequency.SelectedItem.ToString() == "Once")
            {
                dtpBillEndDate.Enabled = false;
                dtpBillStartDate.Enabled = false;
            }
            else
            {
                dtpBillEndDate.Enabled = true;
                dtpBillStartDate.Enabled = true;
            }
        }

        private void tbxSpendingAmount_Leave(object sender, EventArgs e)
        {
            decimal newSpendingAmount = decimal.Parse(tbxSpendingAmount.Text, NumberStyles.Currency);
            tbxSpendingAmount.Text = String.Format("{0:c}", newSpendingAmount);
        }

        private void tbxBillAmount_Leave(object sender, EventArgs e)
        {
            decimal newBillAmount = decimal.Parse(tbxBillAmount.Text, NumberStyles.Currency);
            tbxBillAmount.Text = String.Format("{0:c}", newBillAmount);
        }

        private void btnSaveBrowse_Click(object sender, EventArgs e)
        {

            DialogResult result = fbdSaveLocation.ShowDialog();

            if(result == DialogResult.OK)
            {
                tbxSaveLocation.Text = fbdSaveLocation.SelectedPath;
                Properties.Settings.Default.SaveLocation = fbdSaveLocation.SelectedPath;
                Properties.Settings.Default.Save();
            }

        }

        private void tbxEmailAddress_Leave(object sender, EventArgs e)
        {
            if (!tbxEmailAddress.Text.Contains('@'))
            {
                lblErrorEmail.Text = "Not a Valid!";
            }
            else
            {
                lblErrorEmail.Text = String.Empty;
            }
        }

        private void mtbxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (mtbxPassword.Text != mtbxConfirmPassword.Text)
            {
                lblErrorPassword.Text = "Password Doesnt Match!";
            }
            else
            {
                lblErrorPassword.Text = String.Empty;
            }
        }

    }
}
