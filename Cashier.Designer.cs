using System.Windows.Forms;

namespace PharmacyManagementSystem_1_
{
    partial class Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_C_Dashboard1 = new PharmacyManagementSystem_1_.CashierUC.UC_C_Dashboard();
            this.uC_C_SellMedicine1 = new PharmacyManagementSystem_1_.CashierUC.UC_C_SellMedicine();
            this.uC_A_MedicineValidityCheck1 = new PharmacyManagementSystem_1_.AdministratorUC.UC_A_MedicineValidityCheck();
            this.uC_ViewPatient2 = new PharmacyManagementSystem_1_.CashierUC.UC_ViewPatient();
            this.uC_ViewPatient1 = new PharmacyManagementSystem_1_.CashierUC.UC_ViewPatient();
            this.uC_AddPatient1 = new PharmacyManagementSystem_1_.CashierUC.UC_AddPatient();
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_C_Dashboard2 = new PharmacyManagementSystem_1_.CashierUC.UC_C_Dashboard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSellMedicine);
            this.panel1.Controls.Add(this.btnViewPatient);
            this.panel1.Controls.Add(this.btnAddPatient);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 784);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogOut.Location = new System.Drawing.Point(5, 614);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(261, 45);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSellMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSellMedicine.CheckedState.Parent = this.btnSellMedicine;
            this.btnSellMedicine.CustomImages.Parent = this.btnSellMedicine;
            this.btnSellMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSellMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSellMedicine.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSellMedicine.HoverState.Parent = this.btnSellMedicine;
            this.btnSellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMedicine.Image")));
            this.btnSellMedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSellMedicine.Location = new System.Drawing.Point(27, 548);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.ShadowDecoration.Parent = this.btnSellMedicine;
            this.btnSellMedicine.Size = new System.Drawing.Size(226, 45);
            this.btnSellMedicine.TabIndex = 6;
            this.btnSellMedicine.Text = "Sell Medicine";
            this.btnSellMedicine.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewPatient.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewPatient.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewPatient.CheckedState.Parent = this.btnViewPatient;
            this.btnViewPatient.CustomImages.Parent = this.btnViewPatient;
            this.btnViewPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewPatient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPatient.ForeColor = System.Drawing.Color.White;
            this.btnViewPatient.HoverState.FillColor = System.Drawing.Color.White;
            this.btnViewPatient.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnViewPatient.HoverState.Parent = this.btnViewPatient;
            this.btnViewPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPatient.Image")));
            this.btnViewPatient.ImageSize = new System.Drawing.Size(35, 35);
            this.btnViewPatient.Location = new System.Drawing.Point(5, 428);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.ShadowDecoration.Parent = this.btnViewPatient;
            this.btnViewPatient.Size = new System.Drawing.Size(261, 45);
            this.btnViewPatient.TabIndex = 4;
            this.btnViewPatient.Text = "View Patient";
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddPatient.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddPatient.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddPatient.CheckedState.Parent = this.btnAddPatient;
            this.btnAddPatient.CustomImages.Parent = this.btnAddPatient;
            this.btnAddPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddPatient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddPatient.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddPatient.HoverState.Parent = this.btnAddPatient;
            this.btnAddPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPatient.Image")));
            this.btnAddPatient.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddPatient.Location = new System.Drawing.Point(5, 364);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.ShadowDecoration.Parent = this.btnAddPatient;
            this.btnAddPatient.Size = new System.Drawing.Size(261, 45);
            this.btnAddPatient.TabIndex = 3;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDashboard.Location = new System.Drawing.Point(5, 299);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(261, 45);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cashier";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_C_Dashboard2);
            this.panel2.Controls.Add(this.uC_C_Dashboard1);
            this.panel2.Controls.Add(this.uC_C_SellMedicine1);
            this.panel2.Controls.Add(this.uC_A_MedicineValidityCheck1);
            this.panel2.Controls.Add(this.uC_ViewPatient2);
            this.panel2.Controls.Add(this.uC_ViewPatient1);
            this.panel2.Controls.Add(this.uC_AddPatient1);
            this.panel2.Location = new System.Drawing.Point(272, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 784);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button1.Location = new System.Drawing.Point(27, 486);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(226, 45);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Medicine Validity Check";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // uC_C_Dashboard1
            // 
            this.uC_C_Dashboard1.Location = new System.Drawing.Point(0, -14);
            this.uC_C_Dashboard1.Name = "uC_C_Dashboard1";
            this.uC_C_Dashboard1.Size = new System.Drawing.Size(1115, 812);
            this.uC_C_Dashboard1.TabIndex = 5;
            this.uC_C_Dashboard1.Load += new System.EventHandler(this.uC_C_Dashboard1_Load);
            // 
            // uC_C_SellMedicine1
            // 
            this.uC_C_SellMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_C_SellMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_C_SellMedicine1.Name = "uC_C_SellMedicine1";
            this.uC_C_SellMedicine1.Size = new System.Drawing.Size(1104, 770);
            this.uC_C_SellMedicine1.TabIndex = 4;
            // 
            // uC_A_MedicineValidityCheck1
            // 
            this.uC_A_MedicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uC_A_MedicineValidityCheck1.ForeColor = System.Drawing.Color.Black;
            this.uC_A_MedicineValidityCheck1.Location = new System.Drawing.Point(0, 0);
            this.uC_A_MedicineValidityCheck1.Name = "uC_A_MedicineValidityCheck1";
            this.uC_A_MedicineValidityCheck1.Size = new System.Drawing.Size(1104, 770);
            this.uC_A_MedicineValidityCheck1.TabIndex = 3;
            // 
            // uC_ViewPatient2
            // 
            this.uC_ViewPatient2.BackColor = System.Drawing.Color.White;
            this.uC_ViewPatient2.Location = new System.Drawing.Point(0, 33);
            this.uC_ViewPatient2.Name = "uC_ViewPatient2";
            this.uC_ViewPatient2.Size = new System.Drawing.Size(904, 705);
            this.uC_ViewPatient2.TabIndex = 2;
            // 
            // uC_ViewPatient1
            // 
            this.uC_ViewPatient1.BackColor = System.Drawing.Color.White;
            this.uC_ViewPatient1.Location = new System.Drawing.Point(0, 14);
            this.uC_ViewPatient1.Name = "uC_ViewPatient1";
            this.uC_ViewPatient1.Size = new System.Drawing.Size(1104, 770);
            this.uC_ViewPatient1.TabIndex = 1;
            this.uC_ViewPatient1.Load += new System.EventHandler(this.uC_ViewPatient1_Load);
            // 
            // uC_AddPatient1
            // 
            this.uC_AddPatient1.BackColor = System.Drawing.Color.White;
            this.uC_AddPatient1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddPatient1.Name = "uC_AddPatient1";
            this.uC_AddPatient1.Size = new System.Drawing.Size(1104, 770);
            this.uC_AddPatient1.TabIndex = 0;
            this.uC_AddPatient1.Load += new System.EventHandler(this.uC_AddPatient1_Load);
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.TargetControl = this.panel2;
            // 
            // uC_C_Dashboard2
            // 
            this.uC_C_Dashboard2.Location = new System.Drawing.Point(0, -14);
            this.uC_C_Dashboard2.Name = "uC_C_Dashboard2";
            this.uC_C_Dashboard2.Size = new System.Drawing.Size(1091, 812);
            this.uC_C_Dashboard2.TabIndex = 6;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1347, 772);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnViewPatient;
        private Guna.UI2.WinForms.Guna2Button btnAddPatient;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnSellMedicine;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private CashierUC.UC_AddPatient uC_AddPatient1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private CashierUC.UC_ViewPatient uC_ViewPatient2;
        private CashierUC.UC_ViewPatient uC_ViewPatient1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private AdministratorUC.UC_A_MedicineValidityCheck uC_A_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private CashierUC.UC_C_SellMedicine uC_C_SellMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private CashierUC.UC_C_Dashboard uC_C_Dashboard1;
        private CashierUC.UC_C_Dashboard uC_C_Dashboard2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
    }
}