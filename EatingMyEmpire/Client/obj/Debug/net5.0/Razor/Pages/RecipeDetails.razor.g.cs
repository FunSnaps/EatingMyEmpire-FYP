#pragma checksum "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f215b7c6592199ad5a26d3408c3023fece72a3b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/recipedetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/recipedetails")]
    public partial class RecipeDetails : RecipeDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Recipe Details</h3>");
#nullable restore
#line 6 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
 if (Recipe == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"spinner-border\"></div>");
#nullable restore
#line 9 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center m-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-header");
            __builder.OpenElement(10, "h1");
            __builder.AddContent(11, 
#nullable restore
#line 16 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
               Recipe.RecipeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body text-center");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "class", "card-img-top");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 20 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                          Recipe.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n          ");
            __builder.OpenElement(19, "h5");
            __builder.AddContent(20, 
#nullable restore
#line 22 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
               Recipe.RecipeDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n          ");
            __builder.AddMarkupContent(22, "<p class=\"text-left font-italic\">Ingredients</p>\r\n          ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "text-left");
            __builder.AddContent(25, 
#nullable restore
#line 25 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                 Recipe.RecipeStep == null ? "N/A" : Recipe.RecipeStep.Ingredients

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n          ");
            __builder.AddMarkupContent(27, "<p class=\"text-left font-italic\">Instructions</p>\r\n          ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "text-left");
            __builder.AddContent(30, 
#nullable restore
#line 28 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                 Recipe.RecipeStep == null ? "N/A" : Recipe.RecipeStep.Instructions

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.AddMarkupContent(32, "<div class=\"card-footer text-center\"><a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n          <a href=\"#\" class=\"btn btn-primary\">Edit</a>\r\n          <a href=\"#\" class=\"btn btn-danger\">Delete</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
