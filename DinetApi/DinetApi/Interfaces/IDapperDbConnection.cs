using System.Data;

namespace DinetApi.Interfaces
{
    public interface IDapperDbConnection
    {
            public IDbConnection CreateConnection();
     
    }
}
