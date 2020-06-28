using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DataModel.Eshopping
{
    public class RoleModel
    {
        public int RoleID { get; set; }

        [Required(ErrorMessage = "Role name is required")]
        [StringLength(100, ErrorMessage = "Role name should not exceed 100 characters")]
        public string RoleName { get; set; }

        [StringLength(500, ErrorMessage = "Role description should not exceed 500 characters")]
        public string RoleDescription { get; set; }
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "CreatedBy is required")]
        public string  CreatedBy { get; set; }
    }
}
