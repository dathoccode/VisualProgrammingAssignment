namespace CoffeeHouseABC.User_Control
{
    partial class UC_Order
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel panelList;
        private Label lblTongTien;
        private Button btnThanhToan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelList = new FlowLayoutPanel();
            lblTongTien = new Label();
            btnThanhToan = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // panelList
            // 
            panelList.AutoScroll = true;
            panelList.BackColor = Color.White;
            panelList.Dock = DockStyle.Top;
            panelList.Location = new Point(0, 0);
            panelList.Name = "panelList";
            panelList.Size = new Size(1580, 628);
            panelList.TabIndex = 0;
            // 
            // lblTongTien
            // 
            lblTongTien.BackColor = Color.White;
            lblTongTien.Dock = DockStyle.Bottom;
            lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongTien.Location = new Point(0, 631);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(1580, 46);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng: 0 VNĐ";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(70, 183, 91);
            btnThanhToan.Dock = DockStyle.Bottom;
            btnThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(0, 677);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(1580, 77);
            btnThanhToan.TabIndex = 2;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += BtnThanhToan_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            guna2Elipse1.TargetControl = panelList;
            // 
            // UC_Order
            // 
            BackColor = Color.White;
            Controls.Add(panelList);
            Controls.Add(lblTongTien);
            Controls.Add(btnThanhToan);
            Name = "UC_Order";
            Size = new Size(1580, 754);
            ResumeLayout(false);
        }
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
