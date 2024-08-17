using CwkSocial.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V2;

[ApiVersion("2.0")]
[ApiController]
[Route("api/v2/[controller]")]
public class PostsController : Controller
{

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var post = new Post { Id = id, Content = "Hello, universe!" };
        return Ok(post);
    }
}