#pragma checksum "/Users/leo/Documents/blazorTest/firstApp/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0296891ab458012453a050655170ea0a1db46307"
// <auto-generated/>
#pragma warning disable 1591
namespace firstApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/leo/Documents/blazorTest/firstApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/leo/Documents/blazorTest/firstApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/Users/leo/Documents/blazorTest/firstApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/Users/leo/Documents/blazorTest/firstApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/Users/leo/Documents/blazorTest/firstApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/Users/leo/Documents/blazorTest/firstApp/_Imports.razor"
using firstApp;

#line default
#line hidden
#line 7 "/Users/leo/Documents/blazorTest/firstApp/_Imports.razor"
using firstApp.Shared;

#line default
#line hidden
#line 8 "/Users/leo/Documents/blazorTest/firstApp/_Imports.razor"
using firstApp.Shared.Components.Atoms;

#line default
#line hidden
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content px-4");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddContent(7, 
#line 13 "/Users/leo/Documents/blazorTest/firstApp/Shared/MainLayout.razor"
         Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591