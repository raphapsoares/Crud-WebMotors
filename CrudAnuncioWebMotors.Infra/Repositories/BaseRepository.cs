using CrudAnuncioWebMotors.Infra.Services;
using System.Data.SqlClient;

namespace CrudAnuncioWebMotors.Infra.Repositories
{
    public class BaseRepository 
    {
        protected SqlTransaction transaction;
        protected DbContext _context;

        public BaseRepository()
        {
        }

        public BaseRepository(DbContext dbContext)
        {
            _context = dbContext;

        }
    }
}
