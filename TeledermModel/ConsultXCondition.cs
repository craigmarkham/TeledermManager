namespace TeledermModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App.ConsultXCondition")]
    public partial class ConsultXCondition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ConsultSID { get; set; }

        public int ConditionSID { get; set; }
    }
}
