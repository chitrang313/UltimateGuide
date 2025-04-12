using System.ComponentModel.DataAnnotations;

namespace UltimateGuide.Models {
    public class Person {
        public Guid Id{ get; set; }
        [Required(ErrorMessage = "Person name can't be null or empty")]
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string? password { get; set; }
        public string? confirmPassword { get; set; }

        public override string ToString() {
            return $"{Id}, {firstName}, {lastName}, {age}, {email}, {password}, {confirmPassword}";
        }
    }
}
