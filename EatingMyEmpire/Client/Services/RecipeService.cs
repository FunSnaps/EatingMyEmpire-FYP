using EatingMyEmpire.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace EatingMyEmpire.Client.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly HttpClient httpClient;

        public RecipeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Recipe Recipe { get; set; } = new Recipe();

        public async Task<Recipe> CreateRecipe(Recipe newRecipe)
        {
            var result = await httpClient.PostAsJsonAsync("api/recipe", newRecipe);
            Recipe = await result.Content.ReadFromJsonAsync<Recipe>();
            return Recipe;
        }

        public async Task<Recipe> GetRecipe(int id)
        {
            return await httpClient.GetFromJsonAsync<Recipe>($"api/recipe/{id}");
        }

        public async Task<IEnumerable<Recipe>> GetRecipes()
        {         
            return await httpClient.GetFromJsonAsync<Recipe[]>("api/recipe");
        }

        public async Task<Recipe> UpdateRecipe(Recipe updatedRecipe, int id)
        {
            var result = await httpClient.PutAsJsonAsync($"api/recipe/{id}", updatedRecipe);
            Recipe = await result.Content.ReadFromJsonAsync<Recipe>();
            return Recipe;
        }
    }
}

