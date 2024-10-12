using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services;

public class UserServices
{
    private readonly PaymentContext _context;

    public UserServices(PaymentContext context)
    {
        _context = context;
    }
    
    public void TryRegisterUser(UserModel user)
    {
        try
        {
            _context.User.Add(user);
            _context.SaveChanges();
            Console.WriteLine("User registered successfully: ");
            Console.WriteLine($"ID: {user.Id} \nName: {user.FirstName} {user.LastName} \nEmail: {user.Email} \nPhone Number: {user.PhoneNumber} \nActive account: {user.IsActive} \nAccount Balance: {user.AccountBalance}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}