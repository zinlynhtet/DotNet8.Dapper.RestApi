namespace DotNet8.Dapper.RestApi.Properties.Features;

[Route("api/[controller]")]
[ApiController]
public class DapperController : BaseController
{
    private readonly IApplication _application;
    public DapperController(IApplication application) => _application = application ?? throw new ArgumentNullException(nameof(application));

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var list = await _application.GetBlogs();
            return Ok(list);
        }
        catch (Exception ex)
        {
            return InternalSeverError(ex);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var item = await _application.GetBlogById(id);
            if (item is null) return NotFound("No Data Found.");
            return Ok(item);
        }
        catch (Exception ex)
        {
            return InternalSeverError(ex);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create(BlogDataModel reqModel)
    {
        try
        {
            var item = await _application.CreateBlog(reqModel);
            var message = item > 0 ? "Saving Successful." : "Saving Failed";
            return Ok(message);
        }
        catch (Exception ex)
        {
            return InternalSeverError(ex);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, BlogDataModel reqModel)
    {
        try
        {
            var item = await _application.PutBlog(id, reqModel);
            var message = item > 0 ? "Updating Successful." : "Updating Failed";
            return Ok(message);
        }
        catch (Exception ex)
        {
            return InternalSeverError(ex);
        }
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, BlogDataModel reqModel)
    {
        try
        {
            var item = await _application.PatchBlog(id, reqModel);
            var message = item > 0 ? "Updating Successful." : "Updating Failed";
            return Ok(message);
        }
        catch (Exception ex)
        {
            return InternalSeverError(ex);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var item = await _application.DeleteBlog(id);
            var message = item > 0 ? "Updating Successful." : "Updating Failed";
            return Ok(message);
        }
        catch (Exception ex)
        {
            return InternalSeverError(ex);
        }
    }
}