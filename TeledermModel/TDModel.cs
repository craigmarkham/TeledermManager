namespace TeledermModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TDModel : DbContext
    {
        public TDModel()
            : base("name=TDEntities")
        {
        }

        public virtual DbSet<Condition> Conditions { get; set; }
        public virtual DbSet<Consult> Consults { get; set; }
        public virtual DbSet<ConsultXCondition> ConsultXConditions { get; set; }
        public virtual DbSet<DifferentialDiagnosi> DifferentialDiagnosis { get; set; }
        public virtual DbSet<Imager> Imagers { get; set; }
        public virtual DbSet<PatAddress> PatAddresses { get; set; }
        public virtual DbSet<PathologyReport> PathologyReports { get; set; }
        public virtual DbSet<PathologyReportRaw> PathologyReportRaws { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Reader> Readers { get; set; }
        public virtual DbSet<TreatmentRequest> TreatmentRequests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Condition>()
                .Property(e => e.LocationText)
                .IsUnicode(false);

            modelBuilder.Entity<Consult>()
                .Property(e => e.CPRSStatus)
                .IsUnicode(false);

            modelBuilder.Entity<PatAddress>()
                .Property(e => e.StreetAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<PatAddress>()
                .Property(e => e.StreetAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<PatAddress>()
                .Property(e => e.StreetAddress3)
                .IsUnicode(false);

            modelBuilder.Entity<PatAddress>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<PatAddress>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<PatAddress>()
                .Property(e => e.Zip4)
                .IsUnicode(false);

            modelBuilder.Entity<PatAddress>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<PatAddress>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<PatAddress>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<PatAddress>()
                .Property(e => e.BadAddressIndicator)
                .IsUnicode(false);

            modelBuilder.Entity<PathologyReport>()
                .Property(e => e.FinalDiagnosis)
                .IsUnicode(false);

            modelBuilder.Entity<PathologyReport>()
                .Property(e => e.BreslowThickness)
                .HasPrecision(4, 2);

            modelBuilder.Entity<PathologyReportRaw>()
                .Property(e => e.PathologyReportRaw1)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.PatientICN)
                .IsUnicode(false);
        }
    }
}
