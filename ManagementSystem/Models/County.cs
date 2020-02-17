using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
