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
        public async Task<ActionResult> GetRecipes()
        {
            try
            {
                return Ok(await recipeRepository.GetRecipes());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error getting data from the database!");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Shared.Recipe>> GetRecipe(int id)
        {
            try
            {
                var result = await recipeRepository.GetRecipe(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error getting data from the database!");
            }
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Shared.Recipe>>> Search(string RecipeName, string RecipeDescription)
        {
            try
            {
                var result = await recipeRepository.Search(RecipeName, RecipeDescription);

                if (result.Any())
                {
                    return Ok(result);
                }

                return NotFound("This recipe does not exist!");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database!");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Shared.Recipe>> CreateRecipe(Shared.Recipe recipe)
        {
            try
            {
                if (recipe == null)
                {
                    return BadRequest();
                }

                var rec = await recipeRepository.GetRecipeByName(recipe.RecipeName);

                //Validation error
                if (rec != null)
                {
                    ModelState.AddModelError("RecipeName", "Recipe already Exists!");
                    return BadRequest(ModelState);
                }

                var createdRecipe = await recipeRepository.CreateRecipe(recipe);

                //Anonymous object
                return CreatedAtAction(nameof(GetRecipe), new { id = createdRecipe.id }, createdRecipe);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database!");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Shared.Recipe>> UpdateRecipe(int id, Shared.Recipe recipe)
        {
            try
            {
                if (id != recipe.id)
                {
                    return BadRequest("Recipe id mismatch!");
                }
                var recipeToUpdate = await recipeRepository.GetRecipe(recipe.id);

                if (recipeToUpdate == null)
                {
                    return NotFound($"Recipe with ID: {recipe.id} was not found!");
                }

                return await recipeRepository.UpdateRecipe(recipe);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data!");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Shared.Recipe>> DeleteRecipe(int id)
        {
            try
            {
                var recipeToDelete = await recipeRepository.GetRecipe(id);

                if (recipeToDelete == null)
                {
                    return NotFound($"Recipe with ID: {id} was not found!");
                }

                return await recipeRepository.DeleteRecipe(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data from the database!");
            }
        }

    }
}
