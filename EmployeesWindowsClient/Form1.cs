using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EmployeeLibrary;

namespace EmployeesWindowsClient
{
    public partial class Form1 : Form
    {
        static Business myBusiness = new Business();

        public Form1()
        {
            InitializeComponent();
        }

        /* * * * File ToolStrip Menu  * * * */
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Empoyeefile;

            Empoyeefile = "myEmployees.bin";
            myBusiness.SaveBusiness(Empoyeefile);

            MessageBox.Show("Employees Saved", "Saving File");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Employeefile;

            Employeefile = "myEmployees.bin";
            myBusiness.LoadBusiness(Employeefile);

            MessageBox.Show("Employees Loaded", "Loading File");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        /* ****  Add Tool Stip Menu  **** */

        // Add Employee
        private void monthlyPaidEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();

            DialogResult dr = myForm2.ShowDialog();

            // DialogResult Object; returned by the InputForm Form2
            if (dr == DialogResult.OK)
            {
                myBusiness.AddEmployee(myForm2.MonthlyEmployee.ID, myForm2.MonthlyEmployee);

                mainDisplay.Text = myForm2.MonthlyEmployee.ToString() + "\n\n Employee Successfully Added.";
            } 

            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("No Employee Added");
            }
        }

        private void weeklyPaidEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 myForm3 = new Form3();

            DialogResult dr = myForm3.ShowDialog();

            if (dr == DialogResult.OK)
            {
                myBusiness.AddEmployee(myForm3.WeeklyEmployee.ID, myForm3.WeeklyEmployee);

                mainDisplay.Text = myForm3.WeeklyEmployee.ToString() + "\n\n Employee Successfully Added.";
            }

            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("No Employee Added");
            }
        }

        private void hourlyPaidEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 myForm4 = new Form4();

            DialogResult dr = myForm4.ShowDialog();

            if (dr == DialogResult.OK)
            {
                myBusiness.AddEmployee(myForm4.HourlyEmployee.ID, myForm4.HourlyEmployee);
                mainDisplay.Text = myForm4.HourlyEmployee.ToString() + "\n\n Employee Successfully Added.";
            }

            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("No Employee Added");
            }
        }

        private void tempHourlyPaidEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 myForm5 = new Form5();

            DialogResult dr = myForm5.ShowDialog();

            if (dr == DialogResult.OK)
            {
                myBusiness.AddEmployee(myForm5.TemporaryHourlyEmployee.ID, myForm5.TemporaryHourlyEmployee);
                mainDisplay.Text = myForm5.TemporaryHourlyEmployee.ToString() + "\n\n Employee Successfully Added.";
            }

            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("No Employee Added");
            }
        }

        // Add Post
        private void addpostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string eId;
            Form8 myForm8 = new Form8();
            DialogResult dr = myForm8.ShowDialog();

            if (dr == DialogResult.OK)
            {
                eId = myForm8.myEmployeeID;

                Employee myEmployee;

                myEmployee = myBusiness.SelectEmployee(eId);

                if (myEmployee is IPostHistory)
                {
                    Form6 myForm6 = new Form6();

                    DialogResult dr1 = myForm6.ShowDialog();

                    if (dr1 == DialogResult.OK)
                    {
                        myBusiness.AddPost(myEmployee.ID, myForm6.myPost.ID, myForm6.myPost);
                        mainDisplay.Text = myForm6.myPost.ToString() + "\n\n Post Successfully Added.";
                    }
                    if (dr1 == DialogResult.Cancel)
                    {
                        MessageBox.Show("No Post Added");
                    }
                }
                else
                {
                    mainDisplay.Text = "Post Cannot be Entered as Employee doesnot have Post History!!";
                }
            }

            
        }

        
        /* * * * Remove ToolStrip Menu  * * * */
 
        //Remove Employee
        private void removeemployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string eId;

            MessageBox.Show("Remove Employee \n\n Press OK to continue", "Collection Update");

            Form8 myForm8 = new Form8();
            DialogResult dr = myForm8.ShowDialog();

            if (dr == DialogResult.OK)
            {
                eId = myForm8.myEmployeeID;

                myBusiness.RemoveEmployee(eId);

                MessageBox.Show("Employee successfully removed", "Collection Update");
            }

        }
        //Remove Post
        private void removepostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string eId;
            Employee myEmployee;

            MessageBox.Show("Remove Post \n\n Press OK to continue", "Collection Update");

            Form8 myForm8 = new Form8();
            DialogResult dr = myForm8.ShowDialog();

            if (dr == DialogResult.OK)
            {
                eId = myForm8.myEmployeeID;

                myEmployee = myBusiness.SelectEmployee(eId);

                if (myEmployee is IPostHistory)
                {
                    Form7 myForm7 = new Form7();

                    DialogResult dr1 = myForm7.ShowDialog();

                    if (dr1 == DialogResult.OK)
                    {
                        myBusiness.RemovePost(myEmployee.ID, myForm7.mypostID);
                        mainDisplay.Text = "Post Successfully Removed!!";
                    }

                    if (dr1 == DialogResult.Cancel)
                    {
                        MessageBox.Show("No Post Removed");
                    }
                }
                else
                {
                    mainDisplay.Text = "Employee doesn't have the post to remove!!";
                }
            }
        }
        /* * * * Display ToolStrip Menu  * * * */

        // Display individual employee
        private void displayEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string eId;
            string myDisplay = "";
            Employee myEmployee;

            Form8 myForm8 = new Form8();
            DialogResult dr = myForm8.ShowDialog();

            if (dr == DialogResult.OK)
            {
                eId = myForm8.myEmployeeID;
                myEmployee = myBusiness.SelectEmployee(eId);

                myDisplay = myDisplay + "\n\t" + myEmployee.ToString() + "\n";

                if (myEmployee is IPostHistory)
                {
                    IPostHistory myIPostHistoryEmployee = (IPostHistory)myEmployee;

                    myDisplay = myDisplay + "\t\t Posts \n";
                    foreach (Post myPost in myIPostHistoryEmployee.PostHistory)
                    {
                        myDisplay = myDisplay + "\t\t" + myPost.ToString() + "\n";
                    }
                    myDisplay = myDisplay + "\n";
                }
                mainDisplay.Text = myDisplay;
                sslDisplayInfo.Text = "Employee Displayed";
            }
        }

        // Display all employee
        private void allEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees myEmployees = myBusiness.Employees;
            string myDisplay = "";

            foreach (Employee myEmployee in myEmployees)
            {
                myDisplay = myDisplay + "\n\t" + myEmployee.ToString() + "\n";

                if (myEmployee is IPostHistory)
                {
                    IPostHistory myIPostHistoryEmployee = (IPostHistory)myEmployee;

                    myDisplay = myDisplay + "\t \t Posts \n";
                    foreach (Post myPost in myIPostHistoryEmployee.PostHistory)
                    {
                        myDisplay = myDisplay + "\t\t" + myPost.ToString() + "\n";
                    }
                    myDisplay = myDisplay + "\n";
                }
            }

            mainDisplay.Text = myDisplay;
            sslDisplayInfo.Text = "Record Count: " + myEmployees.Count.ToString();
        }

        // Display iPostHistory employee
        private void iPostHistoryEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees myEmployees = myBusiness.ReturnIPostHistoryEmployees();
            string myDisplay = "";

            foreach (Employee myEmployee in myEmployees)
            {
                IPostHistory myIPostHistoryEmployee = (IPostHistory)myEmployee;
                myDisplay = myDisplay + "\n\t" + myEmployee.ToString() + "\n";
                myDisplay = myDisplay + "\t\t Posts \n";

                foreach (Post myPost in myIPostHistoryEmployee.PostHistory)
                {
                    myDisplay = myDisplay + "\t\t" + myPost.ToString() + "\n";
                }
                myDisplay = myDisplay + "\n";
            }

            mainDisplay.Text = myDisplay;
            sslDisplayInfo.Text = "Record Count: " + myEmployees.Count.ToString();
        }

        /* * * * Calculate ToolStrip Menu  * * * */
        //Calculate
        private void totalWeeklyPayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double allEmpTotalWeeklyPay = myBusiness.totalweeklypay();

            mainDisplay.Text = "All Employees Total Weekly Wages is : \t" + "£" + Convert.ToString(allEmpTotalWeeklyPay);
        }

        /* * * * About ToolStrip Menu  * * * */
        // About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The WHan Generic Employee HR System, v1", "System Information");
        }

        // Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            mainDisplay.Text = "";
            sslDisplayInfo.Text = "";
        }
  
    }
}
