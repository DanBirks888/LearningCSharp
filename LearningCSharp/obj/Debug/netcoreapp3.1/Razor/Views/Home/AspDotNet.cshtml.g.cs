#pragma checksum "C:\Users\drbor\source\repos\LearningCSharp\LearningCSharp\Views\Home\AspDotNet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49731df51a7f15c7c01ace361c2b84192ed78546"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AspDotNet), @"mvc.1.0.view", @"/Views/Home/AspDotNet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49731df51a7f15c7c01ace361c2b84192ed78546", @"/Views/Home/AspDotNet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325f52889291cc4769739c65f19ace87d9c5921b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AspDotNet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LearningCSharp.Models.TechStack>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<h1 style=""padding:30px"" class=""text-center"">ASP.NET MVC</h1>

<h3 style=""padding:10px"">Basic MVC Functionality</h3>
<div class=""row"">
    <div class=""col-4"">
        <div class=""list-group"" id=""list-tab"" role=""tablist"">
            <a class=""list-group-item list-group-item-action active"" id=""list-home-list"" data-toggle=""list"" href=""#list-home"" role=""tab"" style=""font-size:large"" aria-controls=""home"">Classes</a>
            <a class=""list-group-item list-group-item-action"" id=""list-profile-list"" data-toggle=""list"" href=""#list-profile"" role=""tab"" style=""font-size:large"" aria-controls=""profile"">Controller</a>
            <a class=""list-group-item list-group-item-action"" id=""list-messages-list"" data-toggle=""list"" href=""#list-messages"" role=""tab"" style=""font-size:large"" aria-controls=""messages"">View</a>
            <img src=""https://pnnsoft.com/Storage/BaseContents/c5e41a0a-2979-45dd-8c20-810c8a91c393/70c2c2b4-4fd8-4ab6-b923-6ac036f57974.png"" />
        </div>
    </div>
    <div class=""col-8"">
  ");
            WriteLiteral(@"      <div class=""tab-content"" id=""nav-tabContent"">
            <div class=""tab-pane fade show active"" id=""list-home"" role=""tabpanel"" aria-labelledby=""list-home-list"">
                <ul class=""list-group"" style=""text-size-adjust:auto"">
                    <li class=""list-group-item list-group-item-primary"" style=""font-size:medium"">Right Click on the Models Folder and create a new Class!</li>
                    <li class=""list-group-item list-group-item-secondary"" style=""font-size:medium"">Inside the Class Brackets, writing props provides a shortcut to creating attributes quickly</li>
                    <li class=""list-group-item list-group-item-success"" style=""font-size:medium"">If you are familiar with POJO's from Java, ASP.NET and C# allow lighting fast Class creation</li>
                    <li class=""list-group-item list-group-item-danger"" style=""font-size:medium"">The Access Modifers, Type, Name, Getters + Setters are incorportated into one single line</li>


                </ul>
           ");
            WriteLiteral(@"     <img src=""/images/poco.png"" class=""img-fluid"" alt=""Responsive image"">
            </div>
            <div class=""tab-pane fade"" id=""list-profile"" role=""tabpanel"" aria-labelledby=""list-profile-list"">
                <ul class=""list-group"" style=""text-size-adjust:auto"">
                    <li class=""list-group-item list-group-item-primary"" style=""font-size:medium"">Right Click on the Controller Folder and create a new Empty Controller Class</li>
                    <li class=""list-group-item list-group-item-secondary"" style=""font-size:medium"">IActionResult() is an Interface which specifies how the server should respond to the request</li>
                    <li class=""list-group-item list-group-item-success"" style=""font-size:medium"">Inside this method, Object Instantian of the POCO can be done here to pass data</li>
                    <li class=""list-group-item list-group-item-danger"" style=""font-size:medium"">By Right Click on the method, in this case POCODataReturn()</li>
                    <li");
            WriteLiteral(@" class=""list-group-item list-group-item-dark"" style=""font-size:medium"">Click Add View and from here it is possible to generate a View which is populated by the POCO</li>

                </ul>
                <img src=""/images/listOfPocos.png"" class=""img-fluid"" alt=""Responsive image"">

            </div>
            <div class=""tab-pane fade"" id=""list-messages"" role=""tabpanel"" aria-labelledby=""list-messages-list"">
                <ul class=""list-group"" style=""text-size-adjust:auto"">
                    <li class=""list-group-item list-group-item-primary"" style=""font-size:medium"">Upon Instantian of the Controller, a View Folder should have been generated</li>
                    <li class=""list-group-item list-group-item-secondary"" style=""font-size:medium"">If your View does not auto-generate, Right Click on the Method in your Controller</li>
                    <li class=""list-group-item list-group-item-success"" style=""font-size:medium"">Now you can create a new View importing all necessary HTML as des");
            WriteLiteral(@"ired</li>
                    <li class=""list-group-item list-group-item-danger"" style=""font-size:medium"">If you did not auto-generate your View, type the following:</li>
                    <img src=""/images/view.png"" class=""img-fluid"" alt=""Responsive image"">
                    <li class=""list-group-item list-group-item-primary"" style=""font-size:medium"">Now inside this HTML View, attributes can be delcared like so:</li>
                    <img src=""/images/callingPOCO.png"" class=""img-fluid"" alt=""Responsive image"">
                </ul>
            </div>
        </div>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LearningCSharp.Models.TechStack> Html { get; private set; }
    }
}
#pragma warning restore 1591
