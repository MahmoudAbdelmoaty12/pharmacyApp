namespace PharmacyApp.View
{
    partial class Order
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridview).BeginInit();
            SuspendLayout();
            // 
            // datagridview
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridview.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            datagridview.ColumnHeadersHeight = 4;
            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            datagridview.DefaultCellStyle = dataGridViewCellStyle3;
            datagridview.GridColor = Color.FromArgb(231, 229, 255);
            datagridview.Location = new Point(143, 257);
            datagridview.Name = "datagridview";
            datagridview.RowHeadersVisible = false;
            datagridview.RowHeadersWidth = 51;
            datagridview.Size = new Size(915, 297);
            datagridview.TabIndex = 78;
            datagridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            datagridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            datagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            datagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            datagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            datagridview.ThemeStyle.BackColor = Color.White;
            datagridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            datagridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            datagridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            datagridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            datagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagridview.ThemeStyle.HeaderStyle.Height = 4;
            datagridview.ThemeStyle.ReadOnly = false;
            datagridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            datagridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            datagridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            datagridview.ThemeStyle.RowsStyle.Height = 29;
            datagridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            datagridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(521, 204);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 50);
            label1.TabIndex = 79;
            label1.Text = "Order";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 581);
            Controls.Add(label1);
            Controls.Add(datagridview);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)datagridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
        private Label label1;
    }
}