#pragma checksum "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34c468cc55cecf6aee2ea38be6aee0750329aba8"
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
#line 1 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\_ViewImports.cshtml"
using ClinicProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\_ViewImports.cshtml"
using ClinicProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34c468cc55cecf6aee2ea38be6aee0750329aba8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1a5b90897981b1c3a3409f62eb6ee1b871fc22b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<Doctor, Clinic>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsOfDoctor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("aa-secondary-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34c468cc55cecf6aee2ea38be6aee0750329aba85174", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"UTF-8\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"style.css\">\r\n    <title>Star rating using pure CSS</title>\r\n    \r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34c468cc55cecf6aee2ea38be6aee0750329aba86315", async() => {
                WriteLiteral(@"
    <!-- Latest property -->
    <section id=""aa-latest-property"">
        <div class=""container"">
            <div class=""aa-latest-property-area"">
                <div class=""aa-title"">
                    <h2>Latest Doctors</h2>
                    <span>
                    </span>
                    <p>
                        In our community, we are grateful for the exceptional doctors whose top-notch skills, compassion, expertise, and empathy make a real difference in patients' lives, providing exceptional care that positively impacts our health.
                    </p>

                </div>
                <div class=""aa-latest-properties-content"">
                    <div class=""row"">
");
#nullable restore
#line 36 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                         foreach (var doctor in Model)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-md-4\">\r\n                                <article class=\"aa-properties-item\">\r\n\r\n                                    <a href=\"#\" class=\"aa-properties-item-img\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34c468cc55cecf6aee2ea38be6aee0750329aba87859", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1376, "~/uploads/", 1376, 10, true);
#nullable restore
#line 43 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1386, doctor.Key.Doctor_ImageProfile, 1386, 31, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </a>\r\n\r\n");
#nullable restore
#line 46 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                                     if (doctor.Key.Doctor_AppointmentType.Equals(ClinicProject.Data.Enum.AppointmentType.Urgent))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"aa-tag sold-out\">\r\n                                            ");
#nullable restore
#line 49 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                                       Write(doctor.Key.Doctor_AppointmentType);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 51 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"aa-tag for-sale\">\r\n                                            ");
#nullable restore
#line 55 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                                       Write(doctor.Key.Doctor_AppointmentType);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 57 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    <div class=\"aa-properties-item-content\">\r\n                                        <div class=\"aa-properties-info\">\r\n                                            <span>");
#nullable restore
#line 61 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                                             Write(doctor.Key.Doctor_Specialization);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n                                        </div>\r\n                                        <div class=\"aa-properties-about\">\r\n                                            <h3><a href=\"#\">Dr:");
#nullable restore
#line 65 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                                                          Write(doctor.Key.Doctor_FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 65 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                                                                                       Write(doctor.Key.Doctor_LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a></h3>\r\n                                            <h4> ");
#nullable restore
#line 66 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                                            Write(doctor.Value.ClinicRate);

#line default
#line hidden
#nullable disable
                WriteLiteral(" stars</h4>\r\n                                        </div>\r\n                                        <div class=\"aa-properties-detial\">\r\n                                            <span class=\"aa-price\">\r\n                                                ");
#nullable restore
#line 70 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                                           Write(doctor.Value.clinc_Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" JD\r\n                                            </span>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34c468cc55cecf6aee2ea38be6aee0750329aba813788", async() => {
                    WriteLiteral("View Details");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                                                                                                    WriteLiteral(doctor.Key.DoctorId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n\r\n                                      \r\n                                </article>\r\n                            </div>\r\n");
#nullable restore
#line 78 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- / Latest property -->\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<Doctor, Clinic>> Html { get; private set; }
    }
}
#pragma warning restore 1591