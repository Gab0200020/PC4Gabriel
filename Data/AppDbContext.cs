using Microsoft.EntityFrameworkCore;
using EcommerceML.Models;

namespace EcommerceML.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<SentimentInputModel> Sentiments { get; set; }
        public DbSet<RecommendationInputModel> Recommendations { get; set; }
        // Puedes agregar más entidades según tu necesidad
    }
}
