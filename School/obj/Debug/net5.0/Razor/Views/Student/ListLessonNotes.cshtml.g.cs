#pragma checksum "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Student\ListLessonNotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61ba40e21de486e8d544bb502354e725dac913fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ListLessonNotes), @"mvc.1.0.view", @"/Views/Student/ListLessonNotes.cshtml")]
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
#line 1 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\_ViewImports.cshtml"
using School;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\_ViewImports.cshtml"
using School.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Student\ListLessonNotes.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61ba40e21de486e8d544bb502354e725dac913fa", @"/Views/Student/ListLessonNotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_ListLessonNotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LessonStudent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Student\ListLessonNotes.cshtml"
  
    ViewData["Title"] = "ListLessonNotes";
    Layout = "~/Views/Shared/_StudentLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>List  Lesson Notes</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Lesson ID</th>\r\n        <th>Lesson Name</th>\r\n        <th>Exam 1</th>\r\n        <th>Exam 2</th>\r\n        <th>Result</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Student\ListLessonNotes.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <th>");
#nullable restore
#line 23 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Student\ListLessonNotes.cshtml"
   Write(item.LessonID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <td>");
#nullable restore
#line 24 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Student\ListLessonNotes.cshtml"
   Write(item.Lesson.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Student\ListLessonNotes.cshtml"
   Write(item.Exam1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Student\ListLessonNotes.cshtml"
   Write(item.Exam2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Student\ListLessonNotes.cshtml"
   Write(item.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 29 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Student\ListLessonNotes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LessonStudent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
