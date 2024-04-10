using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamBaiTap5
{
	public class Website
	{
		[Key]
        public int STT { get; set; }
		public string Ten { get; set; }
        public string WebSitee { get; set; }
        public int SoLuong { get; set; }
		public string TrangThai { get; set; }
	}
}
