#pragma checksum "/Users/Dan/Projects/LearningCSharp/LearningCSharp/Views/Home/Database.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6666c73f9aafeaa1339a29673e6a24931740518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Database), @"mvc.1.0.view", @"/Views/Home/Database.cshtml")]
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
#line 1 "/Users/Dan/Projects/LearningCSharp/LearningCSharp/Views/_ViewImports.cshtml"
using LearningCSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Dan/Projects/LearningCSharp/LearningCSharp/Views/_ViewImports.cshtml"
using LearningCSharp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6666c73f9aafeaa1339a29673e6a24931740518", @"/Views/Home/Database.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c411ce635d67228dcc6302a8d2d0948a01462332", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Database : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Dan/Projects/LearningCSharp/LearningCSharp/Views/Home/Database.cshtml"
  
    ViewData["Title"] = "Database";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"text-center\" style=\"padding:30px\">");
#nullable restore
#line 4 "/Users/Dan/Projects/LearningCSharp/LearningCSharp/Views/Home/Database.cshtml"
                                        Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<h2 style=""padding: 30px"">SQL</h2>

<div class=""row"">
        <div class=""col-8"">
        <div class=""tab-content"" id=""nav-tabContent"" style=""text-size-adjust:150%"">
            <div class=""tab-pane fade show active"" id=""list-home"" role=""tabpanel"" aria-labelledby=""list-home-list"">
                <ul class=""list-group"">
                    <li class=""list-group-item list-group-item-primary"">SQL Stands for Structured Query Language!</li>
                    <li class=""list-group-item list-group-item-secondary"">Is used for Querying and Modifying a Database!</li>
                    <li class=""list-group-item list-group-item-success"">SQL Commands are embedded inside of most Programming Languages!</li>
                    <li class=""list-group-item list-group-item-danger"">SQL is a Declarative language instead of Prodecural</li>
                </ul>
            </div>
            <div class=""tab-pane fade"" id=""list-profile"" role=""tabpanel"" aria-labelledby=""list-profile-list"">
                <ul class=""lis");
            WriteLiteral(@"t-group"">
                    <li class=""list-group-item list-group-item-primary"">Worked through Official Oracle SQL Develop Online course</li>
                    <li class=""list-group-item list-group-item-secondary"">Used SQL Workbench to extend an MVC and Singlton Project </li>
                    <li class=""list-group-item list-group-item-success"">Built Passion Project Astrology API using MongoDB</li>
                    <li class=""list-group-item list-group-item-danger"">Accessed </li>
                </ul>
            </div>
            <div class=""tab-pane fade"" id=""list-messages"" role=""tabpanel"" aria-labelledby=""list-messages-list"">
                <ul class=""list-group"">
                    <li class=""list-group-item list-group-item-primary"">SELECT - extracts data from a database</li>
                    <li class=""list-group-item list-group-item-secondary"">UPDATE - updates data in a database</li>
                    <li class=""list-group-item list-group-item-success"">DELETE - deletes data from a datab");
            WriteLiteral(@"ase</li>
                    <li class=""list-group-item list-group-item-danger"">INSERT INTO - inserts new data into a database</li> 
                </ul>
            </div>
            <div class=""tab-pane fade"" id=""list-settings"" role=""tabpanel"" aria-labelledby=""list-settings-list"">
             <ul class=""list-group"">
                    <li class=""list-group-item list-group-item-primary"">No Coding Skills requires since statements are clean and simple to use</li>
                    <li class=""list-group-item list-group-item-primary"">Standardised Language and documentation providing uniformed platform for all users</li>
                    <li class=""list-group-item list-group-item-danger"">SQL has a difficult interface that makes few users uncomfortable while dealing with the database.</li>
                    <li class=""list-group-item list-group-item-danger"">Some versions are costly and hence, programmers cannot access it.</li> 
                </ul>

            </div>
        </div>
    </div>
<div cla");
            WriteLiteral(@"ss=""col-4"">
        <div class=""list-group"" id=""list-tab"" role=""tablist"">
            <a class=""list-group-item list-group-item-action active"" id=""list-home-list"" data-toggle=""list"" href=""#list-home"" role=""tab"" aria-controls=""home"">What is SQL?</a>
            <a class=""list-group-item list-group-item-action"" id=""list-profile-list"" data-toggle=""list"" href=""#list-profile"" role=""tab"" aria-controls=""profile"">Experience with Databases</a>
            <a class=""list-group-item list-group-item-action"" id=""list-messages-list"" data-toggle=""list"" href=""#list-messages"" role=""tab"" aria-controls=""messages"">SQL Statements</a>
            <a class=""list-group-item list-group-item-action"" id=""list-settings-list"" data-toggle=""list"" href=""#list-settings"" role=""tab"" aria-controls=""settings"">Pro's and Cons</a>
        </div>
    </div>

</div>

<h2 style=""padding: 30px"" class=""text-right"">T-SQL</h2>

<div class=""row"">
<div class=""col-4"">
        <div class=""list-group"" id=""list-tab"" role=""tablist"">
            <a class=""list-gr");
            WriteLiteral(@"oup-item list-group-item-action active"" id=""list-tsql-list"" data-toggle=""list"" href=""#list-tsql"" role=""tab"" aria-controls=""tsql"">What is T-SQL?</a>
            <a class=""list-group-item list-group-item-action"" id=""list-microsoft-list"" data-toggle=""list"" href=""#list-microsoft"" role=""tab"" aria-controls=""microsoft"">Microsoft Suite</a>
            <a class=""list-group-item list-group-item-action"" id=""list-messages-list"" data-toggle=""list"" href=""#list-commands"" role=""tab"" aria-controls=""commands"">T-SQL Statements</a>
            <a class=""list-group-item list-group-item-action"" id=""list-settings-list"" data-toggle=""list"" href=""#list-procedural"" role=""tab"" aria-controls=""procedural"">Pro's and Con's</a>
        </div>
    </div>
        <div class=""col-8"">
        <div class=""tab-content"" id=""nav-tabContent"" style=""text-size-adjust:150%"">
            <div class=""tab-pane fade show active"" id=""list-tsql"" role=""tabpanel"" aria-labelledby=""list-home-list"">
                <ul class=""list-group"">
                    <li c");
            WriteLiteral(@"lass=""list-group-item list-group-item-primary"">Transactional Structured Query Language!</li>
                    <li class=""list-group-item list-group-item-secondary"">T-SQL is an extension to SQL Programming Language</li>
                    <li class=""list-group-item list-group-item-success"">Is propietary, whilst SQL is open format</li>
                    <li class=""list-group-item list-group-item-danger"">Declarative but contains Procedural for flexibility</li>
                </ul>
            </div>
            <div class=""tab-pane fade"" id=""list-microsoft"" role=""tabpanel"" aria-labelledby=""list-profile-list"">
                <ul class=""list-group"">
                    <li class=""list-group-item list-group-item-primary"">SQL Server</li>
                    <li class=""list-group-item list-group-item-secondary"">Azure SQL Database</li>
                    <li class=""list-group-item list-group-item-success"">Azure Synapse Analytics</li>
                    <li class=""list-group-item list-group-item-danger"">Paral");
            WriteLiteral(@"lel Data Warehouse</li> 
                </ul>
            </div>
            <div class=""tab-pane fade"" id=""list-commands"" role=""tabpanel"" aria-labelledby=""list-messages-list"">
                <ul class=""list-group"">
                    <li class=""list-group-item list-group-item-primary"">DECLARE - Assigning a name to a variable (Starts Null)</li>
                    <li class=""list-group-item list-group-item-secondary"">SET - Assigning a value to a variable</li>
                    <li class=""list-group-item list-group-item-success"">USE - Use specified data or database (Takes params)</li>
                    <li class=""list-group-item list-group-item-danger"">IF - Example of one of many conditional statements to manipulate data</li> 
                </ul>
            </div>
            <div class=""tab-pane fade"" id=""list-procedural"" role=""tabpanel"" aria-labelledby=""list-settings-list"">
                <ul class=""list-group"">
                    <li class=""list-group-item list-group-item-primary"">Straightforwar");
            WriteLiteral(@"d configuration and installation</li>
                    <li class=""list-group-item list-group-item-primary"">Although more flexible, it is a proprietary language</li>
                    <li class=""list-group-item list-group-item-danger"">Restrictive compatibility with new technologies</li>
                    <li class=""list-group-item list-group-item-danger"">Powerful demanding software can force hardware upgrades</li> 
                </ul>
            </div>
        </div>
    </div>
    
</div>


<h1 class=""text-center"" style=""padding:30px"">SQL? or T-SQL? or PL-SQL?</h1>
<div class=""container"">
    <div class=""card-deck mb-3 text-center"">
        <div class=""card mb-4 box-shadow"">
            <div class=""card-header"">
                <h4 class=""my-0 font-weight-normal"">System R's (1970s)</h4>
            </div>
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">SQL <small class=""text-muted"">/ PL</small></h1>
                <ul class=""list-unstyled mt-3 mb-4"">
  ");
            WriteLiteral(@"                  <li>Most Common</li>
                    <li>Data-Ortientated Language</li>
                    <li>Specifies Structure of Data</li>
                    <li>Stores Via Collections</li>
                </ul>
                <a href=""https://www.w3schools.com/sql/"" button type=""button"" class=""btn btn-lg btn-block btn-primary"">SQL</a>
            </div>
        </div>
        <div class=""card mb-4 box-shadow"">
            <div class=""card-header"">
                <h4 class=""my-0 font-weight-normal"">Microsoft's</h4>
            </div>
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">SQL <small class=""text-muted"">/ T</small></h1>
                <ul class=""list-unstyled mt-3 mb-4"">
                    <li>Declare local variables</li>
                    <li>Kill and exception handling</li>
                    <li>Built-in functions for math</li>
                    <li>Extend SQL statements</li>
                </ul>
                <a href=""https://do");
            WriteLiteral(@"cs.microsoft.com/en-us/sql/t-sql/language-reference?view=sql-server-ver15"" button type=""button"" class=""btn btn-lg btn-block btn-primary"">T-SQL</a>
            </div>
        </div>

        <div class=""card mb-4 box-shadow"">
            <div class=""card-header"">
                <h4 class=""my-0 font-weight-normal"">Oracle's SQL</h4>
            </div>
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">SQL <small class=""text-muted"">/ PL</small></h1>
                <ul class=""list-unstyled mt-3 mb-4"">
                    <li>Adds Procedural language</li>
                    <li>Variables, Arrays, Loops</li>
                    <li>Encapsulation</li>
                    <li>Some features</li>
                </ul>
                <a href=""https://www.oracle.com/uk/database/technologies/appdev/sqldeveloper-landing.html"" type=""button"" class=""btn btn-lg btn-block btn-primary"">Oracle SQL</a>
            </div>
        </div>
        <div class=""card mb-4 box-shadow"">
       ");
            WriteLiteral(@"     <div class=""card-header"">
                <h4 class=""my-0 font-weight-normal"">Post Gre's SQL</h4>
            </div>
            <div class=""card-body"">
                <h1 class=""card-title pricing-card-title"">SQL <small class=""text-muted"">/ PG</small></h1>
                <ul class=""list-unstyled mt-3 mb-4"">
                    <li>Adds Procedural language</li>
                    <li>Variables, Arrays, Loops</li>
                    <li>Encapsulation</li>
                    <li>Some features</li>
                </ul>
                <a href=""https://www.postgresql.org/"" type=""button"" class=""btn btn-lg btn-block btn-primary"">Oracle SQL</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
