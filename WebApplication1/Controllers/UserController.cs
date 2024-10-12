using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("/api/user/")]
public class UserController : ControllerBase
{
    private readonly UserServices _userServices;

    public UserController(UserServices userServices)
    {
        _userServices = userServices;
    }
    
    [HttpPost("register")]
    public ActionResult RegisterUser([FromBody] UserModel newUser)
    {
        _userServices.TryRegisterUser(newUser);
        return Ok(newUser);
    }
}