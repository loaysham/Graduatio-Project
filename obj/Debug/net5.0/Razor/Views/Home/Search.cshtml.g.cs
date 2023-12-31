#pragma checksum "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ae0e08d121a75ffc2dc813a4f08f7e972b72b8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ae0e08d121a75ffc2dc813a4f08f7e972b72b8c", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1a5b90897981b1c3a3409f62eb6ee1b871fc22b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<Doctor, Clinic>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Latest property -->
<section id=""aa-latest-property"">
    <div class=""container"">
        <div class=""aa-latest-property-area"">
            <div class=""aa-title"">
                <h2>Latest Doctors</h2>
                <span></span>
                <p>
                     In our community, we are grateful for the exceptional doctors whose top-notch skills, compassion, expertise, and empathy make a real difference in patients' lives, providing exceptional care that positively impacts our health.
                </p>
            </div>
");
#nullable restore
#line 18 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
             if (Model.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3><span style=\"color:red\">Sorry, there are no results for your search</span></h3>\r\n");
#nullable restore
#line 21 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"aa-latest-properties-content\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 26 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                     foreach (var doctor in Model)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4\">\r\n                            <article class=\"aa-properties-item\">\r\n\r\n\r\n                                    <a href=\"#\" class=\"aa-properties-item-img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5ae0e08d121a75ffc2dc813a4f08f7e972b72b8c6695", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1300, "~/uploads/", 1300, 10, true);
#nullable restore
#line 34 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 1310, doctor.Key.Doctor_ImageProfile, 1310, 31, false);

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
#line 37 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                                 if (doctor.Key.Doctor_AppointmentType.Equals(ClinicProject.Data.Enum.AppointmentType.Urgent))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"aa-tag sold-out\">\r\n                                        ");
#nullable restore
#line 40 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                                   Write(doctor.Key.Doctor_AppointmentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 42 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"aa-tag for-sale\">\r\n                                        ");
#nullable restore
#line 46 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                                   Write(doctor.Key.Doctor_AppointmentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 48 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"aa-properties-item-content\">\r\n                                    <div class=\"aa-properties-info\">\r\n                                        <span>");
#nullable restore
#line 52 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                                         Write(doctor.Key.Doctor_Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                    </div>\r\n                                    <div class=\"aa-properties-about\">\r\n                                        <h3><a href=\"#\">Dr:");
#nullable restore
#line 56 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                                                      Write(doctor.Key.Doctor_FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 56 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                                                                                   Write(doctor.Key.Doctor_LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h3>\r\n                                        <h4> ");
#nullable restore
#line 57 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                                        Write(doctor.Value.ClinicRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" stars</h4>\r\n                                    </div>\r\n                                    <div class=\"aa-properties-detial\">\r\n                                        <span class=\"aa-price\">\r\n                                            ");
#nullable restore
#line 61 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                                       Write(doctor.Value.clinc_Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" JD\r\n                                        </span>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ae0e08d121a75ffc2dc813a4f08f7e972b72b8c12399", async() => {
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
#line 63 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
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
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </article>\r\n                        </div>\r\n");
#nullable restore
#line 68 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 71 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Home\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n<!-- / Latest property -->");
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
