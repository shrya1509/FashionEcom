using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BunaWebDesign.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
      [Required(ErrorMessage="Enter Name")]
        public string Name { get; set; }
       [Required(ErrorMessage="Enter Salary")]
        public string Salary { get; set; }
        public string Gender { get; set; }
      [Required(ErrorMessage="EnterDepartment")]
        public int DepartmentId { get; set; }
        public bool IsDeleted { get; set; }

        public string  DepartmentName{ get; set; }
        public bool Remember { get; set; }
        public string SiteName { get; set; }

    }
}