#pragma checksum "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dc8f955aebaf87c07dd8b48303eb3331eb7bfb7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazoriseDemoApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using BlazoriseDemoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using BlazoriseDemoApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Blazorise.Charts.Streaming;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Blazorise.Bootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using BlazoriseDemoApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using BlazoriseDemoApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using IgniteUI.Blazor.Controls;

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
            __builder.AddAttribute(2, "b-yp2p6b0i0v");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-yp2p6b0i0v");
            __builder.OpenComponent<BlazoriseDemoApp.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-yp2p6b0i0v");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content px-4");
            __builder.AddAttribute(13, "b-yp2p6b0i0v");
            __builder.AddContent(14, 
#nullable restore
#line 12 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
