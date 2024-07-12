using System.Security.Claims;

namespace Project.Net8.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetLoggedInUserId(this ClaimsPrincipal principal)
        {
            if (principal == null)
                throw new ArgumentNullException(nameof(principal));

            return principal.FindFirstValue("id");
        }
    }
}
