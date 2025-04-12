using System.ComponentModel.DataAnnotations;

namespace UltimateGuide.CustomValidators {
    public class MinBirthYearValidatorAttribute : ValidationAttribute {
        public int MinBirthYear { get; }
        public string DefaultErrorMessage { get; set; } = "Date of Birth must be less then {0}";
        public MinBirthYearValidatorAttribute() { }
        public MinBirthYearValidatorAttribute(int minBirthYear) {
            MinBirthYear = minBirthYear;
        }

        protected override ValidationResult? IsValid(object? value,ValidationContext validationContext) {
            if (value != null) {
                DateTime date = (DateTime)value;
                if (date.Year >= MinBirthYear) {
                    return new ValidationResult(string.Format(ErrorMessage ?? DefaultErrorMessage,MinBirthYear));
                } else {
                    return ValidationResult.Success;
                }
            }
            return null;
        }
    }
}
