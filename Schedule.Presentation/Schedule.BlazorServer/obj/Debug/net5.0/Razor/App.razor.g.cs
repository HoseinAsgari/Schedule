#pragma checksum "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47764d0e644515fb6f13308e97611864282cdfa2"
// <auto-generated/>
#pragma warning disable 1591
namespace Schedule.BlazorServer
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "PreferExactMatches", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\App.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 3 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(7, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(8);
                __builder2.AddAttribute(9, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 6 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "<div class=\"container\"><h1 class=\"text-danger mt-5\">صفحه ای با این آدرس پیدا نشد!!!</h1>\r\n                <hr>\r\n                <p>احتمالاً آدرس را اشتباه وارد کردید. اگر از درست بودن آدرس اطمینان دارید لطفاً این خطا را به ما گزارش دهید.</p></div>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591