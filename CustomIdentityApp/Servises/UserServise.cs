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

        public string GetCurrentUserName()
        {
            var userName = _httpContextAccessor
                .HttpContext
                .User.Identity.Name;
                
            return userName;
        }
    }
}
