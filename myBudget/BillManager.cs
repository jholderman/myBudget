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
    public partial class BillManager : Form
    {
        public BillManager()
        {
            InitializeComponent();
        }

        private void BillManager_Load(object sender, EventArgs e)
        {
            cbFrequency.SelectedIndex = 0;
        }

        private void cbFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFrequency.SelectedItem.ToString() == "Once")
            {
                lblStartDate.Hide();
                lblEndDate.Hide();
                dtpStartDate.Hide();
                dtpEndDate.Hide();
            } else if(lblStartDate.Visible == false)
            {
                lblStartDate.Visible = true;
                lblEndDate.Visible = true;
                dtpStartDate.Visible = true;
                dtpEndDate.Visible = true;
            }
        }
    }
}
