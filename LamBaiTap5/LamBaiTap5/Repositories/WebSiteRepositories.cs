using LamBaiTap5.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamBaiTap5.Repositories
{
	public class WebSiteRepositories
	{
		private DBContext _dbcontext;
		private List<Website> _websites;
        public WebSiteRepositories()
        {
            _websites = new List<Website>();
            _dbcontext = new DBContext();
			GetWebsiteDB();

		}
		public void GetWebsiteDB()
		{
			_websites = _dbcontext.Websites.ToList();
		}
		public List<Website> GetWebsite()
		{
			return _websites;
		}
		public string Add(Website v)
		{
			try
			{
				_dbcontext.Websites.Add(v);
				_dbcontext.SaveChanges();
				GetWebsiteDB();
				return "Thêm Thành Công";
			}
			catch (Exception)
			{

				return "Thêm Thất Bại";
			}
		}
		public string Update(Website v)
		{
			try
			{
				var Exists = _dbcontext.Websites.FirstOrDefault(x => x.STT == v.STT);
				if (Exists != null)
				{
					Exists.Ten = v.Ten;
					Exists.WebSitee = v.WebSitee;
					Exists.SoLuong = v.SoLuong;
					Exists.TrangThai = v.TrangThai;
					_dbcontext.SaveChanges();
					GetWebsiteDB();
					return "Update Thành Công";
				}
				else
				{
					return "Id Không Tồn Tại";
				}
			}
			catch (Exception)
			{

				return "Update Thất Bại";
			}
		}
		public string Delete(int Ma)
		{
			try
			{
				var Exists = _dbcontext.Websites.FirstOrDefault(x => x.STT == Ma);
				if (Exists != null)
				{
					_dbcontext.Websites.Remove(Exists);
					_dbcontext.SaveChanges();
					GetWebsiteDB();
					return "Xóa Thành Công";
				}
				else
				{
					return "Id Không Tồn Tại";
				}
			}
			catch (Exception)
			{

				return "XÓa Thất Bại";
			}
		}
		public List<Website> timkiem(string timkiem)
		{
			return _dbcontext.Websites.Where(x => x.Ten != timkiem).ToList();
		}
	}
}
