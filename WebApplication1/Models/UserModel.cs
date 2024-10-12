namespace WebApplication1.Models;

public class UserModel
{
    public int Id { get; set; }
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
    public decimal AccountBalance { get; set; }
    public string PhoneNumber { get; set; } = String.Empty;
    public string ProfilePictureUrl { get; set; } = String.Empty;
    public string Country { get; set; } = String.Empty;
    public string Street { get; set; } = String.Empty;
    public int Number { get; set; }
    public string City { get; set; } = String.Empty;
    public string State { get; set; } = String.Empty;
    public int ZipCode { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;

    public UserModel(string firstName, string lastName, string email, string password, decimal accountBalance, string phoneNumber, string profilePictureUrl, string country, string street, int number, string city, string state, int zipCode)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        AccountBalance = accountBalance;
        PhoneNumber = phoneNumber;
        ProfilePictureUrl = profilePictureUrl;
        Country = country;
        Street = street;
        Number = number;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
}