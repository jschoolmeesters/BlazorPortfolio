using System.Globalization;
using System.Text.Json.Serialization;

namespace BlazorPortfolio.Models {
    public class Post
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        public DateTime DateAsDateTime {
            get {
                return DateTime.Parse(Date, new CultureInfo("nl-NL"));
            }
        }

        /*
        Post(string id, string title, string date) {
            Id = id;
            Title = title;
            Date = date;
        }
        */
    }
}