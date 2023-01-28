namespace mert_polat_211103040.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("avukatlar")]
    public partial class avukatlar
    {
        [Key]
        public int avukatid { get; set; }

        public string içerik { get; set; }

        public string isim { get; set; }
    }
}
