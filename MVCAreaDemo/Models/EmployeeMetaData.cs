using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCAreaDemo.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee
    {
    }

    public class EmployeeMetaData
    {
        [StringLength(10,MinimumLength =5, ErrorMessage = "Custom Message - Min Length 5 and Max Length is 10")]
        [Required]
        public string Name { get; set; }
    }
}