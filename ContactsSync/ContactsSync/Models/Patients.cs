using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactsSync.Models
{
    [Table("patients")]
    public partial class Patients
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("First_Name")]
        [StringLength(128)]
        public string FirstName { get; set; }
        [Column("Middle_Name")]
        [StringLength(128)]
        public string MiddleName { get; set; }
        [Column("Last_Name")]
        [StringLength(128)]
        public string LastName { get; set; }
        [StringLength(128)]
        public string Nickname { get; set; }
        [Column("Full_Name")]
        [StringLength(128)]
        public string FullName { get; set; }
        [StringLength(128)]
        public string Address1 { get; set; }
        [StringLength(128)]
        public string Address2 { get; set; }
        [StringLength(128)]
        public string City { get; set; }
        [StringLength(128)]
        public string State { get; set; }
        [StringLength(128)]
        public string Zipcode { get; set; }
        [Column("DOB")]
        [StringLength(128)]
        public string Dob { get; set; }
        [Column("Home_Phone")]
        [StringLength(128)]
        public string HomePhone { get; set; }
        [Column("Work_Phone")]
        [StringLength(128)]
        public string WorkPhone { get; set; }
        [Column("Cell_Phone")]
        [StringLength(128)]
        public string CellPhone { get; set; }
        [StringLength(128)]
        public string Email { get; set; }
    }
}
