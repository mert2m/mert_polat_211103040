namespace mert_polat_211103040.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class içerik
    {
        [Key]
        public int kariyerid { get; set; }

        [Column("içerik")]
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string içerik1 { get; set; }

        public string s1 { get; set; }  
        public string gereksinimler { get; set; }   
        public string s2 { get; set; }
        public string gereksinimler2 { get; set; }

        public string kalan { get; set; }
    }
}
