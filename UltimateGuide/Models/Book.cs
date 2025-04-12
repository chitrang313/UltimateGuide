using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace UltimateGuide.Models {
    public class Book {
        public int bookid { get; set; }
        public string author { get; set; }

        public override string ToString() {
            return $"Book: {bookid} && author: {author}";
        }
    }
}
