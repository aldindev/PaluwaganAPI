using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CustomerAddress { get; set; }
    public string CustomerPhone { get; set; }
    public string CustomerEmail { get; set; }
}

