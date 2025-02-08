using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_poe.Pages
{
    public class NewModuleModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost() 
        {
            string ModuleCode = Request.Form["txtMcod"];
            string ModuleName = Request.Form["txtModName"];
            int ModuleCredits = Convert.ToInt32(Request.Form["txtCred"]);
            int WeeklyClassHours = Convert.ToInt32(Request.Form["txtHrs"]);
            int Number_of_Weeks = Convert.ToInt32(Request.Form["txtnw"]);
            DateTime StartDate = Convert.ToDateTime(Request.Form["txtDate"]);
            int SelfstudyHours = Convert.ToInt32(Request.Form["txtSS"]);

            ClientModuleAndPersonalData clm = new ClientModuleAndPersonalData(StartDate,ModuleCode, ModuleName, ModuleCredits, WeeklyClassHours, Number_of_Weeks);
            clm.AddModuleData();
            Response.Redirect("/AllModules");
        }
    }
}
