namespace mert_polat_211103040.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("muhasebe")]
    public partial class muhasebe
    {
        public int muhasebeid { get; set; }

        public string ad { get; set; }
		[AllowHtml]
		[UIHint("tinymce_full_compressed")]
		public string içerik { get; set; }

        public string iletişim { get; set; }

        public string resim { get; set; }
    }
}
