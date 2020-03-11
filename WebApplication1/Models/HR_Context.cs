namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HR_Context : DbContext
    {
        public HR_Context()
            : base("name=HR_Context")
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmpPromotion> EmpPromotion { get; set; }
        public virtual DbSet<JobTitle> JobTitle { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.INN)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmpPromotion)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpPromotion>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<JobTitle>()
                .Property(e => e.NameJobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<JobTitle>()
                .HasMany(e => e.EmpPromotion)
                .WithRequired(e => e.JobTitle)
                .WillCascadeOnDelete(false);
        }
    }
}
