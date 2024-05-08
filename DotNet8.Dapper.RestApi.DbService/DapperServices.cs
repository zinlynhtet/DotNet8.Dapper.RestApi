using System.Data;
using Microsoft.Data.SqlClient;

namespace DotNet8.Dapper.RestApi.DbService;

public class DapperServices
{
    private readonly string _connection;

    public DapperServices(string connection) => _connection = connection;

    public List<T> Query<T>(string query, object? param = null)
    {
        IDbConnection dbConnection = new SqlConnection(_connection);
        var lst = dbConnection.Query<T>(query, _connection).toList();
    }
}