#pragma checksum "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\TopMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c50fd0e7b37dfeabcc5f404df8e2110b2eb1380"
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
    public partial class TopMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-menu");
            __builder.AddAttribute(2, "b-6svip1a404");
            __builder.AddMarkupContent(3, "<img src=\"icons/banana.png\" b-6svip1a404>\r\n    ");
            __builder.OpenElement(4, "span");
            __builder.AddAttribute(5, "class", "popover-header");
            __builder.AddAttribute(6, "b-6svip1a404");
#nullable restore
#line 7 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\TopMenu.razor"
__builder.AddContent(7, BananaService.Bananas);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenComponent<BlazorBattles.Client.Shared.AddBananas>(9);
            __builder.AddAttribute(10, "BananasAdded", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 9 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\TopMenu.razor"
                              AddBananas

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\TopMenu.razor"
       
    [Parameter]
    public int Bananas { get; set; } = 100;

    protected override void OnInitialized()
    {
        BananaService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        BananaService.OnChange -= StateHasChanged;
    }

    public void AddBananas(int value)
    {
        Bananas += value;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBananaService BananaService { get; set; }
    }
}
#pragma warning restore 1591