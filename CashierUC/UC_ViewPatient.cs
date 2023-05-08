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
    public partial class UC_ViewPatient : UserControl
    {

        function fn = new function();
        String query;

        public UC_ViewPatient()
        {
            InitializeComponent();
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from patients where name like '"+txtPatients.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        private void UC_ViewPatient_Load(object sender, EventArgs e)
        {
            
            query = "select * from patients";
            DataSet ds = fn.getData(query);
           // DataSet ds = fn.getData(query);
           guna2DataGridView2.DataSource = ds.Tables[0];
        }

        String patientName;
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                patientName = guna2DataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
               
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("Are you sure?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "Delete from patients where name = '"+patientName+"'";
                fn.setData(query, "Patient record deleted.");
                UC_ViewPatient_Load(this, null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewPatient_Load(this, null);
        }
    }
}
