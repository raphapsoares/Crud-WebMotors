using CrudAnuncioWebMotors.Domain.Services.Config;
using System.Data;
using System.Data.SqlClient;

namespace CrudAnuncioWebMotors.Infra.Services
{
    public sealed class DbContext : IDisposable
    {
        public SqlConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }

        public DbContext(IConnectionConfig connectionConfig)
        {
            var stringConnection = connectionConfig.GetConnectionString();
            Connection = new SqlConnection(stringConnection);
            Connection.Open();
        }

        public void Dispose()
        {
            Connection?.Dispose();
        }
    }
}
