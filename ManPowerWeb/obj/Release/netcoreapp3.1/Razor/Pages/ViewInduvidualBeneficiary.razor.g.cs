#pragma checksum "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffb8e1366349c82fd31c10a7bcaf2836d79c84b0"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/InduvidualBeneficiary/ViewInduvidualBeneficiary/{BenificiaryId}")]
    public partial class ViewInduvidualBeneficiary : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "primary-container");
            __builder.AddMarkupContent(5, "\r\n        \r\n");
#nullable restore
#line 6 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
         foreach (var prop in InduvidualBeneficiarylist.Where(u => u.BenificiaryId == Convert.ToInt32(BenificiaryId)))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "wizard-heading");
            __builder.AddContent(9, "Induvidual Beneficiary details ");
#nullable restore
#line 8 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
__builder.AddContent(10, prop.BenificiaryId);

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
                __builder2.AddMarkupContent(22, "<label class=\"label\">NIC</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(23);
                __builder2.AddAttribute(24, "TValue", "string");
                __builder2.AddAttribute(25, "Class", "w-100");
                __builder2.AddAttribute(26, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.Nic.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(28, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(30, "<label class=\"label\">Name</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                __builder2.AddAttribute(32, "TValue", "string");
                __builder2.AddAttribute(33, "Class", "w-100");
                __builder2.AddAttribute(34, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.InduvidualBeneficiaryName.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(36, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(38, "<label class=\"label\">Gender</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(39);
                __builder2.AddAttribute(40, "TValue", "string");
                __builder2.AddAttribute(41, "Class", "w-100");
                __builder2.AddAttribute(42, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.Gender.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(44, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(46, "<label class=\"label\">Date Of Birth</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(47);
                __builder2.AddAttribute(48, "TValue", "string");
                __builder2.AddAttribute(49, "Class", "w-100");
                __builder2.AddAttribute(50, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.DateOfBirth.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(52, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(54, "<label class=\"label\">Personal Address</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(55);
                __builder2.AddAttribute(56, "TValue", "string");
                __builder2.AddAttribute(57, "Class", "w-100");
                __builder2.AddAttribute(58, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.PersonalAddress.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(60, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(62, "<label class=\"label\">Email</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(63);
                __builder2.AddAttribute(64, "TValue", "string");
                __builder2.AddAttribute(65, "Class", "w-100");
                __builder2.AddAttribute(66, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.Email.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(68, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(70, "<label class=\"label\">Job preference</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(71);
                __builder2.AddAttribute(72, "TValue", "string");
                __builder2.AddAttribute(73, "Class", "w-100");
                __builder2.AddAttribute(74, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.JobPreference.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(76, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(78, "<label class=\"label\">Contact Number</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(79);
                __builder2.AddAttribute(80, "TValue", "string");
                __builder2.AddAttribute(81, "Class", "w-100");
                __builder2.AddAttribute(82, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.ContactNumber.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(84, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(86, "<label class=\"label\">Whatsapp Number</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(87);
                __builder2.AddAttribute(88, "TValue", "string");
                __builder2.AddAttribute(89, "Class", "w-100");
                __builder2.AddAttribute(90, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.WhatsappNumber.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(92, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(94, "<label class=\"label\">School Name</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(95);
                __builder2.AddAttribute(96, "TValue", "string");
                __builder2.AddAttribute(97, "Class", "w-100");
                __builder2.AddAttribute(98, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.SchoolName.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(100, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(102, "<label class=\"label\">Address of School</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(103);
                __builder2.AddAttribute(104, "TValue", "string");
                __builder2.AddAttribute(105, "Class", "w-100");
                __builder2.AddAttribute(106, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.AddressOfSchool.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(107, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(108, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(110, "<label class=\"label\">Grade</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(111);
                __builder2.AddAttribute(112, "TValue", "string");
                __builder2.AddAttribute(113, "Class", "w-100");
                __builder2.AddAttribute(114, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.Grade.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(116, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(117, " <br>\r\n\r\n                    ");
                __builder2.AddMarkupContent(118, "<label class=\"label\">Parent NIC</label>\r\n                     ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(119);
                __builder2.AddAttribute(120, "TValue", "string");
                __builder2.AddAttribute(121, "Class", "w-100");
                __builder2.AddAttribute(122, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
                                                                                prop.ParentNic.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(123, "Style", "margin-bottom:10px;font-size:0.9em;");
                __builder2.AddAttribute(124, "Disabled", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(125, " <br>\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n            ");
                __builder2.AddMarkupContent(127, "<a href=\"/planning/Registration\">\r\n                 <input type=\"button\" class=\"primary-btn\" value=\"Back\" style=\"width:220px;\">\r\n               </a>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(129, "           \r\n");
#nullable restore
#line 72 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(130, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "D:\SLIIT\Intern bellwantage\Man Power 2\ManPowerWeb\Pages\ViewInduvidualBeneficiary.razor"
       
    [Parameter]
    public string BenificiaryId { get; set; }

    [Parameter]
    public InduvidualBeneficiary InduvidualBeneficiary { get; set; }

    List<InduvidualBeneficiary> InduvidualBeneficiarylist = new List<InduvidualBeneficiary>();

    protected override void OnInitialized()
    {
        base.OnInitialized();

        InduvidualBeneficiaryController induvidualBeneficiaryController = ControllerFactory.CreateInduvidualBeneficiaryController();
        InduvidualBeneficiarylist = induvidualBeneficiaryController.GetAllInduvidualBeneficiary();

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
