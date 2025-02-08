using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_poe.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost()
        {
            string username = Request.Form["txtUsername"];
            string pass = Request.Form["txtPass"];

            ClientModuleAndPersonalData cl = new ClientModuleAndPersonalData(username,pass);
            cl.Login(username, pass);
            if(cl.Username.Equals(username) && cl.Password.Equals(pass))
              {
                Response.Redirect("/AllModules");

            }

            
        }

    }
}