#pragma checksum "/Users/tomarares/Developer/MersTrenuri-NetCore-Front/MVC-TEST_FRONT/Views/Statie/Adauga.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9cc55b916f66601b7c72dfa455515764b7df7ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statie_Adauga), @"mvc.1.0.view", @"/Views/Statie/Adauga.cshtml")]
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
#line 1 "/Users/tomarares/Developer/MersTrenuri-NetCore-Front/MVC-TEST_FRONT/Views/_ViewImports.cshtml"
using MVC_TEST_FRONT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tomarares/Developer/MersTrenuri-NetCore-Front/MVC-TEST_FRONT/Views/_ViewImports.cshtml"
using MVC_TEST_FRONT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9cc55b916f66601b7c72dfa455515764b7df7ab", @"/Views/Statie/Adauga.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aa7070592da520c683610ca6bd73c9080328b51", @"/Views/_ViewImports.cshtml")]
    public class Views_Statie_Adauga : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/tomarares/Developer/MersTrenuri-NetCore-Front/MVC-TEST_FRONT/Views/Statie/Adauga.cshtml"
  
    ViewData["Title"] = "Adauga Statie";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "/Users/tomarares/Developer/MersTrenuri-NetCore-Front/MVC-TEST_FRONT/Views/Statie/Adauga.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9cc55b916f66601b7c72dfa455515764b7df7ab3665", async() => {
                WriteLiteral("\n  <div class=\"form-group\">\n    <label for=\"nume\">Nume</label>\n    <input type=\"text\" class=\"form-control\" id=\"nume\" name=\"nume\" placeholder=\"Introdu nume\">\n  </div>\n  <button type=\"submit\" id=\"adauga\" class=\"btn btn-primary\">Adauga</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script>

    $('#adauga').click(function (e) { 
        var serviceUrl = 'https://localhost:5001/api/stations/createstation';
        var nume = $('input[name=""nume""]').val();
        const data = JSON.stringify(nume);
        console.log(nume)
        console.log(""banana"");
        var settings = {
            ""url"": ""https://localhost:5001/api/stations/createstation"",
            ""method"": ""POST"",
            ""timeout"": 0,
            ""headers"": {
                ""Content-Type"": ""application/json""
            },
            ""data"": JSON.stringify({ ""name"": data }),
        };

        $.ajax(settings).done(function (response) {
            console.log(nume);
        });
    });
</script>
");
            }
            );
            WriteLiteral("\n");
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