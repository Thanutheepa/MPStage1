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
    [Microsoft.AspNetCore.Components.RouteAttribute("/dme22Approval")]
    public partial class DME22Approval : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 162 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME22Approval.razor"
       
    string[] form = { "DME 21", "DME 22" };
    string[] year = { "2021", "2022" };

    private int status;
    private List<DME21Model> dme = new List<DME21Model>();
    private bool isClicked = false;
    private int count;
    private string statusName;
    private string monthName;

    private string selectedForm;
    private string selectedYear;
    private int selectedMonth;
    private int selectedStatus;

    List<TaskType> taskTypes = new List<TaskType>();
    List<ProjectStatus> pStatus = new List<ProjectStatus>();
    List<TaskAllocationDetail> taskAllocationDetails = new List<TaskAllocationDetail>();
    TaskAllocationDetail single = new TaskAllocationDetail();
    TaskAllocationDetail task = new TaskAllocationDetail();
    List<TaskAllocation> taskAllocations = new List<TaskAllocation>();
    List<TaskAllocation> myList = new List<TaskAllocation>();
    List<Month> monthTable = new List<Month>();
    public SystemUser userRegistationDetailsList;


    protected override void OnInitialized()
    {
        base.OnInitialized();

        monthTable.Add(new Month() { monthName = "January", monthNumber = 1 });
        monthTable.Add(new Month() { monthName = "February", monthNumber = 2 });
        monthTable.Add(new Month() { monthName = "March", monthNumber = 3 });
        monthTable.Add(new Month() { monthName = "April", monthNumber = 4 });
        monthTable.Add(new Month() { monthName = "May", monthNumber = 5 });
        monthTable.Add(new Month() { monthName = "June", monthNumber = 6 });
        monthTable.Add(new Month() { monthName = "July", monthNumber = 7 });
        monthTable.Add(new Month() { monthName = "August", monthNumber = 8 });
        monthTable.Add(new Month() { monthName = "September", monthNumber = 9 });
        monthTable.Add(new Month() { monthName = "October", monthNumber = 10 });
        monthTable.Add(new Month() { monthName = "November", monthNumber = 11 });
        monthTable.Add(new Month() { monthName = "December", monthNumber = 12 });


        ProjectStatusController projectStatus = ControllerFactory.CreateProjectStatusController();
        pStatus = projectStatus.GetAllProjectStatus(false);

        TaskTypeController taskTypeController = ControllerFactory.CreateTaskTypeController();
        taskTypes = taskTypeController.GetAllTaskType(false);

        TaskAllocationDetailController aa = ControllerFactory.CreateTaskAllocationDetailController();
        taskAllocationDetails = aa.GetAllTaskAllocationDetail(false, false, false);

        TaskAllocationController taskAllocationList = ControllerFactory.CreateTaskAllocationController();
        taskAllocations = taskAllocationList.GetAllTaskAllocation(true, false, true, true);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            userRegistationDetailsList = await sessionStorage.GetItemAsync<SystemUser>("UserDetails");
            foreach (var i in taskAllocations.Where(u => u.ApprovedBy == userRegistationDetailsList.Name && u.StatusId == 4))
            {
                myList.Add(i);
            }

            StateHasChanged();
        }
    }

    async Task navigateToView(int index)
    {
        NavigationManager.NavigateTo($"/approvalView/{index}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
