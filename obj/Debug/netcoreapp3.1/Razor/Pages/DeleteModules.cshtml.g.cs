#pragma checksum "E:\poe update\WebApplication poe\WebApplication poe\Pages\DeleteModules.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f9805d6d72c1e19f7cf91199ad3d2d07fc62f4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication_poe.Pages.Pages_DeleteModules), @"mvc.1.0.razor-page", @"/Pages/DeleteModules.cshtml")]
namespace WebApplication_poe.Pages
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
#line 1 "E:\poe update\WebApplication poe\WebApplication poe\Pages\_ViewImports.cshtml"
using WebApplication_poe;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f9805d6d72c1e19f7cf91199ad3d2d07fc62f4a", @"/Pages/DeleteModules.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad3e2aa52d5d3f24c80160dd6b35f2452ec646a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DeleteModules : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "E:\poe update\WebApplication poe\WebApplication poe\Pages\DeleteModules.cshtml"
  
    string Modulecode = Request.Query["Modulecode"];
    ClientModuleAndPersonalData mo = new ClientModuleAndPersonalData();
    mo.DeleteModules(Modulecode);



    Response.Redirect("/AllModules");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_DeleteModules> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_DeleteModules> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_DeleteModules>)PageContext?.ViewData;
        public Pages_DeleteModules Model => ViewData.Model;
    }
}
#pragma warning restore 1591
