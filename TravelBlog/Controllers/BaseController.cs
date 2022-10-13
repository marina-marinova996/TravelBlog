using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelBlog.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
