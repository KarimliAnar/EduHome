#pragma checksum "C:\Users\Admin\source\repos\EduHomeProject\EduHomeProject\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cadaa5c3f6f322bf7674e7c8811a2934349955f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\EduHomeProject\EduHomeProject\Views\_ViewImports.cshtml"
using EduHomeProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\EduHomeProject\EduHomeProject\Views\_ViewImports.cshtml"
using EduHomeProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\EduHomeProject\EduHomeProject\Views\_ViewImports.cshtml"
using EduHomeProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cadaa5c3f6f322bf7674e7c8811a2934349955f", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32582e616ddfbe24fc16d97d1b456087d4d715cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FooterVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("eduhome"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer class=""footer-area"">
    <div class=""main-footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4 col-sm-6 col-xs-12"">
                    <div class=""single-widget pr-60"">
                        <div class=""footer-logo pb-25"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cadaa5c3f6f322bf7674e7c8811a2934349955f4831", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9cadaa5c3f6f322bf7674e7c8811a2934349955f5047", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 395, "~/img/logo/", 395, 11, true);
#nullable restore
#line 9 "C:\Users\Admin\source\repos\EduHomeProject\EduHomeProject\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 406, Model.Bio.FooterLogo, 406, 21, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"footer-social\">\r\n                            <ul>\r\n");
#nullable restore
#line 13 "C:\Users\Admin\source\repos\EduHomeProject\EduHomeProject\Views\Shared\Components\Footer\Default.cshtml"
                                 foreach (SocialMedia social in Model.SocialMedias) 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a  target=\"_blank\"");
            BeginWriteAttribute("href", "href=\"", 748, "\"", 766, 1);
#nullable restore
#line 15 "C:\Users\Admin\source\repos\EduHomeProject\EduHomeProject\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 754, social.Link, 754, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 770, "\"", 800, 3);
            WriteAttributeValue("", 778, "zmdi", 778, 4, true);
            WriteAttributeValue(" ", 782, "zmdi-", 783, 6, true);
#nullable restore
#line 15 "C:\Users\Admin\source\repos\EduHomeProject\EduHomeProject\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 788, social.Icon, 788, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n");
#nullable restore
#line 16 "C:\Users\Admin\source\repos\EduHomeProject\EduHomeProject\Views\Shared\Components\Footer\Default.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3 col-sm-6 col-xs-12"">
                    <div class=""single-widget"">
                        <h3>information</h3>
                        <ul>
                            <li><a href=""#"">addmission</a></li>
                            <li><a href=""#"">Academic Calender</a></li>
                            <li><a href=""event.html"">Event List</a></li>
                            <li><a href=""#"">Hostel &amp; Dinning</a></li>
                            <li><a href=""#"">TimeTable</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-2 col-sm-6 col-xs-12"">
                    <div class=""single-widget"">
                        <h3>useful links</h3>
                        <ul>
                            <li><a href=""course.html"">our courses</a>");
            WriteLiteral(@"</li>
                            <li><a href=""about.html"">about us</a></li>
                            <li><a href=""teacher.html"">teachers &amp; faculty</a></li>
                            <li><a href=""#"">teams &amp; conditions</a></li>
                            <li><a href=""event.html"">our events</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-3 col-sm-6 col-xs-12"">
                    <div class=""single-widget"">
                        <h3>get in touch</h3>
                        <p>Your address goes here, Street<br>City, Roadno 785 New York</p>
                        <p>+880  548  986  898  87<br>+880  659  785  658  98</p>
                        <p>info@eduhome.com<br>www.eduhome.com</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""footer-bottom text-center"">
        <div class=""container"">
            <div class=""row"">
                ");
            WriteLiteral("<div class=\"col-xs-12\">\r\n                    <p>Copyright © <a href=\"#\" target=\"_blank\">HasTech</a> 2017. All Right Reserved By Hastech.</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FooterVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
