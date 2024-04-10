using LamBaiTap5.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamBaiTap5
{
	public partial class Form1 : Form
	{
		private WebSiteService sv;
		public Form1()
		{
			InitializeComponent();
			sv = new WebSiteService();
			LoadGrid();
			LoadCbb();
		}
		private void LoadGrid()
		{
			dtg_DanhSach.ColumnCount = 5;
			dtg_DanhSach.Columns[0].Name = "STT";
			dtg_DanhSach.Columns[1].Name = "Tên";
			dtg_DanhSach.Columns[2].Name = "Số Lượng";
			dtg_DanhSach.Columns[3].Name = "Trạng Thái";
			dtg_DanhSach.Rows.Clear();
			foreach (var item in sv.GetWebsites())
			{
				dtg_DanhSach.Rows.Add(item.STT, item.Ten, item.SoLuong,item.TrangThai);
			}
		}
		private void LoadGrid(string timkiem)
		{
			dtg_DanhSach.ColumnCount = 5;
			dtg_DanhSach.Columns[0].Name = "STT";
			dtg_DanhSach.Columns[1].Name = "Tên";
			dtg_DanhSach.Columns[2].Name = "Số Lượng";
			dtg_DanhSach.Columns[3].Name = "Trạng Thái";
			dtg_DanhSach.Rows.Clear();
			foreach (var item in sv.timkiem(timkiem))
			{
				dtg_DanhSach.Rows.Add(item.STT, item.Ten, item.SoLuong, item.TrangThai);
			}
		}
		private void LoadCbb()
		{
			string[] TrangThai = { "Hoạt Động", "Không Hoạt Động" };
            foreach (var item in TrangThai)
            {
				cbbTrangThai.Items.Add(item);
            }
        }

		private void Clear()
		{
			txtTen.Clear();
			txtwebsite.Clear();
			txtSoLuong.Clear();
			cbbTrangThai.Text = "";
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			Website w = new Website();	
			w.Ten = txtTen.Text;
			w.WebSitee = txtwebsite.Text;
			if (!w.WebSitee.EndsWith(".com"))
			{
				MessageBox.Show("Tên Website phải có .com ở cuối");
				return;
			}
			if (string.IsNullOrEmpty(w.Ten))
			{
				MessageBox.Show("Tên Không được Bỏ Trống");
				return;
			}
			w.SoLuong = int.Parse(txtSoLuong.Text.ToString());
			if (w.SoLuong < 0)
			{
				MessageBox.Show( "Số Lượng Phải Là Số Nguyên Dương");
				return;

			}
			w.TrangThai = cbbTrangThai.Text;
			MessageBox.Show(sv.Add(w), "Thông Báo");
			LoadGrid();
			Clear();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			Website w = new Website();
			if (dtg_DanhSach.SelectedRows.Count == 0 || dtg_DanhSach.SelectedRows[0].Cells[0].Value == null || string.IsNullOrEmpty(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString()))
			{
				MessageBox.Show("Chọn Id Cần Xóa");
				return;
			}
			w.STT = int.Parse(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString());
			w.Ten = txtTen.Text;
			w.WebSitee = txtwebsite.Text;
			w.SoLuong = int.Parse(txtSoLuong.Text.ToString());
			if (!w.WebSitee.EndsWith(".com"))
			{
				MessageBox.Show("Tên Website phải có .com ở cuối");
				return;
			}
			if (string.IsNullOrEmpty(w.Ten))
			{
				MessageBox.Show("Tên Không được Bỏ Trống");
				return;
			}
			if (w.SoLuong < 0)
			{
				MessageBox.Show("Số Lượng Phải Là Số Nguyên Dương");
				return;

			}
			w.TrangThai = cbbTrangThai.Text;
			MessageBox.Show(sv.Update(w), "Thông Báo");
			LoadGrid();
			Clear();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (dtg_DanhSach.SelectedRows.Count == 0 || dtg_DanhSach.SelectedRows[0].Cells[0].Value == null || string.IsNullOrEmpty(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString()))
			{
				MessageBox.Show("Chọn Id Cần Xóa");
				return;
			}
			int STT = int.Parse(dtg_DanhSach.SelectedRows[0].Cells[0].Value.ToString());
			MessageBox.Show(sv.Delete(STT), "Thông Báo");
			LoadGrid();
			Clear();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void dtg_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= sv.GetWebsites().Count) return;
			DataGridViewRow selectedRow = dtg_DanhSach.SelectedRows[0];
			txtTen.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
			txtSoLuong.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
			cbbTrangThai.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			LoadGrid(txtTimKiem.Text);
		}
	}
}
