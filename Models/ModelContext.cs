using Microsoft.EntityFrameworkCore;

namespace Final_thesis_api.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext() { }
        public ModelContext(DbContextOptions options) : base(options) { }
    }
}
