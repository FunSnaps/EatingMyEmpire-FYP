using EatingMyEmpire.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Client.Pages
{
    public class DisplayRecipeBase : ComponentBase
    {
        [Parameter]
        public Recipe Recipe { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }
    }
}
