namespace TeledermModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App.PatAddress")]
    public partial class PatAddress
    {
        [Key]
        public int PatAddressSID { get; set; }

        public int PatientSID { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        [StringLength(50)]
        public string StreetAddress1 { get; set; }

        [StringLength(50)]
        public string StreetAddress2 { get; set; }

        [StringLength(50)]
        public string StreetAddress3 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Zip { get; set; }

        [StringLength(50)]
        public string Zip4 { get; set; }

        [StringLength(50)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(50)]
        public string BadAddressIndicator { get; set; }
    }
}
