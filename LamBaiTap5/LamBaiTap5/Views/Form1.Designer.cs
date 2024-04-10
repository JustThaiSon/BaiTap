namespace LamBaiTap5
{
	partial class Form1
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
			this.btnXoa = new System.Windows.Forms.Button();
			this.cbbTrangThai = new System.Windows.Forms.ComboBox();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.dtg_DanhSach = new System.Windows.Forms.DataGridView();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.txtwebsite = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSach)).BeginInit();
			this.SuspendLayout();
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(704, 229);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(173, 59);
			this.btnXoa.TabIndex = 44;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// cbbTrangThai
			// 
			this.cbbTrangThai.FormattingEnabled = true;
			this.cbbTrangThai.Location = new System.Drawing.Point(326, 279);
			this.cbbTrangThai.Name = "cbbTrangThai";
			this.cbbTrangThai.Size = new System.Drawing.Size(221, 24);
			this.cbbTrangThai.TabIndex = 43;
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(704, 146);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(173, 59);
			this.btnSua.TabIndex = 42;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(704, 307);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(173, 59);
			this.btnClear.TabIndex = 41;
			this.btnClear.Text = "Xóa Form";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(704, 66);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(173, 59);
			this.btnThem.TabIndex = 40;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// dtg_DanhSach
			// 
			this.dtg_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtg_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg_DanhSach.Location = new System.Drawing.Point(174, 381);
			this.dtg_DanhSach.Name = "dtg_DanhSach";
			this.dtg_DanhSach.RowHeadersWidth = 51;
			this.dtg_DanhSach.RowTemplate.Height = 24;
			this.dtg_DanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_DanhSach.Size = new System.Drawing.Size(754, 173);
			this.dtg_DanhSach.TabIndex = 39;
			this.dtg_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSach_CellClick);
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(174, 344);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(221, 22);
			this.txtTimKiem.TabIndex = 38;
			this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
			// 
			// txtwebsite
			// 
			this.txtwebsite.Location = new System.Drawing.Point(326, 146);
			this.txtwebsite.Name = "txtwebsite";
			this.txtwebsite.Size = new System.Drawing.Size(221, 22);
			this.txtwebsite.TabIndex = 35;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(326, 80);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(221, 22);
			this.txtTen.TabIndex = 34;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(193, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 22);
			this.label4.TabIndex = 33;
			this.label4.Text = "WebSite";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(193, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 22);
			this.label3.TabIndex = 32;
			this.label3.Text = "Số Lượng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(193, 281);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 22);
			this.label2.TabIndex = 31;
			this.label2.Text = "Trạng Thái";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(193, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 22);
			this.label1.TabIndex = 30;
			this.label1.Text = "Tên";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(326, 209);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(221, 22);
			this.txtSoLuong.TabIndex = 45;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1102, 620);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.cbbTrangThai);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dtg_DanhSach);
			this.Controls.Add(this.txtTimKiem);
			this.Controls.Add(this.txtwebsite);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSach)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.ComboBox cbbTrangThai;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridView dtg_DanhSach;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.TextBox txtwebsite;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSoLuong;
	}
}

