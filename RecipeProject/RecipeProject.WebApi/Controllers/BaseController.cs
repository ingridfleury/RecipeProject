using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RecipeProject.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]

    public class BaseController : ControllerBase
    {

    }
}
