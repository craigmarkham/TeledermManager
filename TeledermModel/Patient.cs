namespace TeledermModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App.Patient")]
    public partial class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PatientSID { get; set; }

        [StringLength(50)]
        public string PatientICN { get; set; }

        public bool? IsSCSC { get; set; }
    }
}
