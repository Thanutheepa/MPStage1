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
#line 5 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42.razor"
using ManPowerCore.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42.razor"
using ManPowerCore.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42.razor"
using ManPowerCore.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42.razor"
using ManPowerWeb.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DME42")]
    public partial class DME42 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 297 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\DME42.razor"
       




    string value;

    void OnChange(string value, string name)
    {

    }


    string[] SelectedOrganizationType = { "Private","Public" };


    class Model
    {
        public DateTime date { get; set; }
        public string nameOfTheProgram { get; set; }= "";
        public string institute { get; set; }= "";
        public string address { get; set; }= "";
        public string subjectAreaOrTopic { get; set; }= "";
        public string nameOfTheOrganization { get; set; }= "";
        public string organizationType { get; set; }= "";
        public string ds { get; set; } = "";
        public string organizationAddress { get; set; }= "";

        public string name { get; set; }= "";
        public string position { get; set; }= "";
        public string contactNumber { get; set; }= "";
        public string whatsappNumber { get; set; }= "";
        public string email { get; set; }= "";
        public string detailsOfTheProvidedService { get; set; }= "";

    }

    public string year = "";

    bool popup;

    Model model = new Model();

    List<ResourceProvisionProgress>resourceProvisionProgressValidate = new List<ResourceProvisionProgress>();

    void  OnSubmit(Model model)
    {

        

        //ResourceProvisionProgressController resourceProvisionProgressController2 = ControllerFactory.CreateResourceProvisionProgressController();
        //resourceProvisionProgressValidate = resourceProvisionProgressController2.GetAllResourceProvisionProgress(model.institute, , model.ds);

        //if ( resourceProvisionProgressValidate.Count == 0)
        //{
           
          
        //}
        //else
        //{


        //}




        ResourceProvisionProgress resourceProvisionProgress = new ResourceProvisionProgress();
        ResourceProvisionProgressController resourceProvisionProgressController = ControllerFactory.CreateResourceProvisionProgressController();


        resourceProvisionProgress.ResourceProvisionProgressId = 1;
        resourceProvisionProgress.Date = model.date;
        resourceProvisionProgress.NameOfTheProgram = model.nameOfTheProgram;
        resourceProvisionProgress.Institute = model.institute;
        resourceProvisionProgress.Address = model.address;
        resourceProvisionProgress.SubjectAreaOrTopic = model.subjectAreaOrTopic;
        resourceProvisionProgress.NameOfTheOrganization = model.nameOfTheOrganization;
        resourceProvisionProgress.OrganizationType = model.organizationType;
        resourceProvisionProgress.Ds = model.ds;
        resourceProvisionProgress.OrganizationAddress = model.organizationAddress;
        resourceProvisionProgress.Name = model.name;
        resourceProvisionProgress.Position = model.position;
        resourceProvisionProgress.ContactNumber = model.contactNumber;
        resourceProvisionProgress.WhatsappNumber = model.whatsappNumber;
        resourceProvisionProgress.Email = model.email;
        resourceProvisionProgress.DetailsOfTheProvidedService = model.detailsOfTheProvidedService;


        resourceProvisionProgressController.SaveResourceProvisionProgress(resourceProvisionProgress);

        JSRuntime.InvokeAsync<object>("ErrorAlert", "success", "", "Added success");

        Clear();


        //   console.Log($"Submit: {JsonSerializer.Serialize(model, new JsonSerializerOptions() {  WriteIndented = true })}");
    }

    void OnInvalidSubmit(FormInvalidSubmitEventArgs args)
    {
        // console.Log($"InvalidSubmit: {JsonSerializer.Serialize(args, new JsonSerializerOptions() {  WriteIndented = true })}");
    }



    IEnumerable<ResourceProProgress> resourceProProgress;

    private void AddData()
    {

        ResourceProProgress resourceProProgressObj = new ResourceProProgress();



        resourceProProgressObj.Date = model.date;
        resourceProProgressObj.NameOfTheProgram = model.nameOfTheProgram;
        resourceProProgressObj.Institute = model.institute;
        resourceProProgressObj.Address = model.address;
        resourceProProgressObj.SubjectAreaOrTopic = model.subjectAreaOrTopic;
        resourceProProgressObj.NameOfTheOrganization = model.nameOfTheOrganization;
        resourceProProgressObj.OrganizationType = model.organizationType;
        resourceProProgressObj.Ds = model.ds;
        resourceProProgressObj.OrganizationAddress = model.organizationAddress;
        resourceProProgressObj.Name = model.name;
        resourceProProgressObj.Position = model.position;
        resourceProProgressObj.ContactNumber = model.contactNumber;
        resourceProProgressObj.WhatsappNumber = model.whatsappNumber;
        resourceProProgressObj.Email = model.email;
        resourceProProgressObj.DetailsOfTheProvidedService = model.detailsOfTheProvidedService;


        resourceProProgress = new ResourceProProgress[] { resourceProProgressObj };

    }


    private void Clear()
    {

        model.nameOfTheProgram = "";
        model.institute = "";
        model.address= "";
        model.subjectAreaOrTopic = "";
        model.nameOfTheOrganization ="";
        model.organizationType ="";
        model.ds ="";
        model.organizationAddress ="";
        model.name ="";
        model.position ="";
        model.name ="";
        model.position ="";
        model.contactNumber ="";
        model.whatsappNumber ="";
        model.whatsappNumber ="";
        model.email ="";
        model.detailsOfTheProvidedService ="";

        ResourceProProgress resourceProProgressObj = new ResourceProProgress();

       
        resourceProProgressObj.Date = model.date;
        resourceProProgressObj.NameOfTheProgram = "";
        resourceProProgressObj.Institute = "";
        resourceProProgressObj.Address = "";
        resourceProProgressObj.SubjectAreaOrTopic = "";
        resourceProProgressObj.NameOfTheOrganization = "";
        resourceProProgressObj.OrganizationType = "";
        resourceProProgressObj.Ds = "";
        resourceProProgressObj.OrganizationAddress = "";
        resourceProProgressObj.Name = "";
        resourceProProgressObj.Position = "";
        resourceProProgressObj.ContactNumber = "";
        resourceProProgressObj.WhatsappNumber = "";
        resourceProProgressObj.Email = "";
        resourceProProgressObj.DetailsOfTheProvidedService = "";


        resourceProProgress = new ResourceProProgress[] { resourceProProgressObj };
  

    }

    

     

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
