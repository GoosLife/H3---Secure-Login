using H3___Secure_Login.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace H3___Secure_Login.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        [HttpGet("/login")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        []
        public IActionResult Login(LoginModel model)
        {
            return Ok(model.Username + " " + model.Password);
        }
    }
}
