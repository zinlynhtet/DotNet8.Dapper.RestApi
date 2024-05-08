namespace DotNet8.Dapper.RestApi.DbService;

public static class SqlConnectionStrings
{
    public static SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder
    {
        DataSource = ".",
        InitialCatalog = "TestDb",
        UserID = "sa",
        Password = "sasa@123",
        TrustServerCertificate = true
    };
}