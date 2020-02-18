using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models
{
    public class County
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "County")]
        [Required(ErrorMessage = "Name of County is required")]
        [StringLength(ManagementSystemConstants.MAX_COUNTY_NAME_LENGTH)]
        public string Name { get; set; }

    }
}
