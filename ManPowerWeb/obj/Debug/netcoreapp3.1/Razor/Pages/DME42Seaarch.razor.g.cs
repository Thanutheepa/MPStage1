#pragma checksum "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86d722e514b2aba411fc40eb255f0edd6f5a0cad"
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
#line 4 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
using ManPowerCore.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
using ManPowerCore.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
using ManPowerCore.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
using ManPowerWeb.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DME42Search")]
    public partial class DME42Seaarch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "main");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.AddMarkupContent(6, "<div class=\"wizard-heading\">DME 42</div>\r\n\r\n        \r\n\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.AddAttribute(9, "style", "margin-left:6px");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-6");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "row");
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-3");
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(20);
                __builder2.AddAttribute(21, "Text", "Year");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-7");
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(27);
                __builder2.AddAttribute(28, "Class", "w-100");
                __builder2.AddAttribute(29, "Placeholder", "");
                __builder2.AddAttribute(30, "Name", "year");
                __builder2.AddAttribute(31, "Style", "margin-bottom:10px;font-size:0.9em; display: block");
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                      year

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => year = __value, year))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => year));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(36);
                __builder2.AddAttribute(37, "Component", "year");
                __builder2.AddAttribute(38, "Text", "Year is required");
                __builder2.AddAttribute(39, "Style", "position: absolute");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                <br>\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n\r\n\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "col-6");
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "row");
                __builder2.AddAttribute(50, "style", "margin-left:-3px");
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-3");
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(55);
                __builder2.AddAttribute(56, "Text", "Institute");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-7");
                __builder2.AddMarkupContent(61, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(62);
                __builder2.AddAttribute(63, "Class", "w-100");
                __builder2.AddAttribute(64, "Placeholder", "");
                __builder2.AddAttribute(65, "Name", "Institute");
                __builder2.AddAttribute(66, "Style", "margin-bottom:10px;font-size:0.9em; display: block");
                __builder2.AddAttribute(67, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                  Institute

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Institute = __value, Institute))));
                __builder2.AddAttribute(69, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Institute));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(71);
                __builder2.AddAttribute(72, "Component", "Institute");
                __builder2.AddAttribute(73, "Text", "Possition is required");
                __builder2.AddAttribute(74, "Style", "position: absolute");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        <br>\r\n\r\n\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(79);
                __builder2.AddAttribute(80, "Shade", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Shade>(
#nullable restore
#line 55 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                             Shade.Darker

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "Text", "Search");
                __builder2.AddAttribute(82, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 55 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                      ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                    () => Search(Institute, year)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n\r\n        <br><br>\r\n\r\n\r\n        ");
                __builder2.OpenElement(85, "a");
                __builder2.AddAttribute(86, "href", "/DME42");
                __builder2.AddMarkupContent(87, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(88);
                __builder2.AddAttribute(89, "Shade", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Shade>(
#nullable restore
#line 61 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                 Shade.Darker

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "Text", "Add Resource");
                __builder2.AddAttribute(91, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 61 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 61 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                   ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "Style", "width:170px;");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n        <br><br><br><br>\r\n\r\n\r\n\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<ResourceProvisionProgress>>(96);
                __builder2.AddAttribute(97, "Style", "width: 1000px");
                __builder2.AddAttribute(98, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "AllowColumnResize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "AllowAlternatingRows", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                       false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 68 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                                          FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "PageSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 68 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                                                                                             5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(105, "PagerHorizontalAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.HorizontalAlign>(
#nullable restore
#line 68 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                                                                                                                                         HorizontalAlign.Left

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(106, "ShowPagingSummary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                                                                                                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(107, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ResourceProvisionProgress>>(
#nullable restore
#line 69 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                               cc

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "ColumnWidth", "300px");
                __builder2.AddAttribute(109, "LogicalFilterOperator", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 69 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(111, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(112);
                    __builder3.AddAttribute(113, "Property", "Date");
                    __builder3.AddAttribute(114, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 72 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                    false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(115, "Title", "Date");
                    __builder3.AddAttribute(116, "Frozen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 72 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                                true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(117, "Width", "150px");
                    __builder3.AddAttribute(118, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 72 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                                                               TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(120);
                    __builder3.AddAttribute(121, "Property", "NameOfTheProgram");
                    __builder3.AddAttribute(122, "Title", "Name of the Program");
                    __builder3.AddAttribute(123, "Frozen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 73 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
                                                                                                                                        true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(124, "Width", "220px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(125, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(126);
                    __builder3.AddAttribute(127, "Property", "Institute");
                    __builder3.AddAttribute(128, "Title", "Institute");
                    __builder3.AddAttribute(129, "Width", "160px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(130, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(131);
                    __builder3.AddAttribute(132, "Property", "Address");
                    __builder3.AddAttribute(133, "Title", "Address");
                    __builder3.AddAttribute(134, "Width", "120px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(135, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(136);
                    __builder3.AddAttribute(137, "Property", "SubjectAreaOrTopic");
                    __builder3.AddAttribute(138, "Title", "Subject Area");
                    __builder3.AddAttribute(139, "Width", "170px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(140, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(141);
                    __builder3.AddAttribute(142, "Property", "NameOfTheOrganization");
                    __builder3.AddAttribute(143, "Title", "Name of the Organization");
                    __builder3.AddAttribute(144, "FormatString", "{0:d}");
                    __builder3.AddAttribute(145, "Width", "230px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(147);
                    __builder3.AddAttribute(148, "Property", "OrganizationType");
                    __builder3.AddAttribute(149, "Title", "Organization Type");
                    __builder3.AddAttribute(150, "FormatString", "{0:d}");
                    __builder3.AddAttribute(151, "Width", "200px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(152, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(153);
                    __builder3.AddAttribute(154, "Property", "Ds");
                    __builder3.AddAttribute(155, "Title", "DS");
                    __builder3.AddAttribute(156, "Width", "150px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(157, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(158);
                    __builder3.AddAttribute(159, "Property", "OrganizationAddress");
                    __builder3.AddAttribute(160, "Title", "Address");
                    __builder3.AddAttribute(161, "Width", "200px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(162, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(163);
                    __builder3.AddAttribute(164, "Property", "Name");
                    __builder3.AddAttribute(165, "Title", "Name");
                    __builder3.AddAttribute(166, "Width", "200px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(167, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(168);
                    __builder3.AddAttribute(169, "Property", "Position");
                    __builder3.AddAttribute(170, "Title", "Position");
                    __builder3.AddAttribute(171, "Width", "150px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(172, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(173);
                    __builder3.AddAttribute(174, "Property", "ContactNumber");
                    __builder3.AddAttribute(175, "Title", "Contact Number");
                    __builder3.AddAttribute(176, "Width", "180px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(177, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(178);
                    __builder3.AddAttribute(179, "Property", "WhatsappNumber");
                    __builder3.AddAttribute(180, "Title", "Whatsapp Number");
                    __builder3.AddAttribute(181, "Width", "180px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(182, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(183);
                    __builder3.AddAttribute(184, "Property", "Email");
                    __builder3.AddAttribute(185, "Title", "Email");
                    __builder3.AddAttribute(186, "Width", "220px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(187, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ResourceProvisionProgress>>(188);
                    __builder3.AddAttribute(189, "Property", "DetailsOfTheProvidedService");
                    __builder3.AddAttribute(190, "Title", "Details of the Provided Service");
                    __builder3.AddAttribute(191, "Width", "320px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(192, "\r\n\r\n\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(193, "\r\n\r\n        <br><br>\r\n\r\n           \r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(194, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42Seaarch.razor"
       




    public string year = "";
    public string Institute = "";


    List<ResourceProvisionProgress> cc = new List<ResourceProvisionProgress>();



    void Search(string I, string Y)
    {
        ResourceProvisionProgress resourceProvisionProgress = new ResourceProvisionProgress();
        ResourceProvisionProgressController resourceProvisionProgressController = ControllerFactory.CreateResourceProvisionProgressController();

        cc = resourceProvisionProgressController.GetAllResourceProvisionProgress(I, Y);

    }


    void OnInvalidSubmit(FormInvalidSubmitEventArgs args)
    {
        // console.Log($"InvalidSubmit: {JsonSerializer.Serialize(args, new JsonSerializerOptions() {  WriteIndented = true })}");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591