using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesWindowsClient
{
    public partial class Form8 : Form
    {
        private string _myEmployeeID;

        public string myEmployeeID
        {
            get
            {
                return _myEmployeeID;
            }
        }
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _myEmployeeID = txt_EmployeeID.Text; this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
