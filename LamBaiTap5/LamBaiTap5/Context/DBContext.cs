using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamBaiTap5.Context
{
	public class DBContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Data Source=LAPTOP-APKREC8K\\SQLEXPRESS;Initial Catalog=LuyenTap5;Integrated Security=True;TrustServerCertificate=True");
			}
			base.OnConfiguring(optionsBuilder);
		}
		public DbSet<Website> Websites {  get; set; }
	}
}
