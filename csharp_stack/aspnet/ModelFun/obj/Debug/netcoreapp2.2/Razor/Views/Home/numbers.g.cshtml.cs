#pragma checksum "C:\Users\blufo\OneDrive\Documents\coding_dojo\csharp_stack\aspnet\ModelFun\Views\Home\numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3927b77eb2b7675bcd4f0851b085f317207ab344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_numbers), @"mvc.1.0.view", @"/Views/Home/numbers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/numbers.cshtml", typeof(AspNetCore.Views_Home_numbers))]
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
#line 1 "C:\Users\blufo\OneDrive\Documents\coding_dojo\csharp_stack\aspnet\ModelFun\Views\_ViewImports.cshtml"
using ModelFun;

#line default
#line hidden
#line 1 "C:\Users\blufo\OneDrive\Documents\coding_dojo\csharp_stack\aspnet\ModelFun\Views\Home\numbers.cshtml"
using ModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3927b77eb2b7675bcd4f0851b085f317207ab344", @"/Views/Home/numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e1b1b354fa57554a7cd6a0042c9084b91a9f81a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Numbers>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 80, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h3>Here are some Numbers!</h3>\r\n\r\n</div>\r\n<ul>\r\n");
            EndContext();
#line 8 "C:\Users\blufo\OneDrive\Documents\coding_dojo\csharp_stack\aspnet\ModelFun\Views\Home\numbers.cshtml"
     foreach (int num in Model.nums)
    {

#line default
#line hidden
            BeginContext(165, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(178, 3, false);
#line 10 "C:\Users\blufo\OneDrive\Documents\coding_dojo\csharp_stack\aspnet\ModelFun\Views\Home\numbers.cshtml"
       Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(181, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "C:\Users\blufo\OneDrive\Documents\coding_dojo\csharp_stack\aspnet\ModelFun\Views\Home\numbers.cshtml"
    }

#line default
#line hidden
            BeginContext(195, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Numbers> Html { get; private set; }
    }
}
#pragma warning restore 1591
