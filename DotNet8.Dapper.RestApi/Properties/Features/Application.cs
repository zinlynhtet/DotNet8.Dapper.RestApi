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

    public async Task<BlogDataModel> GetBlogById(int id)
    {
        var item = await FindById(id);
        return item;
    }

    private async Task<BlogDataModel>? FindById(int id)
    {
        var query = Queries.GetByIdQuery;
        var item = _dapperServices.QueryFirstOrDefault<BlogDataModel>(query, new BlogDataModel { BlogId = id });
        return item;
    }
    
}