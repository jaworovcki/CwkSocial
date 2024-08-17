using CwkSocial.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V1;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v1/[controller]")]
public class PostsController : Controller
{

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var post = new Post { Id = id, Content = "Hello, world!" };
        return Ok(post);
    }
}