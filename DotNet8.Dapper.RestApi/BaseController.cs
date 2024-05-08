namespace DotNet8.Dapper.RestApi;

[ApiController]
public class BaseController : ControllerBase
{
    [NonAction]
    protected IActionResult InternalSeverError(Exception ex)
    {
        return Ok(ex);
    }
}