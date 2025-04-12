using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.Models {
    public class Book {
        [FromQuery]
        public int bookid { get; set; }
        public string author { get; set; }
    }
}
