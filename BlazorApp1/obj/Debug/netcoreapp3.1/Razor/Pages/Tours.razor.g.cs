#pragma checksum "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09e0f2185eea4f935cad6c8a81b8c0999c2399f2"
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
            __builder.AddMarkupContent(0, "<h1>Tours</h1>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    ");
            __Blazor.BlazorApp1.Pages.Tours.TypeInference.CreateMatSelectItem_0(__builder, 3, 4, 
#nullable restore
#line 17 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                                                 vlaue1Items

#line default
#line hidden
#nullable disable
            , 5, "Tour", 6, 
#nullable restore
#line 17 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                                 value1

#line default
#line hidden
#nullable disable
            , 7, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value1 = __value, value1)), 8, () => value1);
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "p");
            __builder.AddMarkupContent(12, "\r\n    ");
            __Blazor.BlazorApp1.Pages.Tours.TypeInference.CreateMatSelectItem_1(__builder, 13, 14, 
#nullable restore
#line 21 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                                                        typetransportItems

#line default
#line hidden
#nullable disable
            , 15, "Transport", 16, 
#nullable restore
#line 21 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                                 typetransport

#line default
#line hidden
#nullable disable
            , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => typetransport = __value, typetransport)), 18, () => typetransport);
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenElement(21, "p");
            __builder.AddMarkupContent(22, "\r\n    ");
            __Blazor.BlazorApp1.Pages.Tours.TypeInference.CreateMatTextField_2(__builder, 23, 24, "Int Field", 25, 
#nullable restore
#line 25 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                                myDoubleValue

#line default
#line hidden
#nullable disable
            , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => myDoubleValue = __value, myDoubleValue)), 27, () => myDoubleValue);
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(30);
            __builder.AddAttribute(31, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                                  Filter

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(34, "Baton");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n\r\n");
#nullable restore
#line 29 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
 if (tours == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "    ");
            __builder.AddMarkupContent(37, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 32 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "tabletour");
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.AddMarkupContent(42, @"<thead>
            <tr>
                <th>Name</th>
                <th>Route</th>
                <th>Type of tour</th>
                <th>Date of start</th>
                <th>Date of finish</th>
                <th>Type of transport</th>
                <th>Price</th> 
            </tr>
        </thead>
        ");
            __builder.OpenElement(43, "tbody");
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 48 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
             foreach (var tours in tours)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                ");
            __builder.OpenElement(46, "tr");
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 51 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.nameTour

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 52 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.route

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 53 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.typeOfTour

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 54 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.dateOfStart

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 55 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.dateOfFinish

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 56 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.typeOfTransport

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 57 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                         tours.price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "td");
            __builder.OpenElement(70, "a");
            __builder.AddAttribute(71, "href", "/tourone/" + (
#nullable restore
#line 58 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                                           tours.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(72, "More");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 60 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 63 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
     if (pageNum > 1)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "        ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "name", "prev");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                                      PrevPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(82, "Prev");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 66 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "    ");
            __builder.OpenElement(85, "span");
            __builder.AddContent(86, 
#nullable restore
#line 68 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
           pageNum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
                      NextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(90, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 70 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\ООП\WindowsForm\EntityFramework\WebApplicationEF\BlazorApp1\Pages\Tours.razor"
       


    //public DateTime Date1 { get; set; }

    string? value1;
    string[] vlaue1Items = new[]
    {
                "Extreme",
                "Gastro-tour",
                "Cruise",
                "Ski",
                "Ukraine",
                "All",
    };

    string? typetransport;
    string[] typetransportItems = new[]
    {
                "Bus",
                "Train",
                "Airplane",
                "Ship",
                "All",
    };


    double myDoubleValue;

    bool click = false;

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
        if (click == true)
        {
            await this.Filter();
        }
        else
        {
            tours = await tourService.GetAll(new PagingParameters { PageNumber = pageNum, PageSize = pageSize });
        }
    }
    public async Task PrevPage()
    {
        if (pageNum > 1)
        {
            pageNum--;
            if (click == true)
            {
                await this.Filter();
            }
            else
            {
                tours = await tourService.GetAll(new PagingParameters { PageNumber = pageNum, PageSize = pageSize });
            }
        }


    }

    public async Task Filter()
    {
        click = true;
        PagingParameters paging = new PagingParameters
        {
            PageNumber = pageNum,
            PageSize = pageSize,
            //Date = Date1,
            TypeOfTour = value1 ?? "All",
            TypeOfTransport = typetransport ?? "All",
            Price = myDoubleValue == 0 ? 1000000 : myDoubleValue
        };
        tours = await tourService.GetFilter(paging);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TourService tourService { get; set; }
    }
}
namespace __Blazor.BlazorApp1.Pages.Tours
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatSelectItem_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TValue> __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelectItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatSelectItem_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TValue> __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelectItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
