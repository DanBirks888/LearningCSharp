#pragma checksum "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6e8ec66e3254ffa9c4ed7aae8b4dc11cca130f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TechStack_POCODataReturn), @"mvc.1.0.view", @"/Views/TechStack/POCODataReturn.cshtml")]
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
#line 1 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\_ViewImports.cshtml"
using LearningCSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\_ViewImports.cshtml"
using LearningCSharp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6e8ec66e3254ffa9c4ed7aae8b4dc11cca130f5", @"/Views/TechStack/POCODataReturn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325f52889291cc4769739c65f19ace87d9c5921b", @"/Views/_ViewImports.cshtml")]
    public class Views_TechStack_POCODataReturn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LearningCSharp.Models.TechStack>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml"
  
    ViewData["Title"] = "POCODataReturn";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Returning Data</h1>
<div class=""card text-center"">
    <div class=""card-body"">
        <h4 class=""card-title"">Using Auto-Generate Options and Functionality:</h4>
        <ul class=""list-group"">
            <li class=""list-group-item list-group-item-primary"">When generating a View, it is important to select the Razer View Option</li>
            <li class=""list-group-item list-group-item-secondary"">Razer View Provides options for What Class the data will be Instantiated from</li>
            <li class=""list-group-item list-group-item-success"">For Websites such as this it is important to select the layout.cshtml, to keep page consistency</li>
            <li class=""list-group-item list-group-item-danger"">Once generated, the content can be wrapped like it is on this page, and edited using Bootstrap classes!</li>
        </ul>
        <h4 class=""card-header"">Returning Data from Poco (Hardcoded):</h4>
        <table class=""table table-dark; py-xl-5"">
            <thead>
     ");
            WriteLiteral("           <tr class=\"bg-dark\" style=\"color:ghostwhite\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 23 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml"
                   Write(Html.DisplayNameFor(model => model.UsedBefore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml"
                   Write(Html.DisplayNameFor(model => model.Proficiency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:right\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml"
                   Write(Html.DisplayNameFor(model => model.FavAtrribute));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td style=\"text-align:left\">\r\n                            ");
#nullable restore
#line 41 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 44 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UsedBefore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 47 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Proficiency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:right\">\r\n                            ");
#nullable restore
#line 50 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FavAtrribute));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\TechStack\POCODataReturn.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LearningCSharp.Models.TechStack>> Html { get; private set; }
    }
}
#pragma warning restore 1591
