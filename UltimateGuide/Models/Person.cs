namespace UltimateGuide.Models {
    public class Person {
        public string? Name{ get; set; }
        public DateTime? DateofBirth { get; set; }
        public Gender Gender { get; set; }
    }
    public enum Gender { 
        Male, Female, Other
    }
}
