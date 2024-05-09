namespace DotNet8.Dapper.RestApi.Properties.Features;

public interface IApplication
{
    Task<List<BlogDataModel>> GetBlogs();
    Task<BlogDataModel> GetBlogById(int id);
    Task<int> CreateBlog(BlogDataModel reqModel);
    Task<int> PutBlog(int id, BlogDataModel reqModel);
    Task<int> PatchBlog(int id, BlogDataModel reqModel);
    Task<int> DeleteBlog(int id);
    Task<BlogDataModel>? FindById(int id);
}