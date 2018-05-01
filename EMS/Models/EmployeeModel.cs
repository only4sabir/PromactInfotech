using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    //[MetadataType(typeof(EmployeeModel))]
    //public partial class Employee
    //{
    //}
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Please enter Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Surname.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter Address.")]
        public string Address { get; set; }
        public string Qualification { get; set; }
        [Required(ErrorMessage = "Please enter MobileNo."), RegularExpression(@"\d{10,15}", ErrorMessage = "Please enter valid MobileNo.")]
        public string Contact { get; set; }

    }
}