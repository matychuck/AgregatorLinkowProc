#pragma checksum "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9ca4d50b1329808fc5e09f51047c558b89f4551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_CreatePost), @"mvc.1.0.view", @"/Views/Post/CreatePost.cshtml")]
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
#line 1 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\_ViewImports.cshtml"
using AgregatorLinkowProc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\_ViewImports.cshtml"
using AgregatorLinkowProc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9ca4d50b1329808fc5e09f51047c558b89f4551", @"/Views/Post/CreatePost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e80bfeb581b7e6290cc629d9cffb6341ed03cffb", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_CreatePost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AgregatorLinkowProc.ViewModels.CreatePostVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""slidedown_head"">
    Create post
    <i class=""fa fa-bars"" aria-hidden=""true"" style=""float:right; padding-top:4px""></i>
</div>
    <div class=""slidedown_body"" style=""display:none"">
        <div class=""row form-space"">
            <div class=""offset-lg-2 col-lg-8 offset-lg-2"">
                ");
#nullable restore
#line 13 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
           Write(Html.EditorFor(model => model.post.Title, new { htmlAttributes = new { @class = "form-control", placeholder = "Title" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            ");
#nullable restore
#line 15 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
       Write(Html.ValidationMessageFor(model => model.post.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row form-space\">\r\n            <div class=\"offset-lg-2 col-lg-8 offset-lg-2\">\r\n                ");
#nullable restore
#line 19 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
           Write(Html.EditorFor(model => model.post.Link, new { htmlAttributes = new { @class = "form-control", placeholder = "Link" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            ");
#nullable restore
#line 21 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
       Write(Html.ValidationMessageFor(model => model.post.Link, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row form-space\">\r\n            <div class=\"offset-lg-2 col-lg-8 offset-lg-2\">\r\n                <input type=\"submit\" class=\"btn btn-primary float-right\" value=\"Add\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
 if (Model.posts != null)
{
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
         foreach (var item in Model.posts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"post-main offset-lg-2 col-lg-8 offset-lg-2\">\r\n                    <div class=\"post-main-title\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1586, "\"", 1611, 2);
            WriteAttributeValue("", 1593, "https://", 1593, 8, true);
#nullable restore
#line 37 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
WriteAttributeValue("", 1601, item.Link, 1601, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 37 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                    </div>\r\n                    <div class=\"post-link\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1731, "\"", 1756, 2);
            WriteAttributeValue("", 1738, "https://", 1738, 8, true);
#nullable restore
#line 40 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
WriteAttributeValue("", 1746, item.Link, 1746, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">(");
#nullable restore
#line 40 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
                                                 Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</a>
                    </div>
                    <hr />
                    <div class=""post-main-footer col-lg-12 ."">
                        <div class=""row"">
                            <div class=""col-lg-9 form-inline"">
                                <button type=""button"" class=""btn likeBtn"" disabled=""disabled"">
                                    <span style=""color: darkgray;""><i class=""fa fa-heart""></i></span>
                                </button>
            
                                <label>");
#nullable restore
#line 50 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
                                  Write(item.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n                            <div class=\"col-lg-3\" style=\"margin-top:3px;\">\r\n                                ");
#nullable restore
#line 53 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
                           Write(item.Date.ToString("MM/dd/yyyy H:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n            \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 60 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row pages\">\r\n        <div class=\"offset-lg-2 col-lg-8 offset-lg-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
       Write(Html.PagedListPager((IPagedList)Model.posts, page => Url.Action("CreatePost", new { page = page }),
                new X.PagedList.Mvc.Core.Common.PagedListRenderOptions
                {
                    ContainerDivClasses = new[] { "navigation" },
                    LiElementClasses = new[] { "page-item" },
                    PageClasses = new[] { "page-link" },
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 72 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\user\source\repos\AgregatorLinkowProc\AgregatorLinkowProc\AgregatorLinkowProc\Views\Post\CreatePost.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $('.slidedown_head').click(function () {
            $(this).next('.slidedown_body').slideToggle();
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgregatorLinkowProc.ViewModels.CreatePostVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
