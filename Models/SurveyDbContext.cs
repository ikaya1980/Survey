using Microsoft.EntityFrameworkCore;

namespace Survey.Models
{
    public class SurveyDbContext : DbContext
    {
        public SurveyDbContext(DbContextOptions<SurveyDbContext> options) : base(options)
        { }
        public DbSet<Question> Questions { get; set; }

        public DbSet<Section> Sections { get; set; }
    }
}





