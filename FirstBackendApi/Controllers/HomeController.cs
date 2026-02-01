using FirstBackendApi.Models;
using FirstBackendApi.Services;
using Microsoft.AspNetCore.Mvc;



namespace FirstBackendApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HomeController : Controller 
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpPost]
        public IActionResult CreateHome([FromBody] HomeRequestDto request)
        {
            
            var home = _homeService.Create(request.Name);   
            return Ok(home);
        }
    }
}
