using Guna.UI2.WinForms;
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
    public partial class UC_A_ViewMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_A_ViewMedicine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       public String MedicineName;
       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "Delete from medic where mname = '" + MedicineName + "'";
                fn.setData(query, "Patient record deleted.");
                UC_A_ViewMedicine_Load(this, null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_A_ViewMedicine_Load(this, null);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '" + txtName.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MedicineName = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
            catch
            {

            }
        }

        private void UC_A_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            DataSet ds = fn.getData(query);

            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
