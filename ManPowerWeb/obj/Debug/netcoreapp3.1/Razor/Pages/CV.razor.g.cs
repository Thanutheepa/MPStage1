#pragma checksum "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CV.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b15bd5399c9324d2dbeed145a036d8ce91dffdb0"
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
#line 14 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\_Imports.razor"
using ManPowerCore.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CV.razor"
using ManPowerCore.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CV.razor"
using ManPowerCore.Controller;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/scheduler")]
    public partial class CV : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "calend");
            __builder.AddAttribute(2, "style", "margin-left: 278px");
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenScheduler<Appointment>>(4);
            __builder.AddAttribute(5, "SlotRender", (System.Action<Radzen.SchedulerSlotRenderEventArgs>)(
#nullable restore
#line 13 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CV.razor"
                                             OnSlotRender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "height: 768px;");
            __builder.AddAttribute(7, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Appointment>>(
#nullable restore
#line 13 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CV.razor"
                                                                                                           appointments

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "StartProperty", "Start");
            __builder.AddAttribute(9, "EndProperty", "End");
            __builder.AddAttribute(10, "TextProperty", "Text");
            __builder.AddAttribute(11, "SelectedIndex", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CV.razor"
                                           2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "SlotSelect", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.SchedulerSlotSelectEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.SchedulerSlotSelectEventArgs>(this, 
#nullable restore
#line 15 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CV.razor"
                    OnSlotSelect

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "AppointmentSelect", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.SchedulerAppointmentSelectEventArgs<Appointment>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.SchedulerAppointmentSelectEventArgs<Appointment>>(this, 
#nullable restore
#line 15 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CV.razor"
                                                    OnAppointmentSelect

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "AppointmentRender", (System.Action<Radzen.SchedulerAppointmentRenderEventArgs<Appointment>>)(
#nullable restore
#line 15 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CV.razor"
                                                                                           OnAppointmentRender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDayView>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenWeekView>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenMonthView>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(23, (__value) => {
#nullable restore
#line 13 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CV.razor"
                       scheduler = (Radzen.Blazor.RadzenScheduler<Appointment>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\CV.razor"
       
    RadzenScheduler<Appointment> scheduler;
    List<ManPowerCore.Domain.TaskAllocationDetail> taskAllocationDetail = new List<ManPowerCore.Domain.TaskAllocationDetail>();

    Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();

    IList<Appointment> appointments = new List<Appointment>();


    protected override void OnInitialized()
    {

        base.OnInitialized();
        TaskAllocationDetailController taskAllocationDetailController = ControllerFactory.CreateTaskAllocationDetailController();
        taskAllocationDetail = taskAllocationDetailController.GetAllTaskAllocationDetail(false,false,false);

        foreach (var item in taskAllocationDetail)
        {
            
                appointments.Add(new Appointment()
                    {
                        Start = item.StartTime,
                        End = item.EndTime,
                        Text = item.TaskDescription
                    });
            
           
        }


    }





    void OnSlotRender(SchedulerSlotRenderEventArgs args) 
    {
        // Highlight today in month view
        if (args.View.Text == "Month" && args.Start.Date == DateTime.Today)
        {
            args.Attributes["style"] = "background: rgba(255,220,40,.2);";
        }

        // Highlight working hours (9-18)
        if ((args.View.Text == "Week" || args.View.Text == "Day") && args.Start.Hour > 8 && args.Start.Hour < 19)
        {
            args.Attributes["style"] = "background: rgba(255,220,40,.2);";
        }
    }

    async Task OnSlotSelect(SchedulerSlotSelectEventArgs args)
    {
        

        Appointment data = await DialogService.OpenAsync<AddAppointmentPage>("Add Appointment",
            new Dictionary<string, object> { { "Start", args.Start }, { "End", args.End } });

        if (data != null)
        {
            appointments.Add(data);
            // Either call the Reload method or reassign the Data property of the Scheduler
            await scheduler.Reload();
        }
    }

    async Task OnAppointmentSelect(SchedulerAppointmentSelectEventArgs<Appointment> args)
    {
        

        await DialogService.OpenAsync<EditAppointmentPage>("Edit Appointment", new Dictionary<string, object> { { "Appointment", args.Data } });

        await scheduler.Reload();
    }

    void OnAppointmentRender(SchedulerAppointmentRenderEventArgs<Appointment> args)
    {
        // Never call StateHasChanged in AppointmentRender - would lead to infinite loop

        if (args.Data.Text == "Birthday")
        {
            args.Attributes["style"] = "background: red";
        }
    }



    
        
        


   public class Appointment
  {
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Text { get; set; }
  }

  Appointment[] data = new Appointment[]
  {
      new Appointment
      {
        Start = DateTime.Today,
        End = DateTime.Today.AddDays(1),
        Text = "Birthday"
      },

       
  };
       



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591