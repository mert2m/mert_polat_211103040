namespace mert_polat_211103040.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class çalışmaAlanlari
    {
        [Key]
        public int calismaid { get; set; }

        public string başlık { get; set; }

        public string içerik { get; set; }
		public string sira { get; set; }
	}
}
