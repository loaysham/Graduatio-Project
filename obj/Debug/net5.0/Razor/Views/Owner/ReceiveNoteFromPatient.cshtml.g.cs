#pragma checksum "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Owner\ReceiveNoteFromPatient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80e56100288b87a5b45bbd41b53ff24549bc8897"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owner_ReceiveNoteFromPatient), @"mvc.1.0.view", @"/Views/Owner/ReceiveNoteFromPatient.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e56100288b87a5b45bbd41b53ff24549bc8897", @"/Views/Owner/ReceiveNoteFromPatient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1a5b90897981b1c3a3409f62eb6ee1b871fc22b", @"/Views/_ViewImports.cshtml")]
    public class Views_Owner_ReceiveNoteFromPatient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PatientNoteToAdmin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Owner\ReceiveNoteFromPatient.cshtml"
  
    ViewData["Title"] = "ReceiveNoteFromPatient";
    Layout = "~/Views/Shared/_Layout_Owner.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 style=\"color: brown\">Admin Recieve Notes From Patients</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Patient Name</th>\r\n            <th>Date</th>\r\n            <th>Description</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Owner\ReceiveNoteFromPatient.cshtml"
         foreach (var note in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Owner\ReceiveNoteFromPatient.cshtml"
               Write(note.patient.Patient_FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Owner\ReceiveNoteFromPatient.cshtml"
                                               Write(note.patient.Patient_LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Owner\ReceiveNoteFromPatient.cshtml"
               Write(note.MessageTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <textarea rows=\"5\" cols=\"50\" readonly>");
#nullable restore
#line 23 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Owner\ReceiveNoteFromPatient.cshtml"
                                                     Write(note.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\HP\source\repos\kkaledmelhem\ClinicProject\ClinicProject\Views\Owner\ReceiveNoteFromPatient.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PatientNoteToAdmin>> Html { get; private set; }
    }
}
#pragma warning restore 1591