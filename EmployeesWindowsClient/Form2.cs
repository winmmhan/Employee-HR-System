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
    public partial class Form2 : Form
    {
        private MonthlyPaidEmployee _MonthlyEmployee;

        public MonthlyPaidEmployee MonthlyEmployee
        {
            get { return _MonthlyEmployee; }
        }

        public Form2()
        {
            InitializeComponent();
        }

   
        private void btnAdd_Click(object sender, EventArgs e)
        {
          _MonthlyEmployee = new MonthlyPaidEmployee(txt_Id.Text, txt_Name.Text, txt_Address.Text, 
                                    Convert.ToDouble(txt_Salary.Text), Convert.ToDateTime(txt_Startdate.Text),
                                    Convert.ToDateTime(txt_Enddate.Text));

            MessageBox.Show("New Employee Added");

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
