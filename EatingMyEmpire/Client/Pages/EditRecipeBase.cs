using EatingMyEmpire.Client.Services;
using EatingMyEmpire.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Client.Pages
{
    public class EditRecipeBase : ComponentBase
    {
        [Inject]
        public IRecipeService RecipeService { get; set; }

        public Recipe Recipe { get; set; } = new Recipe();

        [Inject]
        public IRecipeStepService RecipeStepService { get; set; }

        public RecipeStep RecipeStep { get; set; } = new RecipeStep();

       /* public string RecipeStepId { get; set; }*/

        [Parameter]
        public string id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Recipe = await RecipeService.GetRecipe(int.Parse(id));
            RecipeStep = await RecipeStepService.GetRecipeStep(int.Parse(id));
            /*RecipeStepId = Recipe.RecipeStepId.ToString();*/
        }
    }
}
