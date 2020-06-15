using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContactsSync.Models
{
    public partial class patientInfoContext : DbContext
    {
        public patientInfoContext()
        {
        }

        public patientInfoContext(DbContextOptions<patientInfoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Patients> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.10.10.33\\CORLISSDEV;Database=patientInfo;User Id=corlissapi;Password=publicpassword;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patients>(entity =>
            {
                entity.ToTable("patients");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CellPhone)
                    .HasColumnName("Cell_Phone")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasColumnName("Full_Name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("Home_Phone")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("Middle_Name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("Work_Phone")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
