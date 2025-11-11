namespace CoffeeHouseABC.User_Control
{
    partial class UC_Menu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button btnDatHang;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowPanel = new FlowLayoutPanel();
            btnDatHang = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Top;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(1580, 692);
            flowPanel.TabIndex = 0;
            // 
            // btnDatHang
            // 
            btnDatHang.BackColor = Color.DodgerBlue;
            btnDatHang.Dock = DockStyle.Bottom;
            btnDatHang.FlatStyle = FlatStyle.Flat;
            btnDatHang.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDatHang.ForeColor = Color.White;
            btnDatHang.Location = new Point(0, 698);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(1580, 56);
            btnDatHang.TabIndex = 1;
            btnDatHang.Text = "Đặt hàng";
            btnDatHang.UseVisualStyleBackColor = false;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 50;
            guna2Elipse1.TargetControl = btnDatHang;
            // 
            // UC_Menu
            // 
            Controls.Add(btnDatHang);
            Controls.Add(flowPanel);
            Name = "UC_Menu";
            Size = new Size(1580, 754);
            ResumeLayout(false);
        }
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
