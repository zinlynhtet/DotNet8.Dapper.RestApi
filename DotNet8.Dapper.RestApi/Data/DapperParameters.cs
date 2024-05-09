namespace DotNet8.Dapper.RestApi.Properties.Data;

public class DapperParameters
{
    public DapperParameters()
    {
    }

    public DapperParameters(string name, object value)
    {
        Name = name;
        Value = value;
    }

    public string Name { get; set; }
    public Object Value { get; set; }
}