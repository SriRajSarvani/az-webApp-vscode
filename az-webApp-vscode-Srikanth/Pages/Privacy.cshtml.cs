using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace az_webApp_vscode_Srikanth.Pages
{
    
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        //public void OnGet()
        //{
        //    throw new Exception("Testing New insights");
        //}
        public void OnGet()
        {
            
            
        }
    }

}
