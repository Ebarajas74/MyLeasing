﻿using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The field {0} is mandatory.")]
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Document { get; set; }

        [Required(ErrorMessage ="The field {0} is mandatory.")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        public string Adress { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
