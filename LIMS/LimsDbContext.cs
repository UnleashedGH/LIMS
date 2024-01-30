using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS
{
    public  class LimsDbContext : DbContext
    {

        public   DbSet<Patient> Patients {  get; set; }
        public DbSet<Test> tests {  get; set; }
        public DbSet<Result> results {  get; set; }
        public DbSet<User> users {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-HFUQ8MH\ALISQL2019; Initial Catalog=Lims; Integrated Security=true; Encrypt=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>()
                .HasOne(t => t.Patient)
                .WithMany(p => p.Tests)
                .HasForeignKey(t => t.PatientID);
             

            base.OnModelCreating(modelBuilder);
        }
    }
}
