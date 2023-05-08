using PharmacyManagementSystem_1_.CashierUC;
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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }


        public Cashier(String patients)
        {
            InitializeComponent();
        }
        private void Cashier_Load(object sender, EventArgs e)
        {
            //uC_Dashboard1.Visible = false;
            uC_AddPatient1.Visible = false;
            uC_ViewPatient1.Visible = false;
            uC_A_MedicineValidityCheck1.Visible = false;
            uC_C_SellMedicine1.Visible = false;
            uC_C_Dashboard1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_C_SellMedicine1.Visible = true;
            uC_C_SellMedicine1.BringToFront();
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            uC_AddPatient1.Visible = true;
            uC_AddPatient1.BringToFront();
        }

        private void uC_AddPatient1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_C_Dashboard1.Visible= true;
            uC_C_Dashboard1.BringToFront();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            uC_ViewPatient1.Visible = true;
            uC_ViewPatient1.BringToFront();
        }

        private void uC_ViewPatient1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_A_MedicineValidityCheck1.Visible = true;
            uC_A_MedicineValidityCheck1.BringToFront();


        }

        private void uC_C_Dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
