// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Schedule.BlazorServer.Pages.Plan
{
    #line hidden
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.ViewModels.Plan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.ViewModels.Rule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.ViewModels.Goals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Schedule.Application.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ShowPlan")]
    public partial class ShowPlan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "c:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Plan\ShowPlan.razor"
       
    protected List<ShowPlanViewModel> showPlanViewModel { get; set; } = new List<ShowPlanViewModel>();

    protected override async Task OnInitializedAsync()
    {
        showPlanViewModel = await _planService.GetPlans(await localStorage.GetItemAsync<string>("userName"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlanService _planService { get; set; }
    }
}
#pragma warning restore 1591