
namespace QLKH_ThayCao
{
    partial class frm_QuanLyGiangVien
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
            this.ThemGiangVien_btn = new System.Windows.Forms.Button();
            this.NextPage_lbl = new System.Windows.Forms.LinkLabel();
            this.PrePage_lbl = new System.Windows.Forms.LinkLabel();
            this.totalPage_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Page_cmb = new System.Windows.Forms.ComboBox();
            this.SDT_txt = new System.Windows.Forms.TextBox();
            this.SDT_lbl = new System.Windows.Forms.Label();
            this.TenGiangVien_txt = new System.Windows.Forms.TextBox();
            this.MaGiangVien_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TenGiangVien_lbl = new System.Windows.Forms.Label();
            this.DSGiangVien_dgv = new System.Windows.Forms.DataGridView();
            this.MaGiangVien_lbl = new System.Windows.Forms.Label();
            this.ClearData_btn = new System.Windows.Forms.Button();
            this.XoaGiangVien_btn = new System.Windows.Forms.Button();
            this.searchType_cb = new System.Windows.Forms.ComboBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pageSize_num = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DiaChi_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CCCD_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.SuaGiangVien_btn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.DSGiangVien_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSize_num)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThemGiangVien_btn
            // 
            this.ThemGiangVien_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemGiangVien_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(127)))), ((int)(((byte)(231)))));
            this.ThemGiangVien_btn.FlatAppearance.BorderSize = 0;
            this.ThemGiangVien_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemGiangVien_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemGiangVien_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.ThemGiangVien_btn.Location = new System.Drawing.Point(279, 561);
            this.ThemGiangVien_btn.Name = "ThemGiangVien_btn";
            this.ThemGiangVien_btn.Size = new System.Drawing.Size(98, 52);
            this.ThemGiangVien_btn.TabIndex = 10;
            this.ThemGiangVien_btn.Text = "Thêm";
            this.ThemGiangVien_btn.UseVisualStyleBackColor = false;
            this.ThemGiangVien_btn.Click += new System.EventHandler(this.ThemGiangVien_btn_Click);
            // 
            // NextPage_lbl
            // 
            this.NextPage_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextPage_lbl.AutoSize = true;
            this.NextPage_lbl.Location = new System.Drawing.Point(767, 652);
            this.NextPage_lbl.Name = "NextPage_lbl";
            this.NextPage_lbl.Size = new System.Drawing.Size(55, 13);
            this.NextPage_lbl.TabIndex = 7;
            this.NextPage_lbl.TabStop = true;
            this.NextPage_lbl.Text = "Trang sau";
            this.NextPage_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextPage_lbl_LinkClicked);
            // 
            // PrePage_lbl
            // 
            this.PrePage_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrePage_lbl.AutoSize = true;
            this.PrePage_lbl.Location = new System.Drawing.Point(530, 652);
            this.PrePage_lbl.Name = "PrePage_lbl";
            this.PrePage_lbl.Size = new System.Drawing.Size(62, 13);
            this.PrePage_lbl.TabIndex = 6;
            this.PrePage_lbl.TabStop = true;
            this.PrePage_lbl.Text = "Trang trước";
            this.PrePage_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PrePage_lbl_LinkClicked);
            // 
            // totalPage_lbl
            // 
            this.totalPage_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPage_lbl.AutoSize = true;
            this.totalPage_lbl.Location = new System.Drawing.Point(711, 652);
            this.totalPage_lbl.Name = "totalPage_lbl";
            this.totalPage_lbl.Size = new System.Drawing.Size(37, 13);
            this.totalPage_lbl.TabIndex = 5;
            this.totalPage_lbl.Text = "/Tổng";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trang";
            // 
            // Page_cmb
            // 
            this.Page_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Page_cmb.FormattingEnabled = true;
            this.Page_cmb.Location = new System.Drawing.Point(636, 649);
            this.Page_cmb.Name = "Page_cmb";
            this.Page_cmb.Size = new System.Drawing.Size(69, 21);
            this.Page_cmb.TabIndex = 3;
            this.Page_cmb.SelectedIndexChanged += new System.EventHandler(this.Page_cmb_SelectedIndexChanged);
            // 
            // SDT_txt
            // 
            this.SDT_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SDT_txt.Location = new System.Drawing.Point(140, 122);
            this.SDT_txt.Name = "SDT_txt";
            this.SDT_txt.Size = new System.Drawing.Size(295, 23);
            this.SDT_txt.TabIndex = 17;
            // 
            // SDT_lbl
            // 
            this.SDT_lbl.AutoSize = true;
            this.SDT_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT_lbl.Location = new System.Drawing.Point(17, 125);
            this.SDT_lbl.Name = "SDT_lbl";
            this.SDT_lbl.Size = new System.Drawing.Size(32, 13);
            this.SDT_lbl.TabIndex = 12;
            this.SDT_lbl.Text = "SDT:";
            // 
            // TenGiangVien_txt
            // 
            this.TenGiangVien_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TenGiangVien_txt.Location = new System.Drawing.Point(140, 73);
            this.TenGiangVien_txt.Name = "TenGiangVien_txt";
            this.TenGiangVien_txt.Size = new System.Drawing.Size(295, 23);
            this.TenGiangVien_txt.TabIndex = 16;
            // 
            // MaGiangVien_txt
            // 
            this.MaGiangVien_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaGiangVien_txt.Location = new System.Drawing.Point(140, 29);
            this.MaGiangVien_txt.Name = "MaGiangVien_txt";
            this.MaGiangVien_txt.Size = new System.Drawing.Size(295, 23);
            this.MaGiangVien_txt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(321, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh sách giảng viên";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số bản ghi trên 1 trang";
            // 
            // TenGiangVien_lbl
            // 
            this.TenGiangVien_lbl.AutoSize = true;
            this.TenGiangVien_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenGiangVien_lbl.Location = new System.Drawing.Point(17, 77);
            this.TenGiangVien_lbl.Name = "TenGiangVien_lbl";
            this.TenGiangVien_lbl.Size = new System.Drawing.Size(81, 13);
            this.TenGiangVien_lbl.TabIndex = 13;
            this.TenGiangVien_lbl.Text = "Tên giảng viên:";
            // 
            // DSGiangVien_dgv
            // 
            this.DSGiangVien_dgv.AllowUserToAddRows = false;
            this.DSGiangVien_dgv.AllowUserToDeleteRows = false;
            this.DSGiangVien_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DSGiangVien_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DSGiangVien_dgv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DSGiangVien_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSGiangVien_dgv.Location = new System.Drawing.Point(3, 49);
            this.DSGiangVien_dgv.Name = "DSGiangVien_dgv";
            this.DSGiangVien_dgv.ReadOnly = true;
            this.DSGiangVien_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DSGiangVien_dgv.Size = new System.Drawing.Size(904, 564);
            this.DSGiangVien_dgv.TabIndex = 0;
            this.DSGiangVien_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSGiangVien_dgv_CellClick);
            // 
            // MaGiangVien_lbl
            // 
            this.MaGiangVien_lbl.AutoSize = true;
            this.MaGiangVien_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaGiangVien_lbl.Location = new System.Drawing.Point(17, 31);
            this.MaGiangVien_lbl.Name = "MaGiangVien_lbl";
            this.MaGiangVien_lbl.Size = new System.Drawing.Size(77, 13);
            this.MaGiangVien_lbl.TabIndex = 14;
            this.MaGiangVien_lbl.Text = "Mã giảng viên:";
            // 
            // ClearData_btn
            // 
            this.ClearData_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(130)))), ((int)(((byte)(105)))));
            this.ClearData_btn.FlatAppearance.BorderSize = 0;
            this.ClearData_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearData_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearData_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.ClearData_btn.Location = new System.Drawing.Point(57, 561);
            this.ClearData_btn.Name = "ClearData_btn";
            this.ClearData_btn.Size = new System.Drawing.Size(92, 52);
            this.ClearData_btn.TabIndex = 5;
            this.ClearData_btn.Text = "Làm mới";
            this.ClearData_btn.UseVisualStyleBackColor = false;
            this.ClearData_btn.Click += new System.EventHandler(this.ClearData_btn_Click);
            // 
            // XoaGiangVien_btn
            // 
            this.XoaGiangVien_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.XoaGiangVien_btn.FlatAppearance.BorderSize = 0;
            this.XoaGiangVien_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XoaGiangVien_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaGiangVien_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.XoaGiangVien_btn.Location = new System.Drawing.Point(57, 629);
            this.XoaGiangVien_btn.Name = "XoaGiangVien_btn";
            this.XoaGiangVien_btn.Size = new System.Drawing.Size(92, 50);
            this.XoaGiangVien_btn.TabIndex = 4;
            this.XoaGiangVien_btn.Text = "Xóa";
            this.XoaGiangVien_btn.UseVisualStyleBackColor = false;
            this.XoaGiangVien_btn.Click += new System.EventHandler(this.XoaGiangVien_btn_Click);
            // 
            // searchType_cb
            // 
            this.searchType_cb.FormattingEnabled = true;
            this.searchType_cb.Items.AddRange(new object[] {
            "Tìm kiếm theo",
            "Mã",
            "Tên"});
            this.searchType_cb.Location = new System.Drawing.Point(217, 35);
            this.searchType_cb.Name = "searchType_cb";
            this.searchType_cb.Size = new System.Drawing.Size(118, 24);
            this.searchType_cb.TabIndex = 8;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(351, 35);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 9;
            this.Search_btn.Text = "Tìm kiếm";
            this.Search_btn.UseVisualStyleBackColor = true;
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(20, 36);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(191, 23);
            this.Search_txt.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchType_cb);
            this.groupBox1.Controls.Add(this.Search_btn);
            this.groupBox1.Controls.Add(this.Search_txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 81);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // pageSize_num
            // 
            this.pageSize_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pageSize_num.Location = new System.Drawing.Point(134, 648);
            this.pageSize_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSize_num.Name = "pageSize_num";
            this.pageSize_num.Size = new System.Drawing.Size(63, 20);
            this.pageSize_num.TabIndex = 1;
            this.pageSize_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DiaChi_txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CCCD_txt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Email_txt);
            this.groupBox2.Controls.Add(this.Email_lbl);
            this.groupBox2.Controls.Add(this.SDT_txt);
            this.groupBox2.Controls.Add(this.SDT_lbl);
            this.groupBox2.Controls.Add(this.TenGiangVien_txt);
            this.groupBox2.Controls.Add(this.TenGiangVien_lbl);
            this.groupBox2.Controls.Add(this.MaGiangVien_txt);
            this.groupBox2.Controls.Add(this.MaGiangVien_lbl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 352);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết giảng viên";
            // 
            // DiaChi_txt
            // 
            this.DiaChi_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiaChi_txt.Location = new System.Drawing.Point(140, 273);
            this.DiaChi_txt.Name = "DiaChi_txt";
            this.DiaChi_txt.Size = new System.Drawing.Size(295, 23);
            this.DiaChi_txt.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Địa chỉ:";
            // 
            // CCCD_txt
            // 
            this.CCCD_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CCCD_txt.Location = new System.Drawing.Point(140, 222);
            this.CCCD_txt.Name = "CCCD_txt";
            this.CCCD_txt.Size = new System.Drawing.Size(295, 23);
            this.CCCD_txt.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CCCD:";
            // 
            // Email_txt
            // 
            this.Email_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email_txt.Location = new System.Drawing.Point(140, 171);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(295, 23);
            this.Email_txt.TabIndex = 17;
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.Location = new System.Drawing.Point(17, 174);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(35, 13);
            this.Email_lbl.TabIndex = 12;
            this.Email_lbl.Text = "Email:";
            // 
            // SuaGiangVien_btn
            // 
            this.SuaGiangVien_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SuaGiangVien_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SuaGiangVien_btn.FlatAppearance.BorderSize = 0;
            this.SuaGiangVien_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuaGiangVien_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaGiangVien_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.SuaGiangVien_btn.Location = new System.Drawing.Point(280, 627);
            this.SuaGiangVien_btn.Name = "SuaGiangVien_btn";
            this.SuaGiangVien_btn.Size = new System.Drawing.Size(98, 50);
            this.SuaGiangVien_btn.TabIndex = 3;
            this.SuaGiangVien_btn.Text = "Sửa";
            this.SuaGiangVien_btn.UseVisualStyleBackColor = false;
            this.SuaGiangVien_btn.Click += new System.EventHandler(this.SuaGiangVien_btn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(236)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(236)))));
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.ClearData_btn);
            this.splitContainer1.Panel1.Controls.Add(this.XoaGiangVien_btn);
            this.splitContainer1.Panel1.Controls.Add(this.SuaGiangVien_btn);
            this.splitContainer1.Panel1.Controls.Add(this.ThemGiangVien_btn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(236)))));
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.NextPage_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.PrePage_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.totalPage_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Page_cmb);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.pageSize_num);
            this.splitContainer1.Panel2.Controls.Add(this.DSGiangVien_dgv);
            this.splitContainer1.Size = new System.Drawing.Size(1393, 718);
            this.splitContainer1.SplitterDistance = 479;
            this.splitContainer1.TabIndex = 1;
            // 
            // frm_QuanLyGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 718);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QuanLyGiangVien";
            this.Text = "aQ";
            this.Load += new System.EventHandler(this.frm_QuanLyGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSGiangVien_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSize_num)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ThemGiangVien_btn;
        private System.Windows.Forms.LinkLabel NextPage_lbl;
        private System.Windows.Forms.LinkLabel PrePage_lbl;
        private System.Windows.Forms.Label totalPage_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Page_cmb;
        private System.Windows.Forms.TextBox SDT_txt;
        private System.Windows.Forms.Label SDT_lbl;
        private System.Windows.Forms.TextBox TenGiangVien_txt;
        private System.Windows.Forms.TextBox MaGiangVien_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TenGiangVien_lbl;
        private System.Windows.Forms.DataGridView DSGiangVien_dgv;
        private System.Windows.Forms.Label MaGiangVien_lbl;
        private System.Windows.Forms.Button ClearData_btn;
        private System.Windows.Forms.Button XoaGiangVien_btn;
        private System.Windows.Forms.ComboBox searchType_cb;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown pageSize_num;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SuaGiangVien_btn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox DiaChi_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CCCD_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Label Email_lbl;
    }
}