#pragma checksum "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d8a56b1022bf08fb8b0ac9ca5673514741b6666"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drinks_Index), @"mvc.1.0.view", @"/Views/Drinks/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d8a56b1022bf08fb8b0ac9ca5673514741b6666", @"/Views/Drinks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Drinks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 4 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d8a56b1022bf08fb8b0ac9ca5673514741b66663252", async() => {
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

<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>

<h3> Catalogo de Bebidas</h3>
<br />
<div class=""container"">
    <div id=""event-handling"">

        <div class=""row"">
            <div class=""col-sm-4"">
                <div class=""input-group input-group-sm mb-3"">
                    <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Buscar...</span>
                    <input type=""text"" class=""form-control"" aria-label=""Sizing example input"" aria-describedby=""inputGroup-sizing-sm"" v-model=""query"">
                </div>
            </div>

        </div>
        <br />
        <div class=""row"">
            <div clas");
            WriteLiteral(@"s=""col-sm-2"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" name=""typeSearchCheck"" id=""byName"" value=""ByName"" v-model=""typeSearch"">
                    <label class=""form-check-label"" for=""byName"">
                        Buscar por nombre
                    </label>
                </div>
            </div>
            <div class=""col-sm-4"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""radio"" name=""typeSearchCheck"" value=""ByIngredient"" id=""byIngredient"" v-model=""typeSearch"">
                    <label class=""form-check-label"" for=""byIngredient"">
                        Buscar por Ingrediente
                    </label>
                </div>
            </div>
            <tr v-for=""item in favoritList"">
                <td scope=""col"">{{ item }}</td>
            </tr>
        </div>
        <br />
        <div class=""row"">
            <div class=""col-sm-2"">
             ");
            WriteLiteral(@"   <button v-on:click=""Search"" class=""btn btn-primary"">Buscar bebidas</button>
            </div>
        </div>
        <br />

        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"" style=""width: 7%"">Imagen</th>
                    <th scope=""col"" style=""width: 30%"">Nombre</th>
                    <th scope=""col"" style=""width: 10%"">Id</th>
                    <th scope=""col"" style=""width: 15%""></th>
                    <th scope=""col"" style=""width: 20%""></th>
                </tr>
            </thead>
            <tbody>
                <tr v-for=""item in drinksList"">
                    <td scope=""col"">
                        <img :src=""item.strDrinkThumb"" class=""img-thumbnail float-start"" />
                    </td>
                    <td scope=""col"">{{ item.strDrink }}</td>
                    <td scope=""col"">{{ item.idDrink }}</td>
                    <td scope=""col"">
                        <button type=""button""");
            WriteLiteral(@" class=""btn btn-primary"" v-on:click=""Detail(item.idDrink)"">Ver Detalle</button>
                    </td>
                    <td scope=""col""><button type=""button"" class=""btn btn-dark""  v-on:click=""AddFavorite(item)"">Agregar a Favoritos</button></td>
                </tr>
            </tbody>
        </table>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Users\Cobe 1\Documents\proyecto\ProyectoTab\WebClient\Views\Drinks\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
    <script src=""https://unpkg.com/vue@next""></script>

    <script>
        const EventHandling = {
            data() {
                return {
                    query: '',
                    typeSearch: '',
                    info: '',
                    drinksList: [],
                    showModal: false,
                    favoritList: [],
                    drinkFavorite:null
                }
            },
            mounted() {
                if (localStorage.getItem('favoritList')) {
                    try {
                        this.cats = JSON.parse(localStorage.getItem('favoritList'));
                    } catch (e) {
                        localStorage.removeItem('favoritList');
                    }
                }
            },
            watch: {
                drink(newdrink) {
                    if (localStorage.favoritList) {

                        localStorage.favori");
                WriteLiteral(@"tList.push(newdrink);
                    }
                    else
                    {
                        localStorage.favoritList = newdrink;
                    }
                    
                }
            },
            methods: {
                Search() {
                    if (this.query == '' && this.typeSearch == '') {
                        alert('Porfavor Complete los campos')
                    }
                    else {
                        axios
                            .get('https://localhost:44397/Drinks/SearchDrinks?query=' + this.query + '&typeSearch=' + this.typeSearch)
                            .then(response => (this.drinksList = response.data))
                    }
                },
                Detail(idDrink) {
                    window.open('https://localhost:44397/Drinks/Detail?idDrink=' + idDrink);
                },
                AddFavorite(newFavorite) {
                    this.favoritList.push(this.newFavorite);
    ");
                WriteLiteral(@"                this.saveFavorite();
                },
                DeleteFavorite(idDrink) {
                    this.favoritList.splice(x, 1);
                    this.saveFavorite();
                },
                saveFavorite() {
                    const parsed = JSON.stringify(this.favoritList);
                    localStorage.setItem('favoritList', parsed);
                }
            }
        }

        const app = Vue.createApp(EventHandling).mount('#event-handling')
    </script>
");
            }
            );
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
