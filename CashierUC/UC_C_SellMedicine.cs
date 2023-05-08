using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem_1_.CashierUC
{
    public partial class UC_C_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        String query2;
        DataSet ds;
        public UC_C_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_C_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = " select mname from medic where eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = " select mname from medic where mname like '"+txtSearch.Text+"%' and eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }



        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnits.Clear();

            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);

            txtMediName.Text = name;
            query = " select mid,eDate,perUnit from medic where mname = '"+name+"'";
            ds = fn.getData(query);
            txtMediID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpiryDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString(); 
        }

        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {
            if(txtNoOfUnits.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNoOfUnits.Text);
                Int64 TotalAmount = unitPrice * noOfUnit;
                txtTotalPrice.Text = TotalAmount.ToString();
                totallabel.Text = "Aed. " + TotalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, TotalAmount = 0;
        protected Int64 quantity, newQuantity;

       
        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            if (txtMediID.Text != "")
            {
                query = " select quantity from medic where mid = '"+txtMediID.Text+"'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtNoOfUnits.Text);

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMediID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMediName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtPricePerUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtNoOfUnits.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtExpiryDate.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    
                    totallabel.Text = "Aed. ";

                    query = "update medic set quantity = '"+newQuantity+"' where mid = '"+txtMediID.Text+"'";
                    fn.setData(query, "Medicine Added");

                    query2 = " insert into bill values ( '" + int.Parse(txtMediID.Text) + "','" + txtMediName.Text + "','" + int.Parse(txtPricePerUnit.Text) + "','" + int.Parse(txtNoOfUnits.Text) + "','" + int.Parse(txtTotalPrice.Text) + "')";
                    fn.setData(query2, "Bill generated");

                }
                else
                {
                    MessageBox.Show("Medicine is out of stock. \n Only " + quantity + " left", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                UC_C_SellMedicine_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show(" Select Medicine First", "Information !!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        int valueAmount;
        String valueID;
        protected Int64 noOfunit;

       

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueID = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

            }
            catch
            {

            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(valueID != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid = '"+valueID+"'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfunit;

                    query = "update medic set quantity = '"+newQuantity+"' where mid = '"+valueID+"'";
                    fn.setData(query, "Medicine removed from bill.");
                    TotalAmount = TotalAmount - valueAmount;
                    totallabel.Text = "Aed. " + TotalAmount.ToString();
                }
                UC_C_SellMedicine_Load(this, null);
            }
            
        }




        private void clearAll()
        {
            txtMediID.Clear();
            txtPricePerUnit.Clear();
            txtNoOfUnits.Clear();
            txtMediName.Clear();
            txtTotalPrice.Clear();
            txtTotalPrice.Clear();
        }
    }
}
