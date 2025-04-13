using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace UltimateGuide.CustomValidators {
  public class DateRangeValidatorAttribute:ValidationAttribute {
    private readonly string otherPropertyName;

    public DateRangeValidatorAttribute(string otherPropertyName) {
      this.otherPropertyName = otherPropertyName;
    }
    protected override ValidationResult? IsValid(object? value,ValidationContext validationContext) {
      if (value != null) {
        DateTime toDate = Convert.ToDateTime(value);

        if (otherPropertyName != null) {
          PropertyInfo? otherProperty = validationContext.ObjectType.GetProperty(otherPropertyName);

          DateTime fromDate = Convert.ToDateTime(otherProperty.GetValue(validationContext.ObjectInstance));

          if (fromDate > toDate) {
            return new ValidationResult(string.Format(ErrorMessage),new string[] {
                        otherPropertyName, validationContext.MemberName,
                    });
          } else {
            return ValidationResult.Success;
          }
        }
      }
      return null;
    }
  }
}
