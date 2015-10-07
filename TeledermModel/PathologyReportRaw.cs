namespace TeledermModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App.PathologyReportRaw")]
    public partial class PathologyReportRaw
    {
        [Key]
        public int PathologyReportRawSID { get; set; }

        public int PatientSID { get; set; }

        [Column("PathologyReportRaw")]
        public string PathologyReportRaw1 { get; set; }

        public DateTime? DateRead { get; set; }
    }
}
