#pragma checksum "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "558132085d2d5afa3aee18b2e5ba856446063950"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_PatientsHistory), @"mvc.1.0.view", @"/Views/Doctor/PatientsHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"558132085d2d5afa3aee18b2e5ba856446063950", @"/Views/Doctor/PatientsHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1a5b90897981b1c3a3409f62eb6ee1b871fc22b", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_PatientsHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<OldReservation, Patient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml"
  
    ViewData["Title"] = "ReservationForPatient";
    Layout = "~/Views/Shared/Doctor_Layout/_Layout_Doctor.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead class=""thead-dark"">
        <tr>
            <th>Patient Name</th>
            <th>Patient Location</th>
            <th>Patient Age</th>
            <th>Day</th>
            <th>Start Time</th>
            <th>End Time</th>
            <th>Specialization</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml"
               Write(item.Value.Patient_FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml"
                                             Write(item.Value.Patient_LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml"
               Write(item.Value.Patient_Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml"
               Write(item.Value.Patient_Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml"
               Write(item.Key.OldReservation_Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml"
               Write(item.Key.Strat_Oldreservation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml"
               Write(item.Key.End_Oldreservation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml"
               Write(item.Key.OldReservation_Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\PatientsHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<OldReservation, Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
