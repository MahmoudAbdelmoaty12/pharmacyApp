using pharmacyApp.Application.Services;
using PharmacyApp.Infrastructure.Repositories;

namespace PharmacyApp.View
{
    partial class Pharmacy
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
           
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacy));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            Btn_addmedicine = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel2 = new Panel();
            //uI_Modify1 = new UI_Modify();
            //uI_ViewMedicine1 = new UI_ViewMedicine();
            //uI_AddMedicine1 = new UI_AddMedicine(medicineService);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 118, 225);
            panel1.Controls.Add(guna2Button5);
            panel1.Controls.Add(guna2Button4);
            panel1.Controls.Add(guna2Button3);
            panel1.Controls.Add(Btn_addmedicine);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 768);
            panel1.TabIndex = 0;
            // 
            // guna2Button5
            // 
            guna2Button5.BorderRadius = 19;
            guna2Button5.BorderThickness = 1;
            guna2Button5.CheckedState.FillColor = Color.White;
            guna2Button5.CheckedState.ForeColor = Color.Black;
            guna2Button5.CustomizableEdges = customizableEdges1;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.FromArgb(0, 118, 255);
            guna2Button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2Button5.ForeColor = SystemColors.ButtonHighlight;
            guna2Button5.Image = (Image)resources.GetObject("guna2Button5.Image");
            guna2Button5.Location = new Point(46, 635);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button5.Size = new Size(180, 45);
            guna2Button5.TabIndex = 4;
            guna2Button5.Text = "Log Out";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // guna2Button4
            // 
            guna2Button4.BorderRadius = 19;
            guna2Button4.BorderThickness = 1;
            guna2Button4.CheckedState.FillColor = Color.White;
            guna2Button4.CheckedState.ForeColor = Color.Black;
            guna2Button4.CustomizableEdges = customizableEdges3;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.FromArgb(0, 118, 255);
            guna2Button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2Button4.ForeColor = SystemColors.ButtonHighlight;
            guna2Button4.Image = (Image)resources.GetObject("guna2Button4.Image");
            guna2Button4.Location = new Point(43, 552);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button4.Size = new Size(180, 45);
            guna2Button4.TabIndex = 3;
            guna2Button4.Text = "Modify Medicine";
            guna2Button4.Click += guna2Button4_Click;
            // 
            // guna2Button3
            // 
            guna2Button3.BorderRadius = 19;
            guna2Button3.BorderThickness = 1;
            guna2Button3.CheckedState.FillColor = Color.White;
            guna2Button3.CheckedState.ForeColor = Color.Black;
            guna2Button3.CustomizableEdges = customizableEdges5;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.FromArgb(0, 118, 255);
            guna2Button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2Button3.ForeColor = SystemColors.ButtonHighlight;
            guna2Button3.Image = (Image)resources.GetObject("guna2Button3.Image");
            guna2Button3.Location = new Point(46, 471);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button3.Size = new Size(180, 45);
            guna2Button3.TabIndex = 2;
            guna2Button3.Text = "View  Medicine";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // Btn_addmedicine
            // 
            Btn_addmedicine.BorderRadius = 19;
            Btn_addmedicine.BorderThickness = 1;
            Btn_addmedicine.CheckedState.FillColor = Color.White;
            Btn_addmedicine.CheckedState.ForeColor = Color.Black;
            Btn_addmedicine.CustomizableEdges = customizableEdges7;
            Btn_addmedicine.DisabledState.BorderColor = Color.DarkGray;
            Btn_addmedicine.DisabledState.CustomBorderColor = Color.DarkGray;
            Btn_addmedicine.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Btn_addmedicine.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Btn_addmedicine.FillColor = Color.FromArgb(0, 118, 255);
            Btn_addmedicine.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Btn_addmedicine.ForeColor = SystemColors.ButtonHighlight;
            Btn_addmedicine.Image = (Image)resources.GetObject("Btn_addmedicine.Image");
            Btn_addmedicine.Location = new Point(46, 389);
            Btn_addmedicine.Name = "Btn_addmedicine";
            Btn_addmedicine.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Btn_addmedicine.Size = new Size(180, 45);
            Btn_addmedicine.TabIndex = 1;
            Btn_addmedicine.Text = "Add  Medicine";
            Btn_addmedicine.Click += guna2Button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(66, 337);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 0;
            label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = panel2;
            // 
            // panel2
            // 
            panel2.Controls.Add(uI_Modify1);
            panel2.Controls.Add(uI_ViewMedicine1);
            panel2.Controls.Add(uI_AddMedicine1);
            panel2.Location = new Point(272, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1104, 770);
            panel2.TabIndex = 1;
            // 
            // uI_Modify1
            // 
            uI_Modify1.Location = new Point(3, 3);
            uI_Modify1.Name = "uI_Modify1";
            uI_Modify1.Size = new Size(1104, 764);
            uI_Modify1.TabIndex = 2;
            // 
            // uI_ViewMedicine1
            // 
            uI_ViewMedicine1.Location = new Point(3, 3);
            uI_ViewMedicine1.Name = "uI_ViewMedicine1";
            uI_ViewMedicine1.Size = new Size(1104, 762);
            uI_ViewMedicine1.TabIndex = 1;
            // 
            // uI_AddMedicine1
            // 
            uI_AddMedicine1.Location = new Point(3, 3);
            uI_AddMedicine1.Name = "uI_AddMedicine1";
            uI_AddMedicine1.Size = new Size(1098, 762);
            uI_AddMedicine1.TabIndex = 0;
            uI_AddMedicine1.Load += uI_AddMedicine1_Load_1;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = panel2;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = panel2;
            // 
            // Pharmacy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1380, 780);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pharmacy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pharmacy";
            Load += Pharmacy_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button Btn_addmedicine;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Panel panel2;
        private UI_AddMedicine uI_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UI_ViewMedicine uI_ViewMedicine1;
        private UI_Modify uI_Modify1;
    }
}