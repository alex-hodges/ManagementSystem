using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(ManagementSystemConstants.MAX_FIRST_NAME_LENGTH)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(ManagementSystemConstants.MAX_LAST_NAME_LENGTH)]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(ManagementSystemConstants.MAX_EMAIL_LENGTH)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(ManagementSystemConstants.MAX_PHONE_LENGTH)]
        public string PhonePrimary { get; set; }

        [DataType(DataType.Date)]

        public DateTime DateOfBirth { get; set; }

        [StringLength(ManagementSystemConstants.MAX_STREET_ADDRESS_LENGTH)]
        public string StreetAddress1 { get; set; }

        [StringLength(ManagementSystemConstants.MAX_STREET_ADDRESS_LENGTH)]
        public string StreetAdress2 { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(ManagementSystemConstants.MAX_CITY_LENGTH)]
        public string City { get; set; }

        [Required(ErrorMessage = "County is required")]
        public int CountyId { get; set; }
        public virtual County County { get; set; }

        [Required(ErrorMessage = "Postcode is required")]
        [Display(Name = "Postcode")]
        [RegularExpression("^([A-Za-z][A-Ha-hJ-Yj-y]?[0-9][A-Za-z0-9]? ?[0-9][A-Za-z]{2}|[Gg][Ii][Rr] ?0[Aa]{2})$")] //UK Postcode
        [StringLength(ManagementSystemConstants.MAX_POSTCODE_LENGTH, MinimumLength = ManagementSystemConstants.MIN_POSTCODE_LENGTH)]
        public string Postcode { get; set; }


        [Required]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Display(Name = "Full Name")]
        public string FriendlyName => $"{FirstName} {LastName}";

        [Display(Name = "Full Address")]
        public string FriendlyAddress => string.IsNullOrWhiteSpace(StreetAdress2)
            ? $"{StreetAddress1}, {City}, {County}, {Postcode}"
            : $"{StreetAddress1} - {StreetAdress2}, {City}, {Postcode}";
    }


}
