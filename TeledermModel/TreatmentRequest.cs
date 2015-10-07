namespace TeledermModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App.TreatmentRequest")]
    public partial class TreatmentRequest
    {
        [Key]
        public int TreatmentRequestSID { get; set; }

        public int ConditionSID { get; set; }

        public DateTime? DateRequested { get; set; }

        public DateTime? DateCompleted { get; set; }

        public int? ProviderSID { get; set; }

        public int? ProcedureSID { get; set; }
    }
}
