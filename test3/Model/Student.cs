namespace test3.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        [StringLength(8)]
        public string sno { get; set; }

        [StringLength(10)]
        public string sname { get; set; }

        [StringLength(10)]
        public string sex { get; set; }

        public DateTime? birthtime { get; set; }

        [StringLength(10)]
        public string state { get; set; }

        [StringLength(10)]
        public string cno { get; set; }

        //public virtual Class Class { get; set; }
    }
}
