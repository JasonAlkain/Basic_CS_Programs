#pragma checksum "E:\Schools\The Tech Academy\the-tech-academy-repos\C-Sharp\Basic_CS_Programs\WebAppMVC_1_Core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c23803f512788114376dc19f7cf28a410503836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "E:\Schools\The Tech Academy\the-tech-academy-repos\C-Sharp\Basic_CS_Programs\WebAppMVC_1_Core\Views\_ViewImports.cshtml"
using WebAppMVC_1_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Schools\The Tech Academy\the-tech-academy-repos\C-Sharp\Basic_CS_Programs\WebAppMVC_1_Core\Views\_ViewImports.cshtml"
using WebAppMVC_1_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c23803f512788114376dc19f7cf28a410503836", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11f2cbacd835ad9834820cb90f979ca34a7f5dd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Schools\The Tech Academy\the-tech-academy-repos\C-Sharp\Basic_CS_Programs\WebAppMVC_1_Core\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome Traveler</h1>
    <h2>Project Alpha</h2>
    <hr />
    <div class=""row"">
        <div class=""row"">
            <div class=""card"">
                <div class=""card-body"">
                    <h3>Built in ASP.NET Core</h3>
                </div>
                <div class=""card-body"">
                    <div class=""row"">

                        <div class=""col"">
                            <img alt=""Image"" />
                            <hr />
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sed sem posuere risus vulputate ornare. Nunc et sagittis elit. Praesent magna justo, gravida at viverra ut, efficitur quis mi. Phasellus.</p>
                        </div>
                        <div class=""col"">
                            <img src=""../Images/Calendar_Icon.png"" alt=""Calendar Icon"" />
                            <hr />
                            <p>");
#nullable restore
#line 26 "E:\Schools\The Tech Academy\the-tech-academy-repos\C-Sharp\Basic_CS_Programs\WebAppMVC_1_Core\Views\Home\Index.cshtml"
                          Write(ViewBag.localTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                        <div class=""col"">
                            <img alt=""Image"" />
                            <hr />
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sed sem posuere risus vulputate ornare. Nunc et sagittis elit. Praesent magna justo, gravida at viverra ut, efficitur quis mi. Phasellus.</p>
                        </div>

                    </div>
                </div>
            </div>
        </div>

    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
