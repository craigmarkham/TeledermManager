namespace TeledermModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("App.Reader")]
    public partial class Reader
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReaderSID { get; set; }
    }
}
