using EatingMyEmpire.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository recipeRepository;

        public RecipeController(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository;
        } 

        [HttpGet]
        public async Task<ActionResult> GetRecipe()
        {
            try
            {
                return Ok(await recipeRepository.GetRecipes());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error getting data from database!");
            }
        }
    }
}
