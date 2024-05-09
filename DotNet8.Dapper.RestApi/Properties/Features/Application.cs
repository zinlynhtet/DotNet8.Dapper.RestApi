namespace DotNet8.Dapper.RestApi.Properties.Features;

public class Application
{
    private readonly DapperServices _dapperServices;

    public Application(DapperServices dapperServices) => _dapperServices = dapperServices;

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

    public async Task<int> CreateBlog(BlogDataModel reqModel)
    {
        var query = Queries.CreateQuery;
        var item = _dapperServices.Execute(query, reqModel);
        return item;
    }

    public async Task<int> PutBlog(int id, BlogDataModel reqModel)
    {
        var item = await FindById(id);
        if (item is null) throw new Exception("Invalid Id.");
        reqModel.BlogId = id;
        var query = Queries.UpdateQuery;
        var result = _dapperServices.Execute(query, reqModel);
        return result;
    }

    public async Task<int> PatchBlog(int id, BlogDataModel reqModel)
    {
        var item = await FindById(id);
        if (item is null) throw new Exception("Invalid Id.");
        var parameter = new List<DapperParameters>();
        var condition = Queries.Conditions(id, reqModel, parameter);
        var query = Queries.PatchQuery(condition);
        var result = _dapperServices.Execute(query, parameter
            .ToArray());
        return result;
    }

    public async Task<int> DeleteBlog(int id)
    {
        var query = Queries.DeleteQuery;
        var result = _dapperServices.Execute(query, new DapperParameters("@BlogId", id));
        return result;
    }

    private async Task<BlogDataModel>? FindById(int id)
    {
        var query = Queries.GetByIdQuery;
        var item = _dapperServices.QueryFirstOrDefault<BlogDataModel>(query, new BlogDataModel { BlogId = id });
        return item;
    }
}