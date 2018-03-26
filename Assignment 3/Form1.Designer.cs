namespace Assignment_3
{
    partial class Form1
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
            this.loginPanel1 = new System.Windows.Forms.Panel();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.loginButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.bookinPanel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mealBox = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.averageRevenue = new System.Windows.Forms.Label();
            this.valueOfOptionsChosen = new System.Windows.Forms.Label();
            this.totalLodgingFees = new System.Windows.Forms.Label();
            this.totalRegFee = new System.Windows.Forms.Label();
            this.totalBooking = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mealPlan = new System.Windows.Forms.Label();
            this.daysLable = new System.Windows.Forms.Label();
            this.locationName = new System.Windows.Forms.Label();
            this.wsName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.averageDisplay = new System.Windows.Forms.Label();
            this.cirtDisplay = new System.Windows.Forms.Label();
            this.mealDisplay = new System.Windows.Forms.Label();
            this.lodgeDisplay = new System.Windows.Forms.Label();
            this.workShopDisplay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lodgingLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lodgeListBox2 = new System.Windows.Forms.ListBox();
            this.workShopsListBox = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.loginPanel1.SuspendLayout();
            this.bookinPanel2.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel1
            // 
            this.loginPanel1.Controls.Add(this.showPassword);
            this.loginPanel1.Controls.Add(this.loginButton1);
            this.loginPanel1.Controls.Add(this.label1);
            this.loginPanel1.Controls.Add(this.passwordTextBox1);
            this.loginPanel1.Location = new System.Drawing.Point(263, 145);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(228, 131);
            this.loginPanel1.TabIndex = 0;
            this.loginPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel1_Paint);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(86, 47);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(102, 17);
            this.showPassword.TabIndex = 3;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // loginButton1
            // 
            this.loginButton1.Location = new System.Drawing.Point(86, 70);
            this.loginButton1.Name = "loginButton1";
            this.loginButton1.Size = new System.Drawing.Size(75, 23);
            this.loginButton1.TabIndex = 2;
            this.loginButton1.Text = "&Login";
            this.loginButton1.UseVisualStyleBackColor = true;
            this.loginButton1.Click += new System.EventHandler(this.loginButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Location = new System.Drawing.Point(86, 21);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(134, 20);
            this.passwordTextBox1.TabIndex = 0;
            this.passwordTextBox1.TextChanged += new System.EventHandler(this.passwordTextBox1_TextChanged);
            // 
            // bookinPanel2
            // 
            this.bookinPanel2.Controls.Add(this.label11);
            this.bookinPanel2.Controls.Add(this.label18);
            this.bookinPanel2.Controls.Add(this.label17);
            this.bookinPanel2.Controls.Add(this.label16);
            this.bookinPanel2.Controls.Add(this.mealBox);
            this.bookinPanel2.Controls.Add(this.checkBox1);
            this.bookinPanel2.Controls.Add(this.summaryGroupBox);
            this.bookinPanel2.Controls.Add(this.button6);
            this.bookinPanel2.Controls.Add(this.clearButton);
            this.bookinPanel2.Controls.Add(this.summaryButton);
            this.bookinPanel2.Controls.Add(this.bookButton);
            this.bookinPanel2.Controls.Add(this.button2);
            this.bookinPanel2.Controls.Add(this.groupBox1);
            this.bookinPanel2.Controls.Add(this.lodgeListBox2);
            this.bookinPanel2.Controls.Add(this.workShopsListBox);
            this.bookinPanel2.Location = new System.Drawing.Point(20, 12);
            this.bookinPanel2.Name = "bookinPanel2";
            this.bookinPanel2.Size = new System.Drawing.Size(733, 362);
            this.bookinPanel2.TabIndex = 1;
            this.bookinPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.bookinPanel2_Paint);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(14, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Workshop Name *";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(326, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "Meal";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label17.Location = new System.Drawing.Point(247, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "location*";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Location = new System.Drawing.Point(180, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Days";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealBox
            // 
            this.mealBox.FormattingEnabled = true;
            this.mealBox.Items.AddRange(new object[] {
            "Full Board",
            "Half Board",
            "Breakfast"});
            this.mealBox.Location = new System.Drawing.Point(326, 28);
            this.mealBox.Name = "mealBox";
            this.mealBox.Size = new System.Drawing.Size(58, 43);
            this.mealBox.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(41, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Printed certificate";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.averageRevenue);
            this.summaryGroupBox.Controls.Add(this.valueOfOptionsChosen);
            this.summaryGroupBox.Controls.Add(this.totalLodgingFees);
            this.summaryGroupBox.Controls.Add(this.totalRegFee);
            this.summaryGroupBox.Controls.Add(this.totalBooking);
            this.summaryGroupBox.Controls.Add(this.label15);
            this.summaryGroupBox.Controls.Add(this.label14);
            this.summaryGroupBox.Controls.Add(this.label13);
            this.summaryGroupBox.Controls.Add(this.label12);
            this.summaryGroupBox.Controls.Add(this.label3);
            this.summaryGroupBox.Location = new System.Drawing.Point(449, 203);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(279, 153);
            this.summaryGroupBox.TabIndex = 11;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // averageRevenue
            // 
            this.averageRevenue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.averageRevenue.Location = new System.Drawing.Point(179, 125);
            this.averageRevenue.Name = "averageRevenue";
            this.averageRevenue.Size = new System.Drawing.Size(87, 21);
            this.averageRevenue.TabIndex = 9;
            // 
            // valueOfOptionsChosen
            // 
            this.valueOfOptionsChosen.BackColor = System.Drawing.SystemColors.HighlightText;
            this.valueOfOptionsChosen.Location = new System.Drawing.Point(179, 96);
            this.valueOfOptionsChosen.Name = "valueOfOptionsChosen";
            this.valueOfOptionsChosen.Size = new System.Drawing.Size(87, 21);
            this.valueOfOptionsChosen.TabIndex = 8;
            // 
            // totalLodgingFees
            // 
            this.totalLodgingFees.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalLodgingFees.Location = new System.Drawing.Point(179, 66);
            this.totalLodgingFees.Name = "totalLodgingFees";
            this.totalLodgingFees.Size = new System.Drawing.Size(87, 22);
            this.totalLodgingFees.TabIndex = 7;
            // 
            // totalRegFee
            // 
            this.totalRegFee.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalRegFee.Location = new System.Drawing.Point(179, 44);
            this.totalRegFee.Name = "totalRegFee";
            this.totalRegFee.Size = new System.Drawing.Size(87, 17);
            this.totalRegFee.TabIndex = 6;
            // 
            // totalBooking
            // 
            this.totalBooking.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalBooking.Location = new System.Drawing.Point(179, 16);
            this.totalBooking.Name = "totalBooking";
            this.totalBooking.Size = new System.Drawing.Size(87, 22);
            this.totalBooking.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "average revenue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "value of options chosen";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "total lodging fees";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "total registration fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = " total bookings";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(330, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "&Exit";
            this.toolTip1.SetToolTip(this.button6, "closes the application");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.exit);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(249, 145);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.clearButton, "Clears all the data");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(171, 145);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(75, 23);
            this.summaryButton.TabIndex = 6;
            this.summaryButton.Text = "&Summary";
            this.toolTip1.SetToolTip(this.summaryButton, "Overall summary");
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(90, 145);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(75, 23);
            this.bookButton.TabIndex = 5;
            this.bookButton.Text = "&Book";
            this.toolTip1.SetToolTip(this.bookButton, "Confirm Booking");
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Display";
            this.toolTip1.SetToolTip(this.button2, "Display all the field ");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.displayButton);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mealPlan);
            this.groupBox1.Controls.Add(this.daysLable);
            this.groupBox1.Controls.Add(this.locationName);
            this.groupBox1.Controls.Add(this.wsName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.averageDisplay);
            this.groupBox1.Controls.Add(this.cirtDisplay);
            this.groupBox1.Controls.Add(this.mealDisplay);
            this.groupBox1.Controls.Add(this.lodgeDisplay);
            this.groupBox1.Controls.Add(this.workShopDisplay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lodgingLable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Booking";
            // 
            // mealPlan
            // 
            this.mealPlan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mealPlan.Location = new System.Drawing.Point(89, 96);
            this.mealPlan.Name = "mealPlan";
            this.mealPlan.Size = new System.Drawing.Size(111, 17);
            this.mealPlan.TabIndex = 17;
            // 
            // daysLable
            // 
            this.daysLable.BackColor = System.Drawing.SystemColors.HighlightText;
            this.daysLable.Location = new System.Drawing.Point(89, 66);
            this.daysLable.Name = "daysLable";
            this.daysLable.Size = new System.Drawing.Size(111, 22);
            this.daysLable.TabIndex = 16;
            // 
            // locationName
            // 
            this.locationName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.locationName.Location = new System.Drawing.Point(89, 44);
            this.locationName.Name = "locationName";
            this.locationName.Size = new System.Drawing.Size(111, 17);
            this.locationName.TabIndex = 15;
            // 
            // wsName
            // 
            this.wsName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.wsName.Location = new System.Drawing.Point(89, 16);
            this.wsName.Name = "wsName";
            this.wsName.Size = new System.Drawing.Size(148, 22);
            this.wsName.TabIndex = 14;
            this.wsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Meal Plan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "number of days";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "workshop";
            // 
            // averageDisplay
            // 
            this.averageDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.averageDisplay.Location = new System.Drawing.Point(337, 104);
            this.averageDisplay.Name = "averageDisplay";
            this.averageDisplay.Size = new System.Drawing.Size(60, 13);
            this.averageDisplay.TabIndex = 9;
            this.averageDisplay.Click += new System.EventHandler(this.averageDisplay_Click);
            // 
            // cirtDisplay
            // 
            this.cirtDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cirtDisplay.Location = new System.Drawing.Point(337, 83);
            this.cirtDisplay.Name = "cirtDisplay";
            this.cirtDisplay.Size = new System.Drawing.Size(60, 13);
            this.cirtDisplay.TabIndex = 8;
            // 
            // mealDisplay
            // 
            this.mealDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mealDisplay.Location = new System.Drawing.Point(337, 66);
            this.mealDisplay.Name = "mealDisplay";
            this.mealDisplay.Size = new System.Drawing.Size(60, 13);
            this.mealDisplay.TabIndex = 7;
            // 
            // lodgeDisplay
            // 
            this.lodgeDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lodgeDisplay.Location = new System.Drawing.Point(337, 44);
            this.lodgeDisplay.Name = "lodgeDisplay";
            this.lodgeDisplay.Size = new System.Drawing.Size(60, 13);
            this.lodgeDisplay.TabIndex = 6;
            // 
            // workShopDisplay
            // 
            this.workShopDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.workShopDisplay.Location = new System.Drawing.Point(337, 16);
            this.workShopDisplay.Name = "workShopDisplay";
            this.workShopDisplay.Size = new System.Drawing.Size(60, 13);
            this.workShopDisplay.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cirtificate cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Meal cost";
            // 
            // lodgingLable
            // 
            this.lodgingLable.AutoSize = true;
            this.lodgingLable.Location = new System.Drawing.Point(243, 44);
            this.lodgingLable.Name = "lodgingLable";
            this.lodgingLable.Size = new System.Drawing.Size(64, 13);
            this.lodgingLable.TabIndex = 1;
            this.lodgingLable.Text = "lodging cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "workshop cost";
            // 
            // lodgeListBox2
            // 
            this.lodgeListBox2.FormattingEnabled = true;
            this.lodgeListBox2.Items.AddRange(new object[] {
            "Cork",
            "Dublin",
            "Galway",
            "Kiltimagh",
            "Limerick",
            "Wexford"});
            this.lodgeListBox2.Location = new System.Drawing.Point(247, 28);
            this.lodgeListBox2.Name = "lodgeListBox2";
            this.lodgeListBox2.Size = new System.Drawing.Size(73, 95);
            this.lodgeListBox2.TabIndex = 1;
            // 
            // workShopsListBox
            // 
            this.workShopsListBox.FormattingEnabled = true;
            this.workShopsListBox.Items.AddRange(new object[] {
            "ASP.NET With C#                                  4",
            "Desktop Apps With C#    \t\t3",
            ".NET Prog using at Part A\t\t3",
            ".NET Prog using ar Part B\t\t5",
            "Digital Detox\t                                1"});
            this.workShopsListBox.Location = new System.Drawing.Point(14, 28);
            this.workShopsListBox.Name = "workShopsListBox";
            this.workShopsListBox.Size = new System.Drawing.Size(232, 82);
            this.workShopsListBox.TabIndex = 0;
            this.workShopsListBox.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 381);
            this.Controls.Add(this.bookinPanel2);
            this.Controls.Add(this.loginPanel1);
            this.Name = "Form1";
            this.Text = "Learn2Prog Ltd";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel1.ResumeLayout(false);
            this.loginPanel1.PerformLayout();
            this.bookinPanel2.ResumeLayout(false);
            this.bookinPanel2.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel1;
        private System.Windows.Forms.Button loginButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.Panel bookinPanel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lodgeListBox2;
        private System.Windows.Forms.ListBox workShopsListBox;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label averageDisplay;
        private System.Windows.Forms.Label cirtDisplay;
        private System.Windows.Forms.Label mealDisplay;
        private System.Windows.Forms.Label lodgeDisplay;
        private System.Windows.Forms.Label workShopDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lodgingLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label averageRevenue;
        private System.Windows.Forms.Label valueOfOptionsChosen;
        private System.Windows.Forms.Label totalLodgingFees;
        private System.Windows.Forms.Label totalRegFee;
        private System.Windows.Forms.Label totalBooking;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label mealPlan;
        private System.Windows.Forms.Label daysLable;
        private System.Windows.Forms.Label locationName;
        private System.Windows.Forms.Label wsName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox mealBox;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

