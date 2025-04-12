using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using UltimateGuide.CustomValidators;

namespace UltimateGuide.Models {
    public class Person {
        public Guid Id{ get; set; }

        [Required(ErrorMessage = "{0} can't be null or empty")]
        [Display(Name = "Person Name")]
        [StringLength(maximumLength:40, MinimumLength = 3, ErrorMessage = "{0} should be between {2} and {1} charactor long")]
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public int age { get; set; }

        [EmailAddress(ErrorMessage = "{0} need to be in a prper format")]
        [Required(ErrorMessage = "{0} can't be blank")]
        public string email { get; set; }

        [Phone(ErrorMessage = "{0} must contain 10 Digit only")]
        public string phone { get; set; }

        [Required(ErrorMessage = "{0} can't be blank")]
        public string? password { get; set; }

        [Required(ErrorMessage = "{0} can't be blank")]
        [Compare("password",ErrorMessage = "{0} and {1} does not matched")]
        [Display(Name = "Confirm Password")]
        public string? confirmPassword { get; set; }


        [Range(0,999.99,ErrorMessage = "{0} should be in between {1}$ to {2}$")]
        public double price { get; set; }

        //[MinBirthYearValidatorAttribute(2005, ErrorMessage = "Date of Birth must be less then {0}")]
        [MinBirthYearValidatorAttribute(2005)]
        [Display(Name = "Date of Birth")]
        public DateTime dateofbirth{ get; set; }

        public override string ToString() {
            return $"{Id}, {firstName}, {lastName}, {age}, {email}, {password}, {confirmPassword}";
        }
    }
}
