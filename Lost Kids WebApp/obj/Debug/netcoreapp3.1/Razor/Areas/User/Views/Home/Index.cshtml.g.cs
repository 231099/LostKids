#pragma checksum "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7079d2a6c236520876a437bbf90b5e3b935bc53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Home_Index), @"mvc.1.0.view", @"/Areas/User/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\_ViewImports.cshtml"
using Lost_Kids_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\_ViewImports.cshtml"
using Lost_Kids_WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\_ViewImports.cshtml"
using Lost_Kids_WebApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\_ViewImports.cshtml"
using Lost_Kids_WebApp.Models.Comments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\_ViewImports.cshtml"
using Lost_Kids_WebApp.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7079d2a6c236520876a437bbf90b5e3b935bc53", @"/Areas/User/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"393932f897ed0bbc42951c25da167109cdff52a7", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-info active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50%; margin-left: 25%; margin-right: 25%;resize:;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Lost_Kids_WebApp.TagHelpers.PageLinkTagHelper __Lost_Kids_WebApp_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<div class=\"WhiteBackground container\">\r\n\r\n\r\n\r\n    <ul id=\"Post-filter\" class=\"Post-filter-list list-inline text-center\">\r\n\r\n        <li class=\"active btn btn-secondary ml-1 mr-1 \" data-filter=\".AllCategories\">Show All</li>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
         foreach (var category in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"ml-1 mr-1 text-center\" data-filter=\".");
#nullable restore
#line 22 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                                       Write(category.Name.Replace(" ",string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 22 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                                                                                 Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 23 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </ul>\r\n\r\n\r\n\r\n");
#nullable restore
#line 30 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
     foreach (var category in Model.Categories)
    {

        var Post = Model.Posts.Where(m => m.Category.Name.Equals(category.Name));


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 37 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
             if (Post.Count() > 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 820, "\"", 889, 3);
            WriteAttributeValue("", 828, "col-12", 828, 6, true);
#nullable restore
#line 40 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 834, category.Name.Replace(" ",string.Empty), 835, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 875, "AllCategories", 876, 14, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <div class=\"row\">\r\n                        <h3 class=\"text-success\">\r\n                            ");
#nullable restore
#line 44 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                       Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h3>\r\n                    </div>\r\n\r\n\r\n");
#nullable restore
#line 49 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                     foreach (var item in Post)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""border border-dark rounded col-12"" style=""margin-top:10px;margin-bottom:10px;padding:10px;background-color:lightgray"">

                            <div class=""row"">
                                <div class=""col-md-3 col-sm-12"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 1475, "\"", 1492, 1);
#nullable restore
#line 55 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
WriteAttributeValue("", 1481, item.Image, 1481, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""250"" style=""border-radius:5px;border:1px solid #bbb9b9"" />
                                </div>

                                <div class=""col-md-9 col-sm-12"">
                                    <div class=""row pr-3"">
                                        <div class=""col-8"">
                                            <label class=""text-primary"" style=""font-size:21px;"">
                                                ");
#nullable restore
#line 62 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </label>
                                        </div>


                                        <div class=""col-4 text-right"" style=""color:maroon"">
                                            <h6>
                                                ");
#nullable restore
#line 69 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                           Write(item.SubCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </h6>
                                        </div>
                                    </div>

                                    <div class=""row col-12 text-justify d-none d-md-block"">
                                        ");
#nullable restore
#line 75 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                   Write(Html.Raw(@item.Descripition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <hr />\r\n                                    <h5 class=\"text-primary\">Comments</h5>\r\n\r\n");
#nullable restore
#line 80 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                     foreach (var comment in Model.MainComments)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                         if (comment.Postid == item.PostId)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"input-group row col-12 text-justify d-none d-md-block\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7079d2a6c236520876a437bbf90b5e3b935bc5314586", async() => {
#nullable restore
#line 85 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                                                                                     Write(comment.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 85 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => comment.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                                ");
#nullable restore
#line 87 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                           Write(Html.Raw(comment.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                <p class=\"text-success\">(");
#nullable restore
#line 89 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                                                    Write(comment.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n                                            </div>\r\n");
#nullable restore
#line 91 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"

                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                         


                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-md-3 col-sm-12 offset-md-9 text-right\">\r\n\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7079d2a6c236520876a437bbf90b5e3b935bc5317906", async() => {
                WriteLiteral("\r\n                                            <i class=\"fas fa-list-ul\"></i> Details\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                                                                                       WriteLiteral(item.PostId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n                                    </div>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 112 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                         if (User.IsInRole(SD.AdminUser))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n");
#nullable restore
#line 116 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                  
                                    await Html.RenderPartialAsync("MainComment", new CommentViewModel { PostId = item.PostId, MainCommentId = 0 });
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n");
#nullable restore
#line 120 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"




                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                         if (User.IsInRole(SD.EndUser))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n");
#nullable restore
#line 130 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                  
                                    await Html.RenderPartialAsync("MainComment", new CommentViewModel { PostId = item.PostId, MainCommentId = 0 });
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n");
#nullable restore
#line 153 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                   

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                         


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n");
#nullable restore
#line 162 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
            WriteLiteral("        <div class=\"p-4\"></div>\r\n");
#nullable restore
#line 168 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7079d2a6c236520876a437bbf90b5e3b935bc5323421", async() => {
            }
            );
            __Lost_Kids_WebApp_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::Lost_Kids_WebApp.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__Lost_Kids_WebApp_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 170 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
__Lost_Kids_WebApp_TagHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Lost_Kids_WebApp_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 170 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
__Lost_Kids_WebApp_TagHelpers_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __Lost_Kids_WebApp_TagHelpers_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Lost_Kids_WebApp_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Lost_Kids_WebApp_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Lost_Kids_WebApp_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <br />\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(
            function ($) {
                $(""#Post-filter li"").click(
                    function () {
                        $(""#Post-filter li"").removeClass(""active btn btn-secondary"");
                        $(this).addClass(""active btn btn-secondary"");
                        var selectedfilter = $(this).data(""filter"");
                        $("".AllCategories"").fadeOut();
                        setTimeout(function () {
                            $(selectedfilter).slideDown();

                        }, 300);
                    }
                )
            }
        );
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
