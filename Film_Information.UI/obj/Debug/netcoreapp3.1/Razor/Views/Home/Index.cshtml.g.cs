#pragma checksum "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cd871e702e13e39e0cde5ec3a5016b38ac9e68c"
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
#line 2 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\_ViewImports.cshtml"
using Film_Information.Dto.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\_ViewImports.cshtml"
using Film_Information.Dto.Dtos.FilmDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\_ViewImports.cshtml"
using Film_Information.Dto.Dtos.AppUserDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cd871e702e13e39e0cde5ec3a5016b38ac9e68c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad329ce7e3b5e0f3129fec8f45ea04185c0e2bf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    string s = (string)ViewBag.s;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"container\">\r\n        <div class=\"content-grids\">\r\n            <div class=\"col-md-8 content-main\">\r\n                <div class=\"content-grid\">\r\n\r\n                    <div class=\"search\">\r\n");
#nullable restore
#line 15 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                         using (Html.BeginForm("Index", "Home", FormMethod.Get))
                        {

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                       Write(Html.TextBox("s"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"submit\">Ara</button>\r\n");
#nullable restore
#line 20 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 23 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                     if (!string.IsNullOrWhiteSpace(s))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>");
#nullable restore
#line 25 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                        Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral(" için arama yaptınız");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cd871e702e13e39e0cde5ec3a5016b38ac9e68c5891", async() => {
                WriteLiteral("Filtreyi Kaldır");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 26 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 29 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                     foreach (var item in Model.Films)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"content-grid-info\">\r\n\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1047, "\"", 1071, 2);
            WriteAttributeValue("", 1053, "/image/", 1053, 7, true);
#nullable restore
#line 33 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1060, item.Image, 1060, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"h-100\" />\r\n                            <div class=\"post-info\">\r\n                                <h4><a href=\"single.html\">");
#nullable restore
#line 35 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                                                     Write(item.FilmName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>  July 30, 2014 / 27 Comments</h4>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                                 if (item.FilmDescription.Length > 100)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>\r\n                                        ");
#nullable restore
#line 40 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                                    Write(item.FilmDescription.Substring(0,100)+"...");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n");
#nullable restore
#line 42 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                                }

                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 46 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                                  Write(item.FilmDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 47 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 48 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                           Write(Html.ActionLink("Film Detayları", "FilmDetails", "Home", new { id = item.ID }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 49 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                           Write(Html.ActionLink("Filme Yorum Yap", "CommentsAdd", "Comments", new {id=item.ID }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 53 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4 content-right\">\r\n                <div class=\"recent\">\r\n                    <h3>EN SON EKLENEN FİLMLER</h3>\r\n                    <ul>\r\n\r\n");
#nullable restore
#line 70 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                         foreach (var item in Model.LastFilms)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2497, "\"", 2530, 2);
            WriteAttributeValue("", 2504, "/Home/FilmDetails/", 2504, 18, true);
#nullable restore
#line 72 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2522, item.ID, 2522, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 72 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                                                                Write(item.FilmName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 73 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
                <div class=""comments"">
                    <h3>RECENT COMMENTS</h3>
                    <ul>
                        <li><a href=""#"">Amada Doe </a> on <a href=""#"">Hello World!</a></li>
                        <li><a href=""#"">Peter Doe </a> on <a href=""#""> Photography</a></li>
                        <li><a href=""#"">Steve Roberts  </a> on <a href=""#"">HTML5/CSS3</a></li>
                    </ul>
                </div>
                <div class=""clearfix""></div>
                <div class=""categories"">
                    <h3>CATEGORIES</h3>
                    <ul>
");
#nullable restore
#line 88 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                         foreach (var item in Model.Categories)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3363, "\"", 3397, 2);
            WriteAttributeValue("", 3370, "/Home/CategoryFilm/", 3370, 19, true);
#nullable restore
#line 91 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 3389, item.ID, 3389, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                                                                 Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 91 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"
                                                                                     Write(Model.FilmCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></li>\r\n");
#nullable restore
#line 92 "C:\Users\ysnbj\Desktop\Film_Information\Film_Information.UI\Views\Home\Index.cshtml"


                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n                <div class=\"clearfix\"></div>\r\n            </div>\r\n            <div class=\"clearfix\"></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
