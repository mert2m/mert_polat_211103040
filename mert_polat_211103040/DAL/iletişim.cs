namespace mert_polat_211103040.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class iletişim
    {
        public int iletişimid { get; set; }

        public string adres { get; set; }

        public string mail { get; set; }

        public string telefon { get; set; }

        public string fax { get; set; }

        public string mobil { get; set; }
    }
}
