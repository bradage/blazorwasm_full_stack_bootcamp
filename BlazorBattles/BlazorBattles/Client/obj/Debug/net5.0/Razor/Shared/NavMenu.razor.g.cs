#pragma checksum "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e9a70ee22d0ca8b233535771e0566b2b73a315"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBattles.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-ln95ya9lal");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-ln95ya9lal><img src=\"icons/axe.png\" b-ln95ya9lal> Blazor Battles</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-ln95ya9lal");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-ln95ya9lal></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-ln95ya9lal");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-ln95ya9lal");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-ln95ya9lal");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-ln95ya9lal></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(27);
            __builder.AddAttribute(28, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(29, "li");
                __builder2.AddAttribute(30, "class", "nav-item px-3");
                __builder2.AddAttribute(31, "b-ln95ya9lal");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
                __builder2.AddAttribute(33, "class", "nav-link");
                __builder2.AddAttribute(34, "href", "build");
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(36, "<span class=\"oi oi-wrench\" aria-hidden=\"true\" b-ln95ya9lal></span> Build\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenElement(38, "li");
                __builder2.AddAttribute(39, "class", "nav-item px-3");
                __builder2.AddAttribute(40, "b-ln95ya9lal");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
                __builder2.AddAttribute(42, "class", "nav-link");
                __builder2.AddAttribute(43, "href", "army");
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(45, "<span class=\"oi oi-people\" aria-hidden=\"true\" b-ln95ya9lal></span> My Army\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.OpenElement(47, "li");
                __builder2.AddAttribute(48, "class", "nav-item px-3");
                __builder2.AddAttribute(49, "b-ln95ya9lal");
                __builder2.OpenElement(50, "a");
                __builder2.AddAttribute(51, "class", "nav-link");
                __builder2.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\NavMenu.razor"
                                                  Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "style", "cursor: pointer;");
                __builder2.AddAttribute(54, "b-ln95ya9lal");
                __builder2.AddMarkupContent(55, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\" b-ln95ya9lal></span> Logout\r\n                    ");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(56, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(57, "li");
                __builder2.AddAttribute(58, "class", "nav-item px-3");
                __builder2.AddAttribute(59, "b-ln95ya9lal");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
                __builder2.AddAttribute(61, "class", "nav-link");
                __builder2.AddAttribute(62, "href", "register");
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(64, "<span class=\"oi oi-pencil\" aria-hidden=\"true\" b-ln95ya9lal></span> Register\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
