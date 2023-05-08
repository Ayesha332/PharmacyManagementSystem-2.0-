using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem_1_.AdministratorUC
{
    public partial class UC_A_AddMedicine : UserControl
    {

        function fn = new function();
        string query;
       // private string mname;

        public UC_A_AddMedicine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             if(txtMediId.Text!="" && txtMediName.Text!="" && txtSupplierID.Text!="" && txtQuantity.Text!="" && txtPricePerUnit.Text!="")
            {
                string mid = txtMediId.Text;
                string mname = txtMediName.Text;
                string sid = txtSupplierID.Text;
                string mdate = txtManufacturingDate.Text;
                string edate = txtExpireDate.Text;
                string sname = txtSupplierName.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricePerUnit.Text);

                query = "insert into medic(mid, mname, sid, mDate, eDate, quantity, perUnit,sname) values ('"+mid+"','"+mname+"', '"+sid+"','"+mdate+"', '"+edate+"','"+quantity+"','"+perunit+"','"+sname+"')";
                fn.setData(query, "Medicine added to Database."); 
                clearAll();
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UC_A_AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // calling clear all method over here
            clearAll();
        }
      
        public void clearAll()
        {
            txtMediId.Clear();
            txtMediName.Clear();
            txtSupplierID.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
            txtSupplierName.ResetText();
        }
    }
}

