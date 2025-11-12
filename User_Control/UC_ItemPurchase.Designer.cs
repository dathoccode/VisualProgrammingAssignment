namespace CoffeeHouseABC.User_Control
{
    partial class UC_ItemPurchase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblMaHD = new Label();
            lblTongTien = new Label();
            lblNgay = new Label();
            lblTrangThai = new Label();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMaHD
            // 
            lblMaHD.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaHD.Location = new Point(3, 0);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(250, 47);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "label1";
            lblMaHD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgay
            // 
            lblNgay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNgay.Location = new Point(259, 0);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(250, 47);
            lblNgay.TabIndex = 2;
            lblNgay.Text = "label1";
            lblNgay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTien.Location = new Point(515, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(250, 47);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "label1";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTrangThai.Location = new Point(771, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(250, 47);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "label3";
            lblTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            btnXoa.BorderRadius = 8;
            btnXoa.CustomizableEdges = customizableEdges1;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.White;
            btnXoa.Font = new Font("Segoe UI", 9F);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(1027, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnXoa.Size = new Size(120, 40);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.BorderColor = Color.FromArgb(224, 224, 224);
            btnXoa.BorderThickness = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblMaHD);
            flowLayoutPanel1.Controls.Add(lblNgay);
            flowLayoutPanel1.Controls.Add(lblTongTien);
            flowLayoutPanel1.Controls.Add(lblTrangThai);
            flowLayoutPanel1.Controls.Add(btnXoa);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1550, 50);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // UC_ItemPurchase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Name = "UC_ItemPurchase";
            Size = new Size(1550, 50);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblMaHD;
        private Label lblTongTien;
        private Label lblNgay;
        private Label lblTrangThai;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
