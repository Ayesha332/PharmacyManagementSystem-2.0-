using PharmacyManagementSystem_1_.AdministratorUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem_1_
{
    public partial class Form1 : Form
    {
        function fn = new function();
       // string query;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {   //calling on clear method
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "Administrator" && password == "pass")
            {
                // Open the administrator page and hide Form 1
                Administrator adminForm = new Administrator();
                adminForm.Show();
                this.Hide();
            }
            else if (username == "Cashier" && password == "cashier")
            {
                // Open the cashier page and hide Form 1
                Cashier cashierForm = new Cashier();
                cashierForm.Show();
                this.Hide();
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnSignIn_Click(object value1, object value2)
        {
            throw new NotImplementedException();
        }
    }
}

