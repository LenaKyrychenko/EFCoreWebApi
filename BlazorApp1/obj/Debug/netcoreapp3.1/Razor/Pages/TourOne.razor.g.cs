#pragma checksum "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09562d45f2056a21af6cc54eddabf5c479e5abea"
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
            __builder.AddMarkupContent(0, "<style>\r\n    body {\r\n        background-color: #FFC897;\r\n    }\r\n\r\n    .conteiner {\r\n        width: 70%;\r\n        height: 900px;\r\n        background-color: #FFFFFF;\r\n        position: absolute;\r\n        margin-left: 15%;\r\n        margin-top: 3%;\r\n        border-radius: 30px;\r\n        box-shadow: 20px -15px 10px 5px rgba(0, 0, 0, .2);\r\n    }\r\n\r\n    .pic img {\r\n        border: 1px black solid;\r\n        position: absolute;\r\n        margin-left: 4%;\r\n        margin-top: 4%;\r\n        width: 45%;\r\n        height: 39%;\r\n        border-radius: 30px;\r\n    }\r\n\r\n    .smallinfo {\r\n        /*border:1px red solid;*/\r\n        width: 43%;\r\n        position: absolute;\r\n        margin-left: 53%;\r\n        margin-top: 3.5%;\r\n        height: 40%;\r\n    }\r\n\r\n        .smallinfo .name {\r\n            font-weight: bold;\r\n            font-family: Sitka Text;\r\n            font-size: 40px;\r\n            text-align: center;\r\n            margin-top: 0px;\r\n            margin-bottom: 0px;\r\n        }\r\n\r\n        .smallinfo .dstart {\r\n            position: absolute;\r\n            font-family: Sitka Text;\r\n            font-size: 30px;\r\n            /*margin-top: 50px;*/\r\n            margin-top: 10px;\r\n            margin-bottom: 0px;\r\n        }\r\n\r\n        .smallinfo .dfinish {\r\n            position: absolute;\r\n            font-family: Sitka Text;\r\n            font-size: 30px;\r\n            /*margin-top: 110px;*/\r\n            margin-top: 70px;\r\n            margin-bottom: 0px;\r\n        }\r\n\r\n        .smallinfo .route {\r\n            position: absolute;\r\n            font-family: Sitka Text;\r\n            font-size: 30px;\r\n            margin-top: 130px;\r\n            /*margin-top: 0px;*/\r\n            margin-bottom: 0px;\r\n        }\r\n\r\n        .smallinfo .price {\r\n            position: absolute;\r\n            font-family: Sitka Text;\r\n            font-size: 40px;\r\n            margin-top: 265px;\r\n            /*margin-top: 0px;*/\r\n            margin-bottom: 0px;\r\n            font-weight: normal;\r\n        }\r\n\r\n        .smallinfo .info {\r\n            /*border:1px red solid;*/\r\n            width: 96%;\r\n            position: absolute;\r\n            margin-left: 2%;\r\n            /*margin-top:3.5%;*/\r\n            height: 70%;\r\n        }\r\n\r\n    .opys {\r\n        width: 92%;\r\n        /*border: 1px solid black;*/\r\n        height: 40%;\r\n        margin-top: 42%;\r\n        margin-left: 4%;\r\n    }\r\n\r\n        .opys p {\r\n            word-wrap: break-word;\r\n            font-family: Bell M;\r\n            font-size: 24px;\r\n            font-weight: normal;\r\n            text-align: center;\r\n            line-height: 1.5;\r\n        }\r\n\r\n    .button {\r\n        /*border: 1px black solid;*/\r\n        width: 68%;\r\n        margin-left: 17%;\r\n    }\r\n\r\n        .button .reserve {\r\n            margin-left: 400px;\r\n        }\r\n\r\n        .button a {\r\n            text-decoration: none;\r\n            outline: none;\r\n            display: inline-block;\r\n            padding: 15px 30px;\r\n            margin: 10px 20px;\r\n            border-radius: 10px;\r\n            box-shadow: 0 0 40px 40px #FFA659 inset, 0 0 0 0 #FFA659;\r\n            font-family: \'Montserrat\', sans-serif;\r\n            font-weight: bold;\r\n            letter-spacing: 2px;\r\n            color: white;\r\n            transition: .15s ease-in-out;\r\n        }\r\n\r\n            .button a:hover {\r\n                box-shadow: 0 0 10px 0 #FF8A24 inset, 0 0 10px 4px #FF8A24;\r\n                color: #FF8A24;\r\n            }\r\n</style>\r\n        ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "conteiner");
            __builder.AddMarkupContent(3, "\r\n            ");
            __builder.AddMarkupContent(4, "<div class=\"pic\">\r\n                <img src=\"img/Hello-Ukraine-Vebinary_01052020_5-700x420.jpg\">\r\n            </div>\r\n            ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "smallinfo");
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "class", "name");
            __builder.AddContent(10, 
#nullable restore
#line 148 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor"
                                 tourViewModel.nameTour

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "info");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "p");
            __builder.AddAttribute(16, "class", "dstart");
            __builder.AddMarkupContent(17, "<b>Date of start:</b> ");
            __builder.AddContent(18, 
#nullable restore
#line 150 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor"
                                                             tourViewModel.dateOfStart.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "p");
            __builder.AddAttribute(21, "class", "dfinish");
            __builder.AddMarkupContent(22, "<b>Date of finish:</b>");
            __builder.AddContent(23, 
#nullable restore
#line 151 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor"
                                                              tourViewModel.dateOfFinish.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "p");
            __builder.AddAttribute(26, "class", "price");
            __builder.AddMarkupContent(27, "<b>Price:</b> ");
            __builder.AddContent(28, 
#nullable restore
#line 152 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor"
                                                    tourViewModel.price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, " UAH");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "class", "route");
            __builder.AddMarkupContent(33, "<b>Route:</b><br> ");
            __builder.AddContent(34, 
#nullable restore
#line 153 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor"
                                                        tourViewModel.route

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "opys");
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "p");
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.AddContent(43, 
#nullable restore
#line 158 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor"
                     tourViewModel.description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.AddMarkupContent(47, "<div class=\"button\">\r\n                <a href=\"#\" class=\"back\">Back</a>\r\n                <a href=\"#\" class=\"reserve\">Reserve</a>\r\n            </div>\r\n        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 168 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\TourOne.razor"
       
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

    protected override async Task OnInitializedAsync()
    {
        tourViewModel = await tourService.GetById(tourid);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TourService tourService { get; set; }
    }
}
#pragma warning restore 1591
