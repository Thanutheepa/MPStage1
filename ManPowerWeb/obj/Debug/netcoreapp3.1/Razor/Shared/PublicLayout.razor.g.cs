#pragma checksum "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\PublicLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c31f6fd8ef1af1b48bfa09b7ab8d66a98d398101"
// <auto-generated/>
#pragma warning disable 1591
namespace ManPowerWeb.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using ManPowerWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using ManPowerWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using ManPowerCore.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using ManPowerCore.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using ManPowerCore.Controller;

#line default
#line hidden
#nullable disable
    public partial class PublicLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"top-row\">\r\n    <div class=\"col-12\">\r\n        <img src=\"../header2.png\" style=\"height:94%; width:30em\">\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "article");
            __builder.AddAttribute(2, "class", "content px-4");
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n    ");
#nullable restore
#line 13 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\PublicLayout.razor"
__builder.AddContent(4, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591