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

        public string PageHeaderText { get; set; }

        [Parameter]
        public string Id { get; set; }
 
        protected async override Task OnInitializedAsync()
        {
            System.Diagnostics.Debug.WriteLine(Id, "HERE:");

            int.TryParse(Id, out int recipeId);

            if (recipeId != 0)
            {
                PageHeaderText = "Edit Recipe";
                Recipe = await RecipeService.GetRecipe(int.Parse(Id));
                RecipeStep = await RecipeStepService.GetRecipeStep(Recipe.RecipeStepId);
            }
            else
            {
                PageHeaderText = "Create Recipe";

                RecipeStep = new RecipeStep();

                Recipe = new Recipe
                {
                    RecipeName = "Empty plate",
                    DateAdded = DateTime.UtcNow,
                    RecipeDescription = "N/A",
                    CourseType = 0,
                    RecipeStep = RecipeStep,
                    PhotoPath = "images/nophoto.jpg"
                };
            }    
            /*Recipes = (await RecipeService.GetRecipes()).ToList();*/
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

        protected async Task Delete_Click()
        {
            await RecipeService.DeleteRecipe(Recipe.id);
            NavigationManager.NavigateTo("/");
        }
    }
}
