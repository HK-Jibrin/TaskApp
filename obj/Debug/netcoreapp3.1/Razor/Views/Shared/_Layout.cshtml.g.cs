#pragma checksum "C:\Users\JIBRIN KASIM\source\repos\TaskApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32cd1dcb32f113ee898423637c83cf0ce7baee32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\JIBRIN KASIM\source\repos\TaskApp\Views\_ViewImports.cshtml"
using TaskApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JIBRIN KASIM\source\repos\TaskApp\Views\_ViewImports.cshtml"
using TaskApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32cd1dcb32f113ee898423637c83cf0ce7baee32", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd26c5584385b36dc74878134b74cbaf12d9483e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "notification", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "taskrecommendation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "taskView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cd1dcb32f113ee898423637c83cf0ce7baee326105", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <!-- HTML5 Shim and Respond.js IE9 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
      <script src=""https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js""></script>
      <![endif]-->
    <!-- Meta -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""description"" content=""Gradient Able Bootstrap admin template made using Bootstrap 4. The starter version of Gradient Able is completely free for personal project."" />
    <meta name=""keywords"" content=""free dashboard template, free admin, free bootstrap template, bootstrap admin template, admin theme, admin dashboard, dashboard template, adm");
                WriteLiteral(@"in template, responsive"" />
    <meta name=""author"" content=""codedthemes"">
    <!-- Favicon icon -->
    <link rel=""icon"" href=""../../assets/images/favicon.ico"" type=""image/x-icon"">
    <!-- Google font-->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:400,600"" rel=""stylesheet"">
    <!-- Required Fremwork -->
    <link rel=""stylesheet"" type=""text/css"" href=""../../assets/css/bootstrap/css/bootstrap.min.css"">
    <!-- themify-icons line icon -->
    <link rel=""stylesheet"" type=""text/css"" href=""../../assets/icon/themify-icons/themify-icons.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""../../assets/icon/font-awesome/css/font-awesome.min.css"">
    <!-- ico font -->
    <link rel=""stylesheet"" type=""text/css"" href=""../../assets/icon/icofont/css/icofont.css"">
    <!-- Style.css -->

    <link rel=""stylesheet"" type=""text/css"" href=""../../assets/css/style.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""../../assets/css/jquery.mCustomScrollbar.css"">
    <title>");
#nullable restore
#line 34 "C:\Users\JIBRIN KASIM\source\repos\TaskApp\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cd1dcb32f113ee898423637c83cf0ce7baee329457", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"            <!-- Pre-loader start -->
            <div class=""theme-loader"">
                <div class=""loader-track"">
                    <div class=""loader-bar""></div>
                </div>
            </div>
            <!-- Pre-loader end -->
            <div id=""pcoded"" class=""pcoded"">
                <div class=""pcoded-overlay-box""></div>
                <div class=""pcoded-container navbar-wrapper"">

                    <nav class=""navbar header-navbar pcoded-header"">
                        <div class=""navbar-wrapper"">
                            <div class=""navbar-logo"">
                                <a class=""mobile-menu"" id=""mobile-collapse"" href=""#!"">
                                    <i class=""ti-menu""></i>
                                </a>
                                <div class=""mobile-search"">
                                    <div class=""header-search"">
                                        <div class=""main-search morphsearch-search"">
                       ");
                WriteLiteral(@"                     <div class=""input-group"">
                                                <span class=""input-group-addon search-close""><i class=""ti-close""></i></span>
                                                <input type=""text"" class=""form-control"" placeholder=""Enter Keyword"">
                                                <span class=""input-group-addon search-btn""><i class=""ti-search""></i></span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <a href=""index.html"">
                                    <img class=""img-fluid"" src=""../../assets/images/logo.png"" alt=""Theme-Logo"" />
                                </a>
                                <a class=""mobile-options"">
                                    <i class=""ti-more""></i>
                                </a>
                            </div>

                  ");
                WriteLiteral(@"          <div class=""navbar-container container-fluid"">
                                <ul class=""nav-left"">
                                    <li>
                                        <div class=""sidebar_toggle""><a href=""javascript:void(0)""><i class=""ti-menu""></i></a></div>
                                    </li>
                                    <li class=""header-search"">
                                        <div class=""main-search morphsearch-search"">
                                            <div class=""input-group"">
                                                <span class=""input-group-addon search-close""><i class=""ti-close""></i></span>
                                                <input type=""text"" class=""form-control"">
                                                <span class=""input-group-addon search-btn""><i class=""ti-search""></i></span>
                                            </div>
                                        </div>
                                ");
                WriteLiteral(@"    </li>
                                    <li>
                                        <a href=""#!"" onclick=""javascript:toggleFullScreen()"">
                                            <i class=""ti-fullscreen""></i>
                                        </a>
                                    </li>
                                </ul>
                                <ul class=""nav-right"">
                                    <li class=""header-notification"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cd1dcb32f113ee898423637c83cf0ce7baee3213548", async() => {
                    WriteLiteral("\r\n                                            <i class=\"ti-bell\"></i>\r\n                                            <span class=\"badge bg-c-pink\"></span>\r\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </li>

                                    <li class=""user-profile header-notification"">
                                        <a href=""#!"">
                                            <img src=""../../assets/images/avatar-4.jpg"" class=""img-radius"" alt=""User-Profile-Image"">
                                            <span>John Doe</span>
                                            <i class=""ti-angle-down""></i>
                                        </a>
                                        <ul class=""show-notification profile-notification"">
");
                WriteLiteral(@"                                            <li>
                                                <a href=""auth-normal-sign-in.html"">
                                                    <i class=""ti-layout-sidebar-left""></i> Logout
                                                </a>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </nav>
                    <div class=""pcoded-main-container"">
                        <div class=""pcoded-wrapper"">
                            <nav class=""pcoded-navbar"">
                                <div class=""sidebar_toggle""><a href=""#""><i class=""icon-close icons""></i></a></div>
                                <div class=""pcoded-inner-navbar main-menu"">

                                    <div class=""pcoded-navigatio-lavel"" data-i18n=""nav.category.n");
                WriteLiteral("avigation\">Layout</div>\r\n                                    <ul class=\"pcoded-item pcoded-left-item\">\r\n                                        <li class=\"active\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cd1dcb32f113ee898423637c83cf0ce7baee3217127", async() => {
                    WriteLiteral(@"
                                                <span class=""pcoded-micon""><i class=""ti-home""></i><b>D</b></span>
                                                <span class=""pcoded-mtext"" data-i18n=""nav.dash.main"">Dashboard</span>
                                                <span class=""pcoded-mcaret""></span>
                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </li>
                                        <li class=""pcoded-hasmenu"">
                                            <a href=""javascript:void(0)"">
                                                <span class=""pcoded-micon""><i class=""ti-layout-grid2-alt""></i></span>
                                                <span class=""pcoded-mtext"" data-i18n=""nav.basic-components.main"">Admin</span>
                                                <span class=""pcoded-mcaret""></span>
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cd1dcb32f113ee898423637c83cf0ce7baee3219300", async() => {
                    WriteLiteral("\r\n                                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                <ul class=\"pcoded-submenu\">\r\n                                                    <li class=\" \">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cd1dcb32f113ee898423637c83cf0ce7baee3220775", async() => {
                    WriteLiteral(@"
                                                            <span class=""pcoded-micon""><i class=""ti-angle-right""></i></span>
                                                            <span class=""pcoded-mtext"" data-i18n=""nav.basic-components.alert"">Add New Staff</span>
                                                            <span class=""pcoded-mcaret""></span>
                                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </li>\r\n                                                    <li class=\" \">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cd1dcb32f113ee898423637c83cf0ce7baee3222832", async() => {
                    WriteLiteral(@"
                                                            <span class=""pcoded-micon""><i class=""ti-angle-right""></i></span>
                                                            <span class=""pcoded-mtext"" data-i18n=""nav.basic-components.breadcrumbs"">View</span>
                                                            <span class=""pcoded-mcaret""></span>
                                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </li>\r\n                                                    <li class=\" \">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cd1dcb32f113ee898423637c83cf0ce7baee3224886", async() => {
                    WriteLiteral(@"
                                                            <span class=""pcoded-micon""><i class=""ti-angle-right""></i></span>
                                                            <span class=""pcoded-mtext"" data-i18n=""nav.basic-components.alert"">Assign Task</span>
                                                            <span class=""pcoded-mcaret""></span>
                                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </li>\r\n                                                    <li class=\" \">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cd1dcb32f113ee898423637c83cf0ce7baee3226941", async() => {
                    WriteLiteral(@"
                                                            <span class=""pcoded-micon""><i class=""ti-angle-right""></i></span>
                                                            <span class=""pcoded-mtext"" data-i18n=""nav.basic-components.breadcrumbs"">View Task</span>
                                                            <span class=""pcoded-mcaret""></span>
                                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </li>\r\n");
                WriteLiteral(@"
                                                </ul>
                                        </li>
                                    </ul>
                                    <ul class=""pcoded-item pcoded-left-item"">
                                        <li>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cd1dcb32f113ee898423637c83cf0ce7baee3229226", async() => {
                    WriteLiteral(@"
                                                <span class=""pcoded-micon""><i class=""ti-layers""></i><b>FC</b></span>
                                                <span class=""pcoded-mtext"" data-i18n=""nav.form-components.main"">Task Submision</span>
                                                <span class=""pcoded-mcaret""></span>
                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </li>\r\n");
                WriteLiteral("\r\n                                    </ul>\r\n\r\n                                    <div class=\"pcoded-navigatio-lavel\" data-i18n=\"nav.category.forms\"></div>\r\n                                    <ul class=\"pcoded-item pcoded-left-item\">\r\n");
                WriteLiteral("                                        <li class=\"pcoded-hasmenu\">\r\n");
                WriteLiteral("                                            <ul class=\"pcoded-submenu\">\r\n");
                WriteLiteral(@"                                            </ul>
                                        </li>

                                    </ul>

                                    <div class=""pcoded-navigatio-lavel"" data-i18n=""nav.category.other"">Other</div>
");
                WriteLiteral(@"                                </div>
                            </nav>
                            <div class=""pcoded-content"">
                                <div class=""pcoded-inner-content"">
                                    <div class=""main-body"">
                                        <div class=""page-wrapper"">

                                            ");
#nullable restore
#line 354 "C:\Users\JIBRIN KASIM\source\repos\TaskApp\Views\Shared\_Layout.cshtml"
                                       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div>
");
                WriteLiteral(@"                </div>

                <script type=""text/javascript"" src=""../../assets/js/jquery/jquery.min.js""></script>
                <script type=""text/javascript"" src=""../../assets/js/jquery-ui/jquery-ui.min.js""></script>
                <script type=""text/javascript"" src=""../../assets/js/popper.js/popper.min.js""></script>
                <script type=""text/javascript"" src=""../../assets/js/bootstrap/js/bootstrap.min.js""></script>
                <!-- jquery slimscroll js -->
                <script type=""text/javascript"" src=""../../assets/js/jquery-slimscroll/jquery.slimscroll.js""></script>
                <!-- modernizr js -->
                <script type=""text/javascript"" src=""../../assets/js/modernizr/modernizr.js""></script>
                <!-- am chart -->
                <script src=""../../assets/pages/widget/amchart/amcharts.min.js""></script>
                <script src=""../../assets/pages/widget/amchart/serial.min.js""></script>
                <!-- Chart js -->
                <s");
                WriteLiteral(@"cript type=""text/javascript"" src=""../../assets/js/chart.js/Chart.js""></script>
                <!-- Todo js -->
                <script type=""text/javascript "" src=""../../assets/pages/todo/todo.js ""></script>
                <!-- Custom js -->
                <script type=""text/javascript"" src=""../../assets/pages/dashboard/custom-dashboard.min.js""></script>
                <script type=""text/javascript"" src=""../../assets/js/script.js""></script>
                <script type=""text/javascript "" src=""../../assets/js/SmoothScroll.js""></script>
                <script src=""../../assets/js/pcoded.min.js""></script>
                <script src=""../../assets/js/vartical-demo.js""></script>
                <script src=""../../assets/js/jquery.mCustomScrollbar.concat.min.js""></script>
");
#nullable restore
#line 391 "C:\Users\JIBRIN KASIM\source\repos\TaskApp\Views\Shared\_Layout.cshtml"
                 if (IsSectionDefined("Scripts"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 393 "C:\Users\JIBRIN KASIM\source\repos\TaskApp\Views\Shared\_Layout.cshtml"
               Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
#nullable restore
#line 393 "C:\Users\JIBRIN KASIM\source\repos\TaskApp\Views\Shared\_Layout.cshtml"
                                                              ;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n");
                WriteLiteral("        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
