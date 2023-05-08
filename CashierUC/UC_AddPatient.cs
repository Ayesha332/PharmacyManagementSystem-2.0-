using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem_1_.CashierUC
{
    public partial class UC_AddPatient : UserControl
    {

        function fn = new function();
        String query;


        public UC_AddPatient()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddPatient_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //calling on clear method
            //  txtPatiendID.Clear();
            clearAll();
        }

        public void clearAll()
        {
            txtName.Clear();
            txtDOB.ResetText();
            txtMobileNo.Clear();
            txtEmailID.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String dob = txtDOB.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmailID.Text;
            //Int64 Pateint_ID = Int64.Parse(txtPatiendID.Text);

            try
            {
                query = "insert into patients(name,dob,mobile,email) values ('"+name+"','"+dob+"','"+mobile+"','"+email+"')";
                fn.setData(query, "Patient sucessfully added to database.");
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
                MessageBox.Show(exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPatiendID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
