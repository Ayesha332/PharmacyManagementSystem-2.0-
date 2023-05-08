using Guna.UI2.WinForms;
using System;
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
    public partial class UC_A_MedicineValidityCheck : UserControl
    {

        function fn = new function();
        String query;

        public UC_A_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {

        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCheck.SelectedIndex == 0)
            {
                query = " select * from medic where eDate >= getDate()";
                checkDatabase();
                setLabel.Text = "Valid Medicines";
                setLabel.ForeColor = Color.Black;
           
            }
            else if (txtCheck.SelectedIndex == 1)
            {

                query = " select * from medic where eDate <= getDate()";
                checkDatabase();
                setLabel.Text = "Expired Medicines";
                setLabel.ForeColor = Color.Black;
            }
            else
                    {
                query = " select * from medic";
                checkDatabase();
                setLabel.Text = "All Medicines";
                setLabel.ForeColor = Color.Black;
            }
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtCheck_SelectedIndexChanged(this, null);
        }
        public void checkDatabase()
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
