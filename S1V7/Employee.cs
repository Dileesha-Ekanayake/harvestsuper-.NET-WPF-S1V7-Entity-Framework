using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S1V7
{
    [Table("employee", Schema = "harvest")]
    internal class Employee
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("dob")]
        public DateTime DOB { get; set; }

        [Column("nic")]
        public string Nic { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("mobile")]
        public string Mobile { get; set; }

        [ForeignKey("Gender")]
        [Column("gender_id")]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        [ForeignKey("Designation")]
        [Column("designation_id")]
        public int DesignationId { get; set; }
        public Designation Designation { get; set; }

        [ForeignKey("Employeestatus")]
        [Column("statusemployee_id")]
        public int EmployeeStatusId { get; set; }
        public Employeestatus Employeestatus { get; set; }
    }
}
