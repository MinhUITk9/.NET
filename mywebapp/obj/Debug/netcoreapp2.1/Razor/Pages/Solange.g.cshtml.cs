#pragma checksum "D:\UIT\.NET\mywebapp\Pages\Solange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3163ef9d0bf2e40feef1d1fcf0e485a77830e9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Solange), @"mvc.1.0.razor-page", @"/Pages/Solange.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Solange.cshtml", typeof(AspNetCore.Pages_Solange), null)]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3163ef9d0bf2e40feef1d1fcf0e485a77830e9b", @"/Pages/Solange.cshtml")]
    public class Pages_Solange : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 60, true);
            WriteLiteral("\r\n<h1>Hi Solange</h1>\r\n\r\n<p>This page is at /Solange</p>\r\n\r\n");
            EndContext();
#line 7 "D:\UIT\.NET\mywebapp\Pages\Solange.cshtml"
  
    var i = 2 + 2;

#line default
#line hidden
            BeginContext(94, 28, true);
            WriteLiteral("\r\n<b>The concert starts at: ");
            EndContext();
            BeginContext(123, 1, false);
#line 11 "D:\UIT\.NET\mywebapp\Pages\Solange.cshtml"
                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(124, 8, true);
            WriteLiteral(" pm </b>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Solange> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Solange> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Solange>)PageContext?.ViewData;
        public Pages_Solange Model => ViewData.Model;
    }
}
#pragma warning restore 1591
