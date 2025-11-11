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
            lblMaHD = new Label();
            lblTongTien = new Label();
            lblNgay = new Label();
            lblTrangThai = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMaHD
            // 
            lblMaHD.Location = new Point(3, 0);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(304, 47);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "label1";
            lblMaHD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(623, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(304, 47);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "label1";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgay
            // 
            lblNgay.Location = new Point(313, 0);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(304, 47);
            lblNgay.TabIndex = 2;
            lblNgay.Text = "label1";
            lblNgay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(933, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(304, 47);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "label3";
            lblTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblMaHD);
            flowLayoutPanel1.Controls.Add(lblNgay);
            flowLayoutPanel1.Controls.Add(lblTongTien);
            flowLayoutPanel1.Controls.Add(lblTrangThai);
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
