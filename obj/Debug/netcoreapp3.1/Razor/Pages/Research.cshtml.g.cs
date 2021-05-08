#pragma checksum "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80575829641d22bb5fed5fa4ad78992043b421d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NET_RazorPages.Pages.Pages_Research), @"mvc.1.0.razor-page", @"/Pages/Research.cshtml")]
namespace NET_RazorPages.Pages
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
#line 1 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\_ViewImports.cshtml"
using NET_RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80575829641d22bb5fed5fa4ad78992043b421d8", @"/Pages/Research.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3335d27e5b04d2aa4b59297689165bc28b4a742e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Research : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
  
    ViewData["Title"] = "Research overview";
    int Id = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>There are ");
#nullable restore
#line 9 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
        Write(Model.ResearchList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Papers in this list</p>\r\n\r\n");
#nullable restore
#line 11 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
 if (Model.IsLoading)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <div class=\"spinner-border text-center\" role=\"status\">\r\n        <span class=\"sr-only\">Loading...</span>\r\n    </div>\r\n    <p><a class=\"btn btn-danger\" href=\"Research?loading=false\">Stop loading</a></p>\r\n</div>\r\n");
#nullable restore
#line 20 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
}
else { 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table id=""myTable"" class=""table table-striped"" >
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Title</th>
            <th scope=""col"">Author</th>
            <th scope=""col"">Url</th>
            <th scope=""col"">Pages</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
         foreach (var r in Model.ResearchList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 36 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
                           Write(Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 37 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
               Write(r.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
               Write(r.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1024, "\"", 1037, 1);
#nullable restore
#line 39 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
WriteAttributeValue("", 1031, r.Url, 1031, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
                                Write(r.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td>");
#nullable restore
#line 40 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
               Write(r.Pages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"

            Id++;

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<nav aria-label=""Page navigation example"">
    <ul class=""pagination"">
        <li class=""page-item""><a class=""page-link"" href=""#"">Previous</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
    </ul>
</nav>
");
#nullable restore
#line 57 "D:\Coding\BachelorproefProjecten\NET_RazorPages\Pages\Research.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NET_RazorPages.Pages.Research> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NET_RazorPages.Pages.Research> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NET_RazorPages.Pages.Research>)PageContext?.ViewData;
        public NET_RazorPages.Pages.Research Model => ViewData.Model;
    }
}
#pragma warning restore 1591
