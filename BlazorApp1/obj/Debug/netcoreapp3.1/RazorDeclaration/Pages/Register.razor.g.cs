#pragma checksum "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cab486b6063d090c17f4d0be15fbc83a768028f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Register.razor"
using BlazorApp1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Register.razor"
using BlazorApp1.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Register.razor"
       
    RegisterViewModel RegisterViewModel { get; set; } = new RegisterViewModel();
    public async Task SignUp()
    {
        var res = await accountService.Register(RegisterViewModel);
        if (res.Success)
        {
            NavigationManager.NavigateTo("/Login");
        }
        else
        {
            RegisterViewModel = new RegisterViewModel();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountService accountService { get; set; }
    }
}
#pragma warning restore 1591