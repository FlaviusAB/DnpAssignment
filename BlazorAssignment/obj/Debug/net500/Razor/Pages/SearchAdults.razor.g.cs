#pragma checksum "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a07daacb4f7610f40c99db0a799e3c56c5cdfd2c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAssignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\_Imports.razor"
using BlazorAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\_Imports.razor"
using BlazorAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
using FileData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adults")]
    public partial class SearchAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3> Type a name</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex mb-5");
            __builder.AddAttribute(3, "style", "width: 100%;justify-content: space-between;flex-direction: row");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "type", "search");
            __builder.AddAttribute(7, "placeholder", "Search");
            __builder.AddAttribute(8, "aria-label", "Search");
            __builder.AddAttribute(9, "style", "border-radius: 20px");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
                        _searchInputVal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _searchInputVal = __value, _searchInputVal));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-outline-success ml-2 ");
            __builder.AddAttribute(15, "type", "submit");
            __builder.AddAttribute(16, "style", "border-radius:20px;width: 150px;");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
                      Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "\r\n        Search\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-outline-success ml-2 ");
            __builder.AddAttribute(22, "type", "submit");
            __builder.AddAttribute(23, "style", "border-radius:20px;width: 150px;");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
                      Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "\r\n        Add\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
 if (_val )
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "ul");
            __builder.AddAttribute(27, "class", "list-group");
#nullable restore
#line 28 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
         foreach(var adult in _adultList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "list-group-item");
            __builder.AddAttribute(30, "style", "cursor: pointer");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "d-flex");
            __builder.AddAttribute(33, "style", "flex-direction: row; justify-content: space-between; align-items: center");
            __builder.AddContent(34, 
#nullable restore
#line 32 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, " ");
            __builder.AddContent(36, 
#nullable restore
#line 32 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
                                      adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "d-flex");
            __builder.AddAttribute(40, "style", "flex-direction: row");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-outline-info btn-sm");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
                                                                              () => Edit(adult.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-outline-info btn-sm");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
                                                                              () => View(adult.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "btn btn-outline-info btn-sm mr-3");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
                                                                                   () => Delete(adult.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 45 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
 if (!_val)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "ul");
            __builder.AddAttribute(56, "class", "list-group");
#nullable restore
#line 50 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
             for (var x = 1; x < _adultList.Count; x++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "li");
            __builder.AddAttribute(58, "class", "list-group-item");
            __builder.AddAttribute(59, "style");
            __builder.AddContent(60, 
#nullable restore
#line 53 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
                     _adultList[@x].FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, " ");
            __builder.AddContent(62, 
#nullable restore
#line 53 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
                                               _adultList[@x].LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 55 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 58 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\SearchAdults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
