#pragma checksum "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewUpcomingPrograme.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4015666ffad998e339203c60da628d3e6d3ffb6"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/UpcommingProgramme/ViewUpcommingProgramme/{ProgramTargetId}")]
    public partial class ViewUpcomingPrograme : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "main");
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "primary-container");
            __builder.AddMarkupContent(5, "\r\n        \r\n");
#nullable restore
#line 6 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewUpcomingPrograme.razor"
         foreach (var prop in programTargetsList.Where(u => u.ProgramTargetId == Convert.ToInt32(ProgramTargetId)))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "wizard-heading");
            __builder.AddContent(9, "Approve Programs ");
#nullable restore
#line 8 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewUpcomingPrograme.razor"
__builder.AddContent(10, prop.ProgramTargetId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(12);
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-5");
                __builder2.AddAttribute(20, "style", "margin-right:100px;");
                __builder2.AddMarkupContent(21, "\r\n\r\n                    ");
                __builder2.AddMarkupContent(22, "<label class=\"label\">Date</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(23);
                __builder2.AddAttribute(24, "TValue", "string");
                __builder2.AddAttribute(25, "Class", "w-100");
                __builder2.AddAttribute(26, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewUpcomingPrograme.razor"
                                                                                prop.StartDate.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(28, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(30, "<label class=\"label\">Program Catogery</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                __builder2.AddAttribute(32, "TValue", "string");
                __builder2.AddAttribute(33, "Class", "w-100");
                __builder2.AddAttribute(34, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewUpcomingPrograme.razor"
                                                                                prop.ProgramTypeId.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(36, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(38, "<label class=\"label\">Program</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(39);
                __builder2.AddAttribute(40, "TValue", "string");
                __builder2.AddAttribute(41, "Class", "w-100");
                __builder2.AddAttribute(42, "Placeholder", "");
                __builder2.AddAttribute(43, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(44, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(46, "<label class=\"label\">Program Type</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(47);
                __builder2.AddAttribute(48, "TValue", "string");
                __builder2.AddAttribute(49, "Class", "w-100");
                __builder2.AddAttribute(50, "Placeholder", "");
                __builder2.AddAttribute(51, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(52, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(54, "<label class=\"label\">Work Attended Place</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(55);
                __builder2.AddAttribute(56, "TValue", "string");
                __builder2.AddAttribute(57, "Class", "w-100");
                __builder2.AddAttribute(58, "Placeholder", "");
                __builder2.AddAttribute(59, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(60, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(62, "<label class=\"label\">Expected Duty</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(63);
                __builder2.AddAttribute(64, "TValue", "string");
                __builder2.AddAttribute(65, "Class", "w-100");
                __builder2.AddAttribute(66, "Placeholder", "");
                __builder2.AddAttribute(67, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(68, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(70, "<label class=\"label\">Output</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(71);
                __builder2.AddAttribute(72, "TValue", "string");
                __builder2.AddAttribute(73, "Class", "w-100");
                __builder2.AddAttribute(74, "Placeholder", "");
                __builder2.AddAttribute(75, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(76, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(78, "<label class=\"label\">Outcome</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(79);
                __builder2.AddAttribute(80, "TValue", "string");
                __builder2.AddAttribute(81, "Class", "w-100");
                __builder2.AddAttribute(82, "Placeholder", "");
                __builder2.AddAttribute(83, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(84, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, " <br>\r\n\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.AddMarkupContent(87, "<a href=\"/planning/UpcommingProgramme\">\r\n                 <input type=\"button\" class=\"primary-btn\" value=\"Back\" style=\"width:220px;\">\r\n               </a>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 53 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewUpcomingPrograme.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewUpcomingPrograme.razor"
       
    [Parameter]
    public string ProgramTargetId { get; set; }

    //[Parameter]
    //public ProgramTarget Target { get; set; }

    private List<ProgramTarget> programTargetsList = new List<ProgramTarget>();

    protected override void OnInitialized()
    {
        base.OnInitialized();

         ProgramTargetController programTargetController = ControllerFactory.CreateProgramTargetController();
        programTargetsList = programTargetController.GetAllProgramTarget(false,false,false,false);

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
