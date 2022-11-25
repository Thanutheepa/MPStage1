// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ManPowerWeb.Pages
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
#line 7 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\Login.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\Login.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\Login.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\Login.razor"
using ManPowerCore.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\Login.razor"
using ManPowerCore.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\Login.razor"
using ManPowerCore.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\Login.razor"
using ManPowerCore.Infrastructure;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(PublicLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\Login.razor"
       


    //------------------ validator ----------------------//

    public class Model
    {

        public string userName { get; set; } = "";
        public string pw { get; set; } = "";

    }


    bool popup;

    Model model = new Model();

    // ----------------------------------------------------------------//
    string ViewBag;

    List<SystemUser> userRegistationDetailsList = new List<SystemUser>();
    List<SystemUser> userRegistationDetailsList2 = new List<SystemUser>();

    List<DepartmentUnitPositions> departmentUnitPosition = new List<DepartmentUnitPositions>();
    List<Possitions> positionList = new List<Possitions>();

    public async void OnSubmit(Model model)
    {


        SystemUser systemUser = new SystemUser();
        SystemUserController systemUserController = ControllerFactory.CreateSystemUserController();

        userRegistationDetailsList = systemUserController.GetAllSystemUser(model.userName);

        if (userRegistationDetailsList.Count == 0)
        {
            ViewBag = "enableUsarname";
        }
        else
        {
            userRegistationDetailsList2 = systemUserController.GetAllSystemUser(model.userName, model.pw);


            if (userRegistationDetailsList2.Count == 0)
            {
                ViewBag = "enablePassword";
            }

            else
            {
                int systemUserId;

                foreach (var item in userRegistationDetailsList)
                {
                    systemUserId = item.SystemUserId;



                    DepartmentUnitPositionsController departmentUnitPositionsController = ControllerFactory.CreateDepartmentUnitPositionsController();
                    departmentUnitPosition = departmentUnitPositionsController.GetAllDepartmentUnitPositions(systemUserId);
                }

                int positionId;

                foreach (var item2 in departmentUnitPosition)
                {
                    positionId = item2.PossitionsId;

                    PossitionsController possitionsController = ControllerFactory.CreatePossitionsController();
                    positionList = possitionsController.GetAllPossitions(positionId);

                }

                

                await sessionStorage.SetItemAsync("myFlag", "Green");  

                await LocalStore.SetItemAsync("UserDetails", userRegistationDetailsList.FirstOrDefault());
                await LocalStore.SetItemAsync("Position", positionList.FirstOrDefault());
                await sessionStorage.SetItemAsync("UserDetails", userRegistationDetailsList.FirstOrDefault());
                await sessionStorage.SetItemAsync("Position", positionList.FirstOrDefault());
                await sessionStorage.SetItemAsync("Department", departmentUnitPosition.FirstOrDefault());
                NavigationManager.NavigateTo("/index2");
            }
        }
    }

    void OnInvalidSubmit(FormInvalidSubmitEventArgs args)
    {
        Console.WriteLine($"InvalidSubmit: {JsonSerializer.Serialize(args, new JsonSerializerOptions() { WriteIndented = true })}");
    }

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