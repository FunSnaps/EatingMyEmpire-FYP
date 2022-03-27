using EatingMyEmpire.Client.Services;
using EatingMyEmpire.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Client.Pages
{
    public class RecipeDetailsBase : ComponentBase
    {
        public Recipe Recipe { get; set; } = new Recipe();

        protected string Coordinates { get; set; }

        protected string ButtonText { get; set; } = "Hide Footer";

        protected string CssClass { get; set; } = null;

        public RecipeStep RecipeStep { get; set; } = new RecipeStep();

        [Inject]
        public IRecipeService RecipeService { get; set; }

        [Parameter]
        public string id { get; set; }

        protected async override Task OnInitializedAsync()
        {
           Recipe = await RecipeService.GetRecipe(int.Parse(id));
        }

        protected void Button_Click()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }
            else
            {
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }
    }
}
