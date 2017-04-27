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
    public partial class Form3 : Form
    {
        private WeeklyPaidEmployee _WeeklyEmployee;

        public WeeklyPaidEmployee WeeklyEmployee
        {
            get { return _WeeklyEmployee; }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _WeeklyEmployee = new WeeklyPaidEmployee(txt_Id.Text, txt_Name.Text, txt_Address.Text,
                                    Convert.ToDouble(txt_Salary.Text), Convert.ToInt16(txt_Hours.Text),
                                    Convert.ToDateTime(txt_Startdate.Text),
                                    Convert.ToDateTime(txt_Enddate.Text));
            MessageBox.Show("New Employee Object Created");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

    }
}
