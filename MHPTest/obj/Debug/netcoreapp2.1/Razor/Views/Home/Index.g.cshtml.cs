#pragma checksum "C:\Users\Wifre\source\repos\MHPTest\MHPTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00701ad16e3ef99b17df5b263bbf67ef80b830cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Wifre\source\repos\MHPTest\MHPTest\Views\_ViewImports.cshtml"
using MHPTest;

#line default
#line hidden
#line 2 "C:\Users\Wifre\source\repos\MHPTest\MHPTest\Views\_ViewImports.cshtml"
using MHPTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00701ad16e3ef99b17df5b263bbf67ef80b830cd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bce11e20ad68d52c64d8ac3ccf27e52f3dca5da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MHPTest.Models.FormClass>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Wifre\source\repos\MHPTest\MHPTest\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(62, 12, true);
            WriteLiteral("\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(74, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1afaa410df49a5ad6dae550dd1dddb", async() => {
                BeginContext(80, 43, true);
                WriteLiteral("\r\n\r\n    <title>MHP Calculator</title>\r\n    ");
                EndContext();
                BeginContext(123, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6479ebc716af457fbe194cfa9222601a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(186, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(197, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(201, 1601, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e514af672af4e43953be4390735e89c", async() => {
                BeginContext(207, 28, true);
                WriteLiteral("\r\n    <div align=\"center\">\r\n");
                EndContext();
#line 18 "C:\Users\Wifre\source\repos\MHPTest\MHPTest\Views\Home\Index.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
                BeginContext(281, 209, true);
                WriteLiteral("            <img class=\"image\" src=\"http://mhp-net.es/wp-content/uploads/2016/07/logo-mhp-software-color.png\" />\r\n            <fieldset id=\"rcorners1\">\r\n                <div>\r\n                    <p id=\"text\">");
                EndContext();
                BeginContext(491, 45, false);
#line 23 "C:\Users\Wifre\source\repos\MHPTest\MHPTest\Views\Home\Index.cshtml"
                            Write(Html.DisplayFor(Model => Model.Error_Message));

#line default
#line hidden
                EndContext();
                BeginContext(536, 73, true);
                WriteLiteral("</p>\r\n                </div>\r\n                <div>\r\n                    ");
                EndContext();
                BeginContext(610, 40, false);
#line 26 "C:\Users\Wifre\source\repos\MHPTest\MHPTest\Views\Home\Index.cshtml"
               Write(Html.EditorFor(Model => Model.Operation));

#line default
#line hidden
                EndContext();
                BeginContext(650, 231, true);
                WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <input class=\"button\" type=\"submit\" value=\"Calculate\" />\r\n                </div>\r\n                <div>\r\n                    <p id=\"text\"><b>Operations:</b></p>\r\n");
                EndContext();
#line 33 "C:\Users\Wifre\source\repos\MHPTest\MHPTest\Views\Home\Index.cshtml"
                     for (var i = 0; i < Model.Text.Count; i++)
                    {

#line default
#line hidden
                BeginContext(967, 13, true);
                WriteLiteral("<p id=\"text\">");
                EndContext();
                BeginContext(981, 40, false);
#line 34 "C:\Users\Wifre\source\repos\MHPTest\MHPTest\Views\Home\Index.cshtml"
                             Write(Html.DisplayFor(Model => Model.Text[@i]));

#line default
#line hidden
                EndContext();
                BeginContext(1021, 4, true);
                WriteLiteral("</p>");
                EndContext();
#line 34 "C:\Users\Wifre\source\repos\MHPTest\MHPTest\Views\Home\Index.cshtml"
                                                                               }

#line default
#line hidden
                BeginContext(1028, 736, true);
                WriteLiteral(@"                </div>
            </fieldset>
            <p id=""instructions"">
                <b><i>Basic Instructions:</i></b>
            </p>
            <p id=""instructions"">
                The system only supports numbers, or the following mathematical operators (+, -, /, *).
            </p>
            <p id=""instructions"">
                Square roots are calculated by inserting a letter ""S"" (capital letters only) and the
            </p>
            <p id=""instructions"">
                decimal numbers will be distinguished by having a "","". Only one space between characters
            </p>
            <p id=""instructions"">
                is allowed.Example: 2 3,4 + 9 S 7,34 * -
            </p>
");
                EndContext();
#line 52 "C:\Users\Wifre\source\repos\MHPTest\MHPTest\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1779, 16, true);
                WriteLiteral("        </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1802, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MHPTest.Models.FormClass> Html { get; private set; }
    }
}
#pragma warning restore 1591