using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("/api/user/")]
public class UserController : ControllerBase
{
    private readonly PaymentContext _context;

    public UserController(PaymentContext context)
    {
        _context = context;
    }
    
    [HttpPost("register")]
    public ActionResult RegisterUser([FromBody] UserModel newUser)
    {
        _context.User.Add(newUser);
        _context.SaveChanges();

        return Ok(newUser);
    }
}