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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_A_Dashboard1.Visible = true;
            uC_A_Dashboard1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_A_Dashboard1.Visible = false;
            uC_A_ViewMedicine1.Visible = false;
            med.Visible = false;
            uC_A_MedicineValidityCheck1.Visible = false;
            uC_A_OrderMedicine1.Visible =false;
            uC_A_ViewOrders1.Visible = false;
            btnDashoard.PerformClick();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            med.Visible = true;
            med.BringToFront();
        }

        private void txtMediId_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_A_ViewMedicine1.Visible = true;
            uC_A_ViewMedicine1.BringToFront();
            // view.Visible = true;
           // view.BringToFront();
        }

        private void btnMedValidityCheck_Click(object sender, EventArgs e)
        {
            uC_A_MedicineValidityCheck1.Visible = true;
            uC_A_MedicineValidityCheck1.BringToFront();
        }

        private void btnOrderMedicine_Click(object sender, EventArgs e)
        {
            uC_A_OrderMedicine1.Visible = true;
            uC_A_OrderMedicine1.BringToFront();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            uC_A_ViewOrders1.Visible = true;
            uC_A_ViewOrders1.BringToFront();
        }

        private void uC_A_ViewOrders1_Load(object sender, EventArgs e)
        {

        }
    }
}
