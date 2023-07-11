namespace test3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Class")]
    public partial class Class
    {
        [Key]
        [StringLength(10)]
        public string cno { get; set; }

        [Required]
        [StringLength(10)]
        public string name { get; set; }

        [StringLength(10)]
        public string master { get; set; }

        public DateTime? entertime { get; set; }
    }
}
