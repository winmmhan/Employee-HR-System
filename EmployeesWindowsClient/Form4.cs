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
    public partial class Form4 : Form
    {
        private HourlyPaidEmployee _HourlyEmployee;

        public HourlyPaidEmployee HourlyEmployee
        {
            get { return _HourlyEmployee; }
        }

        public Form4()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            _HourlyEmployee = new HourlyPaidEmployee(txt_Id.Text, txt_Name.Text, txt_Address.Text,
                                    Convert.ToDouble(txt_HourlyRate.Text), Convert.ToInt16(txt_Hours.Text),
                                    Convert.ToDouble(txt_ORate.Text));
            MessageBox.Show("New Employee Object Created");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
