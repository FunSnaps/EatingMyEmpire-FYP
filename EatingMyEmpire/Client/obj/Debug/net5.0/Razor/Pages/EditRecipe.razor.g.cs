#pragma checksum "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756e86ee317cdb4683b7d70d646147cd859a76dd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editrecipe/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/editrecipe")]
    public partial class EditRecipe : EditRecipeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                  EditRecipeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n  ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n  ");
                __builder2.OpenElement(8, "h3");
                __builder2.AddContent(9, 
#nullable restore
#line 10 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
       PageHeaderText

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n  <hr>\r\n  ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group row");
                __builder2.AddMarkupContent(13, "<label for=\"RecipeName\" class=\"col-sm-2 col-form-label\">\r\n      Recipe Name\r\n    </label>\r\n    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "RecipeName");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "placeholder", "Recipe name");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                                                                             EditRecipeModel.RecipeName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditRecipeModel.RecipeName = __value, EditRecipeModel.RecipeName))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditRecipeModel.RecipeName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n      ");
                __Blazor.EatingMyEmpire.Client.Pages.EditRecipe.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 18 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                () => EditRecipeModel.RecipeName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n  ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group row");
                __builder2.AddMarkupContent(29, "<label for=\"RecipeDescription\" class=\"col-sm-2 col-form-label\">\r\n      Description\r\n    </label>\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(32);
                __builder2.AddAttribute(33, "id", "RecipeDescription");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "placeholder", "Recipe description");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                                                                                               EditRecipeModel.RecipeDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditRecipeModel.RecipeDescription = __value, EditRecipeModel.RecipeDescription))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditRecipeModel.RecipeDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n      ");
                __Blazor.EatingMyEmpire.Client.Pages.EditRecipe.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 27 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                () => EditRecipeModel.RecipeDescription

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n  ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group row");
                __builder2.AddMarkupContent(45, "<label for=\"RecipeIngredients\" class=\"col-sm-2 col-form-label\">\r\n      Ingredients\r\n    </label>\r\n    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(48);
                __builder2.AddAttribute(49, "id", "RecipeIngredients");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "placeholder", "Ingredients");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                                                                                        RecipeStep.Ingredients

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RecipeStep.Ingredients = __value, RecipeStep.Ingredients))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RecipeStep.Ingredients));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n      ");
                __Blazor.EatingMyEmpire.Client.Pages.EditRecipe.TypeInference.CreateValidationMessage_2(__builder2, 56, 57, 
#nullable restore
#line 37 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                () => RecipeStep.Ingredients

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n  ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group row");
                __builder2.AddMarkupContent(61, "<label for=\"RecipeInstructions\" class=\"col-sm-2 col-form-label\">\r\n      Instructions\r\n    </label>\r\n    ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(64);
                __builder2.AddAttribute(65, "id", "RecipeInstructions");
                __builder2.AddAttribute(66, "class", "form-control");
                __builder2.AddAttribute(67, "placeholder", "Instructions");
                __builder2.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                                                                                          RecipeStep.Instructions

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RecipeStep.Instructions = __value, RecipeStep.Instructions))));
                __builder2.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RecipeStep.Instructions));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n      ");
                __Blazor.EatingMyEmpire.Client.Pages.EditRecipe.TypeInference.CreateValidationMessage_3(__builder2, 72, 73, 
#nullable restore
#line 46 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                () => RecipeStep.Instructions

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n  ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group row");
                __builder2.AddMarkupContent(77, "<label for=\"RecipeType\" class=\"col-sm-2 col-form-label\">\r\n      Recipe type\r\n    </label>\r\n    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "col-sm-10");
                __Blazor.EatingMyEmpire.Client.Pages.EditRecipe.TypeInference.CreateInputSelect_4(__builder2, 80, 81, 
#nullable restore
#line 55 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                EditRecipeModel.CourseType

#line default
#line hidden
#nullable disable
                , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditRecipeModel.CourseType = __value, EditRecipeModel.CourseType)), 83, () => EditRecipeModel.CourseType, 84, (__builder3) => {
#nullable restore
#line 56 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
         foreach (var coursetype in Enum.GetValues(typeof(CourseType)))
{

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(85, "option");
                    __builder3.AddAttribute(86, "value", 
#nullable restore
#line 58 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                coursetype

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(87, 
#nullable restore
#line 58 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                             coursetype

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 59 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
}

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(88, "\r\n      ");
                __Blazor.EatingMyEmpire.Client.Pages.EditRecipe.TypeInference.CreateValidationMessage_5(__builder2, 89, 90, 
#nullable restore
#line 61 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                () => EditRecipeModel.CourseType

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n\r\n  ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group row");
                __builder2.AddMarkupContent(94, "<label for=\"DateAdded\" class=\"col-sm-2 col-form-label\">\r\n      Date added\r\n    </label>\r\n    ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-sm-10");
                __Blazor.EatingMyEmpire.Client.Pages.EditRecipe.TypeInference.CreateInputDate_6(__builder2, 97, 98, "DateAdded", 99, "form-control", 100, 
#nullable restore
#line 70 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                                                  EditRecipeModel.DateAdded

#line default
#line hidden
#nullable disable
                , 101, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditRecipeModel.DateAdded = __value, EditRecipeModel.DateAdded)), 102, () => EditRecipeModel.DateAdded);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n  ");
                __builder2.AddMarkupContent(104, "<button class=\"btn btn-primary\" type=\"submit\">Submit</button>");
#nullable restore
#line 76 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
   if (EditRecipeModel.id > 0)
  {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(105, "button");
                __builder2.AddAttribute(106, "class", "btn btn-danger");
                __builder2.AddAttribute(107, "type", "button");
                __builder2.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                                           Delete_Click

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(109, "Delete");
                __builder2.CloseElement();
#nullable restore
#line 79 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
  }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(110, "<div class=\"card-footer text-center\"><a href=\"/\" class=\"btn btn-primary\">Back</a></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(111, "\r\n\r\n");
            __builder.OpenComponent<EatingMyEmpire.Components.Confirm>(112);
            __builder.AddAttribute(113, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 87 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                                        ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(114, (__value) => {
#nullable restore
#line 87 "E:\Uni\UniDocs\Year3\FYP\WebApp\EatingMyEmpire\EatingMyEmpire\Client\Pages\EditRecipe.razor"
                                                                                   DeleteConfirmation = (EatingMyEmpire.Components.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.EatingMyEmpire.Client.Pages.EditRecipe
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
