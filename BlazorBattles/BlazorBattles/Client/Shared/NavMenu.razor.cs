using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorBattles.Client.Shared
{
    public partial class NavMenu
    {
        [Inject] ILocalStorageService LocalStorage { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        [Inject] AuthenticationStateProvider AuthStateProvider { get; set; }

        private bool collapseNavMenu = true;

        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        private async void Logout()
        {
            await LocalStorage.RemoveItemAsync("authToken");
            await AuthStateProvider.GetAuthenticationStateAsync();
            NavigationManager.NavigateTo("/");
        }
    }
}
