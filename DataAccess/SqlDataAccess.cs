using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace AFS.NET_Test.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private IConfiguration _config;

        public SqlDataAccess(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<IEnumerable<U>> LoadData<U, T>(string storedProcedures, T parametres, string connectionID = "Default")
        {
            using IDbConnection dbConnection = new SqlConnection(_config.GetConnectionString(connectionID));

            return await dbConnection.QueryAsync<U>(storedProcedures, parametres, commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(string storedProcedures, T parametres, string connectionID = "Default")
        {
            using IDbConnection dbconnection = new SqlConnection(_config.GetConnectionString(connectionID));

            await dbconnection.ExecuteAsync(storedProcedures, parametres, commandType: CommandType.StoredProcedure);
        }
    }
}
