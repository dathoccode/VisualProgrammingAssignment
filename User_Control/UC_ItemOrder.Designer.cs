using Guna.UI2.WinForms;

namespace CoffeeHouseABC.User_Control
{
    partial class UC_ItemOrder
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna2Elipse(components);
            guna2HtmlLabel2 = new Guna2HtmlLabel();
            guna2PictureBox1 = new Guna2PictureBox();
            guna2HtmlLabel3 = new Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna2HtmlLabel();
            guna2NumericUpDown1 = new Guna2NumericUpDown();
            guna2Button1 = new Guna2Button();
            borderPanel = new Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown1).BeginInit();
            borderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 35;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.White;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 11F);
            guna2HtmlLabel2.Location = new Point(13, 215);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(115, 27);
            guna2HtmlLabel2.TabIndex = 3;
            guna2HtmlLabel2.Text = "Tên Sản Phẩm";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BorderRadius = 20;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Dock = DockStyle.Top;
            guna2PictureBox1.Image = Properties.Resources.coffee;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(0, 0);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(300, 200);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 4;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.White;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 11F);
            guna2HtmlLabel3.Location = new Point(170, 215);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(99, 27);
            guna2HtmlLabel3.TabIndex = 5;
            guna2HtmlLabel3.Text = "45.000 VNĐ";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.AutoSize = false;
            guna2HtmlLabel4.BackColor = Color.White;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 11F);
            guna2HtmlLabel4.Location = new Point(13, 262);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(103, 31);
            guna2HtmlLabel4.TabIndex = 6;
            guna2HtmlLabel4.Text = "Số lượng :";
            // 
            // guna2NumericUpDown1
            // 
            guna2NumericUpDown1.BackColor = Color.Transparent;
            guna2NumericUpDown1.CustomizableEdges = customizableEdges5;
            guna2NumericUpDown1.Font = new Font("Segoe UI", 11F);
            guna2NumericUpDown1.Location = new Point(170, 262);
            guna2NumericUpDown1.Margin = new Padding(3, 4, 3, 4);
            guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            guna2NumericUpDown1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2NumericUpDown1.Size = new Size(101, 31);
            guna2NumericUpDown1.TabIndex = 7;
            guna2NumericUpDown1.ValueChanged += guna2NumericUpDown1_ValueChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Red;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(0, 310);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(300, 43);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "Xóa";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // UC_ItemOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2PictureBox1);
            Controls.Add(guna2Button1);
            Controls.Add(borderPanel);
            Margin = new Padding(20);
            Name = "UC_ItemOrder";
            Size = new Size(300, 353);
            // borderPanel
            // 
            borderPanel.BackColor = Color.Transparent;
            borderPanel.BorderColor = Color.Silver;
            borderPanel.BorderRadius = 20;
            borderPanel.BorderThickness = 2;
            borderPanel.Controls.Add(guna2NumericUpDown1);
            borderPanel.Controls.Add(guna2HtmlLabel3);
            borderPanel.Controls.Add(guna2HtmlLabel4);
            borderPanel.Controls.Add(guna2HtmlLabel2);
            borderPanel.Controls.Add(guna2PictureBox1);
            borderPanel.CustomizableEdges = customizableEdges7;
            borderPanel.Dock = DockStyle.Fill;
            borderPanel.FillColor = Color.White;
            borderPanel.Location = new Point(0, 0);
            borderPanel.Margin = new Padding(10);
            borderPanel.Name = "borderPanel";
            borderPanel.Padding = new Padding(10);
            borderPanel.ShadowDecoration.BorderRadius = 20;
            borderPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            borderPanel.ShadowDecoration.Depth = 5;
            borderPanel.ShadowDecoration.Enabled = true;
            borderPanel.ShadowDecoration.Shadow = new Padding(3);
            borderPanel.Size = new Size(300, 353);
            borderPanel.TabIndex = 9;
            // 
            
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2NumericUpDown1).EndInit();
            borderPanel.ResumeLayout(false);
            borderPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel borderPanel;
    }
}
