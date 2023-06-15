using Microsoft.AspNetCore.Identity;

namespace UserIdentitySolution.Entities;

public class User:IdentityUser
{
    public DateOnly? BirthDate { get; set; }
    public string? ProfilePicture { get; set; }
}
