#pragma checksum "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33e4b7ac19fd4d4a3d82716a57fc36017b48d17f"
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
using Lost_Kids_WebApp.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e4b7ac19fd4d4a3d82716a57fc36017b48d17f", @"/Areas/User/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"348c2526a79908566767ec3c1ad68ef53c41e8c6", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Add Comment ...."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row col-12 text-justify d-none d-md-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<div class=\"WhiteBackground container\">\r\n\r\n   \r\n\r\n    <ul id=\"Post-filter\" class=\"Post-filter-list list-inline text-center\">\r\n\r\n        <li class=\"active btn btn-secondary ml-1 mr-1 \" data-filter=\".AllCategories\">Show All</li>\r\n        \r\n");
#nullable restore
#line 18 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
         foreach (var category in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"ml-1 mr-1 text-center\" data-filter=\".");
#nullable restore
#line 20 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                                       Write(category.Name.Replace(" ",string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 20 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                                                                                 Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 21 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </ul>\r\n\r\n\r\n\r\n");
#nullable restore
#line 28 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
     foreach (var category in Model.Categories)
    {

        var Post = Model.Posts.Where(m => m.Category.Name.Equals(category.Name));


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 35 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
             if (Post.Count() > 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 823, "\"", 892, 3);
            WriteAttributeValue("", 831, "col-12", 831, 6, true);
#nullable restore
#line 38 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 837, category.Name.Replace(" ",string.Empty), 838, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 878, "AllCategories", 879, 14, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                <div class=\"row\">\r\n                    <h3 class=\"text-success\">\r\n                        ");
#nullable restore
#line 42 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                   Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n\r\n\r\n");
#nullable restore
#line 47 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                 foreach (var item in Post)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""border border-dark rounded col-12"" style=""margin-top:10px;margin-bottom:10px;padding:10px;background-color:lightgray"">

                        <div class=""row"">
                            <div class=""col-md-3 col-sm-12"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 1434, "\"", 1451, 1);
#nullable restore
#line 53 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
WriteAttributeValue("", 1440, item.Image, 1440, 11, false);

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
#line 60 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
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
#line 67 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
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
#line 73 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                               Write(Html.Raw(@item.Descripition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n\r\n\r\n                                <div class=\"col-md-3 col-sm-12 offset-md-9 text-right\">\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33e4b7ac19fd4d4a3d82716a57fc36017b48d17f12979", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-list-ul\"></i> Details\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
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
            WriteLiteral("\r\n\r\n                                   \r\n                                </div>\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 92 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                     if (User.IsInRole(SD.AdminUser))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row form-row\">\r\n                            <div class=\"col-8\">\r\n\r\n");
#nullable restore
#line 97 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                 if (SignInManager.IsSignedIn(User))
                                {
                                    {
                                        ApplicationUser applicationUser = await UserManager.GetUserAsync(User);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33e4b7ac19fd4d4a3d82716a57fc36017b48d17f16515", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 102 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comments.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                                                                WriteLiteral(applicationUser.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 103 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"

                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33e4b7ac19fd4d4a3d82716a57fc36017b48d17f19229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 106 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comments.CommentDescription);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                            <div>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33e4b7ac19fd4d4a3d82716a57fc36017b48d17f20978", async() => {
                WriteLiteral("\r\n                                    Post Your Comment\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 117 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                     if (User.IsInRole(SD.EndUser))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row form-row\">\r\n                            <div class=\"col-8\">\r\n\r\n");
#nullable restore
#line 124 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                 if (SignInManager.IsSignedIn(User))
                                {
                                    {
                                        ApplicationUser applicationUser = await UserManager.GetUserAsync(User);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33e4b7ac19fd4d4a3d82716a57fc36017b48d17f23487", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 129 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comments.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                                                                                WriteLiteral(applicationUser.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 130 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"

                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33e4b7ac19fd4d4a3d82716a57fc36017b48d17f26201", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 133 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comments.CommentDescription);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                            <div>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33e4b7ac19fd4d4a3d82716a57fc36017b48d17f27950", async() => {
                WriteLiteral("\r\n                                    Post Your Comment\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 144 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n");
#nullable restore
#line 150 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
            WriteLiteral("        <div class=\"p-4\"></div>\r\n");
#nullable restore
#line 156 "C:\Users\user\source\repos\Lost Kids WebApp\Lost Kids WebApp\Areas\User\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
