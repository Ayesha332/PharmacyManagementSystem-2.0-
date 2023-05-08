using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem_1_.AdministratorUC
{
    public partial class UC_A_OrderMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_A_OrderMedicine()
        {
            InitializeComponent();
        }

        private void UC_A_OrderMedicine_Load(object sender, EventArgs e)
        {

        }

        private void txtMediId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            if (txtOrderID.Text != "" && txtMediName.Text != "" && txtSupplierID.Text != "" && txtQuantity.Text != "" && txtPricePerUnit.Text != "")
            {
                string oid = txtOrderID.Text;
                string mname = txtMediName.Text;
                string sid = txtSupplierID.Text;
                
                string sname = txtSupplierName.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricePerUnit.Text);

                query = "insert into orders(orderid, mname, sid, sname, quantity, perUnit) values ('" + oid + "','" + mname + "', '" + sid + "','" + sname+ "','" + quantity + "','" + perunit + "')";
                fn.setData(query, "Order added to Database.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtOrderID.Clear();
            txtMediName.Clear();
            txtSupplierID.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtSupplierName.Clear();
        }
    }
}
