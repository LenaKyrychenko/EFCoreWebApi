#pragma checksum "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d8bad94e1e72142e5291fca6944792323a9ab90"
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
#line 2 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor"
using BlazorApp1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor"
using BlazorApp1.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tourone/{tourid:int}")]
    public partial class TourOne : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 171 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor"
       
    [Parameter]
    public int tourid { get; set; }
    TourViewModel tourViewModel = new TourViewModel
    {
        nameTour = "GFHSFHS",
        route = "dfgdfg-dhsfhsfh-sfghsfhs",
        dateOfStart = DateTime.Now,
        dateOfFinish = DateTime.Now,
        price = 125000
    };

    //protected override async Task OnInitializedAsync()
    //{
    //    tourViewModel = await tourService.GetById(tourid);
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TourService tourService { get; set; }
    }
}
#pragma warning restore 1591
