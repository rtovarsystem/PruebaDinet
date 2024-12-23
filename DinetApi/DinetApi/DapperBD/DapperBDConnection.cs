using DinetApi.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DinetApi.DapperBD
{
    public class DapperDbConnection : IDapperDbConnection
    {
        public readonly string _connectionString;
        public DapperDbConnection(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
