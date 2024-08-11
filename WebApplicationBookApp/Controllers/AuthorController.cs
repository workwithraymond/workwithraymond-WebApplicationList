using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBookApp.Controllers
{
    public class AuthorController : Controller
    {

        private BookDbContext _context;
        private IWebHostEnvironment _hostenv; 
        public AuthorController(BookDbContext context, IWebHostEnvironment hostenv) 
        {
            _context = context;
            _hostenv = hostenv;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
