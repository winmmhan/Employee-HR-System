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
    public partial class Form6 : Form
    {
        private Post _myPost;

        public Post myPost
        {
            get { return _myPost; }
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _myPost = new Post(txt_postID.Text,txt_PostName.Text,Convert.ToDateTime(txt_PostStart.Text),Convert.ToDateTime(txt_PostEnd.Text),Convert.ToDouble(txt_PostSalary.Text));
            MessageBox.Show("New Post Object Created");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        
    }
}
