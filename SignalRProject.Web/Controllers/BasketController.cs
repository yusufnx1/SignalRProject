using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRProject.Web.Dto.BasketDto;
using System.Text;

namespace SignalRProject.Web.Controllers
{
    public class BasketController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BasketController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var repsonsiveMessage = await client.GetAsync("http://localhost:5242/api/Basket/BasketListByMenuTableWithProductName?id=4");
            if (repsonsiveMessage.IsSuccessStatusCode)
            {
                var jsonData = await repsonsiveMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBasketDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> DeleteBasket(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5242/api/Basket/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return NoContent();
        }
    }
}
