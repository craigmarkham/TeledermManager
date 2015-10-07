namespace TeledermModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App.Imager")]
    public partial class Imager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ImagerSID { get; set; }
    }
}
