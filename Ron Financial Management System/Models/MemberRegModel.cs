namespace Ron_Financial_Management_System
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MemberRegModel : DbContext
    {
        public MemberRegModel()
            : base("name=MemberRegModel")
        {
        }

        public virtual DbSet<member> members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<member>()
                .Property(e => e.MemberNo)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.PayrollNo)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.SecondName)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.idno)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Gender)
                .IsUnicode(false);



            modelBuilder.Entity<member>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.maritalsts)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.homaddress)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.regstatus)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Employercode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.stationcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e._class)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Krapin)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.BankAccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .HasOptional(e => e.members1)
                .WithRequired(e => e.member1);
        }
    }
}
