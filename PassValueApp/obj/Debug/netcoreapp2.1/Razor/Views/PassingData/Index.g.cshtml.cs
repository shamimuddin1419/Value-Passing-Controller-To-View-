#pragma checksum "E:\How To Pass Object,Objects List and Data From Controller To View Using ASP.Net Core MVC\PassValueApp\PassValueApp\Views\PassingData\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b344eaafb04a8d0c695df511fdad8cd766e9c1bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PassingData_Index), @"mvc.1.0.view", @"/Views/PassingData/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PassingData/Index.cshtml", typeof(AspNetCore.Views_PassingData_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b344eaafb04a8d0c695df511fdad8cd766e9c1bf", @"/Views/PassingData/Index.cshtml")]
    public class Views_PassingData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\How To Pass Object,Objects List and Data From Controller To View Using ASP.Net Core MVC\PassValueApp\PassValueApp\Views\PassingData\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(56, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "526a346080e14a4187212ccb25266172", async() => {
                BeginContext(62, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            BeginContext(156, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(158, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa4366a0baf44314aefc468d0ae2f6f9", async() => {
                BeginContext(164, 12, true);
                WriteLiteral("\r\n\r\n    ID: ");
                EndContext();
                BeginContext(177, 10, false);
#line 14 "E:\How To Pass Object,Objects List and Data From Controller To View Using ASP.Net Core MVC\PassValueApp\PassValueApp\Views\PassingData\Index.cshtml"
   Write(ViewBag.ID);

#line default
#line hidden
                EndContext();
                BeginContext(187, 25, true);
                WriteLiteral("\r\n    <br />\r\n     Name: ");
                EndContext();
                BeginContext(213, 12, false);
#line 16 "E:\How To Pass Object,Objects List and Data From Controller To View Using ASP.Net Core MVC\PassValueApp\PassValueApp\Views\PassingData\Index.cshtml"
      Write(ViewBag.Name);

#line default
#line hidden
                EndContext();
                BeginContext(225, 24, true);
                WriteLiteral("\r\n    <br />\r\n    Roll: ");
                EndContext();
                BeginContext(250, 12, false);
#line 18 "E:\How To Pass Object,Objects List and Data From Controller To View Using ASP.Net Core MVC\PassValueApp\PassValueApp\Views\PassingData\Index.cshtml"
     Write(ViewBag.Roll);

#line default
#line hidden
                EndContext();
                BeginContext(262, 25, true);
                WriteLiteral("\r\n    <br />\r\n    Email: ");
                EndContext();
                BeginContext(288, 13, false);
#line 20 "E:\How To Pass Object,Objects List and Data From Controller To View Using ASP.Net Core MVC\PassValueApp\PassValueApp\Views\PassingData\Index.cshtml"
      Write(ViewBag.Email);

#line default
#line hidden
                EndContext();
                BeginContext(301, 13, true);
                WriteLiteral("\r\n   \r\n  \r\n\r\n");
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
            BeginContext(321, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
