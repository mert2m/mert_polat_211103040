namespace mert_polat_211103040.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hakkimizda")]
    public partial class hakkimizda
    {
        public int hakkimizdaid { get; set; }

        public string içerik { get; set; }
    }
}
