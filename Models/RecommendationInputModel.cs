using System.ComponentModel.DataAnnotations;

namespace EcommerceML.Models
{
    public class RecommendationInputModel
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
    }
}
