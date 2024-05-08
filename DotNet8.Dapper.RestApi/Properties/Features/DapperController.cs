namespace DotNet8.Dapper.RestApi.Properties.Features;

[Route("api/[controller]")]
[ApiController]
public class DapperController : BaseController
{
    public async Task<IActionResult> Get()
    {
        return Ok();
    }

    public async Task<IActionResult> GetById(int id)
    {
        return Ok();
    }

    public async Task<IActionResult> Create(BlogDataModel reqModel)
    {
        return Ok();
    }

    public async Task<IActionResult> Put(int id, BlogDataModel reqModel)
    {
        return Ok();
    }

    public async Task<IActionResult> Patch(int id, BlogDataModel reqModel)
    {
        return Ok();
    }

    public async Task<IActionResult> Delete(int id)
    {
        return Ok();
    }
}