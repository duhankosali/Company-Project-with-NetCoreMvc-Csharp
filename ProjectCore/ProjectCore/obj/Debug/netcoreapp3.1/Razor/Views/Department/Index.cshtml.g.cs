#pragma checksum "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "206532bed5ec72c0aa287bda5aa85a6650d570c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
#line 1 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\Index.cshtml"
using ProjectCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"206532bed5ec72c0aa287bda5aa85a6650d570c1", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98a3973da45496466a4ed5bb498f29b8a1f80c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Department Table</h2>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Department</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n        <th>Details</th>\r\n    </tr>\r\n\r\n\r\n");
#nullable restore
#line 21 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\Index.cshtml"
   Write(x.DepartmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\Index.cshtml"
   Write(x.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td> <a");
            BeginWriteAttribute("href", " href=\"", 483, "\"", 534, 2);
            WriteAttributeValue("", 490, "/department/DeleteDepartment/", 490, 29, true);
#nullable restore
#line 26 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\Index.cshtml"
WriteAttributeValue("", 519, x.DepartmentId, 519, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a> </td>\r\n    <td> <a");
            BeginWriteAttribute("href", " href=\"", 588, "\"", 637, 2);
            WriteAttributeValue("", 595, "/department/ShowDepartment/", 595, 27, true);
#nullable restore
#line 27 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\Index.cshtml"
WriteAttributeValue("", 622, x.DepartmentId, 622, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a> </td>\r\n    <td> <a");
            BeginWriteAttribute("href", " href=\"", 692, "\"", 744, 2);
            WriteAttributeValue("", 699, "/department/DepartmentDetails/", 699, 30, true);
#nullable restore
#line 28 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\Index.cshtml"
WriteAttributeValue("", 729, x.DepartmentId, 729, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Details</a> </td>\r\n</tr>\r\n");
#nullable restore
#line 30 "C:\Users\duhan\source\repos\ProjectCore\ProjectCore\Views\Department\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/Department/NewDepartment\" class=\"btn btn-primary\">New Department</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
