namespace WebApplicationBookApp.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        public string Author { get; set; }

        public string DateOfPublish { get; set; }

        public float Price { get; set; }

        public string PhotoFileName { get; set; }

        public string PhotoUrl { get; set; } = "/Photos/spongebob.png";
    }
}
