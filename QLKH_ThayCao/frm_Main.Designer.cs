
namespace QLKH_ThayCao
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýKhóaHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_pnl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKhóaHọcToolStripMenuItem,
            this.quảnLýLớpHọcToolStripMenuItem,
            this.quảnLýGiảngViênToolStripMenuItem,
            this.quảnLýSinhViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1235, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýKhóaHọcToolStripMenuItem
            // 
            this.quảnLýKhóaHọcToolStripMenuItem.Name = "quảnLýKhóaHọcToolStripMenuItem";
            this.quảnLýKhóaHọcToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.quảnLýKhóaHọcToolStripMenuItem.Text = "Quản lý Khóa học";
            this.quảnLýKhóaHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhóaHọcToolStripMenuItem_Click);
            // 
            // quảnLýLớpHọcToolStripMenuItem
            // 
            this.quảnLýLớpHọcToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            this.quảnLýLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.quảnLýLớpHọcToolStripMenuItem.Text = "Quản lý Lớp học";
            // 
            // quảnLýGiảngViênToolStripMenuItem
            // 
            this.quảnLýGiảngViênToolStripMenuItem.Name = "quảnLýGiảngViênToolStripMenuItem";
            this.quảnLýGiảngViênToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.quảnLýGiảngViênToolStripMenuItem.Text = "Quản lý Giảng viên";
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý Sinh viên";
            this.quảnLýSinhViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSinhViênToolStripMenuItem_Click);
            // 
            // Main_pnl
            // 
            this.Main_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_pnl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Main_pnl.Location = new System.Drawing.Point(0, 27);
            this.Main_pnl.Name = "Main_pnl";
            this.Main_pnl.Size = new System.Drawing.Size(1235, 767);
            this.Main_pnl.TabIndex = 1;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 797);
            this.Controls.Add(this.Main_pnl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Hệ thống Quản lý khóa học - thầy Cáo";
            this.Resize += new System.EventHandler(this.frm_Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhóaHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.Panel Main_pnl;
    }
}

