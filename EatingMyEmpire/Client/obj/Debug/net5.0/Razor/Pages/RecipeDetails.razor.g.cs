#pragma checksum "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08076ef7587561b25be1bdd53a46ea16a49a69ae"
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
#nullable restore
#line 11 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\_Imports.razor"
using EatingMyEmpire.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/recipedetails/{id}")]
    public partial class RecipeDetails : RecipeDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Recipe Details</h3>");
#nullable restore
#line 5 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
 if (Recipe == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"spinner-border\"></div>");
#nullable restore
#line 8 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
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
#line 15 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
               Recipe.RecipeName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.AddContent(13, 
#nullable restore
#line 15 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                  Coordinates

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body text-center");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "class", "card-img-top");
            __builder.AddAttribute(19, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                                    e => Coordinates = $"X = {e.ClientX} Y = {e.ClientY}"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 19 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                                                                                                  Recipe.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n          ");
            __builder.OpenElement(22, "h5");
            __builder.AddContent(23, 
#nullable restore
#line 21 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
               Recipe.RecipeDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n          ");
            __builder.AddMarkupContent(25, "<p class=\"text-left font-italic\">Recipe type:</p>\r\n          ");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "class", "text-left");
            __builder.AddContent(28, 
#nullable restore
#line 24 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                Recipe.CourseType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n          ");
            __builder.AddMarkupContent(30, "<p class=\"text-left font-italic\">Ingredients:</p>\r\n          ");
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "class", "text-left");
            __builder.AddContent(33, 
#nullable restore
#line 27 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                 Recipe.RecipeStep == null ? "N/A" : Recipe.RecipeStep.Ingredients

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n          ");
            __builder.AddMarkupContent(35, "<p class=\"text-left font-italic\">Instructions:</p>\r\n          ");
            __builder.OpenElement(36, "p");
            __builder.AddAttribute(37, "class", "text-left");
            __builder.AddContent(38, 
#nullable restore
#line 30 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                 Recipe.RecipeStep == null ? "N/A" : Recipe.RecipeStep.Instructions

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n          ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                                     Button_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, 
#nullable restore
#line 32 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                                                    ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 35 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
                                             CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "<a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n          ");
            __builder.AddMarkupContent(48, "<a href=\"#\" class=\"btn btn-primary\">Edit</a>\r\n          ");
            __builder.AddMarkupContent(49, "<a href=\"#\" class=\"btn btn-danger\">Delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\RecipeDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
