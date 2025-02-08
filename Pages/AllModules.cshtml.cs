using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_poe.Pages
{
    public class AllModulesModel : PageModel
    {


        public List<ClientModuleAndPersonalData> moList =
           new List<ClientModuleAndPersonalData>();


        public void OnGet()
        {//on form load
            ClientModuleAndPersonalData em = new ClientModuleAndPersonalData();
            moList = em.allModules();

        }
    }
}
