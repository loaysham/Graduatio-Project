#pragma checksum "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\ReceiveNoteFromPatient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a5b62606b7a5400eeac47d0cb273e27b90c02a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_ReceiveNoteFromPatient), @"mvc.1.0.view", @"/Views/Doctor/ReceiveNoteFromPatient.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a5b62606b7a5400eeac47d0cb273e27b90c02a1", @"/Views/Doctor/ReceiveNoteFromPatient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1a5b90897981b1c3a3409f62eb6ee1b871fc22b", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_ReceiveNoteFromPatient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PatientNoteToDoctor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\ReceiveNoteFromPatient.cshtml"
  
    ViewData["Title"] = "ReceiveNoteFromPatient";
    Layout = "~/Views/Shared/Doctor_Layout/_Layout_Doctor.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 style=""color: brown"">Admin Recieve Notes From Patients</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>Patient Name</th>
            <th>Date</th>
            <th>Description</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\ReceiveNoteFromPatient.cshtml"
         foreach (var note in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\ReceiveNoteFromPatient.cshtml"
               Write(note.patient.Patient_FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\ReceiveNoteFromPatient.cshtml"
                                               Write(note.patient.Patient_LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <th>");
#nullable restore
#line 23 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\ReceiveNoteFromPatient.cshtml"
               Write(note.MessageTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>\r\n                    <textarea rows=\"5\" cols=\"50\" readonly>");
#nullable restore
#line 25 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\ReceiveNoteFromPatient.cshtml"
                                                     Write(note.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Doctor\ReceiveNoteFromPatient.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PatientNoteToDoctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
