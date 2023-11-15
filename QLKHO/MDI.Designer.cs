
namespace QLKHO
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Kho = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_HangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_PhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CTPN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.danhMucToolStripMenuItem,
            this.xuấtNhậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Kho,
            this.menu_HangHoa});
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMucToolStripMenuItem.Text = "Danh mục";
            // 
            // menu_Kho
            // 
            this.menu_Kho.Name = "menu_Kho";
            this.menu_Kho.Size = new System.Drawing.Size(160, 26);
            this.menu_Kho.Text = "Kho";
            // 
            // menu_HangHoa
            // 
            this.menu_HangHoa.Name = "menu_HangHoa";
            this.menu_HangHoa.Size = new System.Drawing.Size(160, 26);
            this.menu_HangHoa.Text = "Hàng Hóa";
            // 
            // xuấtNhậpToolStripMenuItem
            // 
            this.xuấtNhậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_PhieuNhap,
            this.menu_CTPN});
            this.xuấtNhậpToolStripMenuItem.Name = "xuấtNhậpToolStripMenuItem";
            this.xuấtNhậpToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.xuấtNhậpToolStripMenuItem.Text = "Xuất/ Nhập";
            // 
            // menu_PhieuNhap
            // 
            this.menu_PhieuNhap.Name = "menu_PhieuNhap";
            this.menu_PhieuNhap.Size = new System.Drawing.Size(222, 26);
            this.menu_PhieuNhap.Text = "Phiếu Nhập";
            // 
            // menu_CTPN
            // 
            this.menu_CTPN.Name = "menu_CTPN";
            this.menu_CTPN.Size = new System.Drawing.Size(222, 26);
            this.menu_CTPN.Text = "Chi Tiết Phiếu Nhập";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Kho;
        private System.Windows.Forms.ToolStripMenuItem menu_HangHoa;
        private System.Windows.Forms.ToolStripMenuItem xuấtNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_PhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem menu_CTPN;
    }
}