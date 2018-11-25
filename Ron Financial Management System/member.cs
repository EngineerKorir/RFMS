namespace Ron_Financial_Management_System
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class member
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Key]
        [StringLength(20)]
        public string MemberNo { get; set; }

        [StringLength(50)]
        public string PayrollNo { get; set; }

        [Required]
        [StringLength(100)]
        public string Surname { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string SecondName { get; set; }

        [StringLength(25)]
        public string idno { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        public DateTime? birthdate { get; set; }

        [StringLength(10)]
        public string Title { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(30)]
        public string Nationality { get; set; }

        [StringLength(60)]
        public string email { get; set; }

        [StringLength(12)]
        public string maritalsts { get; set; }

        [StringLength(20)]
        public string homaddress { get; set; }

        [StringLength(20)]
        public string status { get; set; }

        [StringLength(50)]
        public string UserID { get; set; }

        public byte? RegFeePaid { get; set; }

        [StringLength(20)]
        public string regstatus { get; set; }

        public DateTime? Regdate { get; set; }

        [StringLength(20)]
        public string Employercode { get; set; }

        [StringLength(100)]
        public string stationcode { get; set; }

        public long? TermsOfService { get; set; }

        [Column("class")]
        [StringLength(10)]
        public string _class { get; set; }

        [StringLength(50)]
        public string Krapin { get; set; }

        public long? Branchcode { get; set; }

        [StringLength(50)]
        public string BankAccountNo { get; set; }

        public int? Bankcode { get; set; }

        public int? Bankbrachcode { get; set; }

        public int? MEM_CTY_CODE { get; set; }

        public int? MEM_CST_CODE { get; set; }

        public int? MEM_LOC_CODE { get; set; }

        public int? MEM_SLO_CODE { get; set; }

        public int? MEM_VIL_CODE { get; set; }

        public int? MEM_GRP_CODE { get; set; }

        public virtual member members1 { get; set; }

        public virtual member member1 { get; set; }
    }
}
