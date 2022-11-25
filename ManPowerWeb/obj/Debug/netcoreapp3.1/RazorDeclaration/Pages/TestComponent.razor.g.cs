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
#line 5 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\TestComponent.razor"
using ManPowerCore.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\TestComponent.razor"
using ManPowerCore.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\TestComponent.razor"
using ManPowerCore.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\TestComponent.razor"
using ManPowerWeb.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\TestComponent.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\TestComponent.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/testPage")]
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 309 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\TestComponent.razor"
         



    async Task ShowInlineDialog()
    {
     var result = await DialogService.OpenAsync("Simple Dialog", ds =>
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(0, @"<div>
                            <p class=""mb-4"">Confirm Order ID</p>
                            <div class=""row"">
                                <div class=""col"">
                                    <RadzenButton Text=""Ok"" Click=""() => ds.Close(true)"" Class=""me-1"" Style=""width: 80px;""></RadzenButton>
                                    <RadzenButton Text=""Cancel"" Click=""() => ds.Close(false)"" ButtonStyle=""ButtonStyle.Light"" Class=""me-1""></RadzenButton>
                                    
                                </div>
                            </div>
           </div>
");
        }
#nullable restore
#line 326 "E:\Industry Bv Projects\Man Power 2\ManPowerWeb\Pages\TestComponent.razor"
       );
    }

     string[] dropcareer = { "Management","Skilled","Non-Skilled","Technical","Non-Technical" };
     string[] levels = { "Top Level","Middle Level","Lower Level" };


    class Model
    {
        public DateTime date { get; set; }
        public string address { get; set; }= "";
        public string websiteLink { get; set; }= "";
        public string BRN { get; set; }= "";
        public string vacancyTOrJobP { get; set; }= "";
        public string selectedDropCPorHP { get; set; }= "";
        public string salaryLevel { get; set; }= "";

        public string level { get; set; } = "";
        public string numberOfVacan { get; set; }= "";

        public string name { get; set; }= "";
        public string position { get; set; }= "";
        public string contactNumber { get; set; }= "";
        public string whatsappNumber { get; set; }= "";
        public string email { get; set; }= "";

    }

    bool popup;

    Model model = new Model();

    void  OnSubmit(Model model)
    {



        CompanyVecansyRegistationDetails companyVecansyRegistationDetails = new CompanyVecansyRegistationDetails();
        CompanyVecansyRegistationDetailsController companyVecansyRegistationDetailsController = ControllerFactory.CreateCompanyVecansyRegistationDetailsController();


        companyVecansyRegistationDetails.CompanyVacansyRegistationDetailsId = 1;
        companyVecansyRegistationDetails.Date = model.date;
        companyVecansyRegistationDetails.Address = model.address;
        companyVecansyRegistationDetails.WebSiteLink = model.websiteLink;
        companyVecansyRegistationDetails.BusinessRegistationNumber = model.BRN;
        companyVecansyRegistationDetails.JobPosition = model.vacancyTOrJobP;
        companyVecansyRegistationDetails.CareerPath = model.selectedDropCPorHP;
        companyVecansyRegistationDetails.SalaryLevel = model.salaryLevel;
        companyVecansyRegistationDetails.NumberOfVacancy = int.Parse(model.numberOfVacan);
        companyVecansyRegistationDetails.Name = model.name;
        companyVecansyRegistationDetails.Position = model.position;
        companyVecansyRegistationDetails.ContactNumber = model.contactNumber;
        companyVecansyRegistationDetails.WhatsappNumber = model.whatsappNumber;
        companyVecansyRegistationDetails.Levels = model.level;
        companyVecansyRegistationDetails.Email = model.email;


       companyVecansyRegistationDetailsController.SaveCompanyVecansyRegistationDetails(companyVecansyRegistationDetails);

       JSRuntime.InvokeAsync<object>("ErrorAlert", "success", "", "Added success");


        //   console.Log($"Submit: {JsonSerializer.Serialize(model, new JsonSerializerOptions() {  WriteIndented = true })}");
    }

    void OnInvalidSubmit(FormInvalidSubmitEventArgs args)
    {
        // console.Log($"InvalidSubmit: {JsonSerializer.Serialize(args, new JsonSerializerOptions() {  WriteIndented = true })}");
    }



    IEnumerable<VacancyRegistaionDetails> vacancyRegistaionDetails;

    private void AddData()
    {

        VacancyRegistaionDetails vacancyRegistaionDetailsObj = new VacancyRegistaionDetails();



        vacancyRegistaionDetailsObj.Date = model.date;
        vacancyRegistaionDetailsObj.Address = model.address;
        vacancyRegistaionDetailsObj.WebsiteLink = model.websiteLink;
        vacancyRegistaionDetailsObj.BRN = model.BRN;
        vacancyRegistaionDetailsObj.VacancyTOrJobP = model.vacancyTOrJobP;
        vacancyRegistaionDetailsObj.DropCPorHP = model.selectedDropCPorHP;
        vacancyRegistaionDetailsObj.SalaryLevel = model.salaryLevel;
        vacancyRegistaionDetailsObj.Level = model.level;
        vacancyRegistaionDetailsObj.NumberOfVacan = model.numberOfVacan;
        vacancyRegistaionDetailsObj.Name = model.name;
        vacancyRegistaionDetailsObj.Position = model.position;
        vacancyRegistaionDetailsObj.ContactNumber = model.contactNumber;
        vacancyRegistaionDetailsObj.WhatsappNumber = model.whatsappNumber;
        vacancyRegistaionDetailsObj.Email = model.email;


        vacancyRegistaionDetails = new VacancyRegistaionDetails[] { vacancyRegistaionDetailsObj };

    }


    private void Clear()
    {

        model.address = "";
        model.websiteLink = "";
        model.websiteLink= "";
        model.BRN = "";
        model.vacancyTOrJobP ="";
        model.selectedDropCPorHP ="";
        model.selectedDropCPorHP ="";
        model.salaryLevel ="";
        model.level ="";
        model.numberOfVacan ="";
        model.name ="";
        model.position ="";
        model.contactNumber ="";
        model.whatsappNumber ="";
        model.whatsappNumber ="";
        model.email ="";

        VacancyRegistaionDetails vacancyRegistaionDetailsObj = new VacancyRegistaionDetails();

       
        vacancyRegistaionDetailsObj.Date = model.date;
        vacancyRegistaionDetailsObj.Address = "";
        vacancyRegistaionDetailsObj.WebsiteLink = "";
        vacancyRegistaionDetailsObj.BRN = "";
        vacancyRegistaionDetailsObj.VacancyTOrJobP = "";
        vacancyRegistaionDetailsObj.DropCPorHP = "";
        vacancyRegistaionDetailsObj.SalaryLevel = "";
        vacancyRegistaionDetailsObj.Level = "";
        vacancyRegistaionDetailsObj.NumberOfVacan = "";
        vacancyRegistaionDetailsObj.Name = "";
        vacancyRegistaionDetailsObj.Position = "";
        vacancyRegistaionDetailsObj.ContactNumber = "";
        vacancyRegistaionDetailsObj.WhatsappNumber = "";
        vacancyRegistaionDetailsObj.Email = "";


        vacancyRegistaionDetails = new VacancyRegistaionDetails[] { vacancyRegistaionDetailsObj };
  

    }

    private async void Submit()
    {


        CompanyVecansyRegistationDetails companyVecansyRegistationDetails = new CompanyVecansyRegistationDetails();
        CompanyVecansyRegistationDetailsController companyVecansyRegistationDetailsController = ControllerFactory.CreateCompanyVecansyRegistationDetailsController();


        companyVecansyRegistationDetails.CompanyVacansyRegistationDetailsId = 1;
        companyVecansyRegistationDetails.Date = model.date;
        companyVecansyRegistationDetails.Address = model.address;
        companyVecansyRegistationDetails.WebSiteLink = model.websiteLink;
        companyVecansyRegistationDetails.BusinessRegistationNumber = model.BRN;
        companyVecansyRegistationDetails.JobPosition = model.vacancyTOrJobP;
        companyVecansyRegistationDetails.CareerPath = model.selectedDropCPorHP;
        companyVecansyRegistationDetails.SalaryLevel = model.salaryLevel;
        companyVecansyRegistationDetails.Levels = model.level;
         companyVecansyRegistationDetails.NumberOfVacancy = int.Parse(model.numberOfVacan);
        companyVecansyRegistationDetails.Name = model.name;
        companyVecansyRegistationDetails.Position = model.position;
        companyVecansyRegistationDetails.ContactNumber = model.contactNumber;
        companyVecansyRegistationDetails.WhatsappNumber = model.whatsappNumber;
        companyVecansyRegistationDetails.Email = model.email;


       companyVecansyRegistationDetailsController.SaveCompanyVecansyRegistationDetails(companyVecansyRegistationDetails);

       await JSRuntime.InvokeAsync<object>("ErrorAlert", "success", "", "Added success");


    }  



     

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
