#pragma checksum "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Account\SignIn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "195eb3550af8f230ffe77a6754bfae203c340351"
// <auto-generated/>
#pragma warning disable 1591
namespace Schedule.BlazorServer.Pages.Account
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignIn")]
    public partial class SignIn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-center");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Account\SignIn.razor"
                      signInViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Account\SignIn.razor"
                                                       SignIntoApp

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "alert" + " alert-danger" + (
#nullable restore
#line 10 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Account\SignIn.razor"
                                        showExistsUserError ? "d-none" : ""

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(12, "\r\n            شما قبلا ثبت نام کرده اید!!!\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n\r\n        ");
                __builder2.AddMarkupContent(14, "<b>نام کاربری:</b>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Account\SignIn.razor"
                                signInViewModel.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => signInViewModel.UserName = __value, signInViewModel.UserName))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => signInViewModel.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n\r\n        <hr>\r\n\r\n        ");
                __builder2.AddMarkupContent(20, "<b>رمز عبور:</b>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Account\SignIn.razor"
                                signInViewModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => signInViewModel.Password = __value, signInViewModel.Password))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => signInViewModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n\r\n        <hr>\r\n\r\n        ");
                __builder2.AddMarkupContent(26, "<b>تکرار رمز عبور:</b>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Account\SignIn.razor"
                                signInViewModel.RePassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => signInViewModel.RePassword = __value, signInViewModel.RePassword))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => signInViewModel.RePassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n\r\n        ");
                __builder2.AddMarkupContent(32, "<button type=\"submit\" class=\"btn btn-success\">ثبت نام</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n    <hr>\r\n    ");
            __builder.AddMarkupContent(34, "<a href=\"/LogIn\" class=\"btn btn-primary\">ورود</a>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Royal\source\repos\Schedule\Schedule.Presentation\Schedule.BlazorServer\Pages\Account\SignIn.razor"
       
    SignInViewModel signInViewModel = new();
    bool showExistsUserError = false;

    async Task SignIntoApp()
    {
        if (await accountService.IsUserExistsByUserName(signInViewModel.UserName))
        {
            await accountService.RegisterAccount(signInViewModel);
            await localStorage.SetItemAsync<string>("userName", signInViewModel.UserName);
        }
        else
        {
            showExistsUserError = true;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService accountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591