#pragma checksum "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d08b98b706e17d87b62d2c5a9c22beae17fb8ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drinks_Detail), @"mvc.1.0.view", @"/Views/Drinks/Detail.cshtml")]
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
#line 1 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d08b98b706e17d87b62d2c5a9c22beae17fb8ab", @"/Views/Drinks/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Drinks_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Drink>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
  
    ViewData["Title"] = "Detalle";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d08b98b706e17d87b62d2c5a9c22beae17fb8ab3265", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n");
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
            WriteLiteral(@"
<br />
<style>

/*****************globals*************/
body {
  font-family: 'open sans';
  overflow-x: hidden; }

img {
  max-width: 100%; }

.preview {
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: vertical;
  -webkit-box-direction: normal;
  -webkit-flex-direction: column;
      -ms-flex-direction: column;
          flex-direction: column; }
  ");
            WriteLiteral(@"@media screen and (max-width: 996px) {
    .preview {
      margin-bottom: 20px; } }

.preview-pic {
  -webkit-box-flex: 1;
  -webkit-flex-grow: 1;
      -ms-flex-positive: 1;
          flex-grow: 1; }

.preview-thumbnail.nav-tabs {
  border: none;
  margin-top: 15px; }
  .preview-thumbnail.nav-tabs li {
    width: 18%;
    margin-right: 2.5%; }
    .preview-thumbnail.nav-tabs li img {
      max-width: 100%;
      display: block; }
    .preview-thumbnail.nav-tabs li a {
      padding: 0;
      margin: 0; }
    .preview-thumbnail.nav-tabs li:last-of-type {
      margin-right: 0; }

.tab-content {
  overflow: hidden; }
  .tab-content img {
    width: 100%;
    -webkit-animation-name: opacity;
            animation-name: opacity;
    -webkit-animation-duration: .3s;
            animation-duration: .3s; }

.card {
  margin-top: 50px;
  background: #eee;
  padding: 3em;
  line-height: 1.5em; }

");
            WriteLiteral(@"@media screen and (min-width: 997px) {
  .wrapper {
    display: -webkit-box;
    display: -webkit-flex;
    display: -ms-flexbox;
    display: flex; } }

.details {
  display: -webkit-box;
  display: -webkit-flex;
  display: -ms-flexbox;
  display: flex;
  -webkit-box-orient: vertical;
  -webkit-box-direction: normal;
  -webkit-flex-direction: column;
      -ms-flex-direction: column;
          flex-direction: column; }

.colors {
  -webkit-box-flex: 1;
  -webkit-flex-grow: 1;
      -ms-flex-positive: 1;
          flex-grow: 1; }

.product-title, .price, .sizes, .colors {
  text-transform: UPPERCASE;
  font-weight: bold; }

.checked, .price span {
  color: #ff9f1a; }

.product-title, .rating, .product-description, .price, .vote, .sizes {
  margin-bottom: 15px; }

.product-title {
  margin-top: 0; }

.size {
  margin-right: 10px; }
  .size:first-of-type {
    margin-left: 40px; }

.color {
  display: inline-block;
  vertical-align: middle;
  margin-right: 10px;
  ");
            WriteLiteral(@"height: 2em;
  width: 2em;
  border-radius: 2px; }
  .color:first-of-type {
    margin-left: 20px; }

.add-to-cart, .like {
  background: #ff9f1a;
  padding: 1.2em 1.5em;
  border: none;
  text-transform: UPPERCASE;
  font-weight: bold;
  color: #fff;
  -webkit-transition: background .3s ease;
          transition: background .3s ease; }
  .add-to-cart:hover, .like:hover {
    background: #b36800;
    color: #fff; }

.not-available {
  text-align: center;
  line-height: 2em; }
  .not-available:before {
    font-family: fontawesome;
    content: ""\f00d"";
    color: #fff; }

.orange {
  background: #ff9f1a; }

.green {
  background: #85ad00; }

.blue {
  background: #0076ad; }

.tooltip-inner {
  padding: 1.3em; }

");
            WriteLiteral("@-webkit-keyframes opacity {\r\n  0% {\r\n    opacity: 0;\r\n    -webkit-transform: scale(3);\r\n            transform: scale(3); }\r\n  100% {\r\n    opacity: 1;\r\n    -webkit-transform: scale(1);\r\n            transform: scale(1); } }\r\n\r\n");
            WriteLiteral(@"@keyframes opacity {
  0% {
    opacity: 0;
    -webkit-transform: scale(3);
            transform: scale(3); }
  100% {
    opacity: 1;
    -webkit-transform: scale(1);
            transform: scale(1); } }
</style>
<div class=""container"">
    <div class=""card"">
        <div class=""container-fliud"">
            <div class=""wrapper row"">
                <div class=""preview col-md-6"">

                    <div class=""preview-pic tab-content"">
                        <div class=""tab-pane active"" id=""pic-1""><img");
            BeginWriteAttribute("src", " src=\"", 4223, "\"", 4249, 1);
#nullable restore
#line 184 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
WriteAttributeValue("", 4229, Model.strDrinkThumb, 4229, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"details col-md-6\">\r\n                    <h3 class=\"product-title\">");
#nullable restore
#line 188 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                         Write(Model.strDrink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"rating\">\r\n                        <span class=\"review-no\">");
#nullable restore
#line 190 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                           Write(Model.strTags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <p class=\"product-description\">");
#nullable restore
#line 192 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                              Write(Model.strInstructions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h4 class=\"price\">IBA: <span>");
#nullable restore
#line 193 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                            Write(Model.strIBA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                    <p class=\"vote\"><strong>");
#nullable restore
#line 194 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                       Write(Model.strImageAttribution);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></p>
                    <h5 class=""sizes"">
                        Ingredients:

                    </h5>
                    <div class=""row"">
                        <table class=""table table-striped"">
                            <thead>
                                <tr>
                                    <th scope=""col"" style=""width: 7%"">Ingredient</th>
                                    <th scope=""col"" style=""width: 6%"">Measure</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td scope=""col"">
                                        ");
#nullable restore
#line 210 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                   Write(Model.strIngredient1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td scope=\"col\">\r\n                                        ");
#nullable restore
#line 213 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                   Write(Model.strMeasure1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td scope=\"col\">\r\n                                        ");
#nullable restore
#line 218 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                   Write(Model.strIngredient2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td scope=\"col\">\r\n                                        ");
#nullable restore
#line 221 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                   Write(Model.strMeasure2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td scope=\"col\">\r\n                                        ");
#nullable restore
#line 226 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                   Write(Model.strIngredient3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td scope=\"col\">\r\n                                        ");
#nullable restore
#line 229 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                   Write(Model.strMeasure3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td scope=\"col\">\r\n                                        ");
#nullable restore
#line 234 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                   Write(Model.strIngredient4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td scope=\"col\">\r\n                                        ");
#nullable restore
#line 237 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Detail.cshtml"
                                   Write(Model.strMeasure4);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""action"">
                        <button class=""add-to-cart btn btn-default"" type=""button"">add to cart</button>
                    </div>
                </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Drink> Html { get; private set; }
    }
}
#pragma warning restore 1591
