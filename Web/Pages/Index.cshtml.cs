using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using API.Models;

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

        public List<Car> Cars { get; private set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:7259/cars");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Cars = JsonConvert.DeserializeObject<List<Car>>(content);
                return Page();
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }
        }
    }
}