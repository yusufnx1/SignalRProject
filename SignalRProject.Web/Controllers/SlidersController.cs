﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRProject.Web.Dto.SliderDto;
using System.Text;

namespace SignalRProject.Web.Controllers
{
    public class SlidersController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SlidersController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responsiveMessage = await client.GetAsync("http://localhost:5242/api/Sliders");
            if (responsiveMessage.IsSuccessStatusCode)
            {
                var jsonData = await responsiveMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSliderDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderDto createSliderDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSliderDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5242/api/Sliders", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteSlider(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5242/api/Slider/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateSlider(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5242/api/Slider/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateSliderDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateSliderDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5242/api/Slider/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
