using System.Data.Entity;

namespace EfCodeFirstHomework
{
    public class VidzyContext : DbContext
    {
        public VidzyContext()
            :base("name=VidzyDbConnection")
        {
            
        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}