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
    public partial class Form7 : Form
    {
        private string _mypostID;

        public string mypostID
        {
            get
           {
                return _mypostID;
            }
        }
        public Form7()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _mypostID = txt_PostID.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
