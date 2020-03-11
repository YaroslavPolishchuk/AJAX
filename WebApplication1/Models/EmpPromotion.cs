namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpPromotion")]
    public partial class EmpPromotion
    {
        public int EmpPromotionId { get; set; }

        public int EmployeeId { get; set; }

        public int JobTitleId { get; set; }

        [Column(TypeName = "date")]
        public DateTime HireDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual JobTitle JobTitle { get; set; }
    }
}
