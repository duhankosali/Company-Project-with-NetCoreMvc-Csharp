#pragma checksum "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\DepartmentDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d21c242e6bc3b9d6accf9a278295095f93d7277"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_DepartmentDetails), @"mvc.1.0.view", @"/Views/Department/DepartmentDetails.cshtml")]
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
#line 1 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\_ViewImports.cshtml"
using ProjectCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\DepartmentDetails.cshtml"
using ProjectCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d21c242e6bc3b9d6accf9a278295095f93d7277", @"/Views/Department/DepartmentDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98a3973da45496466a4ed5bb498f29b8a1f80c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_DepartmentDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\DepartmentDetails.cshtml"
  
    ViewData["Title"] = "DepartmentDetails";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 10 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\DepartmentDetails.cshtml"
Write(ViewBag.depName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Departmanı</h2>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Name</th>\r\n        <th>City</th>\r\n        <th>Department</th>\r\n        \r\n    </tr>\r\n\r\n\r\n");
#nullable restore
#line 22 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\DepartmentDetails.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\DepartmentDetails.cshtml"
           Write(x.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\DepartmentDetails.cshtml"
           Write(x.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\DepartmentDetails.cshtml"
           Write(x.EmployeeCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            \r\n\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\DepartmentDetails.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
