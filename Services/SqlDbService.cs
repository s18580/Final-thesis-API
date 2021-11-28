using Final_thesis_api.Models;

namespace Final_thesis_api.Services
{
    public class SqlDbService : IDbService
    {

        private readonly ModelContext _context;

        public SqlDbService(ModelContext context)
        {
            _context = context;
        }
    }
}
