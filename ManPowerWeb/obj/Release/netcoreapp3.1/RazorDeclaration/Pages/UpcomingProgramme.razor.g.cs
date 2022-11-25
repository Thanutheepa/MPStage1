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
#line 3 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\UpcomingProgramme.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/planning/UpcommingProgramme")]
    public partial class UpcomingProgramme : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\UpcomingProgramme.razor"
       

    private int selectedProgrameType;
    private int selecteddistrict;
    private string officer;
    private string district;
    private string ds;
    private string pName;
    private string pTypeName;
    //private DateTime date;

    //private string emptyText = "No Items to display!";
    //private List<Upcommingmodel> Upcomming = new List<Upcommingmodel> ();

    private List<ProgramTarget> programTargetsList = new List<ProgramTarget>();
    private List<ProgramTarget> myList = new List<ProgramTarget>();
    private List<ProgramAssignee> asignee = new List<ProgramAssignee>();
    private List<DepartmentUnitPositions> unitPositions = new List<DepartmentUnitPositions>();
    private List<SystemUser> user = new List<SystemUser>();
    List<DepartmentUnit> listDistrict = new List<DepartmentUnit>();
    List<DepartmentUnitType> unitType = new List<DepartmentUnitType>();
    List<ProgramType> listProgramType = new List<ProgramType>();
    List<ManPowerCore.Domain.Program> program = new List<ManPowerCore.Domain.Program>();


    protected override void OnInitialized()
    {
        DepartmentUnitPositionsController unitPositionsController = ControllerFactory.CreateDepartmentUnitPositionsController();
        unitPositions = unitPositionsController.GetAllDepartmentUnitPositions(false, false, true, false, true);

        SystemUserController systemUserController = ControllerFactory.CreateSystemUserController();
        user = systemUserController.GetAllSystemUser(true, false, false);

        DepartmentUnitController unit = ControllerFactory.CreateDepartmentUnitController();
        listDistrict = unit.GetAllDepartmentUnit(false, false);

        DepartmentUnitTypeController aa = ControllerFactory.CreateDepartmentUnitTypeController();
        unitType = aa.GetAllDepartmentUnitType(true);

        ProgramTypeController programTypeController = ControllerFactory.CreateProgramTypeController();
        listProgramType = programTypeController.GetAllProgramType(false);

        ProgramTargetController programTargetController = ControllerFactory.CreateProgramTargetController();
        programTargetsList = programTargetController.GetAllProgramTarget(false,false,true,false);

        ProgramAssigneeController programAssigneeController = ControllerFactory.CreateProgramAssigneeController();
        asignee = programAssigneeController.GetAllProgramAssignee(true, true, true);

        ProgramController programController = ControllerFactory.CreateProgramController();
        program = programController.GetAllProgram(false);

    }



    async Task navigateToView(int ProgramTargetId)
    {
        NavigationManager.NavigateTo($"/UpcommingProgramme/ViewUpcommingProgramme/{ProgramTargetId}");
    }
    List<ProgramTarget> ProgramTrgetList = new List<ProgramTarget>();
    private void onClick_Search()
    {
        
        ProgramTarget programTarget = new ProgramTarget();
        ProgramTargetController programTargetController = ControllerFactory.CreateProgramTargetController();

        ProgramTrgetList = programTargetController.GetAllProgramTarget(selectedProgrameType);
    }


        //-------------- Date Picker handler --------------------//

    DateTime? startDate = DateTime.Today;
    DateTime? date = DateTime.Today;

    IEnumerable<DateTime> dates = new DateTime[] { DateTime.Today.AddDays(-1), DateTime.Today.AddDays(1) };



    void OnChange(DateTime? value, string name, string format)
    {
    }

    void DateRenderSpecial(DateRenderEventArgs args)
    {
        if (dates.Contains(args.Date))
        {
            args.Attributes.Add("style", "background-color: #ff6d41; border-color: white;");
        }
    }

    void DateRender(DateRenderEventArgs args)
    {
        args.Disabled = args.Disabled || dates.Contains(args.Date);
    }

    void DateRenderNoWeekends(DateRenderEventArgs args)
    {
        args.Disabled = args.Disabled || args.Date.DayOfWeek == DayOfWeek.Sunday || args.Date.DayOfWeek == DayOfWeek.Saturday;
    }

    void OnTodayClick()
    {
        startDate = DateTime.Today;
        date = DateTime.Today;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591