using AutoMapper;
using EatingMyEmpire.Client.Pages.Models;
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

        [Inject]
        public IMapper Mapper { get; set; }

        [Inject]
        public IRecipeStepService RecipeStepService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Recipe Recipe { get; set; } = new Recipe();
        
        public RecipeStep RecipeStep { get; set; } = new RecipeStep();

        /*public List<RecipeStep> RecipeSteps { get; set; } = new List<RecipeStep>();*/

        /*public List<Recipe> Recipes { get; set; } = new List<Recipe>();*/

        public EditRecipeModel EditRecipeModel { get; set; } = new EditRecipeModel(); 

        [Parameter]
        public string id { get; set; }
 
        protected async override Task OnInitializedAsync()
        {
            int.TryParse(id, out int recipeId);

            if (recipeId != 0)
            {
                Recipe = await RecipeService.GetRecipe(int.Parse(id));
            }
            else
            {
                Recipe = new Recipe
                {
                    RecipeStepId = 1001,
                    DateAdded = DateTime.UtcNow,
                    PhotoPath = "images/nophoto.jpg"
                };
            }

            Recipe = await RecipeService.GetRecipe(int.Parse(id));
            /*Recipes = (await RecipeService.GetRecipes()).ToList();*/

            RecipeStep = await RecipeStepService.GetRecipeStep(int.Parse(id));
            /*RecipeSteps = (await RecipeStepService.GetRecipeSteps()).ToList();*/
            
            Mapper.Map(Recipe, EditRecipeModel);
        }

        protected async Task HandleValidSubmit()
        { 
            EditRecipeModel.RecipeStep.Ingredients = RecipeStep.Ingredients;
            EditRecipeModel.RecipeStep.Instructions = RecipeStep.Instructions;

            Mapper.Map(EditRecipeModel, Recipe);

            Recipe result = null;

            if (Recipe.id != 0)
            {
                result = await RecipeService.UpdateRecipe(Recipe, Recipe.id);

            }
            else
            {
                result = await RecipeService.CreateRecipe(Recipe);
            }
            

            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
