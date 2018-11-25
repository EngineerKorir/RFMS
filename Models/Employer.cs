namespace Ron_Financial_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employer
    {
        [Key]
        [StringLength(20)]
        public string EmployerCode { get; set; }

        [Required]
        [StringLength(100)]
        public string EmployerName { get; set; }

        [StringLength(100)]
        public string EmpBox { get; set; }

        [StringLength(100)]
        public string EmpFax { get; set; }

        [StringLength(100)]
        public string EmpTel { get; set; }

        [StringLength(100)]
        public string EmpMobile { get; set; }

        [StringLength(100)]
        public string EmpEmail { get; set; }

        [StringLength(100)]
        public string Contactperson { get; set; }

        public byte RemUpdateStatus { get; set; }

        public int FosaEmpCode { get; set; }

        public byte C7format { get; set; }

        public byte InterestCalculation { get; set; }

        [StringLength(50)]
        public string userid { get; set; }

        public double? Amount { get; set; }
    }
}
