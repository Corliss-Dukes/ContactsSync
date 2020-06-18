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
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patients>(entity =>
            {
                entity.HasKey(e => e.FirstName)
                    .HasName("PK__patients__4213699B0DF6565A");

                entity.ToTable("patients");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AlertComments)
                    .HasColumnName("Alert_Comments")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AllergiesSummary)
                    .IsRequired()
                    .HasColumnName("Allergies_Summary")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AlottmentIns1)
                    .HasColumnName("Alottment_Ins_1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AlottmentIns1Eff)
                    .HasColumnName("Alottment_Ins_1_Eff")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AlottmentIns1Exp)
                    .HasColumnName("Alottment_Ins_1_Exp")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyFinanceCharge)
                    .IsRequired()
                    .HasColumnName("Apply_Finance_Charge")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BillingName)
                    .HasColumnName("Billing_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CellPhone)
                    .HasColumnName("Cell_Phone")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyLogo)
                    .HasColumnName("Company_Logo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompayPhone)
                    .IsRequired()
                    .HasColumnName("Compay_Phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CourtesyDisc).HasColumnName("Courtesy_Disc");

                entity.Property(e => e.DiagnosisCodes)
                    .HasColumnName("Diagnosis_Codes")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.DriverLisc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerSchool)
                    .IsRequired()
                    .HasColumnName("Employer_School")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLastSuffix)
                    .IsRequired()
                    .HasColumnName("First_Last_Suffix")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full_Name")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorAddress1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorAddress2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorBirthday)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorHomePh)
                    .HasColumnName("GuarantorHomePH")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorSex)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorSsn)
                    .HasColumnName("GuarantorSSN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorSsnPartiallyMasked)
                    .HasColumnName("GuarantorSSN_Partially_Masked")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorState)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorWorkPh)
                    .HasColumnName("GuarantorWorkPH")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuarantorZip)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HeOrShe)
                    .IsRequired()
                    .HasColumnName("he_or_she")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HeOrSheCap)
                    .IsRequired()
                    .HasColumnName("He_or_She_cap")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HimOrHer)
                    .IsRequired()
                    .HasColumnName("him_or_her")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HimOrHerCap)
                    .IsRequired()
                    .HasColumnName("Him_or_Her_cap")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HipaaSigOnFile)
                    .HasColumnName("HIPAA_Sig_On_File")
                    .HasColumnType("date");

                entity.Property(e => e.HisOrHer)
                    .IsRequired()
                    .HasColumnName("his_or_her")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HisOrHerCap)
                    .IsRequired()
                    .HasColumnName("His_or_Her_cap")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("Home_Phone")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1Abbrev)
                    .HasColumnName("Ins_1_Abbrev")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1Address)
                    .IsRequired()
                    .HasColumnName("Ins_1_Address")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1Birthday)
                    .HasColumnName("Ins_1_Birthday")
                    .HasColumnType("date");

                entity.Property(e => e.Ins1City)
                    .IsRequired()
                    .HasColumnName("Ins_1_City")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1CoPay).HasColumnName("Ins_1_Co_pay");

                entity.Property(e => e.Ins1Employer)
                    .IsRequired()
                    .HasColumnName("Ins_1_Employer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1Id)
                    .HasColumnName("Ins_1_ID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1NotPrimary)
                    .IsRequired()
                    .HasColumnName("Ins_1_Not_Primary")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1Phone)
                    .IsRequired()
                    .HasColumnName("Ins_1_Phone")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1PolicyGroup)
                    .HasColumnName("Ins_1_Policy_Group")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1PrimaryName)
                    .IsRequired()
                    .HasColumnName("Ins_1_Primary_Name")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1Relationship)
                    .IsRequired()
                    .HasColumnName("Ins_1_Relationship")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1Sex)
                    .IsRequired()
                    .HasColumnName("Ins_1_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1SignatureDate)
                    .HasColumnName("Ins_1_Signature_Date")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1Ssn)
                    .IsRequired()
                    .HasColumnName("Ins_1_SSN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1State)
                    .IsRequired()
                    .HasColumnName("Ins_1_State")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ins1Zipcode).HasColumnName("Ins_1_Zipcode");

                entity.Property(e => e.Ins2Abbrev)
                    .HasColumnName("Ins_2_Abbrev")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2Address)
                    .IsRequired()
                    .HasColumnName("Ins_2_Address")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2Birthday)
                    .HasColumnName("Ins_2_Birthday")
                    .HasColumnType("date");

                entity.Property(e => e.Ins2City)
                    .IsRequired()
                    .HasColumnName("Ins_2_City")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2CoPay).HasColumnName("Ins_2_Co_pay");

                entity.Property(e => e.Ins2Employer)
                    .IsRequired()
                    .HasColumnName("Ins_2_Employer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2Id)
                    .HasColumnName("Ins_2_ID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2NotPrimary)
                    .IsRequired()
                    .HasColumnName("Ins_2_Not_Primary")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2Phone)
                    .IsRequired()
                    .HasColumnName("Ins_2_Phone")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2PolicyGroup).HasColumnName("Ins_2_Policy_Group");

                entity.Property(e => e.Ins2PrimaryName)
                    .IsRequired()
                    .HasColumnName("Ins_2_Primary_Name")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2Relationship)
                    .IsRequired()
                    .HasColumnName("Ins_2_Relationship")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2Sex)
                    .IsRequired()
                    .HasColumnName("Ins_2_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2SignatureDate)
                    .HasColumnName("Ins_2_Signature_Date")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2Ssn)
                    .HasColumnName("Ins_2_SSN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2State)
                    .IsRequired()
                    .HasColumnName("Ins_2_State")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ins2Zipcode).HasColumnName("Ins_2_Zipcode");

                entity.Property(e => e.Ins3Abbrev)
                    .HasColumnName("Ins_3_Abbrev")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Ins3Address)
                    .IsRequired()
                    .HasColumnName("Ins_3_Address")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ins3Birthday)
                    .HasColumnName("Ins_3_Birthday")
                    .HasColumnType("date");

                entity.Property(e => e.Ins3City)
                    .IsRequired()
                    .HasColumnName("Ins_3_City")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ins3CoPay).HasColumnName("Ins_3_Co_pay");

                entity.Property(e => e.Ins3Employer)
                    .IsRequired()
                    .HasColumnName("Ins_3_Employer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ins3Id).HasColumnName("Ins_3_ID");

                entity.Property(e => e.Ins3NotPrimary)
                    .IsRequired()
                    .HasColumnName("Ins_3_Not_Primary")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Ins3Phone)
                    .IsRequired()
                    .HasColumnName("Ins_3_Phone")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Ins3PolicyGroup)
                    .HasColumnName("Ins_3_Policy_Group")
                    .HasColumnType("numeric(8, 6)");

                entity.Property(e => e.Ins3PrimaryName)
                    .IsRequired()
                    .HasColumnName("Ins_3_Primary_Name")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Ins3Relationship)
                    .IsRequired()
                    .HasColumnName("Ins_3_Relationship")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Ins3Sex)
                    .IsRequired()
                    .HasColumnName("Ins_3_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ins3SignatureDate)
                    .HasColumnName("Ins_3_Signature_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Ins3Ssn)
                    .HasColumnName("Ins_3_SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Ins3State)
                    .IsRequired()
                    .HasColumnName("Ins_3_State")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ins3Zipcode).HasColumnName("Ins_3_Zipcode");

                entity.Property(e => e.Ins4Abbrev)
                    .HasColumnName("Ins_4_Abbrev")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4Address)
                    .IsRequired()
                    .HasColumnName("Ins_4_Address")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4Birthday)
                    .HasColumnName("Ins_4_Birthday")
                    .HasColumnType("date");

                entity.Property(e => e.Ins4City)
                    .IsRequired()
                    .HasColumnName("Ins_4_City")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4CoPay).HasColumnName("Ins_4_Co_pay");

                entity.Property(e => e.Ins4Employer)
                    .IsRequired()
                    .HasColumnName("Ins_4_Employer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4Id)
                    .HasColumnName("Ins_4_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4NotPrimary)
                    .IsRequired()
                    .HasColumnName("Ins_4_Not_Primary")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4Phone)
                    .IsRequired()
                    .HasColumnName("Ins_4_Phone")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4PolicyGroup)
                    .HasColumnName("Ins_4_Policy_Group")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4PrimaryName)
                    .IsRequired()
                    .HasColumnName("Ins_4_Primary_Name")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4Relationship)
                    .IsRequired()
                    .HasColumnName("Ins_4_Relationship")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4Sex)
                    .IsRequired()
                    .HasColumnName("Ins_4_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4SignatureDate)
                    .HasColumnName("Ins_4_Signature_Date")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4Ssn)
                    .HasColumnName("Ins_4_SSN")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4State)
                    .IsRequired()
                    .HasColumnName("Ins_4_State")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ins4Zipcode).HasColumnName("Ins_4_Zipcode");

                entity.Property(e => e.Ins5Abbrev)
                    .HasColumnName("Ins_5_Abbrev")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5Address)
                    .IsRequired()
                    .HasColumnName("Ins_5_Address")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5Birthday)
                    .HasColumnName("Ins_5_Birthday")
                    .HasColumnType("date");

                entity.Property(e => e.Ins5City)
                    .IsRequired()
                    .HasColumnName("Ins_5_City")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5CoPay)
                    .HasColumnName("Ins_5_Co_pay")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5Employer)
                    .IsRequired()
                    .HasColumnName("Ins_5_Employer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5Id)
                    .HasColumnName("Ins_5_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5NotPrimary)
                    .IsRequired()
                    .HasColumnName("Ins_5_Not_Primary")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5Phone)
                    .IsRequired()
                    .HasColumnName("Ins_5_Phone")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5PolicyGroup)
                    .HasColumnName("Ins_5_Policy_Group")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5PrimaryName)
                    .IsRequired()
                    .HasColumnName("Ins_5_Primary_Name")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5Relationship)
                    .IsRequired()
                    .HasColumnName("Ins_5_Relationship")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5Sex)
                    .IsRequired()
                    .HasColumnName("Ins_5_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5SignatureDate)
                    .HasColumnName("Ins_5_Signature_Date")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5Ssn)
                    .HasColumnName("Ins_5_SSN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5State)
                    .IsRequired()
                    .HasColumnName("Ins_5_State")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ins5Zipcode).HasColumnName("Ins_5_Zipcode");

                entity.Property(e => e.Ins6Abbrev)
                    .HasColumnName("Ins_6_Abbrev")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6Address)
                    .IsRequired()
                    .HasColumnName("Ins_6_Address")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6Birthday)
                    .HasColumnName("Ins_6_Birthday")
                    .HasColumnType("date");

                entity.Property(e => e.Ins6City)
                    .IsRequired()
                    .HasColumnName("Ins_6_City")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6CoPay)
                    .HasColumnName("Ins_6_Co_pay")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6Employer)
                    .IsRequired()
                    .HasColumnName("Ins_6_Employer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6Id)
                    .HasColumnName("Ins_6_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6NotPrimary)
                    .IsRequired()
                    .HasColumnName("Ins_6_Not_Primary")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6Phone)
                    .IsRequired()
                    .HasColumnName("Ins_6_Phone")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6PolicyGroup)
                    .HasColumnName("Ins_6_Policy_Group")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6PrimaryName)
                    .IsRequired()
                    .HasColumnName("Ins_6_Primary_Name")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6Relationship)
                    .IsRequired()
                    .HasColumnName("Ins_6_Relationship")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6Sex)
                    .IsRequired()
                    .HasColumnName("Ins_6_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6SignatureDate)
                    .HasColumnName("Ins_6_Signature_Date")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6Ssn)
                    .HasColumnName("Ins_6_SSN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6State)
                    .IsRequired()
                    .HasColumnName("Ins_6_State")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ins6Zipcode).HasColumnName("Ins_6_Zipcode");

                entity.Property(e => e.InsNotes)
                    .HasColumnName("Ins_Notes")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Insurance1)
                    .HasColumnName("Insurance_1")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Insurance2)
                    .HasColumnName("Insurance_2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Insurance3)
                    .HasColumnName("Insurance_3")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.Insurance4)
                    .HasColumnName("Insurance_4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Insurance5)
                    .HasColumnName("Insurance_5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Insurance6)
                    .HasColumnName("Insurance_6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceBalance).HasColumnName("Insurance_Balance");

                entity.Property(e => e.InsuranceNotes)
                    .HasColumnName("Insurance_Notes")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastApptType)
                    .HasColumnName("Last_Appt_Type")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.LastExamDate)
                    .IsRequired()
                    .HasColumnName("Last_Exam_Date")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_Name")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LastProvider)
                    .IsRequired()
                    .HasColumnName("Last_Provider")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.LastVisitDate)
                    .IsRequired()
                    .HasColumnName("Last_Visit_Date")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasColumnName("Marital_Status")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MedicationsFullList)
                    .IsRequired()
                    .HasColumnName("Medications_Full_list")
                    .HasMaxLength(303)
                    .IsUnicode(false);

                entity.Property(e => e.MedicationsSummary)
                    .IsRequired()
                    .HasColumnName("Medications_Summary")
                    .HasMaxLength(458)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("Middle_Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Misc1Guardian)
                    .HasColumnName("Misc1_Guardian")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Misc2)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Newsletter)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OtherPhone)
                    .IsRequired()
                    .HasColumnName("Other_Phone")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PatientBalance).HasColumnName("Patient_Balance");

                entity.Property(e => e.PatientSex)
                    .IsRequired()
                    .HasColumnName("Patient_Sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PortalPassword)
                    .HasColumnName("Portal_Password")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PortalUsername)
                    .HasColumnName("Portal_Username")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PreferredContact)
                    .HasColumnName("Preferred_Contact")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PreferredContactType)
                    .HasColumnName("Preferred_Contact_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimCareCategory)
                    .HasColumnName("Prim_Care_Category")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimCareNameFirst)
                    .HasColumnName("Prim_Care_Name_First")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimCareNameLast)
                    .HasColumnName("Prim_Care_Name_Last")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimCareNameMiddle)
                    .HasColumnName("Prim_Care_Name_Middle")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimCareNamePrefix)
                    .HasColumnName("Prim_Care_Name_Prefix")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimCareNamePrinted)
                    .HasColumnName("Prim_Care_Name_Printed")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimCareNamePrinted2)
                    .HasColumnName("Prim_Care_Name_Printed_2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimCareNameSuffix)
                    .HasColumnName("Prim_Care_Name_Suffix")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimRefAddress)
                    .HasColumnName("Prim_Ref_Address")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimRefEmail)
                    .HasColumnName("Prim_Ref_Email")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimRefFax)
                    .HasColumnName("Prim_Ref_Fax")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimRefNotes)
                    .HasColumnName("Prim_Ref_Notes")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimRefNpi)
                    .HasColumnName("Prim_Ref_NPI")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimRefPhone)
                    .HasColumnName("Prim_Ref_Phone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryCareDoctor)
                    .HasColumnName("Primary_Care_Doctor")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryDoctor)
                    .IsRequired()
                    .HasColumnName("Primary_Doctor")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefAddress)
                    .HasColumnName("Pro_Ref_Address")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefCategory)
                    .HasColumnName("Pro_Ref_Category")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefEmail)
                    .HasColumnName("Pro_Ref_Email")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefFax)
                    .HasColumnName("Pro_Ref_Fax")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefNameFirst)
                    .HasColumnName("Pro_Ref_Name_First")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefNameLast)
                    .HasColumnName("Pro_Ref_Name_Last")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefNameMiddle)
                    .HasColumnName("Pro_Ref_Name_Middle")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefNamePrefix)
                    .HasColumnName("Pro_Ref_Name_Prefix")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefNamePrinted)
                    .HasColumnName("Pro_Ref_Name_Printed")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefNamePrinted2)
                    .HasColumnName("Pro_Ref_Name_Printed_2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefNameSuffix)
                    .HasColumnName("Pro_Ref_Name_Suffix")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefNotes)
                    .HasColumnName("Pro_Ref_Notes")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefNpi)
                    .HasColumnName("Pro_Ref_NPI")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProRefPhone)
                    .HasColumnName("Pro_Ref_Phone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Referral)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SendStatements)
                    .IsRequired()
                    .HasColumnName("Send_Statements")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SigOnFile)
                    .HasColumnName("Sig_On_File")
                    .HasColumnType("date");

                entity.Property(e => e.Ssn)
                    .IsRequired()
                    .HasColumnName("SSN")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SsnPartiallyMasked)
                    .HasColumnName("SSN_Partially_Masked")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TodaysDate)
                    .HasColumnName("Todays_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TodaysProvider)
                    .IsRequired()
                    .HasColumnName("Todays_Provider")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TotalBalance).HasColumnName("Total_Balance");

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("Work_Phone")
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
