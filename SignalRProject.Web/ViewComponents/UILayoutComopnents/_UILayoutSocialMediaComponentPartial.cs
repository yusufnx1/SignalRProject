using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRProject.Web.Dto.SocialMediaDto;

namespace SignalRProject.Web.ViewComponents.UILayoutComopnents
{
    public class _UILayoutSocialMediaComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _UILayoutSocialMediaComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responsiveMessage = await client.GetAsync("http://localhost:5242/api/SocialMedia");
            if (responsiveMessage.IsSuccessStatusCode)
            {
                var jsonData = await responsiveMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
