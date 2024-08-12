using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        public async Task<IActionResult>GetAuthor()
        {
            return Ok(await _context.Authors.ToListAsync());
        }
       
    }
}
