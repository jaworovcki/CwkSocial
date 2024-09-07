using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V1;

[ApiVersion("1.0")]
[Route(ApiRoutes.BASEROUTE)]
[ApiController]
public class PostsController : Controller
{

    [HttpGet(ApiRoutes.Posts.GETBYID)]
    public IActionResult GetById(int id)
    {
        return Ok();
    }
}