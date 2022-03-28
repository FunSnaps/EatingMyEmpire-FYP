using EatingMyEmpire.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EatingMyEmpire.Client.Services
{
    public class RecipeStepService : IRecipeStepService
    {
        private readonly HttpClient httpClient;

        public RecipeStepService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<RecipeStep> GetRecipeStep(int id)
        {
            return await httpClient.GetFromJsonAsync<RecipeStep>($"api/recipestep/{id}");
        }

        public async Task<IEnumerable<RecipeStep>> GetRecipeSteps()
        {
            return await httpClient.GetFromJsonAsync<RecipeStep[]>("api/recipestep");
        }
    }
}
