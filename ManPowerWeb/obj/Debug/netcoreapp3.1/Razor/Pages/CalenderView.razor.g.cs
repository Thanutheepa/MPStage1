#pragma checksum "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CalenderView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5222d3f9aa3fc19a873daadcaeba82cd0ef6882"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/calenderView")]
    public partial class CalenderView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CalenderView</h3>\r\n\r\n\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"cd-schedule loading\">\r\n\t<div class=\"timeline\">\r\n\t\t<ul>\r\n\t\t\t<li><span>09:00</span></li>\r\n\t\t\t<li><span>09:30</span></li>\r\n\t\t\t<li><span>10:00</span></li>\r\n\t\t\t<li><span>10:30</span></li>\r\n\t\t\t<li><span>11:00</span></li>\r\n\t\t\t<li><span>11:30</span></li>\r\n\t\t\t<li><span>12:00</span></li>\r\n\t\t\t<li><span>12:30</span></li>\r\n\t\t\t<li><span>13:00</span></li>\r\n\t\t\t<li><span>13:30</span></li>\r\n\t\t\t<li><span>14:00</span></li>\r\n\t\t\t<li><span>14:30</span></li>\r\n\t\t\t<li><span>15:00</span></li>\r\n\t\t\t<li><span>15:30</span></li>\r\n\t\t\t<li><span>16:00</span></li>\r\n\t\t\t<li><span>16:30</span></li>\r\n\t\t\t<li><span>17:00</span></li>\r\n\t\t\t<li><span>17:30</span></li>\r\n\t\t\t<li><span>18:00</span></li>\r\n\t\t</ul>\r\n\t</div> \r\n\r\n\t<div class=\"events\">\r\n\t\t<ul class=\"wrap\">\r\n\t\t\t<li class=\"events-group\">\r\n\t\t\t\t<div class=\"top-info\"><span>Monday</span></div>\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"09:30\" data-end=\"10:30\" data-content=\"event-abs-circuit\" data-event=\"event-1\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Abs Circuit</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"11:00\" data-end=\"12:30\" data-content=\"event-rowing-workout\" data-event=\"event-2\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Rowing Workout</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"14:00\" data-end=\"15:15\" data-content=\"event-yoga-1\" data-event=\"event-3\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Yoga Level 1</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</li>\r\n\r\n\t\t\t<li class=\"events-group\">\r\n\t\t\t\t<div class=\"top-info\"><span>Tuesday</span></div>\r\n\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"10:00\" data-end=\"11:00\" data-content=\"event-rowing-workout\" data-event=\"event-2\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Rowing Workout</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"11:30\" data-end=\"13:00\" data-content=\"event-restorative-yoga\" data-event=\"event-4\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Restorative Yoga</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"13:30\" data-end=\"15:00\" data-content=\"event-abs-circuit\" data-event=\"event-1\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Abs Circuit</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"15:45\" data-end=\"16:45\" data-content=\"event-yoga-1\" data-event=\"event-3\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Yoga Level 1</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</li>\r\n\r\n\t\t\t<li class=\"events-group\">\r\n\t\t\t\t<div class=\"top-info\"><span>Wednesday</span></div>\r\n\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"09:00\" data-end=\"10:15\" data-content=\"event-restorative-yoga\" data-event=\"event-4\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Restorative Yoga</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"10:45\" data-end=\"11:45\" data-content=\"event-yoga-1\" data-event=\"event-3\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Yoga Level 1</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"12:00\" data-end=\"13:45\" data-content=\"event-rowing-workout\" data-event=\"event-2\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Rowing Workout</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"13:45\" data-end=\"15:00\" data-content=\"event-yoga-1\" data-event=\"event-3\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Yoga Level 1</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</li>\r\n\r\n\t\t\t<li class=\"events-group\">\r\n\t\t\t\t<div class=\"top-info\"><span>Thursday</span></div>\r\n\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"09:30\" data-end=\"10:30\" data-content=\"event-abs-circuit\" data-event=\"event-1\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Abs Circuit</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"12:00\" data-end=\"13:45\" data-content=\"event-restorative-yoga\" data-event=\"event-4\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Restorative Yoga</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"15:30\" data-end=\"16:30\" data-content=\"event-abs-circuit\" data-event=\"event-1\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Abs Circuit</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"17:00\" data-end=\"18:30\" data-content=\"event-rowing-workout\" data-event=\"event-2\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Rowing Workout</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</li>\r\n\r\n\t\t\t<li class=\"events-group\">\r\n\t\t\t\t<div class=\"top-info\"><span>Friday</span></div>\r\n\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"10:00\" data-end=\"11:00\" data-content=\"event-rowing-workout\" data-event=\"event-2\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Rowing Workout</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"12:30\" data-end=\"14:00\" data-content=\"event-abs-circuit\" data-event=\"event-1\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Abs Circuit</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"15:45\" data-end=\"16:45\" data-content=\"event-yoga-1\" data-event=\"event-3\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Yoga Level 1</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</li>\r\n      \r\n      <li class=\"events-group\">\r\n\t\t\t\t<div class=\"top-info\"><span>Saturday</span></div>\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"09:30\" data-end=\"10:30\" data-content=\"event-abs-circuit\" data-event=\"event-1\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Abs Circuit</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"11:00\" data-end=\"12:30\" data-content=\"event-rowing-workout\" data-event=\"event-2\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Rowing Workout</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"14:00\" data-end=\"15:15\" data-content=\"event-yoga-1\" data-event=\"event-3\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Yoga Level 1</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</li>\r\n\r\n      \r\n      \r\n      <li class=\"events-group\">\r\n\t\t\t\t<div class=\"top-info\"><span>Sunday</span></div>\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"09:30\" data-end=\"10:30\" data-content=\"event-abs-circuit\" data-event=\"event-1\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Abs Circuit</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"11:00\" data-end=\"12:30\" data-content=\"event-rowing-workout\" data-event=\"event-2\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Rowing Workout</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t<li class=\"single-event\" data-start=\"14:00\" data-end=\"15:15\" data-content=\"event-yoga-1\" data-event=\"event-3\">\r\n\t\t\t\t\t\t<a href=\"#0\">\r\n\t\t\t\t\t\t\t<em class=\"event-name\">Yoga Level 1</em>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</li>\r\n\r\n\t\t</ul>\r\n\t</div>\r\n\r\n\t<div class=\"event-modal\">\r\n\t\t<header class=\"header\">\r\n\t\t\t<div class=\"content\">\r\n\t\t\t\t<span class=\"event-date\"></span>\r\n\t\t\t\t<h3 class=\"event-name\"></h3>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"header-bg\"></div>\r\n\t\t</header>\r\n\r\n\t\t<div class=\"body\">\r\n\t\t\t<div class=\"event-info\"></div>\r\n\t\t\t<div class=\"body-bg\"></div>\r\n\t\t</div>\r\n\r\n\t\t<a href=\"#0\" class=\"close\">Close</a>\r\n\t</div>\r\n\r\n\t<div class=\"cover-layer\"></div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
