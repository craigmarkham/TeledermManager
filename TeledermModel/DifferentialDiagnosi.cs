namespace TeledermModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App.DifferentialDiagnosis")]
    public partial class DifferentialDiagnosi
    {
        [Key]
        public int DiffDxSID { get; set; }

        public int ConditionSID { get; set; }

        public long ConsultSID { get; set; }

        public int? ICD9SID { get; set; }

        public int? ICD10SID { get; set; }

        public int? DiffDxOrdinal { get; set; }
    }
}
