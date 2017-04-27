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
    public partial class Form5 : Form
    {
        private TemporaryHourlyPaidEmployee _TemporaryHourlyEmployee;

        public TemporaryHourlyPaidEmployee TemporaryHourlyEmployee
        {
            get { return _TemporaryHourlyEmployee; }
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _TemporaryHourlyEmployee = new TemporaryHourlyPaidEmployee(txt_Id.Text, txt_Name.Text, txt_Address.Text,
                                    Convert.ToDouble(txt_HourlyRate.Text), Convert.ToInt16(txt_Hours.Text),
                                    Convert.ToDouble(txt_ORate.Text), Convert.ToDateTime(txt_Startdate.Text),
                                    Convert.ToDateTime(txt_Enddate.Text));
            MessageBox.Show("New Employee Object Created");
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
