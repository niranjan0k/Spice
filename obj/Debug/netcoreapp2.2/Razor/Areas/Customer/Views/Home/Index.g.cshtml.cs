#pragma checksum "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec76502ed256d6183240684b751135e6d247f7cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_Home_Index))]
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
#line 1 "E:\WebApp\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#line 2 "E:\WebApp\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec76502ed256d6183240684b751135e6d247f7cb", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d11972dba3ccf0da976b184cdef3b810ef5472", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThumbnailAreaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 3 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
 if (Model.Coupon.ToList().Count > 0)
{

#line default
#line hidden
            BeginContext(97, 100, true);
            WriteLiteral("    <div class=\"border\">\r\n        <div class=\"carousel\" data-ride=\"carousel\" data-interval=\"2500\">\r\n");
            EndContext();
#line 7 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Coupon.ToList().Count; i++)
            {
                var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                var imgsrc = String.Format("data:image/jpg;base64,{0}", base64);

                if (i == 0)
                {


#line default
#line hidden
            BeginContext(502, 84, true);
            WriteLiteral("                    <div class=\"carousel-item active\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 586, "\"", 599, 1);
#line 16 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 592, imgsrc, 592, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(600, 68, true);
            WriteLiteral(" width=\"50px\" class=\"d-block w-100\" />\r\n                    </div>\r\n");
            EndContext();
#line 18 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(728, 77, true);
            WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 805, "\"", 818, 1);
#line 22 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 811, imgsrc, 811, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(819, 68, true);
            WriteLiteral(" width=\"50px\" class=\"d-block w-100\" />\r\n                    </div>\r\n");
            EndContext();
#line 24 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(921, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
            EndContext();
#line 28 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(952, 253, true);
            WriteLiteral("\r\n<br /><br /><br /><br />\r\n\r\n<div class=\"backgroundWhite container\">\r\n\r\n    <ul id=\"menu-filters\" class=\"menu-filter-list list-inline text-center\">\r\n        <li class=\"active btn btn-secondary ml-1 mr-1\" data-filter=\".menu-restaurant\">Show All</li>\r\n\r\n");
            EndContext();
#line 37 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
         foreach (var item in Model.Category)
        {

#line default
#line hidden
            BeginContext(1263, 48, true);
            WriteLiteral("            <li class=\"ml-1 mr-1\" data-filter=\".");
            EndContext();
            BeginContext(1312, 35, false);
#line 39 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
                                           Write(item.Name.Replace(" ",string.Empty));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1350, 9, false);
#line 39 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
                                                                                 Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1359, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 40 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1377, 15, true);
            WriteLiteral("    </ul>\r\n\r\n\r\n");
            EndContext();
#line 44 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
     foreach (var category in Model.Category)
    {

#line default
#line hidden
            BeginContext(1446, 57, true);
            WriteLiteral("        <div class=\"row\" id=\"menu-wrapper\">\r\n            ");
            EndContext();
            BeginContext(1503, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec76502ed256d6183240684b751135e6d247f7cb8027", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 47 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.MenuItem.Where(m=>m.Category.Name.Equals(category.Name));

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1615, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 49 "E:\WebApp\Spice\Areas\Customer\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1640, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1667, 759, true);
                WriteLiteral(@"
    <script src=""http://code.jquery.com/jquery-3.4.1.js""
            integrity=""sha256-WpOohJOqMqqyKL9FccASB9O0KwACQJpFTUBLTYOVvVU=""
            crossorigin=""anonymous""></script>
    <script>

        var posts = $('.post');

        (function ($) {

            $(""#menu-filters li"").click(function () {
                $(""#menu-filters li"").removeClass('active btn btn-secondary');
                $(this).addClass('active btn btn-secondary');

                var selectedFilter = $(this).data(""filter"");

                $("".menu-restaurant"").fadeOut();

                setTimeout(function () {
                    $(selectedFilter).slideDown();
                }, 300);
            });



        })(jQuery);

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spice.Models.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
