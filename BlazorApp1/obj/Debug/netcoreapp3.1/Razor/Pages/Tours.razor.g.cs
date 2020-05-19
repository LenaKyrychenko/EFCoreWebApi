#pragma checksum "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf17bf0d77c38a0ce6fc1fc722609008e4565dfd"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
using BlazorApp1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
using BlazorApp1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
using DAL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tours")]
    public partial class Tours : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Tours</h1>\r\n\r\n");
#nullable restore
#line 9 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
 if (tours == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 12 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>NameTour</th>\r\n                <th>Route</th>\r\n                <th>DateOfStart</th>\r\n                <th>DateOfFinish</th>\r\n                <th>Price</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 26 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
             foreach (var tours in tours)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 29 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.nameTour

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 30 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.route

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 31 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.dateOfStart

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 32 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.dateOfFinish

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 33 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 35 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                      PrevPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Prev");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "span");
            __builder.AddContent(37, 
#nullable restore
#line 39 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
           pageNum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                      NextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 41 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
       
    private List<TourViewModel> tours;
    private int pageNum = 1;
    private int pageSize = 2;
    protected override async Task OnInitializedAsync()
    {
        tours = await tourService.GetAll(new PagingParameters { PageNumber = pageNum, PageSize = pageSize });
    }
    public async Task NextPage()
    {
        pageNum++;
        tours = await tourService.GetAll(new PagingParameters { PageNumber = pageNum, PageSize = pageSize });
    }
    public async Task PrevPage()
    {
        if (pageNum > 1)
        {
            pageNum--;
            tours = await tourService.GetAll(new PagingParameters { PageNumber = pageNum, PageSize = pageSize });
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TourService tourService { get; set; }
    }
}
#pragma warning restore 1591
