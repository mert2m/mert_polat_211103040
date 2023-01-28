namespace mert_polat_211103040.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sabit")]
    public partial class sabit
    {
        public int sabitid { get; set; }

        [Column("about-img")]
        public string about_img { get; set; }

        [Column("client-1")]
        public string client_1 { get; set; }

        [Column("client-2")]
        public string client_2 { get; set; }

        public string de { get; set; }

        public string en { get; set; }

        [Column("hero-bg")]
        public string hero_bg { get; set; }

        public string iorhan { get; set; }

        public string logo { get; set; }

        public string logobot { get; set; }

        public string logoen { get; set; }

        [Column("portfolio-1")]
        public string portfolio_1 { get; set; }

        [Column("portfolio-1en")]
        public string portfolio_1en { get; set; }

        [Column("portfolio-2")]
        public string portfolio_2 { get; set; }

        [Column("portfolio-2en")]
        public string portfolio_2en { get; set; }

        [Column("portfolio-2TR")]
        public string portfolio_2TR { get; set; }

        [Column("portfolio-2TRTR")]
        public string portfolio_2TRTR { get; set; }

        [Column("quote-sign-left")]
        public string quote_sign_left { get; set; }

        [Column("quote-sign-right")]
        public string quote_sign_right { get; set; }

        [Column("services-bg")]
        public string services_bg { get; set; }

        public string sorhan { get; set; }

        [Column("subscribe-bg")]
        public string subscribe_bg { get; set; }
    }
}
