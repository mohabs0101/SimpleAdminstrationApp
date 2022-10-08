using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adminstrator
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void users_managmentBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users_Managment um = new Users_Managment();

            um.Show();

  
        }

        private void departmentmanagmentBTN_Click(object sender, EventArgs e)
        {

            this.Hide();
            Departments_manager dm = new Departments_manager();
            dm.Show();


        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Departments_manager dm = new Departments_manager();
            dm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users_Managment um = new Users_Managment();

            um.Show();

        }
    }
}
