﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at_test.Pages
{
    public class SobreModel : PageModel
    {
        private readonly ILogger<SobreModel> _logger;

        public SobreModel(ILogger<SobreModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
