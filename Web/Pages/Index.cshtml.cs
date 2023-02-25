using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HttpClient _httpClient;


        public IndexModel(ILogger<IndexModel> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:7259/cars");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(content);
                return Content(content);
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }
        }
    }
}