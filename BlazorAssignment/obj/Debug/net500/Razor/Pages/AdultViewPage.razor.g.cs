#pragma checksum "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\AdultViewPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4045a5585cf57b8f7952d2d7513defd30ec45b3"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/adultView/{Id:int}")]
    public partial class AdultViewPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adult View</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-md-3");
            __builder.AddMarkupContent(3, "<label>\r\n        First Name\r\n    </label>\r\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddAttribute(5, "class", "col-md-12");
            __builder.AddContent(6, 
#nullable restore
#line 8 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\AdultViewPage.razor"
                           _adultModel.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<label>\r\n        Last Name\r\n    </label>\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "class", "col-md-12");
            __builder.AddContent(11, 
#nullable restore
#line 12 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\AdultViewPage.razor"
                           _adultModel.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.AddMarkupContent(13, "<label>\r\n        Hair color\r\n    </label>\r\n    ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "col-md-12");
            __builder.AddContent(16, 
#nullable restore
#line 16 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\AdultViewPage.razor"
                           _adultModel.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.AddMarkupContent(18, "<label>\r\n        Eye Color\r\n    </label>\r\n    ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "col-md-12");
            __builder.AddContent(21, 
#nullable restore
#line 20 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\AdultViewPage.razor"
                           _adultModel.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.AddMarkupContent(23, "<label>\r\n        Age\r\n    </label>\r\n    ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "col-md-12");
            __builder.AddContent(26, 
#nullable restore
#line 24 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\AdultViewPage.razor"
                           _adultModel.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.AddMarkupContent(28, "<label>\r\n        Weight\r\n    </label>\r\n    ");
            __builder.OpenElement(29, "p");
            __builder.AddAttribute(30, "class", "col-md-12");
            __builder.AddContent(31, 
#nullable restore
#line 28 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\AdultViewPage.razor"
                           _adultModel.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.AddMarkupContent(33, "<label>\r\n        Height\r\n    </label>\r\n    ");
            __builder.OpenElement(34, "p");
            __builder.AddAttribute(35, "class", "col-md-12");
            __builder.AddContent(36, 
#nullable restore
#line 32 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\AdultViewPage.razor"
                           _adultModel.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.AddMarkupContent(38, "<label>\r\n        Sex\r\n    </label>\r\n    ");
            __builder.OpenElement(39, "p");
            __builder.AddAttribute(40, "class", "col-md-12");
            __builder.AddContent(41, 
#nullable restore
#line 36 "D:\Alin Assignment\DnpAssignment\BlazorAssignment\Pages\AdultViewPage.razor"
                           _adultModel.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
