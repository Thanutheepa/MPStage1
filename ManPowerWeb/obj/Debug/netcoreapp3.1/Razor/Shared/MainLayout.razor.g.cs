#pragma checksum "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33107c0624b8dc36dd61a03af63b4f1b0c57f26b"
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
#line 4 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
using ManPowerCore.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
using ManPowerCore.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
using ManPowerCore.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
using ManPowerCore.Infrastructure;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ManPowerWeb.Shared.NavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "main");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "top-row");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<div class=\"col-9\">\r\n            <img src=\"../header2.png\" style=\"height:94%; width:30em\">\r\n        </div>\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-1");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(12);
            __builder.AddAttribute(13, "Style", "color:white;");
            __builder.AddAttribute(14, "Icon", "person");
            __builder.AddAttribute(15, "Shade", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Shade>(
#nullable restore
#line 24 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
                                                                    Shade.Lighter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
                                                                                          GetUserInformatin

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 27 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
         if (isClicked == true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-2");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 30 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
                 if (userRegistationDetailsList != null)
                {
                    name = "Log Out " + @userRegistationDetailsList.Name;
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(24);
            __builder.AddAttribute(25, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
                                     LogOutUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "Shade", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Shade>(
#nullable restore
#line 34 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
                                                        Shade.Lighter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
                                                                             name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 34 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
                                                                                               ButtonStyle.Danger

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 36 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
        }


        

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "content px-4");
            __builder.AddMarkupContent(35, "\r\n\r\n\r\n        ");
#nullable restore
#line 55 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
__builder.AddContent(36, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Shared\MainLayout.razor"
       
    private string name;
    private bool isClicked = false;

    public SystemUser userRegistationDetailsList;

    public async Task GetUserInformatin()
    {
        isClicked = true;
        userRegistationDetailsList = await sessionStorage.GetItemAsync<SystemUser>("UserDetails");

    }

    public void LogOutUser()
    {
        sessionStorage.ClearAsync();
        userRegistationDetailsList = new SystemUser();
        NavigationManager.NavigateTo("/login");
    }

    //protected override async void OnInitialized()
    //{
    //    base.OnInitialized();
    //    userRegistationDetailsList = await sessionStorage.GetItemAsync<SystemUser>("UserDetails");
    //}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591