#pragma checksum "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4104591ea80c475f3b5fe63b58b311290f6aabf"
// <auto-generated/>
#pragma warning disable 1591
namespace EatingMyEmpire.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\_Imports.razor"
using EatingMyEmpire.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\_Imports.razor"
using EatingMyEmpire.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class RecipeList : RecipeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Recipe List</h3>");
#nullable restore
#line 5 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeList.razor"
 if (Recipes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"spinner-border\"></div>");
#nullable restore
#line 8 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck");
#nullable restore
#line 12 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeList.razor"
     foreach (var recipe in Recipes)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card m-3");
            __builder.AddAttribute(6, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.OpenElement(9, "h3");
            __builder.AddContent(10, 
#nullable restore
#line 16 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeList.razor"
               recipe.RecipeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 18 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeList.razor"
                                                       recipe.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "alt", "Adobo");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddMarkupContent(17, "<div class=\"card-footer text-center\"><a href=\"#\" class=\"btn btn-primary m-1\">View</a>\r\n          <a href=\"#\" class=\"btn btn-primary m-1\">Edit</a>\r\n          <a href=\"#\" class=\"btn btn-primary m-1\">Delete</a></div>");
            __builder.CloseElement();
#nullable restore
#line 25 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 27 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
