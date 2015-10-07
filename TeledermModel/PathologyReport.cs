namespace TeledermModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App.PathologyReport")]
    public partial class PathologyReport
    {
        [Key]
        public int ConditionPathologySID { get; set; }

        public int ConditionSID { get; set; }

        [StringLength(250)]
        public string FinalDiagnosis { get; set; }

        public int? ICD9SID { get; set; }

        public int? ICD10SID { get; set; }

        public int? CPC_CorrelationSID { get; set; }

        public decimal? BreslowThickness { get; set; }

        public int? MitoticIndex { get; set; }

        public int? TNM_StageSID { get; set; }

        public int? PathologistSID { get; set; }

        public DateTime? ReportDate { get; set; }
    }
}
