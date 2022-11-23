using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Blazor.Pages
{
    public class LoginModel : ComponentBase
    {
        public LoginModel() 
        {
            LoginData = new LoginViewModel();
        }

        public LoginViewModel LoginData { get; set; }

        protected Task LoginAsync()
        {
            return Task.CompletedTask;
        }
    }

    public class LoginViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Too long")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
