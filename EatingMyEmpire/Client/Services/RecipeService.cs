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

        public async Task<Recipe> GetRecipe(int id)
        {
            return await httpClient.GetFromJsonAsync<Recipe>($"api/recipe/{id}");
        }

        public async Task<IEnumerable<Recipe>> GetRecipes()
        {         
            return await httpClient.GetFromJsonAsync<Recipe[]>("api/recipe");
        }
    }
}
