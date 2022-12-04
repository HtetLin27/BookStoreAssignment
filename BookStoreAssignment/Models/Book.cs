using System.ComponentModel.DataAnnotations;

namespace BookStoreAssignment.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        
        public string Category { get; set; } = string.Empty;
       
    }
}
