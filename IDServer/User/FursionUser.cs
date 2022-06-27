using System;
using Microsoft.AspNetCore.Identity;

namespace IDServer.User
{
	public class FursionUser:IdentityUser
	{
        public string? City { get; set; }
        public string? HeadUrl { get; set; }
        public string? Signature { get; set; }
    }
}

