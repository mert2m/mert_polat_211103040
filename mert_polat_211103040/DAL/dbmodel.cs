using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace mert_polat_211103040.DAL
{
	public partial class dbmodel : DbContext
	{
		public dbmodel()
			: base("name=dbmodel")
		{
		}

		public virtual DbSet<avukatlar> avukatlar { get; set; }
		public virtual DbSet<çalışmaAlanlari> çalışmaAlanlari { get; set; }
		public virtual DbSet<hakkimizda> hakkimizda { get; set; }
		public virtual DbSet<içerik> içerik { get; set; }
		public virtual DbSet<iletişim> iletişim { get; set; }
		public virtual DbSet<muhasebe> muhasebe { get; set; }
		public virtual DbSet<sabit> sabit { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
