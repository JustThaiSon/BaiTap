using LamBaiTap5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamBaiTap5.Service
{
	public class WebSiteService
	{
		private WebSiteRepositories nv;
		public WebSiteService()
		{
			nv = new WebSiteRepositories();
		}

		public void GetNVDB()
		{
			nv.GetWebsiteDB();
		}
		public List<Website> GetWebsites()
		{
			return nv.GetWebsite();
		}
		
		public string Add(Website v)
		{
			return nv.Add(v);
		}
		public string Update(Website v)
		{
			return nv.Update(v);
		}
		public List<Website> timkiem(string timkiem)
		{
			return nv.timkiem(timkiem);
		}
		public string Delete(int Ma)
		{
			return nv.Delete(Ma);
		}
	}
}
