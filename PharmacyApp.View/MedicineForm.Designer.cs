namespace PharmacyApp.View
{
    partial class MedicineForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            AddtoCartbutton = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // AddtoCartbutton
            // 
            AddtoCartbutton.BorderRadius = 19;
            AddtoCartbutton.BorderThickness = 1;
            AddtoCartbutton.CustomizableEdges = customizableEdges1;
            AddtoCartbutton.DisabledState.BorderColor = Color.DarkGray;
            AddtoCartbutton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddtoCartbutton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddtoCartbutton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddtoCartbutton.FillColor = Color.FromArgb(0, 118, 225);
            AddtoCartbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddtoCartbutton.ForeColor = Color.White;
            AddtoCartbutton.HoverState.FillColor = Color.White;
            AddtoCartbutton.HoverState.ForeColor = Color.FromArgb(0, 118, 225);
            AddtoCartbutton.Image = (Image)resources.GetObject("AddtoCartbutton.Image");
            AddtoCartbutton.ImageSize = new Size(30, 30);
            AddtoCartbutton.Location = new Point(316, 203);
            AddtoCartbutton.Name = "AddtoCartbutton";
            AddtoCartbutton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddtoCartbutton.Size = new Size(168, 44);
            AddtoCartbutton.TabIndex = 56;
            AddtoCartbutton.Text = "Order";
            AddtoCartbutton.Click += AddtoCartbutton_Click;
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddtoCartbutton);
            Name = "MedicineForm";
            Text = "MedicineForm";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddtoCartbutton;
    }
}