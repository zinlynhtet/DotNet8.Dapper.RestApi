namespace DotNet8.Dapper.RestApi.DbService;

public interface IDapperServices
{
    List<T> Query<T>(string query, object? param = null);
    T QueryFirstOrDefault<T>(string query, object? param = null);
    int Execute(string query, object? param = null);
}