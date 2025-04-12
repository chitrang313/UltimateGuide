using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UltimateGuide.Models {
    public class Person {
        public Guid Id{ get; set; }

        [Required(ErrorMessage = "{0} can't be null or empty")]
        [Display(Name = "Person Name")]
        [StringLength(maximumLength:40, MinimumLength = 3, ErrorMessage = "{0} should be between {2} and {1} charactor long")]
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string? password { get; set; }
        public string? confirmPassword { get; set; }

        [Range(0,999.99,ErrorMessage = "{0} should be in between {1}$ to {2}$")]
        public double price { get; set; }
        public override string ToString() {
            return $"{Id}, {firstName}, {lastName}, {age}, {email}, {password}, {confirmPassword}";
        }
    }
}
