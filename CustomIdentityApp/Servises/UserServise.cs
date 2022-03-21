using CustomIdentityApp.Models;
using System.Security.Claims;

namespace CustomIdentityApp.Servises
{
    public class UserService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetCurrentUserId()
        {
            var idStr = _httpContextAccessor
                .HttpContext
                .User
                .Claims
                .SingleOrDefault(x => x.Type == ClaimTypes.NameIdentifier)
                ?.Value;
            return idStr;
        }
    }
}
