using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    
    public partial class Form1 : Form
    {
        int count;
        string workshop;
        double workshopFee;
        string lodgeName;
        double lodgeFee;
        double average;
        double days;
        double meal;
        string mealname;
        double cert;
        int totalbooking;

        double totalregfee;
        double totallodgefee;
        double averagerevenue;
        double valueoption;
        //decimal halfboard;
        //decimal 
        /*const ASPNETWITHC = 1200;
        const Desktop_APPS_WITH_C = 1000;
        const NET_PROG_USING_AT_PART_A = 1500;
        const NET_Prog_using_AT_PART_8 = 1800;
        const DIGITAL_DETOX = 650;
        const CORK = 150;
const DUBLIN = 225;
const GALWAY = 175;
const KILTMAGH = 295;
const LIMERICK = 135;
const WEXFORD = 89;*/

        public Form1()
        {
            InitializeComponent();
         }

        
        private void loginButton1_Click(object sender, EventArgs e)
        {
            //int count = 0;
            count += 1;
            try
            {
                string password = passwordTextBox1.Text;
                const string MATCHPASSWORD = "iLoveVisualC#";


                if ((!string.IsNullOrEmpty(password) && password == MATCHPASSWORD))
                {
                    loginPanel1.Visible = false;
                    bookinPanel2.Visible = true;
                    count = 0;
                }
                else
                {
                    if (count >= 3)
                    {
                        MessageBox.Show("You have exceeded number of attempts /nPlease try again later", "Learn2Prog -Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                      //  MessageBox.Show("You have exceeded number of attempts /nPlease try again later");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Please enter the valid password, Please remember password is case Sensitive.\n(" + count + " of 3 allowed.)", "Learn2Prog -Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        passwordTextBox1.Focus();
                        passwordTextBox1.SelectAll();
                    }
                   // passwordTextBox1.Text = "";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void exit(object sender, EventArgs e)
        {
            Close();
        }

        private void bookinPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void displayButton(object sender, EventArgs e)
        {
            //int workshop;
            //int lodge;

            /*-workShopDisplay.Text=workShopsListBox.SelectedItem.ToString();*/
            //workshop = workShopDisplay.Text;

            //string workshop = "";

            bookButton.Enabled = true;

            switch (workShopsListBox.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Listbox that are marked '*' are mandatory. Please select the workshop");
                    bookButton.Enabled = false;
                    return;
                    //break;
                    ;
                case 0:  // "ASP.NET With C#":
                    workshopFee = 1200;
                    days = 4;
                    workshop = "ASP.NET With C#";
                    // workShopDisplay.Text = workshop.ToString("C");                                         
                    break;
                case 1:// "Desktop Apps With C#":
                    workshopFee = 1000;
                    days = 3;
                    workshop = "Desktop Apps With C#";

                    //workShopDisplay.Text = workshop.ToString("C");
                    break;
                case 2://".NET Prog using at Part A":
                    workshopFee = 1500;
                    days = 3;
                    workshop = ".NET Prog using at Part A";
                    //workShopDisplay.Text = workshop.ToString("C");
                    break;
                case 3:// ".NET Prog using ar Part 8":
                    workshopFee = 1800;
                    days = 5;
                    workshop = ".NET Prog using ar Part B";
                    // workShopDisplay.Text = workshop.ToString("C");
                    break;
                case 4://"Digital Detox":
                    workshopFee = 650;
                    days = 1;
                    workshop = "Digital Detox";
                    //workShopDisplay.Text = workshop.ToString("C");
                    break;

            }

            //int lodge;

            switch (lodgeListBox2.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Listbox that are marked '*' are mandatory. Please select the Location");
                    bookButton.Enabled = false;
                    return;
                    

                case 0:
                    lodgeFee = (150 * days);
                    lodgeName = "Cork";
                    //lodgeDisplay.Text = lodge.ToString("C");
                    break;
                case 1:
                    lodgeFee = (225 * days);
                    lodgeName = "Dublin";
                    // lodgeDisplay.Text = lodge.ToString("C");
                    break;
                case 2:
                    lodgeFee = (175 * days);
                    lodgeName = "Galway";
                    //lodgeDisplay.Text = lodge.ToString("C");
                    break;
                case 3:
                    lodgeFee = (295 * days);
                    lodgeName = "Kiltimagh";
                    //lodgeDisplay.Text = lodge.ToString("C");
                    break;
                case 4:
                    lodgeFee = (135 * days);
                    lodgeName = "Limerick";
                    // lodgeDisplay.Text = lodge.ToString("C");
                    break;
                case 5:
                    lodgeFee = (89 * days);
                    lodgeName = "Wexford";
                    break;

            }

            switch (mealBox.SelectedIndex)
            {
                case -1:
                    meal = 0;
                    mealname = "NIL";
                    break;
                case 0:
                    meal = 39.50 * days;
                    mealname = "Full Meal";
                    break;
                case 1:
                    meal = 27.50 * days;
                mealname = "Half Board";
                    //lodgeDisplay.Text = lodge.ToString("C");
                    break;
                case 2:
                    meal = 12.50 * days;
                    mealname = "Break Fast";
                    // lodgeDisplay.Text = lodge.ToString("C");
                    break;
            }


           /* try
            {
                if (fullBoard.Checked == true)
                {
                    meal = 39.50 * days;
                    mealname = "Full Meal";

                }
                else if (halfBoard.Checked == true)
                {
                    meal = 27.50 * days;
                    mealname = "Half Board";
                }
                else if (breakFastButton.Checked == true)
                {
                    meal = 12.50 * days;
                    mealname = "Break Fast";
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //meal = 0;
                //mealname = "";

            }
            */
                
                if (checkBox1.Checked == true)
                {
                    cert = 29.95;
                }
                else
                {
                    cert = 0;
                }
                wsName.Text = workshop.ToString();
                locationName.Text = lodgeName.ToString();
                daysLable.Text = days.ToString();
                mealPlan.Text = mealname.ToString();

                workShopDisplay.Text = workshopFee.ToString("C");
                lodgeDisplay.Text = lodgeFee.ToString("C");
                mealDisplay.Text = meal.ToString("C");
                cirtDisplay.Text = cert.ToString("C");

                average = lodgeFee + workshopFee + meal + cert;
                averageDisplay.Text = average.ToString("C");




                /* int lodge;

                  if (workShopsListBox.SelectedIndex != -1)
                  {

                      string workshop = workShopsListBox.SelectedItem.ToString();
                      worShopDisplay.Text = workshop;

                  }

                  else
                  {
                      MessageBox.Show("Please select any");
                  }*/





            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginPanel1.Visible = true;
            bookinPanel2.Visible = false;

            bookButton.Enabled = false;
                       
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            totalbooking += 1;
            string message;
            //message = ("THE TOTAL COST IS:" + average.ToString("C") + "\nName:  " +  workshop + "\nLocation: " +  lodgeName + "\nMeal plan:  " + mealname +"\nNumber of day:  " + days);
           // MessageBox.Show(message);
            MessageBox.Show("Booking Succesfull.\nTHE TOTAL COST IS:  " + average.ToString("C") + "\nName:  " + workshop + "\nLocation: " + lodgeName + "\nMeal plan:  " + mealname + "\nNumber of day:  " + days, "Booking Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            totalregfee = average + totalregfee;
            totallodgefee = lodgeFee + totallodgefee;
            valueoption = (cert + meal) + valueoption;
            averagerevenue = totalregfee / totalbooking;

            workShopDisplay.Text = "";
            lodgeDisplay.Text = "";
            mealDisplay.Text = "";
            cirtDisplay.Text = "";
            averageDisplay.Text = "";
            wsName.Text = "";
            locationName.Text = "";
            daysLable.Text = "";
            mealPlan.Text = "";
            checkBox1.Checked = false;
            mealBox.SelectedIndex = -1;
            lodgeListBox2.SelectedIndex = -1;
            workShopsListBox.SelectedIndex = -1;

            bookButton.Enabled = false;


        }

        private void clearButton_click(object sender, EventArgs e)
        {
            workShopDisplay.Text = "";
            lodgeDisplay.Text = "";
            mealDisplay.Text = "";
            cirtDisplay.Text = "";
            averageDisplay.Text = "";
            wsName.Text = "";
            locationName.Text = "";
            daysLable.Text = "";
            mealPlan.Text = "";
            checkBox1.Checked = false;
            mealBox.SelectedIndex = -1;
            lodgeListBox2.SelectedIndex = -1;
            workShopsListBox.SelectedIndex = -1;
            totalBooking.Text = "";
            totalRegFee.Text = "";
            totalLodgingFees.Text = "";
            valueOfOptionsChosen.Text = "";
            averageRevenue.Text = "";

            bookButton.Enabled = false;


        }

        private void summaryButton_Click(object sender, EventArgs e)
        {


            totalBooking.Text = totalbooking.ToString();

            //totalregfee = average + totalregfee;  
            totalRegFee.Text = totalregfee.ToString("C");
            
            //totallodgefee = lodgeFee + totallodgefee;
            totalLodgingFees.Text = totallodgefee.ToString("C");

            //valueoption = (cert + meal) + valueoption;//doubt
            valueOfOptionsChosen.Text = valueoption.ToString("C");

            //averagerevenue = totalregfee / totalbooking;
            averageRevenue.Text = averagerevenue.ToString("C");
        }

        private void loginPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (showPassword.Checked)
            {

                passwordTextBox1.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox1.PasswordChar = '*';
            }
        }

        private void passwordTextBox1_TextChanged(object sender, EventArgs e)
        {
           // passwordTextBox1.PasswordChar =  "*";
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
           /* if (showPassword.Checked)
            {

                passwordTextBox1.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox1.PasswordChar = '*';
            }*/
        }

        private void averageDisplay_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

       

       

       
    }
}
