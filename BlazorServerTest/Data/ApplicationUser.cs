using Microsoft.AspNetCore.Identity;

namespace BlazorServerTest.Data
{
    public class ApplicationUser: IdentityUser
    {
        public override string UserName { get => base.UserName; set => base.UserName = value; }

    }
}
