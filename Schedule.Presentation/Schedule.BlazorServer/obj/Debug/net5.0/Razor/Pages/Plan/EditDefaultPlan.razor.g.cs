#pragma checksum "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Plan\EditDefaultPlan.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ff87d86b050fa06f504bccf24db4ab287ec1c5c"
// <auto-generated/>
#pragma warning disable 1591
namespace Schedule.BlazorServer.Pages.Plan
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditDefaultPlan")]
    public partial class EditDefaultPlan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"mt-3\">نمایش قالب برنامه ریزی</h1>\r\n<hr>");
#nullable restore
#line 8 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Plan\EditDefaultPlan.razor"
 if (showDefaultPlanViewModel != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-stripped table-dark");
            __builder.AddMarkupContent(3, "<tr><th>ساعت</th>\r\n            <th>توضیح</th>\r\n            <th>وضعیت انجام</th></tr>\r\n        ");
            __builder.OpenElement(4, "tr");
#nullable restore
#line 17 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Plan\EditDefaultPlan.razor"
             foreach (var item in showDefaultPlanViewModel)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<td></td>\r\n                <td></td>\r\n                <td></td>");
#nullable restore
#line 22 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Plan\EditDefaultPlan.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Plan\EditDefaultPlan.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<h1>برنامه ای برای امروز تنظیم نشده!!!</h1>");
#nullable restore
#line 29 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Plan\EditDefaultPlan.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Plan\EditDefaultPlan.razor"
       
    protected List<ShowDefaultPlanViewModel> showDefaultPlanViewModel { get; set; } = new List<ShowDefaultPlanViewModel>();

    protected override async Task OnInitializedAsync()
    {
        showDefaultPlanViewModel = await _planService.GetDefaultPlans(await localStorage.GetItemAsync<string>("userName"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlanService _planService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591
