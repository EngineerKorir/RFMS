namespace Ron_Financial_Management_System.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployerRegModel : DbContext
    {
        public EmployerRegModel()
            : base("name=EmployerRegModel")
        {
        }

        public virtual DbSet<Employer> Employers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employer>()
                .Property(e => e.EmployerCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employer>()
                .Property(e => e.EmployerName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employer>()
                .Property(e => e.EmpBox)
                .IsUnicode(false);

            modelBuilder.Entity<Employer>()
                .Property(e => e.EmpFax)
                .IsUnicode(false);

            modelBuilder.Entity<Employer>()
                .Property(e => e.EmpTel)
                .IsUnicode(false);

            modelBuilder.Entity<Employer>()
                .Property(e => e.EmpMobile)
                .IsUnicode(false);

            modelBuilder.Entity<Employer>()
                .Property(e => e.EmpEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Employer>()
                .Property(e => e.Contactperson)
                .IsUnicode(false);

            modelBuilder.Entity<Employer>()
                .Property(e => e.userid)
                .IsUnicode(false);
        }
    }
}
