#pragma checksum "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\DisplayRecipe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cab990c8989756f6a94d0a81f5ca0ec753dcbff"
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
    public partial class DisplayRecipe : DisplayRecipeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddAttribute(2, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-header");
            __builder.OpenElement(5, "h3");
            __builder.AddContent(6, 
#nullable restore
#line 6 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\DisplayRecipe.razor"
         Recipe.RecipeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n  ");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 9 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\DisplayRecipe.razor"
                                                 Recipe.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "alt", "Recipe Photo");
            __builder.CloseElement();
#nullable restore
#line 11 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\DisplayRecipe.razor"
   if (ShowFooter)
  {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-footer text-center");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", 
#nullable restore
#line 14 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\DisplayRecipe.razor"
                 $"/recipedetails/{Recipe.id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "btn btn-primary m-1");
            __builder.AddContent(17, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n      ");
            __builder.AddMarkupContent(19, "<a href=\"#\" class=\"btn btn-primary m-1\">Edit</a>\r\n      ");
            __builder.AddMarkupContent(20, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>");
            __builder.CloseElement();
#nullable restore
#line 18 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\DisplayRecipe.razor"
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
