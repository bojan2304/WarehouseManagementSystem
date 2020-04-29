using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Only 30 characters allowed")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Only 30 characters allowed")]
        public string LastName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "100 characters allowed")]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "WE Card")]
        public WarehouseEmployeeCard WarehouseEmployeeCard { get; set; }

        public WarehouseBranch HomeWarehouseBranch { get; set; }

    }
}
