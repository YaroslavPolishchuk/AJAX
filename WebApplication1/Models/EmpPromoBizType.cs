using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmpPromoBizType
    {

        public int EmployeeId { get; set; }

   
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string NameJobTitle { get; set; }
        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }

    }
}