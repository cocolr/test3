using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace test3.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .Property(e => e.cno)
                .IsFixedLength();

            modelBuilder.Entity<Class>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Class>()
                .Property(e => e.master)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.sno)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.sname)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.sex)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.state)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.cname)
                .IsFixedLength();
        }
    }
}
