#pragma checksum "D:\srinivasu dandamudi\FirstDotNetCore\Pages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e953e1df290c1c1929522e86fd82fa757f5d8ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FirstDotNetCore.Pages.Pages_Details), @"mvc.1.0.razor-page", @"/Pages/Details.cshtml")]
namespace FirstDotNetCore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\srinivasu dandamudi\FirstDotNetCore\Pages\_ViewImports.cshtml"
using FirstDotNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{restaurantId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e953e1df290c1c1929522e86fd82fa757f5d8ec", @"/Pages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7191fa8507bc16cf5dfaeb35a83c9a9dac8b7656", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"form-group\">\r\n        <label>Id&nbsp;</label>\r\n        ");
#nullable restore
#line 9 "D:\srinivasu dandamudi\FirstDotNetCore\Pages\Details.cshtml"
   Write(Model.restaurant.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Name&nbsp;</label>\r\n        ");
#nullable restore
#line 13 "D:\srinivasu dandamudi\FirstDotNetCore\Pages\Details.cshtml"
   Write(Model.restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Location&nbsp;</label>\r\n        ");
#nullable restore
#line 17 "D:\srinivasu dandamudi\FirstDotNetCore\Pages\Details.cshtml"
   Write(Model.restaurant.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstDotNetCore.Pages.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstDotNetCore.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstDotNetCore.Pages.DetailsModel>)PageContext?.ViewData;
        public FirstDotNetCore.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
