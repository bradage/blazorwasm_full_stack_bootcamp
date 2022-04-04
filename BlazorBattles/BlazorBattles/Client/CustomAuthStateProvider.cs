using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorBattles.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //return Task.FromResult(new AuthenticationState(new ClaimsPrincipal()));

            var identify = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, "Bradey")
            }, "test authentication type");

            var user = new ClaimsPrincipal(identify);

            return Task.FromResult(new AuthenticationState(user));

        }
    }
}
