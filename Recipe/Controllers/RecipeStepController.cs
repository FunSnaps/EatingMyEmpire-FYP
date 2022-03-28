using EatingMyEmpire.Api.Models;
using EatingMyEmpire.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class RecipeStepController : ControllerBase
{
    private readonly IRecipeStepRepository recipeStepRepository;

    public RecipeStepController(IRecipeStepRepository recipeStepRepository)
    {
        this.recipeStepRepository = recipeStepRepository;
    }

    [HttpGet]
    public async Task<ActionResult> GetRecipeSteps()
    {
        try
        {
            return Ok(await recipeStepRepository.GetRecipeSteps());
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<RecipeStep>> GetRecipeStep(int id)
    {
        try
        {
            var result = await recipeStepRepository.GetRecipeStep(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
        }
    }
}