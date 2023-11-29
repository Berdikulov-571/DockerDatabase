using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using RealDockerProject.DataContext;
using RealDockerProject.Models;

namespace RealDockerProject.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAll()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        [HttpPost]
        public async ValueTask<IActionResult> Post(User model)
        {
            await _context.Users.AddAsync(model);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
