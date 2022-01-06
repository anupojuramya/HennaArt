using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace HennaArt.Pages.Gallery
{
    public class ListModel : PageModel
    {

        private readonly IConfiguration config;
        public String Message { get; set; }

        /// <summary>
        /// Counstructor for the PageModel
        /// </summary>
        /// <param name="config"></param>
        public ListModel(IConfiguration config)
        {
            this.config = config;
        }
        
        public void OnGet()
        {
            Message = config["Message"];
        }
    }
}
