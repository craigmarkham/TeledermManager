namespace TeledermModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App.Condition")]
    public partial class Condition
    {
        [Key]
        public int ConditionSID { get; set; }

        public int PatientSID { get; set; }

        public int? ICD9SID { get; set; }

        public int? ICD10SID { get; set; }

        public short? LocationSID { get; set; }

        [StringLength(250)]
        public string LocationText { get; set; }

        public DateTime? FoundDate { get; set; }

        public DateTime? ResolvedDate { get; set; }

        public bool? SuspectedMelanoma { get; set; }
    }
}
