#pragma checksum "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b417368176a91b73aa4461db2dbfaad35923c830"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-l1st1jcckf");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-l1st1jcckf");
            __builder.OpenComponent<BlazorBattles.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-l1st1jcckf");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-l1st1jcckf");
            __builder.OpenComponent<BlazorBattles.Client.Shared.TopMenu>(14);
            __builder.AddAttribute(15, "Bananas", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\MainLayout.razor"
                              200

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "content px-4");
            __builder.AddAttribute(19, "b-l1st1jcckf");
#nullable restore
#line 14 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Shared\MainLayout.razor"
__builder.AddContent(20, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
