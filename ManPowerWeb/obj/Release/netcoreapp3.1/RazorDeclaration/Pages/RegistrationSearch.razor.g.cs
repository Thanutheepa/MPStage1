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
#line 1 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using ManPowerWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using ManPowerWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using ManPowerCore.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using ManPowerCore.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\_Imports.razor"
using ManPowerCore.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\RegistrationSearch.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/planning/Registration")]
    public partial class RegistrationSearch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\RegistrationSearch.razor"
       

    private string selectedName;
    private string selecteddistrict;

    List<DepartmentUnit> listDistrict = new List<DepartmentUnit>();
    List<InduvidualBeneficiary> listName = new List<InduvidualBeneficiary>();
    List<InduvidualBeneficiary> searchNameList = new List<InduvidualBeneficiary>();


    protected override void OnInitialized()
    {
        DepartmentUnitTypeController _DepartmentUnitTypeController = ControllerFactory.CreateDepartmentUnitTypeController();
        listDistrict = _DepartmentUnitTypeController.GetDepartmentUnitType(2, true)._DepartmentUnit;

        InduvidualBeneficiaryController induvidualBeneficiaryController = ControllerFactory.CreateInduvidualBeneficiaryController();
        listName = induvidualBeneficiaryController.GetAllInduvidualBeneficiary();


    }

    async Task navigateToView(int BenificiaryId)
    {
        NavigationManager.NavigateTo($"/InduvidualBeneficiary/ViewInduvidualBeneficiary/{BenificiaryId}");
    }

    private void onClick_Search()
    {
        //InduvidualBeneficiary induvidualBeneficiary = new InduvidualBeneficiary();
        //InduvidualBeneficiaryController induvidualBeneficiaryController = ControllerFactory.CreateInduvidualBeneficiaryController();

        //searchNameList = induvidualBeneficiaryController.GetAllInduvidualBeneficiary(selectedName);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
