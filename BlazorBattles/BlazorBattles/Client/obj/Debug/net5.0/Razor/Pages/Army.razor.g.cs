#pragma checksum "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Pages\Army.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50f22de373373da77a8c7c701216c8ee2640ad68"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBattles.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/army")]
    public partial class Army : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>My Army</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
#nullable restore
#line 7 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
     foreach (var userUnit in UnitService.MyUnits)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "tr");
            __builder.OpenElement(4, "td");
#nullable restore
#line 11 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
                 switch (userUnit.UnitId)
                {
                    case 1:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<img src=\"icons/knight.png\">");
#nullable restore
#line 15 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
                        break;
                    case 2:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<img src=\"icons/archer.png\">");
#nullable restore
#line 18 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
                        break;
                    case 3:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<img src=\"icons/mage.png\">");
#nullable restore
#line 21 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
                        break;
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 25 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
__builder.AddContent(10, UnitService.Units.First(unit => unit.Id == userUnit.UnitId).Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 28 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
__builder.AddContent(13, userUnit.HitPoints);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, " HP\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\mygit\blazorwasm_full_stack_bootcamp\BlazorBattles\BlazorBattles\Client\Pages\Army.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnitService UnitService { get; set; }
    }
}
#pragma warning restore 1591
