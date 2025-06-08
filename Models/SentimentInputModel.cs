using System.ComponentModel.DataAnnotations;

namespace EcommerceML.Models
{
    public class SentimentInputModel
    {
        [Key]
        public int Id { get; set; }

        public string Opinion { get; set; }
    }
}
