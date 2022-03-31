using AutoMapper;
using EatingMyEmpire.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Client.Pages.Models
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile()
        {
            CreateMap<Recipe, EditRecipeModel>();
            CreateMap<EditRecipeModel, Recipe>();
        }
    }
}
