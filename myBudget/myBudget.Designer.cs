namespace myBudget
{
    partial class myBudget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Food",
            "100",
            "200",
            "300",
            "400"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Gas",
            "800",
            "456",
            "235",
            "423"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "8452",
            "General",
            "Checking",
            "$100.25"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "5647",
            "Emergency",
            "Checking",
            "$56.78"}, -1);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lvSpendingTotals = new System.Windows.Forms.ListView();
            this.chCatagory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWeekTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrevWeekTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMonthTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrevMonthTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpSpendingTotals = new System.Windows.Forms.GroupBox();
            this.gpAccountOverview = new System.Windows.Forms.GroupBox();
            this.lvAccountOverview = new System.Windows.Forms.ListView();
            this.chAccountNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAccountType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAccountBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbWeek1Sun = new System.Windows.Forms.GroupBox();
            this.gbWeek1Mon = new System.Windows.Forms.GroupBox();
            this.gbWeek1Tue = new System.Windows.Forms.GroupBox();
            this.gbWeek1Wed = new System.Windows.Forms.GroupBox();
            this.gbWeek1Thr = new System.Windows.Forms.GroupBox();
            this.gbWeek1Fri = new System.Windows.Forms.GroupBox();
            this.gbWeek1Sat = new System.Windows.Forms.GroupBox();
            this.gbWeek2Sat = new System.Windows.Forms.GroupBox();
            this.gbWeek2Fri = new System.Windows.Forms.GroupBox();
            this.gbWeek2Thr = new System.Windows.Forms.GroupBox();
            this.gbWeek2Wed = new System.Windows.Forms.GroupBox();
            this.gbWeek2Tue = new System.Windows.Forms.GroupBox();
            this.gbWeek2Mon = new System.Windows.Forms.GroupBox();
            this.gbWeek2Sun = new System.Windows.Forms.GroupBox();
            this.pnlCalendar = new System.Windows.Forms.Panel();
            this.gpWeek2Sat = new System.Windows.Forms.GroupBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.miFile = new System.Windows.Forms.MenuItem();
            this.miFile_New = new System.Windows.Forms.MenuItem();
            this.miFile_Open = new System.Windows.Forms.MenuItem();
            this.miFile_Save = new System.Windows.Forms.MenuItem();
            this.miFile_Save_SaveAs = new System.Windows.Forms.MenuItem();
            this.miFile_Save_Save = new System.Windows.Forms.MenuItem();
            this.miFile_Seperator = new System.Windows.Forms.MenuItem();
            this.miFile_Exit = new System.Windows.Forms.MenuItem();
            this.miEdit = new System.Windows.Forms.MenuItem();
            this.miEdit_Undo = new System.Windows.Forms.MenuItem();
            this.miEdit_Redo = new System.Windows.Forms.MenuItem();
            this.miEdit_Cut = new System.Windows.Forms.MenuItem();
            this.miEdit_Copy = new System.Windows.Forms.MenuItem();
            this.miEdit_Paste = new System.Windows.Forms.MenuItem();
            this.miEdit_Delete = new System.Windows.Forms.MenuItem();
            this.miEdit_Seperator = new System.Windows.Forms.MenuItem();
            this.miEdit_Settings = new System.Windows.Forms.MenuItem();
            this.miBills = new System.Windows.Forms.MenuItem();
            this.miBills_BillManager = new System.Windows.Forms.MenuItem();
            this.miBills_BillSpending = new System.Windows.Forms.MenuItem();
            this.miRegister = new System.Windows.Forms.MenuItem();
            this.miRegister_RegisterManager = new System.Windows.Forms.MenuItem();
            this.gpSpendingTotals.SuspendLayout();
            this.gpAccountOverview.SuspendLayout();
            this.pnlCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lvSpendingTotals
            // 
            this.lvSpendingTotals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCatagory,
            this.chWeekTotal,
            this.chPrevWeekTotal,
            this.chMonthTotal,
            this.chPrevMonthTotal});
            this.lvSpendingTotals.GridLines = true;
            this.lvSpendingTotals.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSpendingTotals.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvSpendingTotals.Location = new System.Drawing.Point(6, 19);
            this.lvSpendingTotals.MultiSelect = false;
            this.lvSpendingTotals.Name = "lvSpendingTotals";
            this.lvSpendingTotals.Size = new System.Drawing.Size(441, 125);
            this.lvSpendingTotals.TabIndex = 2;
            this.lvSpendingTotals.UseCompatibleStateImageBehavior = false;
            this.lvSpendingTotals.View = System.Windows.Forms.View.Details;
            // 
            // chCatagory
            // 
            this.chCatagory.Text = "Catagory";
            this.chCatagory.Width = 100;
            // 
            // chWeekTotal
            // 
            this.chWeekTotal.Text = "Weekly Total";
            this.chWeekTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWeekTotal.Width = 80;
            // 
            // chPrevWeekTotal
            // 
            this.chPrevWeekTotal.Text = "Last Week";
            this.chPrevWeekTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPrevWeekTotal.Width = 80;
            // 
            // chMonthTotal
            // 
            this.chMonthTotal.Text = "Monthly Total";
            this.chMonthTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMonthTotal.Width = 80;
            // 
            // chPrevMonthTotal
            // 
            this.chPrevMonthTotal.Text = "Last Month";
            this.chPrevMonthTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPrevMonthTotal.Width = 80;
            // 
            // gpSpendingTotals
            // 
            this.gpSpendingTotals.Controls.Add(this.lvSpendingTotals);
            this.gpSpendingTotals.Location = new System.Drawing.Point(12, 56);
            this.gpSpendingTotals.Name = "gpSpendingTotals";
            this.gpSpendingTotals.Size = new System.Drawing.Size(453, 153);
            this.gpSpendingTotals.TabIndex = 3;
            this.gpSpendingTotals.TabStop = false;
            this.gpSpendingTotals.Text = "Spending Totals";
            // 
            // gpAccountOverview
            // 
            this.gpAccountOverview.Controls.Add(this.lvAccountOverview);
            this.gpAccountOverview.Location = new System.Drawing.Point(563, 56);
            this.gpAccountOverview.Name = "gpAccountOverview";
            this.gpAccountOverview.Size = new System.Drawing.Size(433, 153);
            this.gpAccountOverview.TabIndex = 4;
            this.gpAccountOverview.TabStop = false;
            this.gpAccountOverview.Text = "Account Overview";
            // 
            // lvAccountOverview
            // 
            this.lvAccountOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAccountNumber,
            this.chAccountName,
            this.chAccountType,
            this.chAccountBalance});
            this.lvAccountOverview.GridLines = true;
            this.lvAccountOverview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvAccountOverview.Location = new System.Drawing.Point(6, 19);
            this.lvAccountOverview.MultiSelect = false;
            this.lvAccountOverview.Name = "lvAccountOverview";
            this.lvAccountOverview.Size = new System.Drawing.Size(421, 125);
            this.lvAccountOverview.TabIndex = 2;
            this.lvAccountOverview.UseCompatibleStateImageBehavior = false;
            this.lvAccountOverview.View = System.Windows.Forms.View.Details;
            // 
            // chAccountNumber
            // 
            this.chAccountNumber.Text = "Account Number";
            this.chAccountNumber.Width = 100;
            // 
            // chAccountName
            // 
            this.chAccountName.Text = "Account Name";
            this.chAccountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAccountName.Width = 100;
            // 
            // chAccountType
            // 
            this.chAccountType.Text = "Account Type";
            this.chAccountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAccountType.Width = 100;
            // 
            // chAccountBalance
            // 
            this.chAccountBalance.Text = "Account Balance";
            this.chAccountBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chAccountBalance.Width = 100;
            // 
            // gbWeek1Sun
            // 
            this.gbWeek1Sun.Location = new System.Drawing.Point(17, 3);
            this.gbWeek1Sun.Name = "gbWeek1Sun";
            this.gbWeek1Sun.Size = new System.Drawing.Size(134, 134);
            this.gbWeek1Sun.TabIndex = 1;
            this.gbWeek1Sun.TabStop = false;
            this.gbWeek1Sun.Tag = "1";
            this.gbWeek1Sun.Text = "Wk 1 Sun";
            // 
            // gbWeek1Mon
            // 
            this.gbWeek1Mon.Location = new System.Drawing.Point(157, 3);
            this.gbWeek1Mon.Name = "gbWeek1Mon";
            this.gbWeek1Mon.Size = new System.Drawing.Size(134, 134);
            this.gbWeek1Mon.TabIndex = 2;
            this.gbWeek1Mon.TabStop = false;
            this.gbWeek1Mon.Tag = "2";
            this.gbWeek1Mon.Text = "Wk 1 Mon";
            // 
            // gbWeek1Tue
            // 
            this.gbWeek1Tue.Location = new System.Drawing.Point(297, 3);
            this.gbWeek1Tue.Name = "gbWeek1Tue";
            this.gbWeek1Tue.Size = new System.Drawing.Size(134, 134);
            this.gbWeek1Tue.TabIndex = 3;
            this.gbWeek1Tue.TabStop = false;
            this.gbWeek1Tue.Tag = "3";
            this.gbWeek1Tue.Text = "Wk 1 Tue";
            // 
            // gbWeek1Wed
            // 
            this.gbWeek1Wed.Location = new System.Drawing.Point(437, 3);
            this.gbWeek1Wed.Name = "gbWeek1Wed";
            this.gbWeek1Wed.Size = new System.Drawing.Size(134, 134);
            this.gbWeek1Wed.TabIndex = 4;
            this.gbWeek1Wed.TabStop = false;
            this.gbWeek1Wed.Tag = "4";
            this.gbWeek1Wed.Text = "Wk 1 Wed";
            // 
            // gbWeek1Thr
            // 
            this.gbWeek1Thr.Location = new System.Drawing.Point(577, 3);
            this.gbWeek1Thr.Name = "gbWeek1Thr";
            this.gbWeek1Thr.Size = new System.Drawing.Size(134, 134);
            this.gbWeek1Thr.TabIndex = 5;
            this.gbWeek1Thr.TabStop = false;
            this.gbWeek1Thr.Tag = "5";
            this.gbWeek1Thr.Text = "Wk 1 Thr";
            // 
            // gbWeek1Fri
            // 
            this.gbWeek1Fri.Location = new System.Drawing.Point(717, 3);
            this.gbWeek1Fri.Name = "gbWeek1Fri";
            this.gbWeek1Fri.Size = new System.Drawing.Size(134, 134);
            this.gbWeek1Fri.TabIndex = 6;
            this.gbWeek1Fri.TabStop = false;
            this.gbWeek1Fri.Tag = "6";
            this.gbWeek1Fri.Text = "Wk 1 Fri";
            // 
            // gbWeek1Sat
            // 
            this.gbWeek1Sat.Location = new System.Drawing.Point(857, 3);
            this.gbWeek1Sat.Name = "gbWeek1Sat";
            this.gbWeek1Sat.Size = new System.Drawing.Size(134, 134);
            this.gbWeek1Sat.TabIndex = 7;
            this.gbWeek1Sat.TabStop = false;
            this.gbWeek1Sat.Tag = "7";
            this.gbWeek1Sat.Text = "Wk 1 Sat";
            // 
            // gbWeek2Sat
            // 
            this.gbWeek2Sat.Location = new System.Drawing.Point(0, 0);
            this.gbWeek2Sat.Name = "gbWeek2Sat";
            this.gbWeek2Sat.Size = new System.Drawing.Size(134, 134);
            this.gbWeek2Sat.TabIndex = 14;
            this.gbWeek2Sat.TabStop = false;
            this.gbWeek2Sat.Text = "groupBox3";
            // 
            // gbWeek2Fri
            // 
            this.gbWeek2Fri.Location = new System.Drawing.Point(718, 143);
            this.gbWeek2Fri.Name = "gbWeek2Fri";
            this.gbWeek2Fri.Size = new System.Drawing.Size(134, 134);
            this.gbWeek2Fri.TabIndex = 13;
            this.gbWeek2Fri.TabStop = false;
            this.gbWeek2Fri.Tag = "13";
            this.gbWeek2Fri.Text = "Wk 2 Fri";
            // 
            // gbWeek2Thr
            // 
            this.gbWeek2Thr.Location = new System.Drawing.Point(578, 143);
            this.gbWeek2Thr.Name = "gbWeek2Thr";
            this.gbWeek2Thr.Size = new System.Drawing.Size(134, 134);
            this.gbWeek2Thr.TabIndex = 12;
            this.gbWeek2Thr.TabStop = false;
            this.gbWeek2Thr.Tag = "12";
            this.gbWeek2Thr.Text = "Wk 2 Thr";
            // 
            // gbWeek2Wed
            // 
            this.gbWeek2Wed.Location = new System.Drawing.Point(438, 143);
            this.gbWeek2Wed.Name = "gbWeek2Wed";
            this.gbWeek2Wed.Size = new System.Drawing.Size(134, 134);
            this.gbWeek2Wed.TabIndex = 11;
            this.gbWeek2Wed.TabStop = false;
            this.gbWeek2Wed.Tag = "11";
            this.gbWeek2Wed.Text = "Wk 2 Wed";
            // 
            // gbWeek2Tue
            // 
            this.gbWeek2Tue.Location = new System.Drawing.Point(298, 143);
            this.gbWeek2Tue.Name = "gbWeek2Tue";
            this.gbWeek2Tue.Size = new System.Drawing.Size(134, 134);
            this.gbWeek2Tue.TabIndex = 10;
            this.gbWeek2Tue.TabStop = false;
            this.gbWeek2Tue.Tag = "10";
            this.gbWeek2Tue.Text = "Wk 2 Tue";
            // 
            // gbWeek2Mon
            // 
            this.gbWeek2Mon.Location = new System.Drawing.Point(158, 143);
            this.gbWeek2Mon.Name = "gbWeek2Mon";
            this.gbWeek2Mon.Size = new System.Drawing.Size(134, 134);
            this.gbWeek2Mon.TabIndex = 9;
            this.gbWeek2Mon.TabStop = false;
            this.gbWeek2Mon.Tag = "9";
            this.gbWeek2Mon.Text = "Wk 2 Mon";
            // 
            // gbWeek2Sun
            // 
            this.gbWeek2Sun.Location = new System.Drawing.Point(18, 143);
            this.gbWeek2Sun.Name = "gbWeek2Sun";
            this.gbWeek2Sun.Size = new System.Drawing.Size(134, 134);
            this.gbWeek2Sun.TabIndex = 8;
            this.gbWeek2Sun.TabStop = false;
            this.gbWeek2Sun.Tag = "8";
            this.gbWeek2Sun.Text = "Wk 2 Sun";
            // 
            // pnlCalendar
            // 
            this.pnlCalendar.Controls.Add(this.gpWeek2Sat);
            this.pnlCalendar.Controls.Add(this.gbWeek1Sun);
            this.pnlCalendar.Controls.Add(this.gbWeek1Mon);
            this.pnlCalendar.Controls.Add(this.gbWeek2Fri);
            this.pnlCalendar.Controls.Add(this.gbWeek1Tue);
            this.pnlCalendar.Controls.Add(this.gbWeek2Thr);
            this.pnlCalendar.Controls.Add(this.gbWeek1Wed);
            this.pnlCalendar.Controls.Add(this.gbWeek2Wed);
            this.pnlCalendar.Controls.Add(this.gbWeek1Thr);
            this.pnlCalendar.Controls.Add(this.gbWeek2Tue);
            this.pnlCalendar.Controls.Add(this.gbWeek1Fri);
            this.pnlCalendar.Controls.Add(this.gbWeek2Mon);
            this.pnlCalendar.Controls.Add(this.gbWeek1Sat);
            this.pnlCalendar.Controls.Add(this.gbWeek2Sun);
            this.pnlCalendar.Location = new System.Drawing.Point(0, 362);
            this.pnlCalendar.Name = "pnlCalendar";
            this.pnlCalendar.Size = new System.Drawing.Size(1008, 290);
            this.pnlCalendar.TabIndex = 19;
            // 
            // gpWeek2Sat
            // 
            this.gpWeek2Sat.Location = new System.Drawing.Point(858, 143);
            this.gpWeek2Sat.Name = "gpWeek2Sat";
            this.gpWeek2Sat.Size = new System.Drawing.Size(134, 134);
            this.gpWeek2Sat.TabIndex = 8;
            this.gpWeek2Sat.TabStop = false;
            this.gpWeek2Sat.Tag = "14";
            this.gpWeek2Sat.Text = "Wk 2 Sat";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackgroundImage = global::myBudget.Properties.Resources.myBudget_FTR;
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 658);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1008, 50);
            this.pnlFooter.TabIndex = 21;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = global::myBudget.Properties.Resources.myBudget_HDR;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1008, 50);
            this.pnlHeader.TabIndex = 20;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miFile,
            this.miEdit,
            this.miBills,
            this.miRegister});
            // 
            // miFile
            // 
            this.miFile.Index = 0;
            this.miFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miFile_New,
            this.miFile_Open,
            this.miFile_Save,
            this.miFile_Seperator,
            this.miFile_Exit});
            this.miFile.Text = "File";
            // 
            // miFile_New
            // 
            this.miFile_New.Index = 0;
            this.miFile_New.Text = "New";
            this.miFile_New.Click += new System.EventHandler(this.miFile_New_Click);
            // 
            // miFile_Open
            // 
            this.miFile_Open.Index = 1;
            this.miFile_Open.Text = "Open";
            // 
            // miFile_Save
            // 
            this.miFile_Save.Index = 2;
            this.miFile_Save.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miFile_Save_SaveAs,
            this.miFile_Save_Save});
            this.miFile_Save.Text = "Save";
            // 
            // miFile_Save_SaveAs
            // 
            this.miFile_Save_SaveAs.Index = 0;
            this.miFile_Save_SaveAs.Text = "Save As";
            // 
            // miFile_Save_Save
            // 
            this.miFile_Save_Save.Index = 1;
            this.miFile_Save_Save.Text = "Save";
            // 
            // miFile_Seperator
            // 
            this.miFile_Seperator.Index = 3;
            this.miFile_Seperator.Text = "-";
            // 
            // miFile_Exit
            // 
            this.miFile_Exit.Index = 4;
            this.miFile_Exit.Text = "Exit";
            // 
            // miEdit
            // 
            this.miEdit.Index = 1;
            this.miEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miEdit_Undo,
            this.miEdit_Redo,
            this.miEdit_Cut,
            this.miEdit_Copy,
            this.miEdit_Paste,
            this.miEdit_Delete,
            this.miEdit_Seperator,
            this.miEdit_Settings});
            this.miEdit.Text = "Edit";
            // 
            // miEdit_Undo
            // 
            this.miEdit_Undo.Index = 0;
            this.miEdit_Undo.Text = "Undo";
            // 
            // miEdit_Redo
            // 
            this.miEdit_Redo.Index = 1;
            this.miEdit_Redo.Text = "Redo";
            // 
            // miEdit_Cut
            // 
            this.miEdit_Cut.Index = 2;
            this.miEdit_Cut.Text = "Cut";
            // 
            // miEdit_Copy
            // 
            this.miEdit_Copy.Index = 3;
            this.miEdit_Copy.Text = "Copy";
            // 
            // miEdit_Paste
            // 
            this.miEdit_Paste.Index = 4;
            this.miEdit_Paste.Text = "Paste";
            // 
            // miEdit_Delete
            // 
            this.miEdit_Delete.Index = 5;
            this.miEdit_Delete.Text = "Delete";
            // 
            // miEdit_Seperator
            // 
            this.miEdit_Seperator.Index = 6;
            this.miEdit_Seperator.Text = "-";
            // 
            // miEdit_Settings
            // 
            this.miEdit_Settings.Index = 7;
            this.miEdit_Settings.Text = "Settings";
            // 
            // miBills
            // 
            this.miBills.Index = 2;
            this.miBills.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miBills_BillManager,
            this.miBills_BillSpending});
            this.miBills.Text = "Bills";
            // 
            // miBills_BillManager
            // 
            this.miBills_BillManager.Index = 0;
            this.miBills_BillManager.Text = "Bill Manager";
            this.miBills_BillManager.Click += new System.EventHandler(this.miBills_BillManager_Click);
            // 
            // miBills_BillSpending
            // 
            this.miBills_BillSpending.Index = 1;
            this.miBills_BillSpending.Text = "Bill Spending";
            // 
            // miRegister
            // 
            this.miRegister.Index = 3;
            this.miRegister.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miRegister_RegisterManager});
            this.miRegister.Text = "Register";
            // 
            // miRegister_RegisterManager
            // 
            this.miRegister_RegisterManager.Index = 0;
            this.miRegister_RegisterManager.Text = "Register Manager";
            this.miRegister_RegisterManager.Click += new System.EventHandler(this.miRegister_RegisterManager_Click);
            // 
            // myBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlCalendar);
            this.Controls.Add(this.gpAccountOverview);
            this.Controls.Add(this.gpSpendingTotals);
            this.Controls.Add(this.statusStrip1);
            this.Menu = this.mainMenu;
            this.Name = "myBudget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myBudget";
            this.gpSpendingTotals.ResumeLayout(false);
            this.gpAccountOverview.ResumeLayout(false);
            this.pnlCalendar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView lvSpendingTotals;
        private System.Windows.Forms.ColumnHeader chCatagory;
        private System.Windows.Forms.ColumnHeader chWeekTotal;
        private System.Windows.Forms.ColumnHeader chPrevWeekTotal;
        private System.Windows.Forms.ColumnHeader chMonthTotal;
        private System.Windows.Forms.ColumnHeader chPrevMonthTotal;
        private System.Windows.Forms.GroupBox gpSpendingTotals;
        private System.Windows.Forms.GroupBox gpAccountOverview;
        private System.Windows.Forms.ListView lvAccountOverview;
        private System.Windows.Forms.ColumnHeader chAccountNumber;
        private System.Windows.Forms.ColumnHeader chAccountName;
        private System.Windows.Forms.ColumnHeader chAccountType;
        private System.Windows.Forms.ColumnHeader chAccountBalance;
        private System.Windows.Forms.GroupBox gbWeek1Sun;
        private System.Windows.Forms.GroupBox gbWeek1Mon;
        private System.Windows.Forms.GroupBox gbWeek1Tue;
        private System.Windows.Forms.GroupBox gbWeek1Wed;
        private System.Windows.Forms.GroupBox gbWeek1Thr;
        private System.Windows.Forms.GroupBox gbWeek1Fri;
        private System.Windows.Forms.GroupBox gbWeek1Sat;
        private System.Windows.Forms.GroupBox gbWeek2Sat;
        private System.Windows.Forms.GroupBox gbWeek2Fri;
        private System.Windows.Forms.GroupBox gbWeek2Thr;
        private System.Windows.Forms.GroupBox gbWeek2Wed;
        private System.Windows.Forms.GroupBox gbWeek2Tue;
        private System.Windows.Forms.GroupBox gbWeek2Mon;
        private System.Windows.Forms.GroupBox gbWeek2Sun;
        private System.Windows.Forms.Panel pnlCalendar;
        private System.Windows.Forms.GroupBox gpWeek2Sat;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem miFile;
        private System.Windows.Forms.MenuItem miFile_New;
        private System.Windows.Forms.MenuItem miFile_Open;
        private System.Windows.Forms.MenuItem miFile_Save;
        private System.Windows.Forms.MenuItem miFile_Save_SaveAs;
        private System.Windows.Forms.MenuItem miFile_Save_Save;
        private System.Windows.Forms.MenuItem miFile_Seperator;
        private System.Windows.Forms.MenuItem miFile_Exit;
        private System.Windows.Forms.MenuItem miEdit;
        private System.Windows.Forms.MenuItem miEdit_Undo;
        private System.Windows.Forms.MenuItem miEdit_Redo;
        private System.Windows.Forms.MenuItem miEdit_Cut;
        private System.Windows.Forms.MenuItem miEdit_Copy;
        private System.Windows.Forms.MenuItem miEdit_Paste;
        private System.Windows.Forms.MenuItem miEdit_Delete;
        private System.Windows.Forms.MenuItem miEdit_Seperator;
        private System.Windows.Forms.MenuItem miEdit_Settings;
        private System.Windows.Forms.MenuItem miBills;
        private System.Windows.Forms.MenuItem miBills_BillManager;
        private System.Windows.Forms.MenuItem miBills_BillSpending;
        private System.Windows.Forms.MenuItem miRegister;
        private System.Windows.Forms.MenuItem miRegister_RegisterManager;

    }
}

