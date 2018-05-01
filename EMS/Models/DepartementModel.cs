using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    [MetadataType(typeof(DepartementModel))]
    public partial class Departement
    {
    }
    public class DepartementModel
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please enter Department Name.")]
        public string Name { get; set; }

    }
}