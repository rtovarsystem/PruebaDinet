using DinetApi.Interfaces;
using DinetApi.Models;
using Dapper;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace DinetApi.Repositories
{
    public class ProductosRepository: IProductosRepository
    {
        public IDapperDbConnection _dapperDbConnection;
        public ProductosRepository(IDapperDbConnection dapperDbConnection)
        {
            _dapperDbConnection = dapperDbConnection;
        }

        public async Task<Productos> CreateProductosAsync(Productos model)
        {
            using (IDbConnection db = _dapperDbConnection.CreateConnection())
            {
            var parameters = new DynamicParameters();
            parameters.Add("@Nombre", model.Nombre);
            parameters.Add("@Precio", model.Precio);
            parameters.Add("@FechaCreacion", model.FechaCreacion);
            await db.ExecuteAsync("sp_productos_insert", parameters, commandType: CommandType.StoredProcedure);
            return model;

            }
        }



        public async Task<IEnumerable<Productos>> GetAllProductosAsync()
        {
            using (IDbConnection db = _dapperDbConnection.CreateConnection())
            {
                return await db.QueryAsync<Productos>("sp_productos_listar", commandType: CommandType.StoredProcedure);
        
                
             }
        }

          
    }
}
