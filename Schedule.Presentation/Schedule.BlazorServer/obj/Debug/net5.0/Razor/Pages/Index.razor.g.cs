#pragma checksum "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8910efe1999adb6d57fd8a2889394217267bd4d3"
// <auto-generated/>
#pragma warning disable 1591
namespace Schedule.BlazorServer.Pages
{
    #line hidden
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.ViewModels.Plan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.ViewModels.Rule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.ViewModels.Goals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""py-100 py-auto""><div class=""contatiner row m-auto""><h1 class=""row justify-content-center"">خانه</h1>
        <hr>
        <div class=""col-12 col-sm-6 col-md-4 my-3 px-3""><a class=""btn btn-light w-100"" href=""/ShowPlan"">مشاهده برنامه ریزی</a></div>
        <div class=""col-12 col-sm-6 col-md-4 my-3 px-3""><a class=""btn btn-light w-100"" href=""/EditDefaultPlan"">ویرایش قالب برنامه ریزی</a></div>
        <div class=""col-12 col-sm-6 col-md-4 my-3 px-3""><a class=""btn btn-light w-100"" href=""/EditNextPlan"">ویرایش برنامه فردا</a></div>
        <div class=""col-12 col-sm-6 col-md-4 my-3 px-3""><a class=""btn btn-light w-100"" href=""/ShowGoals"">مشاهده اهداف</a></div>
        <div class=""col-12 col-sm-6 col-md-4 my-3 px-3""><a class=""btn btn-light w-100"" href=""/ShowRules"">مشاهده قوانین</a></div>
        <div class=""col-12 col-sm-6 col-md-4 my-3 px-3""><a class=""btn btn-light w-100"" href=""/EditRules"">ویرایش قوانین</a></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591