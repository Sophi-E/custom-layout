#pragma checksum "C:\Users\Test\Desktop\BlazorCustomLayout\Shared\CoinageMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "998f7d243e42b85525dd5bb9d40b5fb6f76c4595"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCustomLayout.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Test\Desktop\BlazorCustomLayout\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Test\Desktop\BlazorCustomLayout\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Test\Desktop\BlazorCustomLayout\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Test\Desktop\BlazorCustomLayout\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Test\Desktop\BlazorCustomLayout\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Test\Desktop\BlazorCustomLayout\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Test\Desktop\BlazorCustomLayout\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Test\Desktop\BlazorCustomLayout\_Imports.razor"
using BlazorCustomLayout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Test\Desktop\BlazorCustomLayout\_Imports.razor"
using BlazorCustomLayout.Shared;

#line default
#line hidden
#nullable disable
    public partial class CoinageMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-dark bg-dark");
            __builder.AddMarkupContent(2, "\r\n  ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\"#\">Coinage</a>\r\n  ");
            __builder.AddMarkupContent(4, @"<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
    <span class=""navbar-toggler-icon""></span>
  </button>

  ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "collapse navbar-collapse");
            __builder.AddAttribute(7, "id", "navbarSupportedContent");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "ul");
            __builder.AddAttribute(10, "class", "navbar-nav mr-auto");
            __builder.AddMarkupContent(11, "\r\n      ");
            __builder.AddMarkupContent(12, "<li class=\"nav-item active\">\r\n        <a class=\"nav-link\" href=\"#\">Home <span class=\"sr-only\">(current)</span></a>\r\n      </li>\r\n      ");
            __builder.AddMarkupContent(13, "<li class=\"nav-item\">\r\n        <a class=\"nav-link\" href=\"#\">Link</a>\r\n      </li>\r\n      ");
            __builder.AddMarkupContent(14, @"<li class=""nav-item dropdown"">
        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
          Dropdown
        </a>
        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
          <a class=""dropdown-item"" href=""#"">Action</a>
          <a class=""dropdown-item"" href=""#"">Another action</a>
          <div class=""dropdown-divider""></div>
          <a class=""dropdown-item"" href=""#"">Something else here</a>
        </div>
      </li>
      ");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "nav-item px-3");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", "nav-link");
            __builder.AddAttribute(20, "href", "admin/users");
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Admin users\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    \r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
