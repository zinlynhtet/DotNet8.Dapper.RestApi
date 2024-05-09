namespace DotNet8.Dapper.RestApi.Properties.Features;

public class Application
{
    private readonly DapperServices _dapperServices;

    public Application(DapperServices dapperServices)
    {
        _dapperServices = dapperServices;
    }

    public async Task<List<BlogDataModel>> GetBlogs()
    {
        var query = Queries.GetAllQuery;
        var lst = _dapperServices.Query<BlogDataModel>(query);
        return lst;
    }

    public async Task<BlogDataModel> GetBlogById()
    {
        var query = Queries.GetByIdQuery;
        var item = _dapperServices.QueryFirstOrDefault<BlogDataModel>(query);
        return item;
    }
}