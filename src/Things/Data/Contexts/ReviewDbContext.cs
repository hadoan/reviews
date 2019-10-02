using Microsoft.EntityFrameworkCore;
using Things.Data.Models;

namespace Things.Data.Contexts
{
    public class ReviewDbContext:DbContext
    {
        public DbSet<Thing> Things { get; set; }
    }
}