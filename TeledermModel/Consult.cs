namespace TeledermModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App.Consult")]
    public partial class Consult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ConsultSID { get; set; }

        public int PatientSID { get; set; }

        public int? RequestingProviderSID { get; set; }

        public int? ReadingProviderSID { get; set; }

        public int? ImagerSID { get; set; }

        public int? OrderingInstitutionSID { get; set; }

        public int? RequestServiceSID { get; set; }

        public DateTime? RequestDate { get; set; }

        public DateTime? CompletionDate { get; set; }

        public long? RemoteConsultSID { get; set; }

        [StringLength(50)]
        public string CPRSStatus { get; set; }
    }
}
