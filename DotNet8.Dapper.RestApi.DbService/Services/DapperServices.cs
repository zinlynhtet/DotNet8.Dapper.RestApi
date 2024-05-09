namespace DotNet8.Dapper.RestApi.DbService.Services;

public class DapperServices
{
    private readonly string _connection;

    public DapperServices(string connection) => _connection = connection;

    public List<T> Query<T>(string query, object? param = null)
    {
        IDbConnection dbConnection = new SqlConnection(_connection);
        var lst = dbConnection.Query<T>(query, _connection).ToList();
        return lst;
    }

    public T QueryFirstOrDefault<T>(string query, object? param = null)
    {
        IDbConnection dbConnection = new SqlConnection(_connection);
        var item = dbConnection.Query<T>(query, _connection).FirstOrDefault();
        return item;
    }

    public int Execute(string query, object? param = null)
    {
        IDbConnection dbConnection = new SqlConnection(_connection);
        var result = dbConnection.Execute(query, param);
        return result;
    }
}